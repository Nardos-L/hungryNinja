using System;
using System.Collections.Generic;


namespace hungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;

        //add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pasta",90,false,false),
                new Food("Pizza",190,true,false),
                new Food("Hotdog",200,false,false),
                new Food("Chicken bake",100,false,false),
                new Food("Vanilla shake",300,false,true),
                new Food("Strawberry smoothie",90,false,true),
                new Food("Salad mix",90,false,false)
            };
        }

        //build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Serve()
        {
            Random rand = new Random();

            var randomFood = Menu[rand.Next(Menu.Count)];
            
            return randomFood ;
        }
    }
}