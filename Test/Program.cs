using System;
using App.Domain.Core;
using System.Linq;
using System.Collections.Generic;
using App.Infrastructure.Data;
using App.Infrastructure.Business;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string genericRepoSavePath = string.Empty;
            ApplicationContext aC = new ApplicationContext();
            List<Customer> Customers = new List<Customer>()
            {
                new Customer("Vasya228","VasyaCool1337","absolutelyVasya@gmel.com",phoneNumber: "+38099323453434"),
                new Customer("NeVasya228","VasyaNeCool1337",lastName:"Pupkin",firstName:"NeVasya"),
                new Customer("Doodie72","7300",firstName:"Albert",phoneNumber: "+38099566234476"),
                new Customer("SayonaraBoy","ZX_Spectrum",lastName:"Solnetsov"),
                new Customer("coldFredericco","notthatcoldactually",firstName:"Fred"),
                new Customer("sonnyC","sonicK",email:"sunnyGirl@gmel.com"),
            };
            #region Customers List Update
            GenericRepository<Customer> GR = new GenericRepository<Customer>(aC, aC.Customers);
            Console.WriteLine("JSON Serialization:\n");
            genericRepoSavePath = GR.DataSavingPath;
            Console.WriteLine("Customer data serialization:");
            foreach (Customer c in Customers)
            {
                GR.Create(c);
                Console.WriteLine($"Successfuly added to context: {c.Login}");
            }

            Console.WriteLine($"\nCustomer data was successfully saved ({genericRepoSavePath})");
            #endregion
            ConsoleDiv();
            Console.WriteLine("Customer data deserialization:");
            JsonDataLoader customerLoader = new JsonDataLoader();
            List<Customer> loadedCustomers = customerLoader.Load<List<Customer>>(genericRepoSavePath);
            foreach (Customer cc in loadedCustomers)
                Console.WriteLine(cc.Login);
            ConsoleDiv();
            Console.WriteLine("LINQ\n");
            List<Limousine> limos = new List<Limousine>()
            {
                new Limousine("Name 3",21000,"LR-LC132"),
                new Limousine("Name 1",12000,"LM-LC1"),
                new Limousine("Name 4",22000,"LG-LC14"),
                new Limousine("Name 2",43000,"LR-LC12"),
                new Limousine("Name 5",44000,"LM-LC153"),
                new Limousine("Name 7",67000,"LR-LC154"),
                new Limousine("Name 8",46000,"LM-LC12"),
                new Limousine("Name 9",43000,"LG-LC155"),
                new Limousine("Name 12",23000,"LR-LC115"),
                new Limousine("Name 65",64000,"LG-LC155"),
            };
            Console.WriteLine("Source list\n");
            foreach (Limousine lim in limos)
                Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
            ConsoleDiv();
            Console.WriteLine("Sort by name\n");
            var sortedByNameLimos = from l in limos
                                                 orderby l.Name
                                                 select l;
            foreach (Limousine lim in sortedByNameLimos)
                Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
            ConsoleDiv();
            Console.WriteLine("Selection by price(> 40000)\n");
            var selectedByPriceLimos = from l in limos
                                       where l.Price > 40000
                                       select l;
            foreach (Limousine lim in selectedByPriceLimos)
                Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
            ConsoleDiv();
            Console.WriteLine("Attach\n");
            Console.WriteLine("Attaching list\n");

            List<Limousine> newlimos = new List<Limousine>()
            {
                new Limousine("Name 34",53427,"LR-FDS32"),
                new Limousine("Name 654",21464,"LM-HGF3"),
                new Limousine("Name 123",65476,"LG-DGF2"),
                new Limousine("Name 765",12345,"LM-HGF32"),
                new Limousine("Name 12",76324,"LR-CVH54"),
                new Limousine("Name 7645",62346,"LM-AS563"),
                new Limousine("Name 8576",73567,"LR-BHJ31"),
                new Limousine("Name 324",83456,"LG-YTGH23"),
                new Limousine("Name 176",76345,"LR-XCV34"),
                new Limousine("Name 34",98432,"LR-AS34"),
            };

            foreach (Limousine lim in newlimos)
                Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
            ConsoleDiv();
            Console.WriteLine("Attached list\n");

            var unitedLists = limos.Union(newlimos);

            foreach (Limousine lim in unitedLists)
                Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
            ConsoleDiv();
            Console.WriteLine("Group by SerialNumber, sort by serial\n");

            var limoGroups = from i
                              in unitedLists
                              orderby i.SerialNumber
                              group i by (i.SerialNumber.Substring(0,2));

            foreach (IGrouping<string, Limousine> group in limoGroups)
            {
                Console.WriteLine(group.Key);
                foreach (Limousine lim in group)
                    Console.WriteLine($"{lim.Name} {lim.Price} {lim.SerialNumber}");
                Console.WriteLine();
            }
        }
        public void DisplayLoadedData<T>() 
        {
            
        }
        public static void ConsoleDiv() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            for (int i = 0; i < 120; i++)
                Console.Write((char)4);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
   
}
