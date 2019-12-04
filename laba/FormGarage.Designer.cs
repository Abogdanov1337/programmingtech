namespace laba
{
    partial class FormGarage
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
            this.pictureBoxGarage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGarage
            // 
            this.pictureBoxGarage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGarage.Name = "pictureBoxGarage";
            this.pictureBoxGarage.Size = new System.Drawing.Size(769, 489);
            this.pictureBoxGarage.TabIndex = 0;
            this.pictureBoxGarage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Припарковать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonParkAuto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCars);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBoxTakeCar);
            this.groupBox1.Location = new System.Drawing.Point(787, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(6, 114);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(170, 133);
            this.pictureBoxTakeCar.TabIndex = 0;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Забрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Items.AddRange(new object[] {
            "Грузовик",
            "Бензовоз"});
            this.comboBoxCars.Location = new System.Drawing.Point(7, 31);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCars.TabIndex = 4;
            // 
            // FormGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxGarage);
            this.Name = "FormGarage";
            this.Text = "Гараж";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGarage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCars;
    }
}