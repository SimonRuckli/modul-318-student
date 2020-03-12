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
            MinimumSize = new Size(680, 490);
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
        /// Durch klicken des "Abfahrtsplan-Buttons" wird dieses Event gefeuert, welches das Abfahrtsplan-Formular öffnet.
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
        /// Diese Funktion verhindert, das im DataGridView etwas markiert werden kann.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvAuflistung_SelectionChanged(object sender, EventArgs e)
        {
            dgvAuflistung.ClearSelection();
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
            if (ddlAbfahrtsort.Text != null && ddlAbfahrtsort.Text != "")
            {
                ddlAbfahrtsort.DroppedDown = true;
            }
            ddlAbfahrtsort.Focus();
        }

        /// <summary>
        /// Durch dieses Event wird das Formular geschlossen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Dieses Event stellt sicher, dass die Applikation richtig schliesst, wenn man es über das rote X macht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abfahrtstafel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Durch dieses Event switcht man von diesem Form zum Ortsformular.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrt_Click(object sender, EventArgs e)
        {
            Hide();
            Ort ort = new Ort();
            ort.ShowDialog();
        }
    }
}
