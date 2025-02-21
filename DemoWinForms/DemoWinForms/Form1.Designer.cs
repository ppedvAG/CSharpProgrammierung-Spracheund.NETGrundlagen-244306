namespace DemoWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFahrzeugListe = new ListBox();
            label1 = new Label();
            lblErgebnis = new Label();
            btnNeuesFahrzeug = new Button();
            btnFahrzeugLoeschen = new Button();
            menuStrip1 = new MenuStrip();
            miBeenden = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbFahrzeugListe
            // 
            lbFahrzeugListe.FormattingEnabled = true;
            lbFahrzeugListe.ItemHeight = 15;
            lbFahrzeugListe.Location = new Point(49, 61);
            lbFahrzeugListe.Name = "lbFahrzeugListe";
            lbFahrzeugListe.Size = new Size(200, 184);
            lbFahrzeugListe.TabIndex = 0;
            lbFahrzeugListe.SelectedIndexChanged += lbFahrzeugListe_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 42);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Vorhandene Fahrzeuge";
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(52, 249);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(52, 15);
            lblErgebnis.TabIndex = 2;
            lblErgebnis.Text = "Ergebnis";
            // 
            // btnNeuesFahrzeug
            // 
            btnNeuesFahrzeug.Location = new Point(423, 66);
            btnNeuesFahrzeug.Name = "btnNeuesFahrzeug";
            btnNeuesFahrzeug.Size = new Size(193, 23);
            btnNeuesFahrzeug.TabIndex = 3;
            btnNeuesFahrzeug.Text = "Neues Fahrzeug";
            btnNeuesFahrzeug.UseVisualStyleBackColor = true;
            btnNeuesFahrzeug.Click += btnNeuesFahrzeug_Click;
            // 
            // btnFahrzeugLoeschen
            // 
            btnFahrzeugLoeschen.Location = new Point(423, 113);
            btnFahrzeugLoeschen.Name = "btnFahrzeugLoeschen";
            btnFahrzeugLoeschen.Size = new Size(193, 23);
            btnFahrzeugLoeschen.TabIndex = 4;
            btnFahrzeugLoeschen.Text = "Lösche Fahrzeug";
            btnFahrzeugLoeschen.UseVisualStyleBackColor = true;
            btnFahrzeugLoeschen.Click += btnFahrzeugLoeschen_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { miBeenden });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // miBeenden
            // 
            miBeenden.Name = "miBeenden";
            miBeenden.Size = new Size(65, 20);
            miBeenden.Text = "Beenden";
            miBeenden.Click += miBeenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFahrzeugLoeschen);
            Controls.Add(btnNeuesFahrzeug);
            Controls.Add(lblErgebnis);
            Controls.Add(label1);
            Controls.Add(lbFahrzeugListe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbFahrzeugListe;
        private Label label1;
        private Label lblErgebnis;
        private Button btnNeuesFahrzeug;
        private Button btnFahrzeugLoeschen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem miBeenden;
    }
}
