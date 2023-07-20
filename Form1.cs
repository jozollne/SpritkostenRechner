using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpritkostenRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            double spritKosten = 0;
            double strecke = 0;
            double verbrauch = 0;
            double gesKosten = 0;

            try
            {
                spritKosten = Convert.ToDouble(spritkostenBox.Text);
                strecke = Convert.ToDouble(streckeBox.Text);
                verbrauch = Convert.ToDouble(verbauchBox.Text);
            }
            catch
            {
                spritGesKostenLabel.Text = "Spritkosten Ges.: Ungültiger Wert";
                return;
            }

            gesKosten = (verbrauch / 100) * strecke * spritKosten;
            spritGesKostenLabel.Text = "Spritkosten Ges.: " + gesKosten + "€";
        }
    }
}
