using System;

namespace classes
{
    // Define class here
    public class Building {
        public Building(string address, string designer){
            _address = address;
            _designer = designer;
        }

        private string _designer {get; set;}
        private DateTime _dateConstructed {get; set;}
        private string _address {get; set;}
        private string _owner {get; set;}

        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume() {
            return (Width * Depth * (3 * Stories));
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string newOwner) {
            _owner = newOwner;
        }

        public void Print() {
            Console.WriteLine(_address);
            Console.WriteLine("----------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume()} cubic meters of space");
        }
    }
}