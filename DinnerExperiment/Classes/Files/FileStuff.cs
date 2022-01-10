//FileStuff**********************************************
using System;
using System.IO;
using DinnerExperiment.Classes.Calendar;

namespace DinnerExperiment.Classes.Files
{
    internal class FileStuff : MealPlan
    {
        public void addRemoveFolder()
        {
            Console.Write("Do you want to create a new Folder? \n Press y or n: ");
            string createSelection = Console.ReadLine();

            switch (createSelection)
            {
                case "y":
                    CreateDirectory();
                    break;

                case "n":
                    Console.WriteLine("No Folder Created!\n");
                    Console.Write("Do you want to Delete a Folder? \n Press y or n: ");
                    string deleteSelection = Console.ReadLine();

                    switch (deleteSelection)
                    {
                        case "y":
                            DeleteDirectory();
                            break;

                        case "n":
                            Console.WriteLine("No Directory Deleted!\n");

                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }

                    break;

                default:
                    Console.Write("Invalid option");
                    break;
            }
        }

        static void CreateDirectory()
        {
            Console.WriteLine("Enter desired Folder to be added, Name Preceeded by Location - Example (C:/Users/clcag/Desktop/C#/NEW_FOLDER_NAME) \n");
            string path = @Console.ReadLine();
            //Check If Directory Exists
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder Exists Already");
                return;
            }


            Directory.CreateDirectory(path);
            Console.WriteLine("The Directory was Created Successfully at {0}.", Directory.GetCreationTime(path));

            Console.Write($"The Folder {path} Has Been Created!\n");

        }

        static void DeleteDirectory()
        {
            Console.WriteLine("Enter desired Folder to be Removed, Name Preceeded by Location - Example (C:/Users/clcag/Desktop/C#/NEW_FOLDER_NAME) \n");
            string path = Console.ReadLine();
            //check If Directory Exists
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("The Directory was Deleted Successfully at {0}.", Directory.GetCreationTime(path));

                Console.Write($"The Folder {path} Has Been Deleted!\n");
                return;
            }
        }

        public void CreateFile()
        {
            Console.WriteLine("Do you want to create a text file?\n type y or n");
            string fileSelection = Console.ReadLine();

            switch (fileSelection)
            {
                case "y":

                    PrintableMealPlan();

                    break;

                case "n":
                    Console.WriteLine("No File Was Created");
                    break;

                default:
                    Console.WriteLine("Incorrect Input");
                    break;
            }
        }



        public void PrintableMealPlan()
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

            MealPlan meal = new MealPlan();
            Console.WriteLine("Enter a File Name preceeded by location:\n");
            string fileName = Console.ReadLine();

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot open {fileName} for writing");
                Console.WriteLine(e.Message);
                return;
            }

            Console.SetOut(writer);

            Date.NextMonday();
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

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
    }

}

