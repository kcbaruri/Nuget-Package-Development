using PackageDependentLibrary;
using System;

namespace NugetPackageConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineContent onlineContent = new OnlineContent();
            onlineContent.Id = 100;
            onlineContent.Name = "Nuget package introduction";
            onlineContent.Description = "This is the nuget package introduction and based on that one can make a rich package to use in the project.";

            Console.WriteLine("You are done to nuget package!");
        }
    }
}
