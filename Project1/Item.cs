﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Item : Entity
    {
        public bool isHidden = false;
        public int actionLocationId;
        public string actionName;

        public Item(string aName, string aDesc, int aActionLocationId, bool aIsHidden = false, string aActionName = "use")
            :base(aName, aDesc)
        {
            actionLocationId = aActionLocationId;
            actionName = aActionName;

            if (aIsHidden)
                isHidden = aIsHidden;
        }

        /// <summary>
        /// Looks for item in Player.inventory
        /// </summary>
        /// <param name="aName">name of the Item</param>
        /// <returns></returns>
        public static bool IsItemInInventory(string aName)
        {
            // look for item in inventory
            for (int i = 0; i < Player.inventory.Count; i++)
            {
                if (Player.inventory[i].name.ToLower() == aName.ToLower())
                {
                    return true;
                }
            }

            // not found
            return false;
        }

        /// <summary>
        /// Looks for item in current location
        /// </summary>
        /// <param name="aName">name of the Item</param>
        /// <returns></returns>
        public static bool IsItemInLocation(string aName)
        {
            // look for item in location
            for (int i = 0; i < World.map[Player.location].items.Count; i++)
            {
                if (World.map[Player.location].items[i].name.ToLower() == aName.ToLower())
                {
                    return true;
                }
            }

            // not found
            return false;
        }


        /// <summary>
        /// Items are only items if in Player.inventory or Player.location
        /// </summary>
        /// <param name="aName">name of the Item</param>
        /// <returns></returns>
        public static string GetItemDescByName(string aName)
        {
            // look for item in location
            for (int i = 0; i < World.map[Player.location].items.Count; i++)
            {
                if (World.map[Player.location].items[i].name.ToLower() == aName.ToLower())
                {
                    return World.map[Player.location].items[i].description;
                }
            }

            // look for item in inventory
            for (int i = 0; i < Player.inventory.Count; i++)
            {
                if (Player.inventory[i].name.ToLower() == aName.ToLower())
                {
                    return Player.inventory[i].description;
                }
            }

            // not found
            return "Item not found";
        }

        public static int GetItemActionLocationIdByName(string aName)
        {
            // look for item in inventory
            for (int i = 0; i < Player.inventory.Count; i++)
            {
                if (Player.inventory[i].name.ToLower() == aName.ToLower())
                {
                    return Player.inventory[i].actionLocationId;
                }
            }
            
            // look for item in location
            for (int i = 0; i < World.map[Player.location].items.Count; i++)
            {
                if (World.map[Player.location].items[i].name.ToLower() == aName.ToLower())
                {
                    return World.map[Player.location].items[i].actionLocationId;
                }
            }
            return -1;
        }

        public static void RemoveItemFromLocation(string item)
        {
            for (int i = 0; i < World.map[Player.location].items.Count; i++ )
            {
                if (World.map[Player.location].items[i].name.ToLower() == item.ToLower())
                {
                    World.map[Player.location].items.RemoveAt(i);
                }
            }
        }
    }
}
