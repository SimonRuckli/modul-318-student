using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportGUI
{
    public partial class Form1 : Form
    {

        private Transport Transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvAuflistung.Rows.Clear();
            Connections c = new Connections();
            c = Transport.GetConnections(ddlAbfahrtsort.Text, ddlAnkunftsort.Text);
            
            foreach(var element in c.ConnectionList)
            {
                if(element.From.Platform == null || element.From.Platform == "")
                {
                    dgvAuflistung.Rows.Add(DateTime.Parse(element.From.Departure).ToShortTimeString(), "1", element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString());
                }
                else 
                {
                    dgvAuflistung.Rows.Add(DateTime.Parse(element.From.Departure).ToShortTimeString(), element.From.Platform, element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString());
                }
            }
        }

        private void dgvAuflistung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Dieses Event wird gefeuert, wenn die ComboBox geöffnet wird. Das Event ruft die Methode Suchen() auf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlAbfahrtsort_DropDown(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Schlägt einige zum eingegebenen Wert passende Stationen vor.
        /// </summary>
        /// <param name="ddl"></param>
        private void Suchen(ComboBox ddl)
        {
            if(ddl.Text.Length >= 2)
            {
                Stations s = new Stations();
                s = Transport.GetStations(ddl.Text);
                foreach (var stat in s.StationList)
                {
                    ddl.Items.Add(stat.Name);
                }
            }
            else
            {
                MessageBox.Show("Bitte gib mehr Buchstaben ein, um die Suche etwas einzugrenzen.");
            }
        }

        private void ddlAnkunftsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Dieses Event wird gefeuert, wenn die ComboBox geöffnet wird. Das Event ruft die Methode Suchen() auf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlAnkunftsort_DropDown(object sender, EventArgs e)
        {
            
        }

        private void btnDropdownAbfahrt_Click(object sender, EventArgs e)
        {
            ddlAbfahrtsort.Items.Clear();
            Suchen(ddlAbfahrtsort);
            ddlAbfahrtsort.DroppedDown = true;
            ddlAbfahrtsort.Focus();
        }

        private void btnDropdownAnkunft_Click(object sender, EventArgs e)
        {
            ddlAnkunftsort.Items.Clear();
            Suchen(ddlAnkunftsort);
            ddlAnkunftsort.DroppedDown = true;
            ddlAnkunftsort.Focus();
        }

        private void dgvAuflistung_SelectionChanged(object sender, EventArgs e)
        {
            dgvAuflistung.ClearSelection();
        }
    }
}
