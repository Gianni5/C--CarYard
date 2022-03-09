using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarYard
{   /// <summary>
    /// Child class inehritance from Vehicle class
    /// </summary>
    public class Car 
    {
        public string Brand { get; set; }
        public int Plate { get; set; } // field with (get and set method)
        public string Model { get; set; } // field with (get and set method)
        public string Colour { get; set; } // field with (get and set method)

        public DateTime Year { get; set; } // field with (get and set method) 

        /// <summary>
        /// constructor for Car class
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="plate"></param>
        /// <param name="model"></param>
        /// <param name="colour"></param>
        /// <param name="year"></param>

        public Car(string brand, int plate, string model, string colour, DateTime year) 
        {
            Brand = brand;
            Plate = plate;
            Model = model;
            Colour = colour;
            Year = year;
        }

        /// <summary>
        /// toString method converting parametra to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Brand} {Plate} {Model} {Colour} {Year.ToShortDateString()}";
        }

        /// <summary>
        /// Print method write to standard output
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Brand:  " + Brand);
            Console.WriteLine("Number Plate:  " + Plate);
            Console.WriteLine("Model:  " + Model);
            Console.WriteLine("Colour:  " + Colour);
            Console.WriteLine("Year:  " + Year.ToShortDateString());
        }

        /// <summary>
        ///  ConvertToCSV method commer separeted value "CSV"
        /// </summary>
        /// <returns></returns>
        public string ConvertToCSV()
        {
            return $"{Brand},{Plate},{Model},{Colour},{Year.ToShortDateString()}";
        }
    
    
    
    
    
    
    
    
    }

}