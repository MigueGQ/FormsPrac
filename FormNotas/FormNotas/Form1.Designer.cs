
namespace FormNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLab1 = new System.Windows.Forms.TextBox();
            this.TxtLab2 = new System.Windows.Forms.TextBox();
            this.TxtLab3 = new System.Windows.Forms.TextBox();
            this.TxtParcial3 = new System.Windows.Forms.TextBox();
            this.TxtParcial2 = new System.Windows.Forms.TextBox();
            this.TxtParcial1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Periodo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Periodo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(646, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tercer Periodo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Laboratorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Laboratorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Laboratorio";
            // 
            // TxtLab1
            // 
            this.TxtLab1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtLab1.Location = new System.Drawing.Point(24, 70);
            this.TxtLab1.Name = "TxtLab1";
            this.TxtLab1.Size = new System.Drawing.Size(150, 31);
            this.TxtLab1.TabIndex = 7;
            this.TxtLab1.Text = "0";
            // 
            // TxtLab2
            // 
            this.TxtLab2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtLab2.Location = new System.Drawing.Point(356, 70);
            this.TxtLab2.Name = "TxtLab2";
            this.TxtLab2.Size = new System.Drawing.Size(150, 31);
            this.TxtLab2.TabIndex = 8;
            this.TxtLab2.Text = "0";
            // 
            // TxtLab3
            // 
            this.TxtLab3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtLab3.Location = new System.Drawing.Point(672, 70);
            this.TxtLab3.Name = "TxtLab3";
            this.TxtLab3.Size = new System.Drawing.Size(150, 31);
            this.TxtLab3.TabIndex = 9;
            this.TxtLab3.Text = "0";
            // 
            // TxtParcial3
            // 
            this.TxtParcial3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtParcial3.Location = new System.Drawing.Point(672, 145);
            this.TxtParcial3.MinimumSize = new System.Drawing.Size(4, 4);
            this.TxtParcial3.Name = "TxtParcial3";
            this.TxtParcial3.Size = new System.Drawing.Size(150, 31);
            this.TxtParcial3.TabIndex = 15;
            this.TxtParcial3.Text = "0";
            this.TxtParcial3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtParcial2
            // 
            this.TxtParcial2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtParcial2.Location = new System.Drawing.Point(356, 145);
            this.TxtParcial2.Name = "TxtParcial2";
            this.TxtParcial2.Size = new System.Drawing.Size(150, 31);
            this.TxtParcial2.TabIndex = 14;
            this.TxtParcial2.Text = "0";
            this.TxtParcial2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtParcial1
            // 
            this.TxtParcial1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtParcial1.Location = new System.Drawing.Point(24, 145);
            this.TxtParcial1.Name = "TxtParcial1";
            this.TxtParcial1.Size = new System.Drawing.Size(150, 31);
            this.TxtParcial1.TabIndex = 13;
            this.TxtParcial1.Text = "0";
            this.TxtParcial1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Parcial";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parcial";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Parcial";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(646, 204);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(176, 45);
            this.Calc.TabIndex = 16;
            this.Calc.Text = "Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 261);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.TxtParcial3);
            this.Controls.Add(this.TxtParcial2);
            this.Controls.Add(this.TxtParcial1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtLab3);
            this.Controls.Add(this.TxtLab2);
            this.Controls.Add(this.TxtLab1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLab1;
        private System.Windows.Forms.TextBox TxtLab2;
        private System.Windows.Forms.TextBox TxtLab3;
        private System.Windows.Forms.TextBox TxtParcial3;
        private System.Windows.Forms.TextBox TxtParcial2;
        private System.Windows.Forms.TextBox TxtParcial1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Calc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

