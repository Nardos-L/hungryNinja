using System;
using System.Collections.Generic;
//using  hungryNinja.Buffet;

namespace hungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        //add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        //add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public bool IsFull
        {
            //if (calorieIntake > 1200)

            get { return (calorieIntake > 1200); }


        }
        /*
        build out the Eat method that: if the Ninja is NOT full
        adds calorie value to ninja's total calorieIntake

        adds the randomly selected Food object to ninja's FoodHistory list
        writes the Food's Name - and if it is spicy/sweet to the console
        if the Ninja IS full
        issues a warning to the console that the ninja is full and cannot eat anymore

        
        */
        public void Eat(Food item)
        {
            Buffet temp = new Buffet();
            if (IsFull)
            {
                Console.WriteLine("Ninja is full can not eat anymore!");
                
            }
            else 
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(temp.Serve());
                foreach (var oneFood in FoodHistory)
                {
                    Console.WriteLine($"Name of food: {oneFood.Name} \n");
                    Console.WriteLine($"Name of spicy: {oneFood.IsSpicy} \n");
                    Console.WriteLine($"Name of sweet: {oneFood.IsSweet} \n");
                }
            }

        }
    }
}