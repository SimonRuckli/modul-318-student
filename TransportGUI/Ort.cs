using System;
using SwissTransport;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TransportGUI
{
    public partial class Ort : Form
    {
        public Ort()
        {
            InitializeComponent();
            MinimumSize = new Size(361, 193);
        }

        /// <summary>
        /// Dieses Event stellt sicher, dass die Applikation richtig schliesst, wenn man es über das rote X macht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Dieses Event wird gefeuert, wenn man den "Beenden" Button klickt.
        /// Durch dieses Event schliesst sich das Formular.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Dieses Event lässt Stations-Vorschläge in der ComboBox erscheinen.
        /// Zur vereinfachten Bedienung, wird die ComboBox automatisch aufgeklappt und der Fokus wird darauf gelegt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDropdownStation_Click(object sender, EventArgs e)
        {
            Abfahrtsplan abfahrtsplan = new Abfahrtsplan();
            ddlStation.Items.Clear();
            abfahrtsplan.Suchen(ddlStation);
            if (ddlStation.Text != null && ddlStation.Text != "")
            {
                ddlStation.DroppedDown = true;
            }
            ddlStation.Focus();
        }

        /// <summary>
        /// Durch dieses Event switcht man von diesem Form zum Abfahrtsplan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtsplan_Click(object sender, EventArgs e)
        {
            Hide();
            Abfahrtsplan abfahrtsplan = new Abfahrtsplan();
            abfahrtsplan.ShowDialog();
        }

        /// <summary>
        /// Durch dieses Event switcht man von diesem Form zur Abfahrtstafel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Hide();
            Abfahrtstafel abfahrtstafel = new Abfahrtstafel();
            abfahrtstafel.ShowDialog();
        }

        /// <summary>
        /// Dieses Event speichert erst die 2 Koordinaten ein, die auf die gewählte Station zeigen.
        /// Danach wird eine URL aufgerufen die Maps öffnet, als Suchbegriff werden die Koordinaten verwendet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            Transport t = new Transport();
            Stations s = new Stations();
            s = t.GetStations(ddlStation.Text);

            string x = s.StationList[0].Coordinate.XCoordinate.ToString();
            string y = s.StationList[0].Coordinate.YCoordinate.ToString();

            System.Diagnostics.Process.Start($"https://www.google.ch/maps/place/{x},{y}");
        }
    }
}
