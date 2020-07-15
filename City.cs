using System;
using System.Collections.Generic;

namespace classes
{
    public class City {
        public City (string name, string mayor, string yearEstablished){
            _name = name;
            _mayor = mayor;
            _yearEstablished = yearEstablished;
        }

        private string _name{get; set;}
        private string _mayor{get; set;}
        private string _yearEstablished{get; set;}

        public List<Building> Buildings{get; set;} = new List<Building>();

        public void AddBuilding(Building building){
            Buildings.Add(building);
        }
    }
}