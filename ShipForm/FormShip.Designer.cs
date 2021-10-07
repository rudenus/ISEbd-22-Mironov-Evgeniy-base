namespace ShipForm
{
	partial class FormShip
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonCreateSteamer = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.pictureBoxShip = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(10, 11);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(91, 23);
			this.buttonCreate.TabIndex = 7;
			this.buttonCreate.Text = "Create Ship";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::ShipForm.Properties.Resources.left1;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(749, 404);
			this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(58, 64);
			this.buttonLeft.TabIndex = 9;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::ShipForm.Properties.Resources.down1;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(811, 404);
			this.buttonDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(58, 64);
			this.buttonDown.TabIndex = 11;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::ShipForm.Properties.Resources.right1;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(874, 404);
			this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(58, 64);
			this.buttonRight.TabIndex = 12;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonCreateSteamer
			// 
			this.buttonCreateSteamer.Location = new System.Drawing.Point(123, 11);
			this.buttonCreateSteamer.Name = "buttonCreateSteamer";
			this.buttonCreateSteamer.Size = new System.Drawing.Size(91, 23);
			this.buttonCreateSteamer.TabIndex = 13;
			this.buttonCreateSteamer.Text = "Create Steamer";
			this.buttonCreateSteamer.UseVisualStyleBackColor = true;
			this.buttonCreateSteamer.Click += new System.EventHandler(this.buttonCreateSteamer_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::ShipForm.Properties.Resources.up1;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(811, 335);
			this.buttonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(58, 64);
			this.buttonUp.TabIndex = 10;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// pictureBoxShip
			// 
			this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBoxShip.Name = "pictureBoxShip";
			this.pictureBoxShip.Size = new System.Drawing.Size(940, 511);
			this.pictureBoxShip.TabIndex = 8;
			this.pictureBoxShip.TabStop = false;
			// 
			// FormShip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 511);
			this.Controls.Add(this.buttonCreateSteamer);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.pictureBoxShip);
			this.Name = "FormShip";
			this.Text = "ShipForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreateSteamer;
    }
}

