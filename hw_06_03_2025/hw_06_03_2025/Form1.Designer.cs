namespace hw_06_03_2025
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
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.GetWeatherButton = new System.Windows.Forms.Button();
            this.WeatherInfoLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // CityTextBox
            this.CityTextBox.Location = new System.Drawing.Point(50, 30);
            this.CityTextBox.Size = new System.Drawing.Size(200, 23);
            this.CityTextBox.PlaceholderText = "Введіть місто";

            // GetWeatherButton
            this.GetWeatherButton.Location = new System.Drawing.Point(270, 30);
            this.GetWeatherButton.Size = new System.Drawing.Size(100, 23);
            this.GetWeatherButton.Text = "Отримати погоду";
            this.GetWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);

            // WeatherInfoLabel
            this.WeatherInfoLabel.Location = new System.Drawing.Point(50, 70);
            this.WeatherInfoLabel.Size = new System.Drawing.Size(400, 150);
            this.WeatherInfoLabel.Text = "Інформація про погоду з'явиться тут";

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.GetWeatherButton);
            this.Controls.Add(this.WeatherInfoLabel);
            this.Text = "Weather App";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button GetWeatherButton;
        private System.Windows.Forms.Label WeatherInfoLabel;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Label lblProgress;
    }
}
