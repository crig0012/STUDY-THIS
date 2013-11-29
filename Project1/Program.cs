using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project1
{
    class Program
    {
        public static int windowWidth = 80;
        public static int windowHeight = 35;
        public static bool run = true;
        public static string errorMessage;
        public static bool isError = false;

        static void Main(string[] args)
        {
            // setup console window
            Console.Clear(); 
            // set size
            Console.SetWindowSize(windowWidth, windowHeight);
            // remove scroll bar with buffer size equal to window size
            Console.BufferWidth = windowWidth;
            Console.BufferHeight = windowHeight;
            
            // generate world
            World.GenerateWorld();

            // begin character creation
            string name = Text.Prompt("Welcome stranger.  What is your name?");
            Player.name = name;
            Player.inventory.Add(new Item("Candle", "A single white candle.", 22));

            Text.WriteLine("Thanks, " + name);
            Text.WriteLine("Press any key to get started.");
            Console.ReadKey();
            Console.Clear();
            Text.WriteLine("The last thing you remember is battling the Ancient LichLord deep within a cavern beneath Death Mountain.   Now suddenly, you are surrounded by the darkness of true night as you stand in front of an ancient stone castle of complex architecture.  Looking up, you notice the faint glow of a light coming from an old clock tower, high above the castle.  The doors to the castle are large and covered in an ancient mold. Unsure of what to do, you drag open the large wooden door, light the candle you found in your pocket, and step into the castle. \n \nPress a key...");
            Console.ReadKey();
            Console.Clear();

            while (run)
            {
                if (!isError)
                {
                    Text.SetPrompt();
                    World.LocationDescription();

                    string temp = Text.Prompt("");
                    Console.Clear();
                    Player.Do(temp);
                }
                // there is an error
                else
                {
                    DisplayError();
                }
            }
        }
        
        // stream writer to write to file.
        public static void SaveGame()
        {
            StreamWriter stream = new StreamWriter("save.dat");
            stream.WriteLine(Player.location);
            stream.Close();
        }

        public static void LoadGame()
        {
            if (File.Exists("save.dat"))
            {
                StreamReader stream = new StreamReader("save.dat");
                Player.location = int.Parse(stream.ReadLine());
                stream.Close();
            }
        }
        // stream reader to find file
        //public static void LoadGame()
        //{
        //    try
        //    {
        //        using (Stream stream = File.Open("data.bin", FileMode.Open))
        //        {
        //            BinaryFormatter bin = new BinaryFormatter();
        //            World.map = (List<Location>)bin.Deserialize(stream);
        //        }
        //    }
        //    catch (IOException)
        //    {
        //    }
        //}

        public static void WinGame()
        {
            run = false;
            Text.WriteLine("As you place the crown upon your head, your vision begins to blur and you fall to the floor.   You wake up in a hot cavern, lit by a few torches on the wall.  This is the cavern of the Ancient LichLord, and you have escaped his twisted maze. ");
        }

        #region Error Handling
        public static void SetError(string aText)
        {
            isError = true;
            errorMessage = aText;
        }

        public static void UnsetError()
        {
            isError = false;
            errorMessage = "";
        }

        public static void DisplayError()
        {
            Text.WriteColor("|r|" + errorMessage + "|g|");
            Text.BlankLines(2);
            UnsetError();
        }
        #endregion
    }
}
