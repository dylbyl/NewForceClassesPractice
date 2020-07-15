using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            City Ironton = new City("Ironton", "Dylan", "2018");
            Building FiveOneTwoEighth = new Building("512 8th Ave", "Dylan Bishop")
            {
                Width = 5,
                Depth = 5,
                Stories = 5
            };

            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Angela Lentz");
            Ironton.AddBuilding(FiveOneTwoEighth);

            Building FiveOneOneEighth = new Building("511 8th Ave", "Angela Lentz")
            {
                Width = 4,
                Depth = 6,
                Stories = 20
            };

            FiveOneOneEighth.Construct();
            FiveOneOneEighth.Purchase("Dylan Bishop");
            Ironton.AddBuilding(FiveOneOneEighth);

            foreach (Building building in Ironton.Buildings)
            {
                building.Print();
            }

            Employee rachel = new Employee("Rachel", "Green", "Fashionista");

            Company acme = new Company("Acme");

            acme.AddEmployee(rachel);

            acme.ListEmployees();
        }
    }
}
