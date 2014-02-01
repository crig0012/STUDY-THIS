var restclient = require('node-restclient');
var Twit = require('twit');
var app = require('express').createServer();

// I deployed to Nodejitsu, which requires an application to respond to HTTP requests
// If you're running locally you don't need this, or express at all.
app.get('/', function(req, res){
    res.send('Hello world.');
});
app.listen(3000);

// insert your twitter app info here
var T = new Twit({
  consumer_key:         '3dJNQChNFa9lYa0EhJnpNQ', 
  consumer_secret:      'YdTz4zmJIyr7dNeM8EWeH2SBienMw1ZpdVlo6AYjSIY',
  access_token:         '2319795476-Mus6jpYNkffK0ksxOJ2WjGmRizdDKcEPe10tqFz',
  access_token_secret:  'OsdC1k2jlyRqvpfyQY8kCAU2XMJrStYEapDrxc5H25sOp'
});

var statement =   "";

// insert your Wordnik API info below
var getNounsURL = "http://api.wordnik.com/v4/words.json/randomWords?" +
                  "minCorpusCount=1000&minDictionaryCount=10&" +
                  "excludePartOfSpeech=proper-noun,proper-noun-plural,proper-noun-posessive,suffix,family-name,idiom,affix&" +
                  "hasDictionaryDef=true&includePartOfSpeech=noun&limit=2&maxLength=12&" +
                  "api_key=86a34f93ad253bff8770d0920360e473c7d8940a96a622028";

var getAdjsURL =  "http://api.wordnik.com//v4/words.json/randomWords?" +
                  "hasDictionaryDef=true&includePartOfSpeech=adjective&limit=2&" + 
                  "minCorpusCount=100&api_key=86a34f93ad253bff8770d0920360e473c7d8940a96a622028";


function makeMetaphor() {
  statement = "";
  restclient.get(getAdjsURL,
  function(data) {
    first = data[0].word.substr(0,1);
    first2 = data[1].word.substr(0,1);
    article = "a";
    if (first === 'a' ||
        first === 'e' ||
        first === 'i' ||
        first === 'o' ||
        first === 'u') {
      article = "an";
    }
   article2 = "a";
    if (first2 === 'a' ||
        first2 === 'e' ||
        first2 === 'i' ||
        first2 === 'o' ||
        first2 === 'u') {
      article2 = "an";
    }

    var connector = "is";
    switch (Math.floor(Math.random()*12)) {
      case 0:
        connector = "of";
      break;
      case 1:
        connector = "and";
      break;
      case 2:
        connector = "seen as";
      break;
      case 3:
        connector = "considered";
      break;
      case 4:
        connector = "that can be";
      break;
    }
	//Chelsea is ... ?
    statement += "Chelsea, " + data[0].word + " " + "and" + " " + data[1].word;

    restclient.get(
      getAdjsURL,
      function(data) {
        var connector = " and";
        switch (Math.floor(Math.random()*8)) {
          case 0:
            connector = ", and";
          break;
          case 1:
            connector = ", yet";
          break;
          case 2:
            connector = " but";
          break;
          case 3:
            connector = ",";
          break;
          case 4:
            connector = ", truly";
          break;
        }
        output = data[0].word + connector + " " + data[1].word;
        statement = statement + ": " + output;
        console.log(statement);
        T.post('statuses/update', { status: statement}, function(err, reply) {
          console.log("error: " + err);
          console.log("reply: " + reply);
        });
      }    
    ,"json");
  }    
  ,"json");
}

function favRTs () {
  T.get('statuses/retweets_of_me', {}, function (e,r) {
    for(var i=0;i<r.length;i++) {
      T.post('favorites/create/'+r[i].id_str,{},function(){});
    }
    console.log('harvested some RTs'); 
  });
}

// every 2 minutes, make and tweet a metaphor
// wrapped in a try/catch in case Twitter is unresponsive, don't really care about error
// handling. it just won't tweet.
setInterval(function() {
  try {
    makeMetaphor();
  }
 catch (e) {
    console.log(e);
  }
},120000);

// every 5 hours, check for people who have RTed a metaphor, and favorite that metaphor
setInterval(function() {
  try {
    favRTs();
  }
 catch (e) {
    console.log(e);
  }
},60000*60*5);
