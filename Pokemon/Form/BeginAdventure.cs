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
        // some needed variables
        int currentListIndex = 0;
        
        
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
        private MenuInfo[] regionsList = new MenuInfo[6] { new MenuInfo(1, "Kanto", "Kanto description"),
        new MenuInfo(2, "Johto", "Johto description"), new MenuInfo(3, "Hoenn", "Hoenn description"),
        new MenuInfo(4, "Sinnoh", "Sinnoh description"), new MenuInfo(5, "Unova", "Unova description"),
        new MenuInfo(6, "Kalos", "Kalos description") };
        
        public BeginAdventure()
        {
            InitializeComponent();
        }

        private void BeginAdventure_Load(object sender, EventArgs e)
        {
            setImages();
            lblCurrentRegion.Text = regionsList[currentListIndex].Name;
            lblDescription.Text = regionsList[currentListIndex].Descr;
        }

        private int getNext()
        {
            if (currentListIndex == 5)
                return 0;
            else
                return (currentListIndex + 1);
        }

        private void setNext()
        {
            if (currentListIndex == 5)
                currentListIndex = 0;
            else
                ++currentListIndex;
        }

        private int getPrevious()
        {
            if (currentListIndex == 0)
                return 5;
            else
                return (currentListIndex - 1);
        }

        private void setPrevious()
        {
            if (currentListIndex == 0)
                currentListIndex = 5;
            else
                --currentListIndex;
        }

        private Image getImagebyIndex(int i)
        {
            return Image.FromFile("..//..//Resources//Images//Regions//" + regionsList[i].Name + ".png");
        }

        private void setImages()
        {
            this.pbxCurrent.Image = getImagebyIndex(currentListIndex);
            int test1 = getNext();
            this.pbxNext.Image = getImagebyIndex(getNext());
            int test2 = getPrevious();
            this.pbxPrevious.Image = getImagebyIndex(getPrevious());
        }

        private void btnCycleRight_Click(object sender, EventArgs e)
        {
            setNext();
            setImages();
            lblCurrentRegion.Text = regionsList[currentListIndex].Name;
            lblDescription.Text = regionsList[currentListIndex].Descr;
        }

        private void btnCycleLeft_Click(object sender, EventArgs e)
        {
            setPrevious();
            setImages();
            lblCurrentRegion.Text = regionsList[currentListIndex].Name;
            lblDescription.Text = regionsList[currentListIndex].Descr;
        }
    }
}
