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
        private MenuInfo[] regionsList = new MenuInfo[6] { new MenuInfo(1, "Kanto", "One of the smaller regions in the world. Kanto is largely made up of flat grassland. Of all the regions Kanto is one of the most technologically advanced. Kanto leads the world in Pokemon technology, the modern Pokeball being a result of developments from the Kanto region."),
        new MenuInfo(2, "Johto", "Closely related to the Kanto region by virtue of neighboring it. Johto is a more traditional region than Kanto, but still has some larger metropolitan areas like Goldenrod City."), new MenuInfo(3, "Hoenn", "The most natural regions that exists. Hoenn lacks the the larger metropolitan cities like other regions. Hoenn also has significantly more water than most of the other regions."),
        new MenuInfo(4, "Sinnoh", "The most traditional of all the regions in the world. Sinnoh is steeped in local myths and legends."), new MenuInfo(5, "Unova", "The most urbanized of all the regions. Unova has massive cities."),
        new MenuInfo(6, "Kalos", "A region where the nobility still have a significant place in society. Kalos is very large, on the scale of Unova.") };
        
        public BeginAdventure()
        {
            InitializeComponent();
        }

        private void BeginAdventure_Load(object sender, EventArgs e)
        {
            // this button is only necessary once the user has moved forward
            // in the process, so it is disabled here.
            btnGoBack.Enabled = false;
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

        private void updateText()
        {
            lblCurrentRegion.Text = regionsList[currentListIndex].Name;
            lblDescription.Text = regionsList[currentListIndex].Descr;
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            if (clicked.Text == "◀")
                setPrevious();
            else
                setNext();
            setImages();
            updateText();
        }
    }
}
