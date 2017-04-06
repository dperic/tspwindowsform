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
                        
            Address origin = new Address(pocetnaAdresaTextBox.Text);
            Trip.GetInstance().Initialize(origin, "addresses.txt", int.Parse(brojVozilaTextBox.Text));

            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());

            Trip.GetInstance().DisplayRoutes();
        }

    }
}
