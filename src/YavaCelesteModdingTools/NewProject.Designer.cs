namespace YavaCelesteModdingTools
{
    partial class NewProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.components = new System.ComponentModel.Container();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celete Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Padding = new System.Windows.Forms.Padding(0);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proceed.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.PlaceholderText = "";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "NewProject";
            this.Text = "Yava's Celeste Modding Tools";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.BackColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ForeColor = System.Drawing.Color.Red;
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label2.AutoSize = false;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Padding = new System.Windows.Forms.Padding(0);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Controls.Add(this.label2);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox3.Location = new System.Drawing.Point(48, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.PlaceholderText = "";
            this.Controls.Add(this.textBox3);
            this.label3 = new System.Windows.Forms.Label();
            this.label3.AutoSize = false;
            this.label3.Location = new System.Drawing.Point(48, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Campaign Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Padding = new System.Windows.Forms.Padding(0);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Controls.Add(this.label3);
            this.label4 = new System.Windows.Forms.Label();
            this.label4.AutoSize = false;
            this.label4.Location = new System.Drawing.Point(48, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Map Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Padding = new System.Windows.Forms.Padding(0);
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Controls.Add(this.label4);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox4.Location = new System.Drawing.Point(48, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.PlaceholderText = "";
            this.Controls.Add(this.textBox4);
            this.label5 = new System.Windows.Forms.Label();
            this.label5.AutoSize = false;
            this.label5.Location = new System.Drawing.Point(48, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Padding = new System.Windows.Forms.Padding(0);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.label5);
            this.label6 = new System.Windows.Forms.Label();
            this.label6.AutoSize = false;
            this.label6.Location = new System.Drawing.Point(48, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Padding = new System.Windows.Forms.Padding(0);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.label6);
            this.label7 = new System.Windows.Forms.Label();
            this.label7.AutoSize = false;
            this.label7.Location = new System.Drawing.Point(48, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Padding = new System.Windows.Forms.Padding(0);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.label7);
            this.label8 = new System.Windows.Forms.Label();
            this.label8.AutoSize = false;
            this.label8.Location = new System.Drawing.Point(48, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Padding = new System.Windows.Forms.Padding(0);
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.label8);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
