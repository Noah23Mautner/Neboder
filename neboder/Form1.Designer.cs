namespace neboder
{
    partial class Form1
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
            this.txtbrojkatova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisinazgrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_izracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbrojkatova
            // 
            this.txtbrojkatova.Location = new System.Drawing.Point(135, 29);
            this.txtbrojkatova.Name = "txtbrojkatova";
            this.txtbrojkatova.Size = new System.Drawing.Size(100, 26);
            this.txtbrojkatova.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj katova";
            // 
            // txtVisinazgrade
            // 
            this.txtVisinazgrade.Location = new System.Drawing.Point(135, 102);
            this.txtVisinazgrade.Name = "txtVisinazgrade";
            this.txtVisinazgrade.Size = new System.Drawing.Size(100, 26);
            this.txtVisinazgrade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visina zgrade";
            // 
            // btn_izracunaj
            // 
            this.btn_izracunaj.Location = new System.Drawing.Point(135, 152);
            this.btn_izracunaj.Name = "btn_izracunaj";
            this.btn_izracunaj.Size = new System.Drawing.Size(100, 37);
            this.btn_izracunaj.TabIndex = 4;
            this.btn_izracunaj.Text = "Izracunaj";
            this.btn_izracunaj.UseVisualStyleBackColor = true;
            this.btn_izracunaj.Click += new System.EventHandler(this.btn_izracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 232);
            this.Controls.Add(this.btn_izracunaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisinazgrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbrojkatova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbrojkatova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisinazgrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_izracunaj;
    }
}

