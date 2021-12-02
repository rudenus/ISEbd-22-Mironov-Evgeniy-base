
namespace ShipForm
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.ParkingShipButton = new System.Windows.Forms.Button();
            this.AddParkingButton = new System.Windows.Forms.Button();
            this.RemoveParkingButton = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewParking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1079, 601);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PickUpButton);
            this.groupBox1.Location = new System.Drawing.Point(1086, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(155, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick up ship";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(75, 46);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(41, 22);
            this.maskedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place";
            // 
            // PickUpButton
            // 
            this.PickUpButton.Location = new System.Drawing.Point(40, 84);
            this.PickUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(75, 23);
            this.PickUpButton.TabIndex = 0;
            this.PickUpButton.Text = "Pick Up";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // ParkingShipButton
            // 
            this.ParkingShipButton.Location = new System.Drawing.Point(1085, 310);
            this.ParkingShipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParkingShipButton.Name = "ParkingShipButton";
            this.ParkingShipButton.Size = new System.Drawing.Size(143, 81);
            this.ParkingShipButton.TabIndex = 2;
            this.ParkingShipButton.Text = "Add Ship";
            this.ParkingShipButton.UseVisualStyleBackColor = true;
            this.ParkingShipButton.Click += new System.EventHandler(this.ParkingShipButton_Click);
            // 
            // AddParkingButton
            // 
            this.AddParkingButton.AutoSize = true;
            this.AddParkingButton.Location = new System.Drawing.Point(1085, 96);
            this.AddParkingButton.Name = "AddParkingButton";
            this.AddParkingButton.Size = new System.Drawing.Size(139, 27);
            this.AddParkingButton.TabIndex = 4;
            this.AddParkingButton.Text = "Add Parking";
            this.AddParkingButton.UseVisualStyleBackColor = true;
            this.AddParkingButton.Click += new System.EventHandler(this.AddParkingButton_Click);
            // 
            // RemoveParkingButton
            // 
            this.RemoveParkingButton.Location = new System.Drawing.Point(1086, 237);
            this.RemoveParkingButton.Name = "RemoveParkingButton";
            this.RemoveParkingButton.Size = new System.Drawing.Size(138, 30);
            this.RemoveParkingButton.TabIndex = 5;
            this.RemoveParkingButton.Text = "Remove Parking";
            this.RemoveParkingButton.UseVisualStyleBackColor = true;
            this.RemoveParkingButton.Click += new System.EventHandler(this.RemoveParkingButton_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1086, 147);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(138, 84);
            this.listBoxParkings.TabIndex = 6;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewParking
            // 
            this.textBoxNewParking.Location = new System.Drawing.Point(1085, 68);
            this.textBoxNewParking.Name = "textBoxNewParking";
            this.textBoxNewParking.Size = new System.Drawing.Size(139, 22);
            this.textBoxNewParking.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parking Lots";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenu,
            this.LoadMenu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(224, 26);
            this.SaveMenu.Text = "Save";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // LoadMenu
            // 
            this.LoadMenu.Name = "LoadMenu";
            this.LoadMenu.Size = new System.Drawing.Size(224, 26);
            this.LoadMenu.Text = "Load";
            this.LoadMenu.Click += new System.EventHandler(this.LoadMenu_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.RemoveParkingButton);
            this.Controls.Add(this.AddParkingButton);
            this.Controls.Add(this.ParkingShipButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormParking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.Button ParkingShipButton;
        private System.Windows.Forms.Button AddParkingButton;
        private System.Windows.Forms.Button RemoveParkingButton;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewParking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadMenu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}