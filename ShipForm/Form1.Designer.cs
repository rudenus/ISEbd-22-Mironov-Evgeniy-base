
namespace ShipForm
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
            this.groupBoxShipOrSteamer = new System.Windows.Forms.GroupBox();
            this.pictureBoxForCreate = new System.Windows.Forms.PictureBox();
            this.CreateShipLabel = new System.Windows.Forms.Label();
            this.CreateSteamerLabel = new System.Windows.Forms.Label();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxShipOrSteamer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCreate)).BeginInit();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShipOrSteamer
            // 
            this.groupBoxShipOrSteamer.Controls.Add(this.CreateSteamerLabel);
            this.groupBoxShipOrSteamer.Controls.Add(this.CreateShipLabel);
            this.groupBoxShipOrSteamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxShipOrSteamer.Location = new System.Drawing.Point(12, 57);
            this.groupBoxShipOrSteamer.Name = "groupBoxShipOrSteamer";
            this.groupBoxShipOrSteamer.Size = new System.Drawing.Size(214, 166);
            this.groupBoxShipOrSteamer.TabIndex = 0;
            this.groupBoxShipOrSteamer.TabStop = false;
            this.groupBoxShipOrSteamer.Text = "Body type";
            // 
            // pictureBoxForCreate
            // 
            this.pictureBoxForCreate.Location = new System.Drawing.Point(37, 0);
            this.pictureBoxForCreate.Name = "pictureBoxForCreate";
            this.pictureBoxForCreate.Size = new System.Drawing.Size(206, 166);
            this.pictureBoxForCreate.TabIndex = 1;
            this.pictureBoxForCreate.TabStop = false;
            // 
            // CreateShipLabel
            // 
            this.CreateShipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateShipLabel.Location = new System.Drawing.Point(24, 45);
            this.CreateShipLabel.Name = "CreateShipLabel";
            this.CreateShipLabel.Size = new System.Drawing.Size(146, 46);
            this.CreateShipLabel.TabIndex = 0;
            this.CreateShipLabel.Text = "Ship";
            this.CreateShipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateShipLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateShipLabel_MouseDown);
            // 
            // CreateSteamerLabel
            // 
            this.CreateSteamerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSteamerLabel.Location = new System.Drawing.Point(24, 108);
            this.CreateSteamerLabel.Name = "CreateSteamerLabel";
            this.CreateSteamerLabel.Size = new System.Drawing.Size(146, 46);
            this.CreateSteamerLabel.TabIndex = 1;
            this.CreateSteamerLabel.Text = "Steamer";
            this.CreateSteamerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateSteamerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateSteamerLabel_MouseDown);
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBox2);
            this.groupBoxParametrs.Controls.Add(this.checkBox1);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParametrs.Controls.Add(this.label4);
            this.groupBoxParametrs.Controls.Add(this.label3);
            this.groupBoxParametrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxParametrs.Location = new System.Drawing.Point(36, 309);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(450, 147);
            this.groupBoxParametrs.TabIndex = 2;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Parametrs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(54, 54);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(92, 30);
            this.numericUpDownSpeed.TabIndex = 2;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(54, 111);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(91, 30);
            this.numericUpDownWeight.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(285, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(285, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 29);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.pictureBoxForCreate);
            this.panel1.Location = new System.Drawing.Point(243, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 166);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(574, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(194, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DopColor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(19, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 58);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(19, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 58);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(264, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 58);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(264, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 58);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(104, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 58);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(181, 234);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(62, 58);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(181, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(62, 58);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(104, 234);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(62, 58);
            this.panel10.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(825, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(825, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxParametrs);
            this.Controls.Add(this.groupBoxShipOrSteamer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxShipOrSteamer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCreate)).EndInit();
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShipOrSteamer;
        private System.Windows.Forms.Label CreateShipLabel;
        private System.Windows.Forms.PictureBox pictureBoxForCreate;
        private System.Windows.Forms.Label CreateSteamerLabel;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}