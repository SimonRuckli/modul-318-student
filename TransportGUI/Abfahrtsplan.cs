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
    public partial class Abfahrtsplan : Form
    {

        private Transport Transport = new Transport();
        public Abfahrtsplan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Auf Knopfdruck wird durch dieses Event das Formular geschlossen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Schlägt einige zum eingegebenen Wert passende Stationen vor.
        /// </summary>
        /// <param name="ddl"></param>
        public void Suchen(ComboBox ddl)
        {
            if(ddl.Text.Length >= 2)
            {
                Stations s = new Stations();
                s = Transport.GetStations(ddl.Text);
                foreach (var stat in s.StationList)
                {
                    if(stat.Id != null) 
                    {
                        ddl.Items.Add(stat.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte gib mehr Buchstaben ein, um die Suche etwas einzugrenzen.");
            }
        }

        /// <summary>
        /// Damit werden die automatischen Vorschläge generiert für die ComboBox des Abfahrtorts, indem die Funktion "Suchen()" aufgerufen wird.
        /// Zur Einfachheit, wird die ComboBox automatisch aufgeklappt und der Fokus gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDropdownAbfahrt_Click(object sender, EventArgs e)
        {
            ddlAbfahrtsort.Items.Clear();
            Suchen(ddlAbfahrtsort);
            if (ddlAbfahrtsort.Text != null && ddlAbfahrtsort.Text != "")
            {
                ddlAbfahrtsort.DroppedDown = true;
            }
            ddlAbfahrtsort.Focus();
        }

        /// <summary>
        /// Damit werden die automatischen Vorschläge generiert für die ComboBox des Ankunftorts, indem die Funktion "Suchen()" aufgerufen wird.
        /// Zur Einfachheit, wird die ComboBox automatisch aufgeklappt und der Fokus gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDropdownAnkunft_Click(object sender, EventArgs e)
        {
            ddlAnkunftsort.Items.Clear();
            Suchen(ddlAnkunftsort);
            if (ddlAnkunftsort.Text != null && ddlAnkunftsort.Text != "")
            {
                ddlAnkunftsort.DroppedDown = true;    
            }
            ddlAnkunftsort.Focus();
        }

        /// <summary>
        /// Dieses Event verhindert, das im DataGridView etwas markiert werden kann.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAuflistung_SelectionChanged(object sender, EventArgs e)
        {
            dgvAuflistung.ClearSelection();
        }

        /// <summary>
        /// Dieses Event schreibt die gefragten Daten in das DataGridView.
        /// Bei Änderung eines Orts werden die alten Daten gelöscht.
        /// Wenn kein Gleis abgerufen werden kann, wird automatisch Gleis 1 angegeben.
        /// Falls der Benutzer eine ungültige Eingabe eingibt, wird er darauf hingewiesen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Verbindungen_Click(object sender, EventArgs e)
        {
            if(ddlAbfahrtsort.Text != null || ddlAnkunftsort != null)
            {
                dgvAuflistung.Rows.Clear();
                Connections Connection = new Connections();
                Connection = Transport.GetConnections(ddlAbfahrtsort.Text, ddlAnkunftsort.Text);

                foreach (var element in Connection.ConnectionList)
                {
                    if (element.From.Platform == null || element.From.Platform == "")
                    {
                        dgvAuflistung.Rows.Add(DateTime.Parse(element.From.Departure).ToShortTimeString(), "1", element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString());
                    }
                    else
                    {
                        dgvAuflistung.Rows.Add(DateTime.Parse(element.From.Departure).ToShortTimeString(), element.From.Platform, element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte gib bei Abfahrtsort und Ankunftsort einen gültigen Wert ein.");
            }
        }

        /// <summary>
        /// Wenn dieses Event gefeuert wird, öffnet sich die Abfahrtstafel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Abfahrtstafel abfahrtstafel = new Abfahrtstafel();
            abfahrtstafel.ShowDialog();
        }
    }
}
