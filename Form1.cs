using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarYard
{
    public partial class Form1 : Form
    {
        private Car[] Cars = new Car[99999];
        private Car SavedCar;
        private Printer PrinterManager = new Printer("Cars.txt");
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// array index
        /// </summary>
        private void SetCar()
        {
            
            SavedCar = new Car(txbBrand.Text, (int)nUdPlate.Value, txbModel.Text, txbColour.Text, dateTimePicker1.Value);
        }

        private void PrintAllCars()
        {
            Console.WriteLine("Printing All Cars..");
            foreach (var car in Cars)
            {
                if(car != null)
                {
                    car.Print();
                }
                  
            }
        }

        private void ClearForm()
        {
            txbBrand.Text = "";
            nUdPlate.Value = 0;
            txbModel.Text = "";
            txbColour.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void UpdateListView()
        {
            listView1.Clear();

            foreach(var car in Cars)
            {
                if (car != null)
                {
                    listView1.Items.Add(car.ToString());
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SetCar();
            SavedCar.Print();
            PrinterManager.Write(SavedCar);
        }

        private void bntSaveCar_Click(object sender, EventArgs e)
        {
            SetCar();

            //assign Car  to Array
            Cars[SavedCar.Plate] = SavedCar;
            PrintAllCars();
            PrinterManager.Write(Cars);
            ClearForm();
        }

        private void btnLoadCars_Click(object sender, EventArgs e)
        {
            Cars = PrinterManager.ReadCars();
            PrintAllCars();
            UpdateListView();
        }

        /// <summary>
        /// open files and folders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
        }

        
    }
}
