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
            ddlAbfahrtsort.Items.Clear();
            Suchen(ddlAbfahrtsort);
        }

        /// <summary>
        /// Schlägt einige zum eingegebenen Wert passende Stationen vor.
        /// </summary>
        /// <param name="ddl"></param>
        private void Suchen(ComboBox ddl)
        {
            Transport t = new Transport();
            Stations s = new Stations();
            s = t.GetStations(ddl.Text);
            foreach (var stat in s.StationList)
            {
                ddl.Items.Add(stat.Name);
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
            ddlAnkunftsort.Items.Clear();
            Suchen(ddlAnkunftsort);
        }
    }
}
