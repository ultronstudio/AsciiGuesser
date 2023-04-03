namespace AsciiGuesser
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblPismeno = new System.Windows.Forms.Label();
            this.tboxPismeno = new System.Windows.Forms.TextBox();
            this.btnHadej = new System.Windows.Forms.Button();
            this.gboxNapoveda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxNapoveda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.Red;
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(688, 104);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "AsciiGuesser";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPismeno
            // 
            this.lblPismeno.AutoSize = true;
            this.lblPismeno.Location = new System.Drawing.Point(12, 115);
            this.lblPismeno.Name = "lblPismeno";
            this.lblPismeno.Size = new System.Drawing.Size(81, 13);
            this.lblPismeno.TabIndex = 1;
            this.lblPismeno.Text = "Zadej písmeno:";
            // 
            // tboxPismeno
            // 
            this.tboxPismeno.Location = new System.Drawing.Point(99, 112);
            this.tboxPismeno.MaxLength = 1;
            this.tboxPismeno.Name = "tboxPismeno";
            this.tboxPismeno.Size = new System.Drawing.Size(110, 20);
            this.tboxPismeno.TabIndex = 2;
            // 
            // btnHadej
            // 
            this.btnHadej.Location = new System.Drawing.Point(15, 186);
            this.btnHadej.Name = "btnHadej";
            this.btnHadej.Size = new System.Drawing.Size(75, 23);
            this.btnHadej.TabIndex = 3;
            this.btnHadej.Text = "Hádej!";
            this.btnHadej.UseVisualStyleBackColor = true;
            this.btnHadej.Click += new System.EventHandler(this.btnHadej_Click);
            // 
            // gboxNapoveda
            // 
            this.gboxNapoveda.Controls.Add(this.label1);
            this.gboxNapoveda.Location = new System.Drawing.Point(224, 112);
            this.gboxNapoveda.Name = "gboxNapoveda";
            this.gboxNapoveda.Size = new System.Drawing.Size(452, 100);
            this.gboxNapoveda.TabIndex = 4;
            this.gboxNapoveda.TabStop = false;
            this.gboxNapoveda.Text = "Nápověda";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Zadej jakékoli písmeno od A do Z\r\n2. Klikni na tlačítko \"Hádej!\" abys zjistil," +
    " zda jsi uhodl nebo neuhodl počítačem myšlené číslo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 221);
            this.Controls.Add(this.gboxNapoveda);
            this.Controls.Add(this.btnHadej);
            this.Controls.Add(this.tboxPismeno);
            this.Controls.Add(this.lblPismeno);
            this.Controls.Add(this.lblAppName);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsciiGuesser";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.gboxNapoveda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblPismeno;
        private System.Windows.Forms.TextBox tboxPismeno;
        private System.Windows.Forms.Button btnHadej;
        private System.Windows.Forms.GroupBox gboxNapoveda;
        private System.Windows.Forms.Label label1;
    }
}

