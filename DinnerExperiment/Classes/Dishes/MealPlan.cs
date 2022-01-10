//MealPlan.cs****************************************************************
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinnerExperiment.Classes.Calendar;

namespace DinnerExperiment.Classes
{
    public class MealPlan
    {

        public readonly string[] side_Carb = { "Red Potato", "Russet Potato", "Rice", "Garlic Bread" };
        public readonly string[] side_Veg = { "Green Beans", "Brussel Sprouts", "Cauliflower", "Broccoli", "Squash", "Asparagus" };
        public readonly string[] dish_Chicken = { "Salsa Chicken", "Chicken Enchilada Bake", "Chicken Parmesan", "Baked Chicken", "Barbeque Chicken", "Crock Pot Chicken" };
        public readonly string[] dish_Fish = { "Salmon", "Shrimp" };
        public readonly string[] dish_Turkey = { "Turkey Chili", "Turkey Meatloaf", "Turkey Burger" };
        public readonly string[] dish_Beef = { "Steak", "Meatloaf", "Spaghetti", "Tacos" };

       
    
    
    public string monDish, tueDish, thuDish, friDish, satDish, sunDish, monVeg, tueVeg, thuVeg, friVeg, satVeg, sunVeg,
        monCarb, tueCarb, thuCarb, friCarb, satCarb, sunCarb;


        static public string GetItem(string[] stringArray)
        {
            return stringArray[GetRandomIndex(stringArray)];
        }
        public void PrintMealPlan()
        {
            monDish = GetItem(dish_Chicken);
            tueDish = GetItem(dish_Fish);
            thuDish = GetItem(dish_Turkey);
            friDish = GetItem(dish_Beef);
            satDish = GetItem(dish_Chicken);
            sunDish = GetItem(dish_Fish);

            monVeg = GetItem(side_Veg);
            tueVeg = GetItem(side_Veg);
            thuVeg = GetItem(side_Veg);
            friVeg = GetItem(side_Veg);
            satVeg = GetItem(side_Veg);
            sunVeg = GetItem(side_Veg);

            monCarb = GetItem(side_Carb);
            tueCarb = GetItem(side_Carb);
            thuCarb = GetItem(side_Carb);
            friCarb = GetItem(side_Carb);
            satCarb = GetItem(side_Carb);
            sunCarb = GetItem(side_Carb);


            Console.WriteLine($"Monday: Chicken, {monDish}, {monVeg}, {monCarb}");
            Console.WriteLine($"Tuesday: Fish, {tueDish}, {tueVeg}, {tueCarb}");
            Console.WriteLine($"Wednesday: Out");
            Console.WriteLine($"Thursday: Turkey, {thuDish}, {thuVeg}, {thuCarb}");
            Console.WriteLine($"Friday: Beef, {friDish}, {friVeg}, {friCarb}");
            Console.WriteLine($"Saturday: Chicken, {satDish}, {satVeg} {satCarb}");
            Console.WriteLine($"Sunday: Fish, {sunDish}, {sunVeg}, {sunCarb}");
            Console.WriteLine("<...............................................>");

            Console.WriteLine("Monday's ingredients are:\n");
            GetMonday();
            Console.WriteLine("Tuesday's ingredients are:\n");
            GetTuesday();
            Console.WriteLine("Thursday's ingredients are:\n");
            GetThursday();
            Console.WriteLine("Fridays ingredients are:\n");
            GetFriday();
            Console.WriteLine("Saturday's ingredients are:\n");
            GetSaturday();
            Console.WriteLine("Sunday's ingredients are:\n");
            GetSunday();

        }

        public void GetMonday()
        {
            switch (monDish)
            {
                case "Salsa Chicken":

                    Console.WriteLine("Salsa Chicken Ingredients");

                    break;

                case "Chicken Enchilada Bake":

                    Console.WriteLine("Chicken Enchilada Bake Ingredients");

                    break;

                case "Chicken Parmesan":

                    Console.WriteLine("Chicken Parmesan Ingredients");

                    break;

                case "Baked Chicken":

                    Console.WriteLine("Baked Chicken Ingredients");

                    break;

                case "Barbeque Chicken":

                    Console.WriteLine("Barbeque Chicken Ingredients");

                    break;

                case "Crock Pot Chicken":

                    Console.WriteLine("Crock Pot Chicken Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (monCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (monVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;



            }
            Console.WriteLine();
        }

        public void GetTuesday()
        {
            switch (tueDish)
            {
                case "Shrimp":

                    Console.WriteLine("Shrimp Ingredients");

                    break;

                case "Salmon":

                    Console.WriteLine("Salmon Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (tueCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (tueVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }
            Console.WriteLine();
        }

        public void GetThursday()
        {
            switch (thuDish)
            {
                case "Turkey Chili":

                    Console.WriteLine("Turkey Chili Ingredients");

                    break;

                case "Turkey Meatloaf":

                    Console.WriteLine("Turkey Meatloaf Ingredients");

                    break;

                case "Turkey Burger":

                    Console.WriteLine("Turkey Burger Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (thuCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (thuVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }
            Console.WriteLine();
        }

        public void GetFriday()
        {
            switch (friDish)
            {
                case "Steak":

                    Console.WriteLine("Steak Ingredients");

                    break;

                case "Spaghetti":

                    Console.WriteLine("Spaghetti Ingredients");

                    break;

                case "Meatloaf":

                    Console.WriteLine("Meatloaf Ingredients");

                    break;

                case "Tacos":

                    Console.WriteLine("Tacos Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;
            }

            switch (friCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (friVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }
            Console.WriteLine();
        }

        public void GetSaturday()
        {
            switch (satDish)
            {
                case "Salsa Chicken":

                    Console.WriteLine("Salsa Chicken Ingredients");

                    break;

                case "Chicken Enchilada Bake":

                    Console.WriteLine("Chicken Enchilada Bake Ingredients");

                    break;

                case "Chicken Parmesan":

                    Console.WriteLine("Chicken Parmesan Ingredients");

                    break;

                case "Baked Chicken":

                    Console.WriteLine("Baked Chicken Ingredients");

                    break;

                case "Barbeque Chicken":

                    Console.WriteLine("Barbeque Chicken Ingredients");

                    break;

                case "Crock Pot Chicken":

                    Console.WriteLine("Crock Pot Chicken Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (satCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (satVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }
            Console.WriteLine();
        }

        public void GetSunday()
        {
            switch (sunDish)
            {
                case "Shrimp":

                    Console.WriteLine("Shrimp Ingredients");

                    break;

                case "Salmon":

                    Console.WriteLine("Salmon Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (sunCarb)
            {
                case "Red Potato":

                    Console.WriteLine("Red Potato Ingredients");

                    break;

                case "Russet Potato":

                    Console.WriteLine("Russet Potato Ingredients");

                    break;

                case "Rice":

                    Console.WriteLine("Rice Ingredients");

                    break;

                case "Garlic Bread":

                    Console.WriteLine("Garlic Bread Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }

            switch (sunVeg)
            {
                case "Broccoli":

                    Console.WriteLine("Broccoli Ingredients");

                    break;

                case "Brussel Sprouts":

                    Console.WriteLine("Brussel Sprouts Ingredients");

                    break;

                case "Asparagus":

                    Console.WriteLine("Asparagus Ingredients");

                    break;

                case "Green Beans":

                    Console.WriteLine("Green Beans Ingredients");

                    break;

                case "Cauliflower":

                    Console.WriteLine("Cauliflower Ingredients");

                    break;

                case "Squash":

                    Console.WriteLine("Squash Ingredients");

                    break;

                default:

                    Console.WriteLine("nothing");

                    break;


            }
            Console.WriteLine();
        }


        static int GetRandomIndex(string[] stringArray)
        {
            Random rand = new Random();
            return rand.Next(stringArray.Length);

        }
    }
}
