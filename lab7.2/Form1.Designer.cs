namespace lab7._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.wtext = new System.Windows.Forms.Button();
            this.rtext = new System.Windows.Forms.Button();
            this.rbinary = new System.Windows.Forms.Button();
            this.wbinary = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LName: ";
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(98, 23);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(174, 26);
            this.fName.TabIndex = 2;
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(97, 59);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(174, 26);
            this.lName.TabIndex = 3;
            // 
            // wtext
            // 
            this.wtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtext.Location = new System.Drawing.Point(97, 123);
            this.wtext.Name = "wtext";
            this.wtext.Size = new System.Drawing.Size(123, 49);
            this.wtext.TabIndex = 4;
            this.wtext.Text = "Write text \r\nfile";
            this.wtext.UseVisualStyleBackColor = true;
            this.wtext.Click += new System.EventHandler(this.wtext_Click);
            // 
            // rtext
            // 
            this.rtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtext.Location = new System.Drawing.Point(227, 123);
            this.rtext.Name = "rtext";
            this.rtext.Size = new System.Drawing.Size(123, 49);
            this.rtext.TabIndex = 5;
            this.rtext.Text = "Read text \r\nfile";
            this.rtext.UseVisualStyleBackColor = true;
            this.rtext.Click += new System.EventHandler(this.rtext_Click);
            // 
            // rbinary
            // 
            this.rbinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbinary.Location = new System.Drawing.Point(227, 192);
            this.rbinary.Name = "rbinary";
            this.rbinary.Size = new System.Drawing.Size(123, 49);
            this.rbinary.TabIndex = 7;
            this.rbinary.Text = "Read binary \r\nfile";
            this.rbinary.UseVisualStyleBackColor = true;
            this.rbinary.Click += new System.EventHandler(this.rbinary_Click);
            // 
            // wbinary
            // 
            this.wbinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbinary.Location = new System.Drawing.Point(98, 192);
            this.wbinary.Name = "wbinary";
            this.wbinary.Size = new System.Drawing.Size(123, 49);
            this.wbinary.TabIndex = 6;
            this.wbinary.Text = "Write binary \r\nfile";
            this.wbinary.UseVisualStyleBackColor = true;
            this.wbinary.Click += new System.EventHandler(this.wbinary_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(395, 201);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 30);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 252);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rbinary);
            this.Controls.Add(this.wbinary);
            this.Controls.Add(this.rtext);
            this.Controls.Add(this.wtext);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Button wtext;
        private System.Windows.Forms.Button rtext;
        private System.Windows.Forms.Button rbinary;
        private System.Windows.Forms.Button wbinary;
        private System.Windows.Forms.Button exit;
    }
}

