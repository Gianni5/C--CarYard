using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarYard
{
    class Printer
    {
        private string FileCar; // field 

        // class constructor
        public Printer (string filecar)
        {
            FileCar = filecar;

        }
        /// <summary>
        /// this is a method to write a car to the file
        /// </summary>
        /// <param name="car"></param>
        /// <param name="append"></param>
        public void Write(Car car , bool append = false)
        {
            StreamWriter sr = new StreamWriter(FileCar , append);// create a new object
            sr.WriteLine(car.ConvertToCSV());
            sr.Close();
        }

        public void Write(Car[]Cars , bool append = false)
        {
            StreamWriter sr = new StreamWriter(FileCar , append);
            foreach(var car in Cars)
            {
                if (car != null)
                {
                    sr.WriteLine(car.ConvertToCSV());
                }
            }
            sr.Close();
        }

        /// <summary>
        /// this is a reading cars method
        /// </summary>
        /// <returns></returns>
        public Car [] ReadCars()
        {
            Car[] loadedCars = new Car[99999];

            // Open my file
            StreamReader file = new StreamReader(FileCar);
            
            // read each line and store it.
            string line = file.ReadLine();
            while (line != null)
            {
                // Breack each line into parts

                string[] fields = line.Split(',');

                // converting non strings
                int plate = int.Parse(fields[1]);
                DateTime year = DateTime.Parse(fields[4]);
                loadedCars[plate] = new Car(fields[0], plate, fields[2], fields[3], year);
                line = file.ReadLine();


            }
            file.Close();

            return loadedCars;
        }


    }
}
