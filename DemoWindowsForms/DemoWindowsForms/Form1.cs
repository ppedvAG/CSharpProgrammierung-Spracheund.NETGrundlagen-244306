using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Demo;

namespace DemoWindowsForms
{
    public partial class frmFahrzeuge : Form
    {
        public frmFahrzeuge()
        {
            InitializeComponent();
        }

        Dictionary<int, Fahrzeug> Fahrzeuge = new Dictionary<int, Fahrzeug>();
        int FahrzeugCounter = 0;

        private void btnFahrzeugHinzufuegen_Click(object sender, EventArgs e)
        {
            Fahrzeug fahrzeug = new Auto("blau", "benzin", 0, 5);
            Fahrzeuge.Add(FahrzeugCounter, fahrzeug);
            lbFahrzeugliste.Items.Add($"{FahrzeugCounter}: {Fahrzeuge[FahrzeugCounter].GetFarbe()}");
            FahrzeugCounter++;
        }

        private void btnFahrzeugEntfernen_Click(object sender, EventArgs e)
        {
            // Ausgewähltes Fahrzeug entfernen
            if (lbFahrzeugliste.SelectedIndex != -1)
            {
                int key = int.Parse(lbFahrzeugliste.SelectedItem.ToString().First().ToString());
                Fahrzeuge.Remove(key);
                lbFahrzeugliste.Items.RemoveAt(lbFahrzeugliste.SelectedIndex);
            }
        }

        private void lbFahrzeugliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ausgewähltes Fahrzeug anzeigen
            if (lbFahrzeugliste.SelectedIndex != -1)
            {
                int key = int.Parse(lbFahrzeugliste.SelectedItem.ToString().First().ToString());
                lblFahrzeugInfo.Text = $"Fahrzeug{key}: Farbe: {Fahrzeuge[key].GetFarbe()}, Geschwindigkeit: {Fahrzeuge[key].GetGeschwindigkeit()}";
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Fahrzeuge.txt";
            saveFileDialog.Filter = "Textdatei|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(path);
                string json = JsonSerializer.Serialize(Fahrzeuge);
                sw.Write(json);
                sw.Close();
            }
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Fahrzeuge.txt";
            openFileDialog.Filter = "Textdatei|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                StreamReader sr = new StreamReader(path);

                Dictionary<int, Auto> geladeneFahrzeuge = new Dictionary<int, Auto>();
                geladeneFahrzeuge = JsonSerializer.Deserialize<Dictionary<int, Auto>>(sr.ReadToEnd());
                foreach (var geladenesFahrzeug in geladeneFahrzeuge)
                {
                    Fahrzeuge.Add(geladenesFahrzeug.Key, geladenesFahrzeug.Value);
                    lbFahrzeugliste.Items.Add($"{FahrzeugCounter}: {geladenesFahrzeug.Value.GetFarbe()}");
                    FahrzeugCounter++;
                }
                sr.Close();
            }
        }
    }
}
