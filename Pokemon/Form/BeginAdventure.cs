using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class BeginAdventure : Form
    {
        // this is just a small helper class to organize data
        // I might actually come back and make it a struct
        private class MenuInfo
        {
            public string Name { get; set; }
            public string Descr { get; set; }
            public int id { get; set; }

            public MenuInfo(int i, string n, string d)
            {
                this.Name = n;
                this.Descr = d;
                this.id = i;
            }
        }

        // a list of regions to iterate through
        protected MenuInfo[] regionsList = new MenuInfo[6] { new MenuInfo(1, "Kanto", "Kanto description"),
        new MenuInfo(2, "Johto", "Johto description"), new MenuInfo(3, "Hoenn", "Hoenn description"),
        new MenuInfo(4, "Sinnoh", "Sinnoh description"), new MenuInfo(5, "Unova", "Unova description"),
        new MenuInfo(6, "Kalos", "Kalos description") };
        
        public BeginAdventure()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panelGetInfo.Hide();
        }
    }
}
