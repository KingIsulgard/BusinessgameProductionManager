﻿namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.templateLBL = new System.Windows.Forms.Label();
            this.lbxSchedualedSales = new System.Windows.Forms.ListBox();
            this.cbxProductName = new System.Windows.Forms.ComboBox();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.cbxTimeType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // templateLBL
            // 
            this.templateLBL.AutoSize = true;
            this.templateLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateLBL.Location = new System.Drawing.Point(42, 9);
            this.templateLBL.Name = "templateLBL";
            this.templateLBL.Size = new System.Drawing.Size(139, 16);
            this.templateLBL.TabIndex = 3;
            this.templateLBL.Text = "Schedualed Sales:";
            // 
            // lbxSchedualedSales
            // 
            this.lbxSchedualedSales.FormattingEnabled = true;
            this.lbxSchedualedSales.Items.AddRange(new object[] {
            " "});
            this.lbxSchedualedSales.Location = new System.Drawing.Point(15, 28);
            this.lbxSchedualedSales.Name = "lbxSchedualedSales";
            this.lbxSchedualedSales.Size = new System.Drawing.Size(189, 186);
            this.lbxSchedualedSales.TabIndex = 4;
            this.lbxSchedualedSales.SelectedIndexChanged += new System.EventHandler(this.lbxSchedualedSales_SelectedIndexChanged);
            this.lbxSchedualedSales.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxSchedualedSales_MouseDoubleClick);
            // 
            // cbxProductName
            // 
            this.cbxProductName.FormattingEnabled = true;
            this.cbxProductName.Location = new System.Drawing.Point(93, 219);
            this.cbxProductName.Name = "cbxProductName";
            this.cbxProductName.Size = new System.Drawing.Size(109, 21);
            this.cbxProductName.TabIndex = 5;
            this.cbxProductName.Text = "Apples";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(15, 247);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(72, 20);
            this.tbxTime.TabIndex = 6;
            // 
            // cbxTimeType
            // 
            this.cbxTimeType.FormattingEnabled = true;
            this.cbxTimeType.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.cbxTimeType.Location = new System.Drawing.Point(93, 246);
            this.cbxTimeType.Name = "cbxTimeType";
            this.cbxTimeType.Size = new System.Drawing.Size(109, 21);
            this.cbxTimeType.TabIndex = 7;
            this.cbxTimeType.Text = "Minutes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Double click and item to remove";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(15, 219);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(72, 20);
            this.tbxAmount.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Note: Only one sale can be made per minute, the others will be enqueued to the ne" +
    "xt minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Do not close this window if you have schedualed events!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(223, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 67);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Experienced an error or got a suggestion?      (inc. name)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(560, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTimeType);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.cbxProductName);
            this.Controls.Add(this.lbxSchedualedSales);
            this.Controls.Add(this.templateLBL);
            this.Name = "Form2";
            this.Text = "Businessgame.be - Production Manager - Lead Green";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label templateLBL;
        private System.Windows.Forms.ListBox lbxSchedualedSales;
        private System.Windows.Forms.ComboBox cbxProductName;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.ComboBox cbxTimeType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}