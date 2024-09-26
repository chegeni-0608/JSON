using JSON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializeToJson_Click(object sender, EventArgs e)
        {
            var emploeeList = new List<EmploeeModel> { 
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            };
        }
    }
}
