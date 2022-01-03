using System;
using System.Data;
using System.Data.SqlTypes;
using EF.Lib;
using EF.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = DataBase.Init();

            db.TabGames.Add(new Games()
            {
                Name = "ResidentEvil",
                Company = "CapCom",
                Genre = "Horror",
                Release = new SqlDateTime(2021, 1, 3).ToString()
            });
            
            db.TabGames.Add(new Games()
            {
                Name = "SilentHill",
                Company = "Konami",
                Genre = "Horror",
                Release = new SqlDateTime(2021, 1, 3).ToString()
            });
            db.SaveChanges();
            
            foreach (Games customer in db.TabGames)
            {
                Console.Write(customer.Id+"\t");
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Company);
                Console.WriteLine(customer.Genre);
                Console.WriteLine(customer.Release);
            }
        }
    }
}