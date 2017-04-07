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

namespace traveling_salesman_problem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_onClick(object sender, EventArgs e)
        {
                        
            Address origin = new Address(tbOriginAddress.Text);
            Trip.GetInstance().Initialize(origin, "addresses.txt", int.Parse(tbVehicleCount.Text));

            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());

            Trip.GetInstance().DisplayRoutes();
        }

    }
}
