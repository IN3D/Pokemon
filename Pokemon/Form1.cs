using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // mongoDB test
            try
            {
                TypeContext tcx = new TypeContext();

                MessageBox.Show("Success, for now...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed!\n" + ex.ToString());
            }

        }


    }
}
