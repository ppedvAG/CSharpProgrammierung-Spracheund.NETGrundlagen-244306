namespace DemoWindowsForms
{
    partial class frmFahrzeuge
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
            lbFahrzeugliste = new ListBox();
            lblInfoListBox = new Label();
            lblFahrzeugInfo = new Label();
            btnFahrzeugHinzufuegen = new Button();
            btnFahrzeugEntfernen = new Button();
            btnSpeichern = new Button();
            btnLaden = new Button();
            SuspendLayout();
            // 
            // lbFahrzeugliste
            // 
            lbFahrzeugliste.FormattingEnabled = true;
            lbFahrzeugliste.ItemHeight = 15;
            lbFahrzeugliste.Location = new Point(43, 57);
            lbFahrzeugliste.Name = "lbFahrzeugliste";
            lbFahrzeugliste.Size = new Size(120, 94);
            lbFahrzeugliste.TabIndex = 0;
            lbFahrzeugliste.SelectedIndexChanged += lbFahrzeugliste_SelectedIndexChanged;
            // 
            // lblInfoListBox
            // 
            lblInfoListBox.AutoSize = true;
            lblInfoListBox.Location = new Point(44, 36);
            lblInfoListBox.Name = "lblInfoListBox";
            lblInfoListBox.Size = new Size(108, 15);
            lblInfoListBox.TabIndex = 1;
            lblInfoListBox.Text = "Liste der Fahrzeuge";
            // 
            // lblFahrzeugInfo
            // 
            lblFahrzeugInfo.AutoSize = true;
            lblFahrzeugInfo.Location = new Point(44, 154);
            lblFahrzeugInfo.Name = "lblFahrzeugInfo";
            lblFahrzeugInfo.Size = new Size(76, 15);
            lblFahrzeugInfo.TabIndex = 2;
            lblFahrzeugInfo.Text = "Fahrzeuginfo";
            // 
            // btnFahrzeugHinzufuegen
            // 
            btnFahrzeugHinzufuegen.Location = new Point(231, 59);
            btnFahrzeugHinzufuegen.Name = "btnFahrzeugHinzufuegen";
            btnFahrzeugHinzufuegen.Size = new Size(149, 23);
            btnFahrzeugHinzufuegen.TabIndex = 3;
            btnFahrzeugHinzufuegen.Text = "Fahrzeug Hinzufügen";
            btnFahrzeugHinzufuegen.UseVisualStyleBackColor = true;
            btnFahrzeugHinzufuegen.Click += btnFahrzeugHinzufuegen_Click;
            // 
            // btnFahrzeugEntfernen
            // 
            btnFahrzeugEntfernen.Location = new Point(231, 100);
            btnFahrzeugEntfernen.Name = "btnFahrzeugEntfernen";
            btnFahrzeugEntfernen.Size = new Size(149, 23);
            btnFahrzeugEntfernen.TabIndex = 4;
            btnFahrzeugEntfernen.Text = "Fahrzeug Entfernen";
            btnFahrzeugEntfernen.UseVisualStyleBackColor = true;
            btnFahrzeugEntfernen.Click += btnFahrzeugEntfernen_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(402, 59);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(129, 23);
            btnSpeichern.TabIndex = 5;
            btnSpeichern.Text = "Fahrzeuge speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(402, 100);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(129, 23);
            btnLaden.TabIndex = 6;
            btnLaden.Text = "Fahrzeuge Laden";
            btnLaden.UseVisualStyleBackColor = true;
            btnLaden.Click += btnLaden_Click;
            // 
            // frmFahrzeuge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 228);
            Controls.Add(btnLaden);
            Controls.Add(btnSpeichern);
            Controls.Add(btnFahrzeugEntfernen);
            Controls.Add(btnFahrzeugHinzufuegen);
            Controls.Add(lblFahrzeugInfo);
            Controls.Add(lblInfoListBox);
            Controls.Add(lbFahrzeugliste);
            Name = "frmFahrzeuge";
            Text = "Fahrzeuge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbFahrzeugliste;
        private Label lblInfoListBox;
        private Label lblFahrzeugInfo;
        private Button btnFahrzeugHinzufuegen;
        private Button btnFahrzeugEntfernen;
        private Button btnSpeichern;
        private Button btnLaden;
    }
}
