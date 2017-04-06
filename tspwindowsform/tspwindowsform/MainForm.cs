using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using traveling_salesman_problem;

namespace tspwindowsform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            string pocetnaAdresa = nazivUliceTextBox.Text + " " + int.Parse(kucniBrojTextBox.Text) + " " + int.Parse(postanskiBrojTextBox.Text) + " " + mjestoTextBox.Text;            
            Address origin = new Address(pocetnaAdresa);
            Trip.GetInstance().Initialize(origin, "addresses.txt", int.Parse(brojVozilaTextBox.Text));

            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());

            rutaLabel.Text = Trip.GetInstance().Plan.ToString();
            Console.WriteLine(Trip.GetInstance().Plan.ToString());
            Console.ReadLine();


        }
    }
}
