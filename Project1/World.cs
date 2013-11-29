using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace Project1
{
    class  World 
    {
        public static List<Location> map = new List<Location>();

        /// <summary>
        ///  Create the World
        /// </summary>
        public static void GenerateWorld()
        {
            map.Add(new Location("Foyer", "The foyer is dark, cramped, and filled with an eerie silence.  A stuffed beast head of an unknown species stares blankly at you from above the door to the courtyard, and ancient weaponry line the walls.   To the north, a thick wooden door opens in to a courtyard, and two stairways haunt the east and west walls.  Both stairwells curve slightly preventing a view of their destination.  The cellar stairs ascends up to the second level as the west stairs descend into darkness."));
            map[0].AddItem(new Item("Stone", "A small stone that looks good for throwing.", 18));
            map[0].AddExit(1);
            map[0].AddExit(8);
            map[0].AddExit(15);

            map.Add(new Location("Courtyard", "It's hard to make out details at this time of night with no moon.  With mostly touch, you decide the courtyard must be surrounded by ancient statues of indistinct forms, with an extremely overgrown fountian in the middle.  To the north, the once decadent great doors to the king's throne room are blocked with the ruins of a collapsed balcony. Along the western wall of the courtyard is another set of large doors inlaid with colored glass in the shape of some unknown religios symbols.  To the east, a passage whos threshold is covered with many thin vines leads into darkness.  The door to the south leads into the foyer."));
            map[1].AddExit(2);
            map[1].AddExit(4);
            //map[1].AddExit(21);
            map[1].AddExit(0);

            map.Add(new Location("Chapel", "Overturned benches lay scattered about the room.   On the south wall is an array of more colored glass windows forming symbols that do not remind you of anything.  At the west end of the room, what used to be a tall pulpit is now burnt and charred.  A crumbling doorway leads north into a darkened passage."));
            map[2].AddItem(new Item("Brass Key", "A dirty brass key", 16, true));
            map[2].AddExit(1);
            map[2].AddExit(3);

            map.Add(new Location("Art Room", "A long narrow room lined with covered paintings and statues.  Cobwebs fill every corner of the room, and a broken mirror lies against the west wall, reflecting the room a hundred times over in it's many pieces.  Covering the north wall is an enormous tapestry depicting this castle beneath a terrible dark maroon vortex."));
            map[3].AddExit(2);
            //map[3].AddExit(23);

            map.Add(new Location("East Hall", "Matching suits of armor line the hall as a tattered red carpet stretches between them.   The last one armor on the left is missing it's strangely shaped helmet.  To the north a door leads into a kitchen.  To the west, a thick metal door blocks your way.   Beside the thick metal door is a small round hole.   The eastern doorway is shut fast." ));
            map[4].AddExit(1);
            // map[4].AddExit(5);  lever opens
            map[4].AddExit(6);

            map.Add(new Location("Armory", "The walls of this room are lined with strangly shaped and sized armor and weapons.  Most of the helmets seem as if they would only fit on a small child, where as the jagged and crude weapons are clearly too heavy for most grown men."));
            map[5].AddItem(new Item("Sword", "Rusty, and questionably made for a man, yet it has a fine edge.", 3));
            map[5].AddExit(4);

            map.Add(new Location("Kitchen", "Tables line the wall with crude cookware hanging above them.  In the center is a blackened fire pit covered in what must be burnt feathers from some great strange bird."));
            map[6].AddExit(4);
            map[6].AddExit(7);

            map.Add(new Location("Servants Room", "This room smells terribly and is full of dirty, unmade beds.   You realize what is making you terrible uncomfortable when you notice the bars on the outside of the windows, and locks on the outside of the door."));
            map[7].AddItem(new Item("Potion", "A small opaque yellow vial filled with a noxtious liquid.  The label on the front says 'Herbicide'.", 1, true));
            map[7].AddExit(6);

            map.Add(new Location("Cellar Stairs", "The stone spiral stairwell is dark and small.  Half way down you find a candleabra within an inset in the stairwell and a tray of old dishes placed on the stairs."));
            map[8].AddExit(0);
            map[8].AddExit(9);

            map.Add(new Location("Cellar", "Small footprints in the dusty stone floor.   Mold is creeping inbetween the cracks of the wall and a musty grandfather clock stands in the corner facing the wall."));
            map[9].AddExit(8);
            map[9].AddExit(10);
            map[9].AddExit(11);
            map[9].AddExit(12);

            map.Add(new Location("Crypts", "Cobwebs cover everything in this dank room except a small rocking horse placed against the wall."));
            map[10].AddExit(9);

            map.Add(new Location("Wine Cellar", "The only clue that this was once a wine cellar is the broken bottles in the corner, and large areas with no dust against the wall where racks used to be."));
            map[11].AddExit(9);

            map.Add(new Location("Prison", "This small room has little in it besides a rotten wooden table and chairs.   On the table is a ring of rusty keys and a stack of crude paper covered in an strange script.  The door to the cell to the west is open, where are the first cell door remains closed.  A human skeleton hand is between the bars, holding the silver lock with broken fingers."));
            map[12].AddExit(9);
            //map[12].AddExit(13);
            map[12].AddExit(14);

            map.Add(new Location("Cell 1", "Its very cramped and moldy in here, and the prisoner's skeleton has fallen to the floor into a pile of bones."));
            map[13].AddItem(new Item("Gear","A tiny gear, clearly an important piece of some machine.", 19, true));
            map[13].AddExit(12);

            map.Add(new Location("Cell 2", "There was once a fire in this cell that burned all of it's contents into an ashy mess in the corner."));
            map[14].AddExit(12);

            map.Add(new Location("West Stairs", "It seems to take forever to reach then end of the stairs.  On the landing half way up, an inset bookcase holds a tattered portrait and a statue of a young girl with glowing red gems for eyes.  A barrier of force prevents you from moving upward."));
            map[15].AddExit(0);
            //map[15].AddExit(16);  cloak opens

            map.Add(new Location("Hall", "The small arched-cealing hallway seems to impose upon your will as to take each step.  There is a door to the west with brass lock that won't open."));
            map[16].AddExit(15);
            //map[16].AddExit(17);  brass key opens
            map[16].AddExit(18);
            map[16].AddExit(19);

            map.Add(new Location("Storage", "This room is full of boxes, barrels, and clothing with a sarcophigus in the corner."));
            map[17].AddItem(new Item("Lever", "A long handle with a small hook on the end.", 4, true));
            map[17].AddExit(16);

            map.Add(new Location("Bedroom", "A very large bed with many fine pillows on it commands the middle of the room.  A master wardobe and sitting area take up the north half of the room.  And a tall vanity stands against the north wall, and you think you can feel a draft coming from somewhere."));
            map[18].AddExit(16);
            //map[18].AddExit(22);

            map.Add(new Location("Clock Tower", "Gears, cogs and chains are bolted to the walls and arrange intricately throughout the room.  The wooden floors creak as you walk, and you catch the sounds and smells of rats. gas/oil lamp cast an erie glow.  It seems that something is missing within the machine."));
            map[19].AddExit(16);
            //map[19].AddExit(20); gear opens

            map.Add(new Location("Treasure Room", "This room is filled with piles of jewelry and coins.   There is a very nice set of steel armor against a wall along stacks of ancient paintings and statues.   An old cloth doll of a young girl lays long forgotten on the floor."));
            map[20].AddItem(new Item("Crown", "A heavy circlet made of gold, inset with large red gems.", 21, true));
            map[20].AddExit(19);

            map.Add(new Location("Throne Room", "A great chamber surrounded by columns with a great and dirty carpet leading from the double doors to the stage.   The throne itself is made of gold, and covered in blood."));
            map[21].AddExit(1);
            map[21].AddExit(22);

            map.Add(new Location("Secret Stairway", "Strange markings and carvings line both walls of this tight spiral stairwell. "));
            map[22].AddExit(18);
            //map[22].AddExit(21);

            map.Add(new Location("Library", "All of the tall walls of this room are lined with ancient and rotting books.  A ladder on wheels leans against the northern bookshelf.  In the center of the room on a pitted metal table is an orrery depicting a solar system with 13 planets, revolvnig around a very small sun."));
            map[23].AddItem(new Item("Ancient Tome", "An ancient book, bound in a leathery material and full of unrecognized symbols and scripts. ", 10, true));
            map[23].AddExit(3);
        }

        /// <summary>
        /// Use a item in a location
        /// </summary>
        /// <param name="item"></param>
        public static void UseItemInLocation(string item)
        {
            string message = "";
            switch (item.ToLower())
            {
                // open passage from bedroom to throne room
                case "stone":
                    map[18].AddExit(22);
                    message = "You hurl the stone at the vanity mirror!   The mirror cracks sharply into many pieces which fall to the floor and shatter.   Behind the mirror, you find a secret passage!";
                    // mirror is broken
                    map[18].description = "A very large bed with many fine pillows on it commands the middle of the room.  A master wardobe and sitting area take up the north half of the room.  And a tall vanity is now broken on the floor.";
                    break;

                // unlock storage room door
                case "brass key":
                    map[16].AddExit(17);
                    message = "The Brass Key fits neatly into the lock and turns with a click.";
                    // door is not locked
                    map[16].description = "The small arched-cealing hallway seems to impose upon your will with each step.  At the bottom of the stairwell is a stone wall with an unlit torch hanging on it.";
                    break;

                // sword cuts through tapestry
                case "rusty sword":
                    map[3].AddExit(23);
                    message = "You take the Rusty Sword in both hands and begin wildly hacking at the tapestry on the north wall.  Behind it you find a small foyer leading into the Library.";
                    // tapestry is tattered
                    map[3].description = "A long narrow room lined with covered paintings and statues.  Cobwebs fill every corner of the room, and a broken mirror lies against the west wall, reflecting the room a hundred times over in it's many pieces.  Covering the north wall a once enormous tapestry depicting this castle beneath a terrible dark maroon vortex, is now slashed to pieces.";
                    break;

                // crown in throne room wins game
                case "crown":
                    Program.WinGame();
                    break;

                // book in crypts finds silver key
                case "ancient tome":
                    map[10].AddItem(new Item("Silver Key", "A tarnished silver key.", 12));
                    message = "As you finish reading the first incantation in the Ancient Tome, the walls around you begin rumbling and shaking.  Dust and debris fill the air, as the small toy horse begins to rock back and forth vigorously.  A crack opens in the wall and a small silver key falls to the floor with a loud ring.  The Ancient Tome crumbles in your hands.";
                    // crack in wall
                    map[10].description = "Cobwebs cover everything in this dank room except a small rocking horse placed against the wall.  There is a large crack in the west wall.";
                    break;

                // silver key opens cell 1
                case "silver key":
                    map[12].AddExit(13);
                    message = "You pry the dead man's finger bones away from the lock, and slip the silver key in and turn it.  The cell door opens with a click.";
                    // door is open skeleton on floor
                    map[12].description = "This small room has little in it besides a rotten wooden table and chairs.   On the table is a ring of rusty keys and a stack of crude paper covered in an strange script.  Both cell doors are open. ";
                    break;

                // gear in clock tower open  treasure room
                case "gear":
                    map[19].AddExit(20);
                    message = "You slip the tiny gear over a square peg.  With many loud groans the machinery all around you begins to move.";
                    // machinery is moving, door is open
                    map[19].description = "Gears, cogs are in motion all around you.  The wooden floors still creak as you walk, and you catch the sounds and smells of rats. gas/oil lamp cast an erie glow.";
                    break;

                // lever opens armory
                case "lever":
                    map[4].AddExit(5);
                    message = "You slip the small hooked end of the lever into the hole beside the metal door, and it clicks into place.   You pull downward on it and the thick metal door swings open slowly.";
                    // door is open
                    map[4].description = "Matching suits of armor line the hall as a tattered red carpet stretches between them.   The last one armor on the left is missing it's strangely shaped helmet.  To the north a door leads into a kitchen.  To the west, a thick metal door blocks your way.   Beside the thick metal door is a lever in the wall.   The eastern doorway stands open.";
                    break;

                // potion clears vines, finds cloak
                case "potion":
                    map[1].AddItem(new Item("Cloak", "A rotten cloak that looks like it has been in the harsh weather for decades.", 15));
                    message = "You dump the potion into the overgrown fountain.  The vines within the fountain begin to smoke and hiss, finally burning away until you can see a dirty cloak laying over the drain in the fountain's base.";
                    // fountain is empty
                    map[1].description = "It's hard to make out details at this time of night with no moon.  With mostly touch, you decide the courtyard must be surrounded by ancient statues of indistinct forms, with an old fountian in the middle.  To the north, the once decadent great doors to the king's throne room are blocked with the ruins of a collapsed balcony. Along the western wall of the courtyard is another set of large doors inlaid with colored glass in the shape of some unknown religios symbols.  To the east, a passage whos threshold is covered with many thin vines leads into darkness.  The door to the south leads into the foyer.";
                    break;

                case "cloak":
                    map[15].AddExit(16);
                    message = "You cover the statue with the rotten cloak hiding it's gaze.   The barrier of force no long impedes your progress up the stairs.";
                    // statue is covered
                    map[15].description = "It seems to take forever to reach then end of the stairs.  On the landing half way up, an inset bookcase holds a tattered portrait and a statue of a young girl is covered in an old cloak.";
                    break;

                // candle lights torch to throne room
                case "candle":
                    map[22].AddExit(21);
                    message = "You light the torch at the base of the stairs, and the wall in front of you begins to rumble and move.   When it stops, you are looking into the Throne Room from behind the Throne.";
                    // door is open
                    map[22].description = "The small arched-cealing hallway seems to impose upon your will with each step.  At the bottom of the stairwell is a door leading into the throne room.";
                    break;
            }

            // remove item from inventory
            Player.RemoveInventoryItem(item);
                    
            // write out the message with some default colors
            Text.WriteColor("|gr|" + message + "|g|");
            Text.BlankLines(2);
        }

        public static bool IsLocation(string aName)
        {
            for (int i = 0; i < map.Count; i++)
            {
                if (map[i].name.ToLower() == aName.ToLower())
                {
                    return true;
                }
            }
            // not found
            return false;
        }

        public static bool IsLocationExit(string aName)
        {
            for (int i = 0; i < map[Player.location].exits.Count; i++)
            {
                if (map[Player.location].exits[i] == World.GetLocationIdByName(aName))
                {
                    // legitimate exit
                    return true;
                }
            }
            return false;
        }

        public static int GetLocationIdByName(string aName)
        {
            for (int i = 0; i < map.Count; i++)
            {
                if (map[i].name.ToLower() == aName.ToLower())
                {
                    return i;
                }
            }
            // not found
            return -1;
        }


        /// <summary>
        /// Draw this Location
        /// </summary>
        public static void LocationDescription()
        {
            Text.WriteLine(map[Player.location].description);
            LocationItems();
            LocationExits();
        }
        public static void LocationItems()
        {
            Text.BlankLines();
            Text.WriteColor("|gr|-- Items --|g|\n");
            for (int i = 0; i < map[Player.location].items.Count; i++)
            {
                if (map[Player.location].items[i].isHidden == false)
                    Text.WriteLine(map[Player.location].items[i].name);
            }
        }
        public static void LocationExits()
        {
            Text.BlankLines();
            Text.WriteColor("|b|-- Exits --|g|\n");
            for (int i = 0; i < map[Player.location].exits.Count; i++)
            {
                Text.WriteLine(map[map[Player.location].exits[i]].name);
            }
        }
        public void LocationName()
        {
            Text.WriteLine(map[Player.location].name);
        }
        public static void ShowHiddenItems()
        {
            for (int i = 0; i < map[Player.location].items.Count; i++)
            {
                if (map[Player.location].items[i].isHidden == true)
                {
                    map[Player.location].items[i].isHidden = false;
                    Text.WriteColor("\n|r|You found an item!|g| |gr|" + map[Player.location].items[i].name + "|g|\n");
                }
            }
        }
    }
}
