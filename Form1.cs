using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisFactory_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Generate_Ores();

            OreList.FullRowSelect = true;
            OreList.GridLines = true;
            OreList.View = View.Details;
            OreList.Sorting = SortOrder.None;
           

            foreach(Ores o in Functions.OreList)
            {
                OreList.Items.Add(new ListViewItem(o.Name));
            }
        }

        private void BTN_Extraction_Click(object sender, EventArgs e)
        {
            AddExtraction add = new AddExtraction();
            add.ShowDialog();
            Extraction ex = add.Extraction;
            Console.WriteLine("loaded");
        }
    }

    public class Ores
    {
        public enum type {None, Limestone, Iron_Ore, Copper_Ore, Caterium_Ore,Coal, Raw_Quartz, Sulfur, Bauxite, SAM_Ore, Uranium}
        public type Type = type.None;
        public string Name;
        public int ResourceSinkPoints;
        public Image Image;
    }

    public class Extraction
    {
        public enum type { None, Miner_Mk1, Miner_Mk2, Miner_Mk3, OilExtractor, WaterExtractor }
        public type Type = type.None;
        public enum nodeType {None = 0, Impure = 30, Normal = 60, Pure = 120}
        public nodeType Nodetype = nodeType.None;
        public string Name;
        public Image Image;
    }

    public static class Functions
    {
        public static List<Ores> OreList = new List<Ores>();
        public static List<Ores> MiningList = new List<Ores>();  

        public static void Generate_Ores()
       {
            Ores Limestone = new Ores() 
            {
                Type = Ores.type.Limestone, 
                Name = "Limestone",
                ResourceSinkPoints = 2,
                Image = null
            };
            OreList.Add(Limestone);

            Ores IronOre = new Ores()
            {
                Type = Ores.type.Iron_Ore,
                Name = "Iron Ore",
                ResourceSinkPoints = 1,
                Image = null
            };
            OreList.Add(IronOre);

            Ores CopperOre = new Ores()
            {
                Type = Ores.type.Copper_Ore,
                Name = "Copper Ore",
                ResourceSinkPoints = 3,
                Image = null
            };
            OreList.Add(CopperOre);

            Ores CateriumOre = new Ores()
            {
                Type = Ores.type.Caterium_Ore,
                Name = "Caterium Ore",
                ResourceSinkPoints = 7,
                Image = null
            };
            OreList.Add(CateriumOre);

            Ores Coal = new Ores()
            {
                Type = Ores.type.Coal,
                Name = "Coal",
                ResourceSinkPoints = 3,
                Image = null
            };
            OreList.Add(Coal);

            Ores RawQuartz = new Ores()
            {
                Type = Ores.type.Raw_Quartz,
                Name = "Raw Quartz",
                ResourceSinkPoints = 15,
                Image = null
            };
            OreList.Add(RawQuartz);

            Ores Sulfur = new Ores()
            {
                Type = Ores.type.Sulfur,
                Name = "Sulfur",
                ResourceSinkPoints = 11,
                Image = null
            };
            OreList.Add(Sulfur);

            Ores Bauxite = new Ores()
            {
                Type = Ores.type.Bauxite,
                Name = "Bauxite",
                ResourceSinkPoints = 8,
                Image = null
            };
            OreList.Add(Bauxite);

            Ores SAMOre = new Ores()
            {
                Type = Ores.type.SAM_Ore,
                Name = "S.A.M Ore",
                ResourceSinkPoints = 0,
                Image = null
            };
            OreList.Add(SAMOre);

            Ores Uranium = new Ores()
            {
                Type = Ores.type.Uranium,
                Name = "Uranium",
                ResourceSinkPoints = 35,
                Image = null
            };
            OreList.Add(Uranium);
        }
    }
           
}


