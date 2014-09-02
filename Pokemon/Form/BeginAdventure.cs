using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon.Core;

namespace Pokemon
{
    public partial class BeginAdventure : Form
    {
        // crap I'm just throwing in to force an upload to the database
        BasePokemon bulbasaur = new BasePokemon("Bulbasaur", 45, 5355, 5609, 001, 87.5, 3, new int[] { 45, 49, 49, 65, 65, 45 }, new int[] { 11, 3 }, new int[] { 0, 0, 0, 1, 0, 0 });
        BasePokemon ivysaur = new BasePokemon("Ivysaur", 45, 5355, 5609, 002, 87.5, 3, new int[] { 60, 62, 63, 80, 80, 60 }, new int[] { 11, 3 }, new int[] { 0, 0, 0, 1, 1, 0 });
        BasePokemon venusaur = new BasePokemon("Venusaur", 45, 5355, 5609, 003, 87.5, 3, new int[] { 80, 82, 83, 100, 100, 80 }, new int[] { 11, 3 }, new int[] { 0, 0, 0, 2, 1, 0 });
        BasePokemon charmander = new BasePokemon("Charmander", 45, 5355, 5609, 004, 87.5, 3, new int[] { 39, 52, 43, 60, 50, 65 }, new int[] { 9 }, new int[] { 0, 0, 0, 0, 0, 1 });
        BasePokemon charmeleon = new BasePokemon("Charmeleon", 45, 5355, 5609, 005, 87.5, 3, new int[] { 58, 64, 58, 80, 65, 80 }, new int[] { 9 }, new int[] { 0, 0, 0, 1, 0, 1 });
        BasePokemon charizard = new BasePokemon("Charizard", 45, 5355, 5609, 006, 87.5, 3, new int[] { 78, 84, 78, 109, 85, 100 }, new int[] { 9, 2 }, new int[] { 0, 0, 0, 3, 0, 0 });
        BasePokemon squirtle = new BasePokemon("Squirtle", 45, 5355, 5609, 007, 87.5, 3, new int[] { 44, 48, 65, 50, 64, 43 }, new int[] { 10 }, new int[] { 0, 0, 1, 0, 0, 0 });
        BasePokemon wartortle = new BasePokemon("Wartortle", 45, 5355, 5609, 008, 87.5, 3, new int[] { 59, 63, 80, 65, 80, 58 }, new int[] { 10 }, new int[] { 0, 0, 1, 0, 1, 0 });
        BasePokemon blastoise = new BasePokemon("Blastoise", 45, 5355, 5609, 009, 87.5, 3, new int[] { 79, 83, 100, 85, 105, 78 }, new int[] { 10 }, new int[] { });

        // end crap
        
        #region Member_Variables
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

        int currentListIndex = 0;
        int selectedOriginIndex = -1;
        int selectedStartIndex = -1;

        // a list of regions to iterate through
        private MenuInfo[] regionsList = new MenuInfo[6]
        { 
        new MenuInfo(1, "Kanto", "One of the smaller regions in the world. Kanto is largely made up of flat grassland. Of all the regions Kanto is one of the most technologically advanced. Kanto leads the world in Pokemon technology, the modern Pokeball being a result of developments from the Kanto region."),
        new MenuInfo(2, "Johto", "Closely related to the Kanto region by virtue of neighboring it. Johto is a more traditional region than Kanto, but still has some larger metropolitan areas like Goldenrod City."),
        new MenuInfo(3, "Hoenn", "The most natural regions that exists. Hoenn lacks the the larger metropolitan cities like other regions. Hoenn also has significantly more water than most of the other regions."),
        new MenuInfo(4, "Sinnoh", "The most traditional of all the regions in the world. Sinnoh is steeped in local myths and legends."),
        new MenuInfo(5, "Unova", "The most urbanized of all the regions. Unova has massive cities."),
        new MenuInfo(6, "Kalos", "A region where the nobility still have a significant place in society. Kalos is very large, on the scale of Unova.")
        };

        private string[] professorNames = new string[6]
        {
            "Oak",
            "Elm",
            "Birch",
            "Rowan",
            "Juniper",
            "Sycamore"
        };

        #endregion

        public BeginAdventure()
        {
            InitializeComponent();
        }

        #region Event_Handlers
        private void BeginAdventure_Load(object sender, EventArgs e)
        {
            // CRAP

            Pokemon.Model.Client client = new Pokemon.Model.Client();
            var basePokemonCollection = client.getCollection<BasePokemon>("basePokemon");

            basePokemonCollection.Save(bulbasaur);
            // END CRAP
            
            
            
            // this button is only necessary once the user has moved forward
            // in the process, so it is disabled here.
            pnlProfessorTalk.Enabled = false;
            pnlProfessorTalk.Visible = false;
            btnGoBack.Enabled = false;
            setImages();
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

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            // if the player is selecting the region of origin
            if (btnGoBack.Enabled == false)
            {
                lblPrompt.Text = "Select a region to start in!";
                btnGoBack.Enabled = true;
                selectedOriginIndex = currentListIndex;
                currentListIndex = 0;
                setImages();
                updateText();
            }
            else
            {
                // second pass
                selectedStartIndex = currentListIndex;
                pnlProfessorTalk.Enabled = true;
                pnlProfessorTalk.Visible = true;

                
                pbxProfessor.Image = Image.FromFile("..//..//Resources//Images//Characters//Large//Professor_" +
                    professorNames[selectedStartIndex] + ".png");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            lblPrompt.Text = "Select your region of origin!";
            btnGoBack.Enabled = false;
            selectedOriginIndex = -1;
            currentListIndex = 0;
            setImages();
            updateText();
        }
#endregion

        #region Private_Methods
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
            this.pbxNext.Image = getImagebyIndex(getNext());
            this.pbxPrevious.Image = getImagebyIndex(getPrevious());
        }

        private void updateText()
        {
            lblCurrentRegion.Text = regionsList[currentListIndex].Name;
            lblDescription.Text = regionsList[currentListIndex].Descr;
        }
        #endregion
    }
}
