
namespace CarStoreApp
{
    partial class CargoShipWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoShipWinForms));
            this.MotorBike_trackBar = new System.Windows.Forms.TrackBar();
            this.Truck_trackBar = new System.Windows.Forms.TrackBar();
            this.Car_trackBar = new System.Windows.Forms.TrackBar();
            this.Train_trackBar = new System.Windows.Forms.TrackBar();
            this.CargoShip_Picturebox = new System.Windows.Forms.PictureBox();
            this.ship_progressBar = new System.Windows.Forms.ProgressBar();
            this.MotorBike_label = new System.Windows.Forms.Label();
            this.Car_label = new System.Windows.Forms.Label();
            this.Truck_label = new System.Windows.Forms.Label();
            this.Train_label = new System.Windows.Forms.Label();
            this.TKT_label = new System.Windows.Forms.Label();
            this.TNT_label = new System.Windows.Forms.Label();
            this.MT_label = new System.Windows.Forms.Label();
            this.CT_label = new System.Windows.Forms.Label();
            this.New_Button = new System.Windows.Forms.Button();
            this.ship_labels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MotorBike_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoShip_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // MotorBike_trackBar
            // 
            this.MotorBike_trackBar.Location = new System.Drawing.Point(12, 358);
            this.MotorBike_trackBar.Name = "MotorBike_trackBar";
            this.MotorBike_trackBar.Size = new System.Drawing.Size(282, 45);
            this.MotorBike_trackBar.TabIndex = 0;
            this.MotorBike_trackBar.Scroll += new System.EventHandler(this.MotorBike_trackBar_Scroll);
            // 
            // Truck_trackBar
            // 
            this.Truck_trackBar.Location = new System.Drawing.Point(12, 474);
            this.Truck_trackBar.Name = "Truck_trackBar";
            this.Truck_trackBar.Size = new System.Drawing.Size(282, 45);
            this.Truck_trackBar.TabIndex = 1;
            this.Truck_trackBar.Scroll += new System.EventHandler(this.Truck_trackBar_Scroll);
            // 
            // Car_trackBar
            // 
            this.Car_trackBar.Location = new System.Drawing.Point(506, 358);
            this.Car_trackBar.Name = "Car_trackBar";
            this.Car_trackBar.Size = new System.Drawing.Size(282, 45);
            this.Car_trackBar.TabIndex = 2;
            this.Car_trackBar.Scroll += new System.EventHandler(this.Car_trackBar_Scroll);
            // 
            // Train_trackBar
            // 
            this.Train_trackBar.Location = new System.Drawing.Point(506, 474);
            this.Train_trackBar.Name = "Train_trackBar";
            this.Train_trackBar.Size = new System.Drawing.Size(282, 45);
            this.Train_trackBar.TabIndex = 3;
            this.Train_trackBar.Scroll += new System.EventHandler(this.Train_trackBar_Scroll);
            // 
            // CargoShip_Picturebox
            // 
            this.CargoShip_Picturebox.Image = global::CarStoreApp.Properties.Resources.cargoship;
            this.CargoShip_Picturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("CargoShip_Picturebox.InitialImage")));
            this.CargoShip_Picturebox.Location = new System.Drawing.Point(12, 12);
            this.CargoShip_Picturebox.Name = "CargoShip_Picturebox";
            this.CargoShip_Picturebox.Size = new System.Drawing.Size(775, 222);
            this.CargoShip_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CargoShip_Picturebox.TabIndex = 4;
            this.CargoShip_Picturebox.TabStop = false;
           // this.CargoShip_Picturebox.Click += new System.EventHandler(this.CargoShip_Picturebox_Click);
            // 
            // ship_progressBar
            // 
            this.ship_progressBar.Location = new System.Drawing.Point(192, 58);
            this.ship_progressBar.Name = "ship_progressBar";
            this.ship_progressBar.Size = new System.Drawing.Size(448, 85);
            this.ship_progressBar.TabIndex = 5;
            this.ship_progressBar.Value = 25;
           // this.ship_progressBar.Click += new System.EventHandler(this.ship_progressBar_Click);
            // 
            // MotorBike_label
            // 
            this.MotorBike_label.AutoSize = true;
            this.MotorBike_label.Location = new System.Drawing.Point(116, 328);
            this.MotorBike_label.Name = "MotorBike_label";
            this.MotorBike_label.Size = new System.Drawing.Size(75, 13);
            this.MotorBike_label.TabIndex = 6;
            this.MotorBike_label.Text = "Motor bike = 1";
           // this.MotorBike_label.Click += new System.EventHandler(this.MotorBike_label_Click);
            // 
            // Car_label
            // 
            this.Car_label.AutoSize = true;
            this.Car_label.Location = new System.Drawing.Point(627, 328);
            this.Car_label.Name = "Car_label";
            this.Car_label.Size = new System.Drawing.Size(41, 13);
            this.Car_label.TabIndex = 7;
            this.Car_label.Text = "Car = 2";
           // this.Car_label.Click += new System.EventHandler(this.Car_label_Click);
            // 
            // Truck_label
            // 
            this.Truck_label.AutoSize = true;
            this.Truck_label.Location = new System.Drawing.Point(127, 441);
            this.Truck_label.Name = "Truck_label";
            this.Truck_label.Size = new System.Drawing.Size(53, 13);
            this.Truck_label.TabIndex = 8;
            this.Truck_label.Text = "Truck = 3";
           // this.Truck_label.Click += new System.EventHandler(this.Truck_label_Click);
            // 
            // Train_label
            // 
            this.Train_label.AutoSize = true;
            this.Train_label.Location = new System.Drawing.Point(623, 441);
            this.Train_label.Name = "Train_label";
            this.Train_label.Size = new System.Drawing.Size(49, 13);
            this.Train_label.TabIndex = 9;
            this.Train_label.Text = "Train = 4";
          //  this.Train_label.Click += new System.EventHandler(this.Train_label_Click);
            // 
            // TKT_label
            // 
            this.TKT_label.AutoSize = true;
            this.TKT_label.Location = new System.Drawing.Point(101, 517);
            this.TKT_label.Name = "TKT_label";
            this.TKT_label.Size = new System.Drawing.Size(105, 13);
            this.TKT_label.TabIndex = 10;
            this.TKT_label.Text = "Slider for truck count";
           // this.TKT_label.Click += new System.EventHandler(this.TKT_label_Click);
            // 
            // TNT_label
            // 
            this.TNT_label.AutoSize = true;
            this.TNT_label.Location = new System.Drawing.Point(597, 517);
            this.TNT_label.Name = "TNT_label";
            this.TNT_label.Size = new System.Drawing.Size(101, 13);
            this.TNT_label.TabIndex = 11;
            this.TNT_label.Text = "Slider for train count";
           // this.TNT_label.Click += new System.EventHandler(this.TNT_label_Click);
            // 
            // MT_label
            // 
            this.MT_label.AutoSize = true;
            this.MT_label.Location = new System.Drawing.Point(88, 390);
            this.MT_label.Name = "MT_label";
            this.MT_label.Size = new System.Drawing.Size(130, 13);
            this.MT_label.TabIndex = 12;
            this.MT_label.Text = "Slider for motor bike count";
            //this.MT_label.Click += new System.EventHandler(this.MT_label_Click);
            // 
            // CT_label
            // 
            this.CT_label.AutoSize = true;
            this.CT_label.Location = new System.Drawing.Point(599, 390);
            this.CT_label.Name = "CT_label";
            this.CT_label.Size = new System.Drawing.Size(96, 13);
            this.CT_label.TabIndex = 13;
            this.CT_label.Text = "Slider for car count";
           // this.CT_label.Click += new System.EventHandler(this.CT_label_Click);
            // 
            // New_Button
            // 
            this.New_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.New_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.New_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.New_Button.Location = new System.Drawing.Point(665, 22);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(106, 43);
            this.New_Button.TabIndex = 14;
            this.New_Button.Text = "New Boat";
            this.New_Button.UseVisualStyleBackColor = false;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // ship_labels
            // 
            this.ship_labels.AutoSize = true;
            this.ship_labels.Location = new System.Drawing.Point(116, 164);
            this.ship_labels.Name = "ship_labels";
            this.ship_labels.Size = new System.Drawing.Size(35, 13);
            this.ship_labels.TabIndex = 15;
            this.ship_labels.Text = "label1";
            this.ship_labels.Click += new System.EventHandler(this.label1_Click);
            // 
            // CargoShipWinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.ship_labels);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.CT_label);
            this.Controls.Add(this.MT_label);
            this.Controls.Add(this.TNT_label);
            this.Controls.Add(this.TKT_label);
            this.Controls.Add(this.Train_label);
            this.Controls.Add(this.Truck_label);
            this.Controls.Add(this.Car_label);
            this.Controls.Add(this.MotorBike_label);
            this.Controls.Add(this.ship_progressBar);
            this.Controls.Add(this.CargoShip_Picturebox);
            this.Controls.Add(this.Train_trackBar);
            this.Controls.Add(this.Car_trackBar);
            this.Controls.Add(this.Truck_trackBar);
            this.Controls.Add(this.MotorBike_trackBar);
            this.Name = "CargoShipWinForms";
            this.Text = "CargoShipWinForms";
            this.Load += new System.EventHandler(this.CargoShipWinForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MotorBike_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoShip_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar MotorBike_trackBar;
        private System.Windows.Forms.TrackBar Truck_trackBar;
        private System.Windows.Forms.TrackBar Car_trackBar;
        private System.Windows.Forms.TrackBar Train_trackBar;
        private System.Windows.Forms.PictureBox CargoShip_Picturebox;
        private System.Windows.Forms.ProgressBar ship_progressBar;
        private System.Windows.Forms.Label MotorBike_label;
        private System.Windows.Forms.Label Car_label;
        private System.Windows.Forms.Label Truck_label;
        private System.Windows.Forms.Label Train_label;
        private System.Windows.Forms.Label TKT_label;
        private System.Windows.Forms.Label TNT_label;
        private System.Windows.Forms.Label MT_label;
        private System.Windows.Forms.Label CT_label;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Label ship_labels;
    }
}