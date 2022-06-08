namespace Receivers
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.kInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.receiverXInput = new System.Windows.Forms.TextBox();
            this.receiverYInput = new System.Windows.Forms.TextBox();
            this.addReceiverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receiverList = new System.Windows.Forms.ListBox();
            this.senderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kInput
            // 
            this.kInput.Location = new System.Drawing.Point(113, 54);
            this.kInput.Name = "kInput";
            this.kInput.Size = new System.Drawing.Size(100, 22);
            this.kInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(77, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "k=";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(338, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(450, 391);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // receiverXInput
            // 
            this.receiverXInput.Location = new System.Drawing.Point(45, 123);
            this.receiverXInput.Name = "receiverXInput";
            this.receiverXInput.Size = new System.Drawing.Size(55, 22);
            this.receiverXInput.TabIndex = 3;
            // 
            // receiverYInput
            // 
            this.receiverYInput.Location = new System.Drawing.Point(160, 123);
            this.receiverYInput.Name = "receiverYInput";
            this.receiverYInput.Size = new System.Drawing.Size(58, 22);
            this.receiverYInput.TabIndex = 4;
            // 
            // addReceiverBtn
            // 
            this.addReceiverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.addReceiverBtn.Location = new System.Drawing.Point(234, 121);
            this.addReceiverBtn.Name = "addReceiverBtn";
            this.addReceiverBtn.Size = new System.Drawing.Size(75, 26);
            this.addReceiverBtn.TabIndex = 5;
            this.addReceiverBtn.Text = "Add";
            this.addReceiverBtn.UseVisualStyleBackColor = true;
            this.addReceiverBtn.Click += new System.EventHandler(this.addReceiverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "x=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(128, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "y=";
            // 
            // receiverList
            // 
            this.receiverList.FormattingEnabled = true;
            this.receiverList.ItemHeight = 16;
            this.receiverList.Location = new System.Drawing.Point(16, 169);
            this.receiverList.Name = "receiverList";
            this.receiverList.Size = new System.Drawing.Size(293, 276);
            this.receiverList.TabIndex = 8;
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.senderLabel.Location = new System.Drawing.Point(338, 16);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(60, 24);
            this.senderLabel.TabIndex = 9;
            this.senderLabel.Text = "label4";
            this.senderLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.receiverList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addReceiverBtn);
            this.Controls.Add(this.receiverYInput);
            this.Controls.Add(this.receiverXInput);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox receiverXInput;
        private System.Windows.Forms.TextBox receiverYInput;
        private System.Windows.Forms.Button addReceiverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox receiverList;
        private System.Windows.Forms.Label senderLabel;
    }
}

