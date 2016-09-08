using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* James William "Jimmy" Buffett (born December 25, 1946) */
            //Musicians.AddMusicArtist(
            //    CreateNewArtist("Jimmy",
            //            "",
            //            "Buffet",
            //        new DateTime(1946, 12, 25))
            //    );
        }

        public MusicArtist CreateNewArtist(string firstName, 
            string middleName, string lastName, DateTime birthDate)
        {
            return new MusicArtist(string.Format("{0}{1} {2}{3} {4}",
                     lastName,
                     ",",
                     firstName,
                     ",",
                     middleName), 
                     birthDate);
        }
    }
}
