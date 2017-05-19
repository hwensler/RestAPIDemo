using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wenslerhRestAPI.Models;

namespace wenslerhRestAPI.Controllers
{
    public class ValuesController : ApiController
    {
        //return a list of items
        public List<Item> GetListOfItems(int id)
        {
            var itemsList = new List<Item>();

            switch (id)
            {
                //case one returns level one items
                case 1:
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Sword", Description = "A really cool sword. ", Strength = 1 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shield", Description = "A really cool shield. ", Strength = 1 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shoes", Description = "A really cool pair of shoes. ", Strength = 1 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Bow", Description = "A realy cool bow.", Strength = 1 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Lance", Description = "A really cool lance. ", Strength = 1 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Axe", Description = "A really cool axe. ", Strength = 1 });
                    break;

                //case 2 returns level 2 items
                case 2:
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Sword", Description = "A really cool sword. ", Strength = 2 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shield", Description = "A really cool shield. ", Strength = 2 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shoes", Description = "A really cool pair of shoes. ", Strength = 2 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Bow", Description = "A realy cool bow.", Strength = 2 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Lance", Description = "A really cool lance. ", Strength = 2 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Axe", Description = "A really cool axe. ", Strength = 2 });
                    break;

                //case 3 returns level 3 items
                case 3:
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Sword", Description = "A really cool sword. ", Strength = 3 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shield", Description = "A really cool shield. ", Strength = 3 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shoes", Description = "A really cool pair of shoes. ", Strength = 3 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Bow", Description = "A realy cool bow.", Strength = 3 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Lance", Description = "A really cool lance. ", Strength = 3 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Axe", Description = "A really cool axe. ", Strength = 3 });
                    break;
                
               //default returns level 0 items
                default:
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Sword", Description = "A really cool sword. ", Strength = 0 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shield", Description = "A really cool shield. ", Strength = 0 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Shoes", Description = "A really cool pair of shoes. ", Strength = 0 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Bow", Description = "A realy cool bow.", Strength = 0 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Lance", Description = "A really cool lance. ", Strength = 0 });
                    itemsList.Add(new Item { ID = Guid.NewGuid().ToString(), Name = "Axe", Description = "A really cool axe. ", Strength = 0 });
                    break;
            }

            return itemsList;
        }

        //Post list of items - since this is the exact same, I figure return the same list of items for post is fine
        public List<Item> Post(int id)
        {
            //literally return those same items since it's the same as the GET assignment
            return GetListOfItems(id);
        }

    }
}
