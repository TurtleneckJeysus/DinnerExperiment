//Program.cs**************************************
using System;
using DinnerExperiment.Classes;
using DinnerExperiment.Classes.Calendar;
using DinnerExperiment.Classes.Files;

namespace DinnerExperiment
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStuff filestuff = new();
            MealPlan mealplan = new();

            filestuff.addRemoveFolder();
            filestuff.CreateFile();
            Console.ReadLine();
            Date.NextMonday();
            mealplan.PrintMealPlan();
            Console.ReadLine();
        }
    }
}