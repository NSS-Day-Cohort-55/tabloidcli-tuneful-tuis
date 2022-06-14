using System;
using System.Collections.Generic;
using TabloidCLI.Models;

namespace TabloidCLI.UserInterfaceManagers
{
    public class ColorManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        private string _connectionString;

        public ColorManager(IUserInterfaceManager parentUI, string connectionString)
        {
            _parentUI = parentUI;
            _connectionString = connectionString;
        }


        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Color Menu");
            Console.WriteLine(" 1) Black");
            Console.WriteLine(" 2) Blue");
            Console.WriteLine(" 3) Magenta");
            Console.WriteLine(" 4) Red");
            Console.WriteLine(" 0) Go Back");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    return this;
                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    return this;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    return this;
                case "4":
                    Console.BackgroundColor = ConsoleColor.Red;
                    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }

        }
    }
}