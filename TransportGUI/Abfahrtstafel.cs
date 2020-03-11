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

namespace TransportGUI
{
    public partial class Abfahrtstafel : Form
    {
        Abfahrtsplan Abfahrtsplan = new Abfahrtsplan();
        public Abfahrtstafel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wenn dieses Event gefeuert wird, werden die gefragten Daten in das DataGridView geschrieben.
        /// Bei erneuter Abfrage mit anderen Stationen, werden die alten Informationen aus dem DataGridView entfernt.
        /// Falls der Benutzer eine ungültige Eingabe eingibt, wird er darauf hingewiesen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbfahrtenAnzeigen_Click(object sender, EventArgs e)
        {
            if (ddlAbfahrtsort.Text != null)
            {
                dgvAuflistung.Rows.Clear();
                Transport transport = new Transport();
                StationBoardRoot s = new StationBoardRoot();
                s = transport.GetStationBoard(ddlAbfahrtsort.Text, ""); //Redundanz vorhanden, da Station einzigartig ist.
                
                foreach(var element in s.Entries)
                {
                    dgvAuflistung.Rows.Add(DateTime.Parse(element.Stop.Departure.ToString()).ToShortTimeString(), element.Name, element.To, element.Operator);
                }
            }
            else
            {
                MessageBox.Show("Bitte gib bei Abfahrtsort und Ankunftsort einen gültigen Wert ein.");
            }
        }

        /// <summary>
        /// Durch klicken des "Abfahrtsplan-Buttons" wird dieses Event gefeuert, was das Schliessen des Formulars zur Folge trägt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtsplan_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Dieses Event lässt Stations-Vorschläge in der ComboBox erscheinen.
        /// Zur vereinfachten Bedienung, wird die ComboBox automatisch aufgeklappt und der Fokus wird darauf gelegt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDropdownAbfahrt_Click(object sender, EventArgs e)
        {
            ddlAbfahrtsort.Items.Clear();
            Abfahrtsplan.Suchen(ddlAbfahrtsort);
            if(ddlAbfahrtsort.Text != null && ddlAbfahrtsort.Text != "")
            {
                ddlAbfahrtsort.DroppedDown = true;
            }
            ddlAbfahrtsort.Focus();
        }

        /// <summary>
        /// Diese Funktion verhindert, das im DataGridView etwas markiert werden kann.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAuflistung_SelectionChanged(object sender, EventArgs e)
        {
            dgvAuflistung.ClearSelection();
        }
    }
}
