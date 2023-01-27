using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolInventoryMGMT
{
    class Program
    {
        static void Main(string[] args)
        {
            ToolInventory inventory = new ToolInventory();

            while (true)
            {
                Console.WriteLine("1. Add Tool");
                Console.WriteLine("2. Remove Tool");
                Console.WriteLine("3. Print Inventory");
                Console.WriteLine("4. Search Tool");
                Console.WriteLine("5. Exit");
                Console.Write("Please choose an option: ");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter tool name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter tool quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter tool cost: ");
                    double cost = double.Parse(Console.ReadLine());
                    Console.Write("Enter tool size in inches: ");
                    double size = double.Parse(Console.ReadLine());
                    Console.Write("Enter tool weight in pounds (use decimal number if needed): ");
                    float weight = float.Parse(Console.ReadLine());
                    Console.Write("Enter tool model: ");
                    string model = Console.ReadLine();

                    inventory.AddTool(name, quantity, cost, size, weight, model);
                    Console.WriteLine("Tool added successfully!");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter tool name: ");
                    string name = Console.ReadLine();

                    inventory.RemoveTool(name);
                    Console.WriteLine("Tool removed successfully!");
                }
                else if (choice == 3)
                {
                    inventory.PrintInventory();
                }
                else if (choice == 4)
                {
                    Console.Write("Enter search string: ");
                    string searchString = Console.ReadLine();

                    List<Tool> searchResults = inventory.Search(searchString);
                    if (searchResults.Count == 0)
                    {
                        Console.WriteLine("No matching tools found.");
                    }
                    else
                    {
                        Console.WriteLine("Search results:");
                        foreach (Tool tool in searchResults)
                        {
                            Console.WriteLine("Name: {0}, Quantity: {1}, Cost: {2}, Size: {3}, Weight: {4}, Model: {5}",
                                              tool.Name, tool.Quantity, tool.Cost, tool.Size, tool.Weight, tool.Model);
                        }
                    }
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
                Console.WriteLine();
            }
        }
    }
}
