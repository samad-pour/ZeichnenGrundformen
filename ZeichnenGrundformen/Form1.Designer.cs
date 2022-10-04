namespace ZeichnenGrundformen
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
            this.BtnLinie = new System.Windows.Forms.Button();
            this.BtnRechteck = new System.Windows.Forms.Button();
            this.BtnPolygon = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LstFarbe = new System.Windows.Forms.ListBox();
            this.BtnLoeschen = new System.Windows.Forms.Button();
            this.ChkFuellen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLinie
            // 
            this.BtnLinie.Location = new System.Drawing.Point(225, 12);
            this.BtnLinie.Name = "BtnLinie";
            this.BtnLinie.Size = new System.Drawing.Size(75, 23);
            this.BtnLinie.TabIndex = 0;
            this.BtnLinie.Text = "Linie";
            this.BtnLinie.UseVisualStyleBackColor = true;
            this.BtnLinie.Click += new System.EventHandler(this.BtnLinie_Click);
            // 
            // BtnRechteck
            // 
            this.BtnRechteck.Location = new System.Drawing.Point(225, 41);
            this.BtnRechteck.Name = "BtnRechteck";
            this.BtnRechteck.Size = new System.Drawing.Size(75, 23);
            this.BtnRechteck.TabIndex = 0;
            this.BtnRechteck.Text = "Rechteck";
            this.BtnRechteck.UseVisualStyleBackColor = true;
            this.BtnRechteck.Click += new System.EventHandler(this.BtnRechteck_Click);
            // 
            // BtnPolygon
            // 
            this.BtnPolygon.Location = new System.Drawing.Point(225, 70);
            this.BtnPolygon.Name = "BtnPolygon";
            this.BtnPolygon.Size = new System.Drawing.Size(75, 23);
            this.BtnPolygon.TabIndex = 0;
            this.BtnPolygon.Text = "Polygon";
            this.BtnPolygon.UseVisualStyleBackColor = true;
            this.BtnPolygon.Click += new System.EventHandler(this.BtnPolygon_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.Location = new System.Drawing.Point(225, 99);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(75, 23);
            this.BtnEllipse.TabIndex = 0;
            this.BtnEllipse.Text = "Ellipse";
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dicke:";
            // 
            // NumPenWidth
            // 
            this.NumPenWidth.Location = new System.Drawing.Point(225, 143);
            this.NumPenWidth.Name = "NumPenWidth";
            this.NumPenWidth.Size = new System.Drawing.Size(75, 23);
            this.NumPenWidth.TabIndex = 2;
            this.NumPenWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumPenWidth.ValueChanged += new System.EventHandler(this.NumPenWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Farbe:";
            // 
            // LstFarbe
            // 
            this.LstFarbe.FormattingEnabled = true;
            this.LstFarbe.ItemHeight = 15;
            this.LstFarbe.Items.AddRange(new object[] {
            "Rot",
            "Grün",
            "Blau"});
            this.LstFarbe.Location = new System.Drawing.Point(225, 187);
            this.LstFarbe.Name = "LstFarbe";
            this.LstFarbe.Size = new System.Drawing.Size(75, 49);
            this.LstFarbe.TabIndex = 3;
            this.LstFarbe.SelectedIndexChanged += new System.EventHandler(this.LstFarbe_SelectedIndexChanged);
            // 
            // BtnLoeschen
            // 
            this.BtnLoeschen.Location = new System.Drawing.Point(225, 242);
            this.BtnLoeschen.Name = "BtnLoeschen";
            this.BtnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.BtnLoeschen.TabIndex = 0;
            this.BtnLoeschen.Text = "Löschen";
            this.BtnLoeschen.UseVisualStyleBackColor = true;
            this.BtnLoeschen.Click += new System.EventHandler(this.BtnLoeschen_Click);
            // 
            // ChkFuellen
            // 
            this.ChkFuellen.AutoSize = true;
            this.ChkFuellen.Location = new System.Drawing.Point(12, 242);
            this.ChkFuellen.Name = "ChkFuellen";
            this.ChkFuellen.Size = new System.Drawing.Size(58, 19);
            this.ChkFuellen.TabIndex = 4;
            this.ChkFuellen.Text = "Füllen";
            this.ChkFuellen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 272);
            this.Controls.Add(this.ChkFuellen);
            this.Controls.Add(this.LstFarbe);
            this.Controls.Add(this.NumPenWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoeschen);
            this.Controls.Add(this.BtnEllipse);
            this.Controls.Add(this.BtnPolygon);
            this.Controls.Add(this.BtnRechteck);
            this.Controls.Add(this.BtnLinie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnLinie;
        private Button BtnRechteck;
        private Button BtnPolygon;
        private Button BtnEllipse;
        private Label label1;
        private NumericUpDown NumPenWidth;
        private Label label2;
        private ListBox LstFarbe;
        private Button BtnLoeschen;
        private CheckBox ChkFuellen;
    }
}