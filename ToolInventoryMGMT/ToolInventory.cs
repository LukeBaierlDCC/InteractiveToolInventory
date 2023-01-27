using System;
using System.Collections.Generic;
using ToolInventoryMGMT;

class ToolInventory
{
    // A list to hold our tools
    private List<Tool> tools;

    public ToolInventory()
    {
        tools = new List<Tool>();
    }

    public void AddTool(string name, int quantity, double cost, double weight, string model)
    {
        tools.Add(new Tool(name, quantity, cost, weight, model));
    }

    public void RemoveTool(string name)
    {
        tools.RemoveAll(tool => tool.Name == name);
    }

    public void PrintInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (Tool tool in tools)
        {
            Console.WriteLine("Name: {0}, Quantity: {1}, Cost: {2}, Weight: {3}, Model: {4}",
                              tool.Name, tool.Quantity, tool.Cost, tool.Weight, tool.Model);
        }
    }

    public List<Tool> Search(string name)
    {
        return tools.FindAll(tool => tool.Name.Contains(name));
    }
}