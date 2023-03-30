namespace WFA230330
{
    partial class FrmMain
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
            lblUI01 = new Label();
            cmbNapSzorszam = new ComboBox();
            txtElkeszitett = new TextBox();
            btnHozzaad = new Button();
            lblUI02 = new Label();
            lblUI03 = new Label();
            txtEladott = new TextBox();
            rtbKonyveles = new RichTextBox();
            lblHiba = new Label();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 35);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(135, 25);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Nap sorszáma:";
            // 
            // cmbNapSzorszam
            // 
            cmbNapSzorszam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNapSzorszam.FormattingEnabled = true;
            cmbNapSzorszam.Location = new Point(153, 31);
            cmbNapSzorszam.Name = "cmbNapSzorszam";
            cmbNapSzorszam.Size = new Size(83, 33);
            cmbNapSzorszam.TabIndex = 1;
            // 
            // txtElkeszitett
            // 
            txtElkeszitett.Location = new Point(377, 31);
            txtElkeszitett.Name = "txtElkeszitett";
            txtElkeszitett.Size = new Size(61, 32);
            txtElkeszitett.TabIndex = 2;
            txtElkeszitett.Text = "0";
            // 
            // btnHozzaad
            // 
            btnHozzaad.Location = new Point(671, 25);
            btnHozzaad.Name = "btnHozzaad";
            btnHozzaad.Size = new Size(123, 43);
            btnHozzaad.TabIndex = 3;
            btnHozzaad.Text = "Hozzáad";
            btnHozzaad.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(276, 35);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(95, 25);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Ekészített:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(480, 35);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(75, 25);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Eladott:";
            // 
            // txtEladott
            // 
            txtEladott.Location = new Point(561, 31);
            txtEladott.Name = "txtEladott";
            txtEladott.Size = new Size(61, 32);
            txtEladott.TabIndex = 2;
            txtEladott.Text = "0";
            // 
            // rtbKonyveles
            // 
            rtbKonyveles.BackColor = Color.White;
            rtbKonyveles.Location = new Point(12, 136);
            rtbKonyveles.Name = "rtbKonyveles";
            rtbKonyveles.ReadOnly = true;
            rtbKonyveles.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbKonyveles.Size = new Size(809, 299);
            rtbKonyveles.TabIndex = 4;
            rtbKonyveles.Text = "";
            // 
            // lblHiba
            // 
            lblHiba.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHiba.ForeColor = Color.Red;
            lblHiba.Location = new Point(377, 83);
            lblHiba.Name = "lblHiba";
            lblHiba.Size = new Size(400, 35);
            lblHiba.TabIndex = 5;
            lblHiba.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 447);
            Controls.Add(lblHiba);
            Controls.Add(rtbKonyveles);
            Controls.Add(btnHozzaad);
            Controls.Add(txtEladott);
            Controls.Add(txtElkeszitett);
            Controls.Add(cmbNapSzorszam);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "Angyalka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private ComboBox cmbNapSzorszam;
        private TextBox txtElkeszitett;
        private Button btnHozzaad;
        private Label lblUI02;
        private Label lblUI03;
        private TextBox txtEladott;
        private RichTextBox rtbKonyveles;
        private Label lblHiba;
    }
}