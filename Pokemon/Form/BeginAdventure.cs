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
        BasePokemon caterpie = new BasePokemon("Caterpie", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon metapod = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon butterfree = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon weedle = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kakuna = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon Beedrill = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon pidgey = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon pidgeotto = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon pidgeot = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon rattata = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon raticate = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon spearow = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon fearow = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon ekans = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon arbok = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { }); 
        BasePokemon pikachu = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon raichu = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon sandshrew = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon sandslash = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidoranf = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidorina = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidoqueen = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidoranm = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidorino = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon nidoking = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon clefairy = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon clefable = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon vulpix = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon ninetales = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon jigglypuff = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon wigglytuff = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon zubat = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon golbat = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon oddish = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon gloom = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon vileplume = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon paras = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon parasect = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon venonat = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon venomoth = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon diglett = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dugtrio = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon meowth = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon persian = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon psyduck = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon golduck = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon mankey = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon primeape = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon growlithe = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon arcanine = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon poliwag = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon poliwhirl = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon poliwrath = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon abra = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kadabra = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon alakazam = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon machop = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon machoke = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon machamp = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon bellsprout = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon weepinbell = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon victreebel = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon tentacool = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon tentacruel = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon geodude = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon graveler = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon golem = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon ponyta = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon rapidash = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon slowpoke = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon slowbro = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon magnemite = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon magneton = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon farfetchd = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon doduo = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dodrio = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon seel = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dewgong = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon grimer = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon muk = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon shellder = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon cloyster = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon gastly = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon haunter = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon gengar = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon onix = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon drowzee = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon hypno = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon krabby = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kingler = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon voltorb = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon electrode = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon exeggcute = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon exeggutor = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon cubone = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon marowak = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon hitmonlee = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon hitmonchan = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon lickitung = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon koffing = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon weezing = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon rhyhorn = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon rhydon = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon chansey = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon tangela = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kangaskhan = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon horsea = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon seedra = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon goldeen = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon seaking = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon staryu = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon starmie = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon mrMime = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon scyther = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon jynx = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon electabuzz = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon magmar = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon pinsir = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon tauros = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon magikarp = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon gyarados = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon lapras = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon ditto = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon eevee = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon vaporeon = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon jolteon = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon flareon = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon porygon = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon omanyte = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon omastar = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kabuto = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon kabutops = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon aerodactyl = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon snorlax = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon articuno = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon zapdos = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon moltres = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dratini = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dragonair = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon dragonite = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon mewtwo = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
        BasePokemon mew = new BasePokemon("name", 0, 0, 0, 0, 0.0, 0, new int[] { }, new int[] { }, new int[] { });
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
