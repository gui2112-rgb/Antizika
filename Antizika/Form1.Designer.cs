namespace Antizika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_EscanearPasta = new Button();
            btn_escanear = new Button();
            btn_CalcularHash = new Button();
            lbl_AntivirusZika = new Label();
            SuspendLayout();
            // 
            // btn_EscanearPasta
            // 
            btn_EscanearPasta.BackColor = Color.Olive;
            btn_EscanearPasta.Location = new Point(581, 189);
            btn_EscanearPasta.Name = "btn_EscanearPasta";
            btn_EscanearPasta.Size = new Size(207, 113);
            btn_EscanearPasta.TabIndex = 0;
            btn_EscanearPasta.Text = "Escanear Pasta";
            btn_EscanearPasta.UseVisualStyleBackColor = false;
            // 
            // btn_escanear
            // 
            btn_escanear.BackColor = Color.DarkOrange;
            btn_escanear.Location = new Point(311, 189);
            btn_escanear.Name = "btn_escanear";
            btn_escanear.Size = new Size(207, 113);
            btn_escanear.TabIndex = 0;
            btn_escanear.Text = "Escanear";
            btn_escanear.UseVisualStyleBackColor = false;
            // 
            // btn_CalcularHash
            // 
            btn_CalcularHash.BackColor = Color.IndianRed;
            btn_CalcularHash.Location = new Point(12, 189);
            btn_CalcularHash.Name = "btn_CalcularHash";
            btn_CalcularHash.Size = new Size(207, 113);
            btn_CalcularHash.TabIndex = 0;
            btn_CalcularHash.Text = "Calcular Hash";
            btn_CalcularHash.UseVisualStyleBackColor = false;
            // 
            // lbl_AntivirusZika
            // 
            lbl_AntivirusZika.AutoSize = true;
            lbl_AntivirusZika.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AntivirusZika.ForeColor = SystemColors.ActiveCaptionText;
            lbl_AntivirusZika.Location = new Point(242, 57);
            lbl_AntivirusZika.Name = "lbl_AntivirusZika";
            lbl_AntivirusZika.Size = new Size(343, 56);
            lbl_AntivirusZika.TabIndex = 1;
            lbl_AntivirusZika.Text = "AntiVirus Zika";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_AntivirusZika);
            Controls.Add(btn_CalcularHash);
            Controls.Add(btn_escanear);
            Controls.Add(btn_EscanearPasta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AntiZika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_EscanearPasta;
        private Button btn_escanear;
        private Button btn_CalcularHash;
        private Label lbl_AntivirusZika;
    }
}
