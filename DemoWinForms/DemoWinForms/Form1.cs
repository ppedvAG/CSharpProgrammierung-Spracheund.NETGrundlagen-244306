using Demo;

namespace DemoWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, Fahrzeug> fahrzeuge = new Dictionary<string, Fahrzeug>();
        int fahrzeugCounter = 0;
        private void btnNeuesFahrzeug_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto("blau", "Benzin", 0, 5);
            lbFahrzeugListe.Items.Add($"Fahrzeug{fahrzeugCounter}: {auto.GetFarbe()}");
            fahrzeuge.Add("Fahrzeug" + fahrzeugCounter, auto);
            fahrzeugCounter++;
        }

        private void btnFahrzeugLoeschen_Click(object sender, EventArgs e)
        {
            // Wenn ein Item selektiert ist
            if (lbFahrzeugListe.SelectedIndex != -1)
            {
                // Teil des SelectetItem nur bis zum Doppelpunkt ist unser Key
                string key = lbFahrzeugListe.SelectedItem.ToString().Substring(0, lbFahrzeugListe.SelectedItem.ToString().IndexOf(':'));
                fahrzeuge.Remove(key);
                lbFahrzeugListe.Items.RemoveAt(lbFahrzeugListe.SelectedIndex);
            }
        }

        private void lbFahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFahrzeugListe.SelectedIndex != -1)
            {
                // Teil des SelectetItem nur bis zum Doppelpunkt ist unser Key
                string key = lbFahrzeugListe.SelectedItem.ToString().Substring(0, lbFahrzeugListe.SelectedItem.ToString().IndexOf(':'));

                lblErgebnis.Text = $"Name: {key}, Farbe: {fahrzeuge[key].GetFarbe()}, Treibstoff: {fahrzeuge[key].GetTreibstoff()}";

            }
        }

        

        private void miBeenden_Click(object sender, EventArgs e)
        {
            // Message Box zum Beenden der Applicaiton mit Auswahl Ja oder Nein
            if (MessageBox.Show("Wollen Sie die Applikation wirklich beenden?", "Beenden", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
