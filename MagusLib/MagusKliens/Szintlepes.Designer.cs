
namespace MagusKliens
{
    partial class Szintlepes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLepes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.fieldFpPerSzint = new System.Windows.Forms.NumericUpDown();
            this.fieldTESzintlepes = new System.Windows.Forms.NumericUpDown();
            this.labelFPPerSzint = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.fieldKEKotelezo = new System.Windows.Forms.TextBox();
            this.fieldTEKotelezo = new System.Windows.Forms.TextBox();
            this.fieldOszthatoHM = new System.Windows.Forms.TextBox();
            this.fieldVEKotelezo = new System.Windows.Forms.TextBox();
            this.fieldCEKotelezo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.fieldKESzintlepes = new System.Windows.Forms.NumericUpDown();
            this.fieldCESzintlepes = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.fieldVESzintlepes = new System.Windows.Forms.NumericUpDown();
            this.fieldSzint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.fieldKEAlap = new System.Windows.Forms.TextBox();
            this.fieldVEAlap = new System.Windows.Forms.TextBox();
            this.fieldTEAlap = new System.Windows.Forms.TextBox();
            this.fieldCEAlap = new System.Windows.Forms.TextBox();
            this.fieldManaPerSzint = new System.Windows.Forms.NumericUpDown();
            this.Mana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fieldFpPerSzint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTESzintlepes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldKESzintlepes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCESzintlepes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldVESzintlepes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldManaPerSzint)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLepes
            // 
            this.buttonLepes.Location = new System.Drawing.Point(310, 130);
            this.buttonLepes.Name = "buttonLepes";
            this.buttonLepes.Size = new System.Drawing.Size(75, 23);
            this.buttonLepes.TabIndex = 70;
            this.buttonLepes.Text = "Szintlépés";
            this.buttonLepes.UseVisualStyleBackColor = true;
            this.buttonLepes.Click += new System.EventHandler(this.buttonLepes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Visszalépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 162;
            this.label11.Text = "Szintenkénti";
            // 
            // fieldFpPerSzint
            // 
            this.fieldFpPerSzint.Location = new System.Drawing.Point(310, 52);
            this.fieldFpPerSzint.Name = "fieldFpPerSzint";
            this.fieldFpPerSzint.Size = new System.Drawing.Size(48, 20);
            this.fieldFpPerSzint.TabIndex = 141;
            // 
            // fieldTESzintlepes
            // 
            this.fieldTESzintlepes.Location = new System.Drawing.Point(164, 56);
            this.fieldTESzintlepes.Name = "fieldTESzintlepes";
            this.fieldTESzintlepes.Size = new System.Drawing.Size(62, 20);
            this.fieldTESzintlepes.TabIndex = 143;
            this.fieldTESzintlepes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldTESzintlepes.ValueChanged += new System.EventHandler(this.fieldKNumUpDown_Validating);
            this.fieldTESzintlepes.Validating += new System.ComponentModel.CancelEventHandler(this.fieldKNumUpDown_Validating);
            // 
            // labelFPPerSzint
            // 
            this.labelFPPerSzint.AutoSize = true;
            this.labelFPPerSzint.Location = new System.Drawing.Point(307, 36);
            this.labelFPPerSzint.Name = "labelFPPerSzint";
            this.labelFPPerSzint.Size = new System.Drawing.Size(51, 13);
            this.labelFPPerSzint.TabIndex = 140;
            this.labelFPPerSzint.Text = "FP/Szint:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 86);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 152;
            this.label32.Text = "Védő:";
            // 
            // fieldKEKotelezo
            // 
            this.fieldKEKotelezo.Location = new System.Drawing.Point(232, 29);
            this.fieldKEKotelezo.Name = "fieldKEKotelezo";
            this.fieldKEKotelezo.ReadOnly = true;
            this.fieldKEKotelezo.Size = new System.Drawing.Size(49, 20);
            this.fieldKEKotelezo.TabIndex = 146;
            this.fieldKEKotelezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldTEKotelezo
            // 
            this.fieldTEKotelezo.Location = new System.Drawing.Point(232, 55);
            this.fieldTEKotelezo.Name = "fieldTEKotelezo";
            this.fieldTEKotelezo.ReadOnly = true;
            this.fieldTEKotelezo.Size = new System.Drawing.Size(49, 20);
            this.fieldTEKotelezo.TabIndex = 147;
            this.fieldTEKotelezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldOszthatoHM
            // 
            this.fieldOszthatoHM.Location = new System.Drawing.Point(109, 132);
            this.fieldOszthatoHM.Name = "fieldOszthatoHM";
            this.fieldOszthatoHM.ReadOnly = true;
            this.fieldOszthatoHM.Size = new System.Drawing.Size(172, 20);
            this.fieldOszthatoHM.TabIndex = 156;
            this.fieldOszthatoHM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldVEKotelezo
            // 
            this.fieldVEKotelezo.Location = new System.Drawing.Point(232, 81);
            this.fieldVEKotelezo.Name = "fieldVEKotelezo";
            this.fieldVEKotelezo.ReadOnly = true;
            this.fieldVEKotelezo.Size = new System.Drawing.Size(49, 20);
            this.fieldVEKotelezo.TabIndex = 148;
            this.fieldVEKotelezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldCEKotelezo
            // 
            this.fieldCEKotelezo.Location = new System.Drawing.Point(232, 107);
            this.fieldCEKotelezo.Name = "fieldCEKotelezo";
            this.fieldCEKotelezo.ReadOnly = true;
            this.fieldCEKotelezo.Size = new System.Drawing.Size(49, 20);
            this.fieldCEKotelezo.TabIndex = 149;
            this.fieldCEKotelezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 13);
            this.label30.TabIndex = 153;
            this.label30.Text = "Célzó:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 13);
            this.label31.TabIndex = 151;
            this.label31.Text = "Támadó:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label52.Location = new System.Drawing.Point(12, 135);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(84, 13);
            this.label52.TabIndex = 155;
            this.label52.Text = "Osztható HM:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 150;
            this.label29.Text = "Kezdeményező:";
            // 
            // fieldKESzintlepes
            // 
            this.fieldKESzintlepes.Location = new System.Drawing.Point(164, 30);
            this.fieldKESzintlepes.Name = "fieldKESzintlepes";
            this.fieldKESzintlepes.Size = new System.Drawing.Size(62, 20);
            this.fieldKESzintlepes.TabIndex = 142;
            this.fieldKESzintlepes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldKESzintlepes.ValueChanged += new System.EventHandler(this.fieldKNumUpDown_Validating);
            this.fieldKESzintlepes.Validating += new System.ComponentModel.CancelEventHandler(this.fieldKNumUpDown_Validating);
            // 
            // fieldCESzintlepes
            // 
            this.fieldCESzintlepes.Location = new System.Drawing.Point(164, 106);
            this.fieldCESzintlepes.Name = "fieldCESzintlepes";
            this.fieldCESzintlepes.Size = new System.Drawing.Size(62, 20);
            this.fieldCESzintlepes.TabIndex = 145;
            this.fieldCESzintlepes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldCESzintlepes.ValueChanged += new System.EventHandler(this.fieldKNumUpDown_Validating);
            this.fieldCESzintlepes.Validating += new System.ComponentModel.CancelEventHandler(this.fieldKNumUpDown_Validating);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(233, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(48, 13);
            this.label33.TabIndex = 154;
            this.label33.Text = "Kötelező";
            // 
            // fieldVESzintlepes
            // 
            this.fieldVESzintlepes.Location = new System.Drawing.Point(164, 82);
            this.fieldVESzintlepes.Name = "fieldVESzintlepes";
            this.fieldVESzintlepes.Size = new System.Drawing.Size(62, 20);
            this.fieldVESzintlepes.TabIndex = 144;
            this.fieldVESzintlepes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldVESzintlepes.ValueChanged += new System.EventHandler(this.fieldKNumUpDown_Validating);
            this.fieldVESzintlepes.Validating += new System.ComponentModel.CancelEventHandler(this.fieldKNumUpDown_Validating);
            // 
            // fieldSzint
            // 
            this.fieldSzint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldSzint.Location = new System.Drawing.Point(385, 68);
            this.fieldSzint.Name = "fieldSzint";
            this.fieldSzint.Size = new System.Drawing.Size(100, 38);
            this.fieldSzint.TabIndex = 163;
            this.fieldSzint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 164;
            this.label1.Text = "Szint:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(117, 10);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(28, 13);
            this.label77.TabIndex = 169;
            this.label77.Text = "Alap";
            // 
            // fieldKEAlap
            // 
            this.fieldKEAlap.Enabled = false;
            this.fieldKEAlap.Location = new System.Drawing.Point(109, 29);
            this.fieldKEAlap.Name = "fieldKEAlap";
            this.fieldKEAlap.ReadOnly = true;
            this.fieldKEAlap.Size = new System.Drawing.Size(49, 20);
            this.fieldKEAlap.TabIndex = 165;
            this.fieldKEAlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldVEAlap
            // 
            this.fieldVEAlap.Enabled = false;
            this.fieldVEAlap.Location = new System.Drawing.Point(109, 81);
            this.fieldVEAlap.Name = "fieldVEAlap";
            this.fieldVEAlap.ReadOnly = true;
            this.fieldVEAlap.Size = new System.Drawing.Size(49, 20);
            this.fieldVEAlap.TabIndex = 167;
            this.fieldVEAlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldTEAlap
            // 
            this.fieldTEAlap.Enabled = false;
            this.fieldTEAlap.Location = new System.Drawing.Point(109, 55);
            this.fieldTEAlap.Name = "fieldTEAlap";
            this.fieldTEAlap.ReadOnly = true;
            this.fieldTEAlap.Size = new System.Drawing.Size(49, 20);
            this.fieldTEAlap.TabIndex = 166;
            this.fieldTEAlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldCEAlap
            // 
            this.fieldCEAlap.Enabled = false;
            this.fieldCEAlap.Location = new System.Drawing.Point(109, 105);
            this.fieldCEAlap.Name = "fieldCEAlap";
            this.fieldCEAlap.ReadOnly = true;
            this.fieldCEAlap.Size = new System.Drawing.Size(49, 20);
            this.fieldCEAlap.TabIndex = 168;
            this.fieldCEAlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fieldManaPerSzint
            // 
            this.fieldManaPerSzint.Location = new System.Drawing.Point(310, 86);
            this.fieldManaPerSzint.Name = "fieldManaPerSzint";
            this.fieldManaPerSzint.Size = new System.Drawing.Size(48, 20);
            this.fieldManaPerSzint.TabIndex = 171;
            // 
            // Mana
            // 
            this.Mana.AutoSize = true;
            this.Mana.Location = new System.Drawing.Point(307, 70);
            this.Mana.Name = "Mana";
            this.Mana.Size = new System.Drawing.Size(65, 13);
            this.Mana.TabIndex = 170;
            this.Mana.Text = "Mana/Szint:";
            // 
            // Szintlepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 164);
            this.Controls.Add(this.fieldManaPerSzint);
            this.Controls.Add(this.Mana);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.fieldKEAlap);
            this.Controls.Add(this.fieldVEAlap);
            this.Controls.Add(this.fieldTEAlap);
            this.Controls.Add(this.fieldCEAlap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldSzint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fieldFpPerSzint);
            this.Controls.Add(this.fieldTESzintlepes);
            this.Controls.Add(this.labelFPPerSzint);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.fieldKEKotelezo);
            this.Controls.Add(this.fieldTEKotelezo);
            this.Controls.Add(this.fieldOszthatoHM);
            this.Controls.Add(this.fieldVEKotelezo);
            this.Controls.Add(this.fieldCEKotelezo);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.fieldKESzintlepes);
            this.Controls.Add(this.fieldCESzintlepes);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.fieldVESzintlepes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLepes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Szintlepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szintlepes";
            this.Load += new System.EventHandler(this.Szintlepes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fieldFpPerSzint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldTESzintlepes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldKESzintlepes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCESzintlepes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldVESzintlepes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldManaPerSzint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLepes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown fieldFpPerSzint;
        private System.Windows.Forms.NumericUpDown fieldTESzintlepes;
        private System.Windows.Forms.Label labelFPPerSzint;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox fieldKEKotelezo;
        private System.Windows.Forms.TextBox fieldTEKotelezo;
        private System.Windows.Forms.TextBox fieldOszthatoHM;
        private System.Windows.Forms.TextBox fieldVEKotelezo;
        private System.Windows.Forms.TextBox fieldCEKotelezo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown fieldKESzintlepes;
        private System.Windows.Forms.NumericUpDown fieldCESzintlepes;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown fieldVESzintlepes;
        private System.Windows.Forms.TextBox fieldSzint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox fieldKEAlap;
        private System.Windows.Forms.TextBox fieldVEAlap;
        private System.Windows.Forms.TextBox fieldTEAlap;
        private System.Windows.Forms.TextBox fieldCEAlap;
        private System.Windows.Forms.NumericUpDown fieldManaPerSzint;
        private System.Windows.Forms.Label Mana;
    }
}