
namespace lab1
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buCompute = new System.Windows.Forms.Button();
            this.lbP = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(249, 48);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(84, 31);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(249, 95);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(84, 31);
            this.txtM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть значення N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть значення M:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість перестановок P =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість розміщень А =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кількість комбінацій С =";
            // 
            // buCompute
            // 
            this.buCompute.Location = new System.Drawing.Point(473, 64);
            this.buCompute.Name = "buCompute";
            this.buCompute.Size = new System.Drawing.Size(128, 42);
            this.buCompute.TabIndex = 10;
            this.buCompute.Text = "Порахувати";
            this.buCompute.UseVisualStyleBackColor = true;
            this.buCompute.Click += new System.EventHandler(this.buCompute_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Location = new System.Drawing.Point(299, 210);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(0, 25);
            this.lbP.TabIndex = 11;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(274, 264);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(0, 25);
            this.lbA.TabIndex = 12;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(274, 318);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(0, 25);
            this.lbC.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbP);
            this.Controls.Add(this.buCompute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buCompute;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbC;
    }
}

