namespace Pogoda
{
    partial class MainPogoda
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
            this.buttonGet = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.lblNetConnection = new System.Windows.Forms.Label();
            this.pictureBoxConnectionStatus = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tabControlInformation = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtInfoDay = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInfoNight = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtInfoNextDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnectionStatus)).BeginInit();
            this.tabControlInformation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.Enabled = false;
            this.buttonGet.Location = new System.Drawing.Point(341, 25);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Ok";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(70, 12);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(200, 21);
            this.comboBoxState.TabIndex = 2;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(70, 39);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCity.TabIndex = 3;
            this.comboBoxCity.Visible = false;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // lblNetConnection
            // 
            this.lblNetConnection.AutoSize = true;
            this.lblNetConnection.Location = new System.Drawing.Point(317, 116);
            this.lblNetConnection.Name = "lblNetConnection";
            this.lblNetConnection.Size = new System.Drawing.Size(99, 13);
            this.lblNetConnection.TabIndex = 4;
            this.lblNetConnection.Text = "Internet connection";
            // 
            // pictureBoxConnectionStatus
            // 
            this.pictureBoxConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConnectionStatus.Image = global::Pogoda.Properties.Resources.unknown;
            this.pictureBoxConnectionStatus.Location = new System.Drawing.Point(353, 132);
            this.pictureBoxConnectionStatus.Name = "pictureBoxConnectionStatus";
            this.pictureBoxConnectionStatus.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConnectionStatus.TabIndex = 5;
            this.pictureBoxConnectionStatus.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 47);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // tabControlInformation
            // 
            this.tabControlInformation.Controls.Add(this.tabPage1);
            this.tabControlInformation.Controls.Add(this.tabPage2);
            this.tabControlInformation.Controls.Add(this.tabPage3);
            this.tabControlInformation.Location = new System.Drawing.Point(15, 66);
            this.tabControlInformation.Name = "tabControlInformation";
            this.tabControlInformation.SelectedIndex = 0;
            this.tabControlInformation.Size = new System.Drawing.Size(286, 217);
            this.tabControlInformation.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtInfoDay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Day";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtInfoDay
            // 
            this.txtInfoDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfoDay.Location = new System.Drawing.Point(0, 0);
            this.txtInfoDay.Multiline = true;
            this.txtInfoDay.Name = "txtInfoDay";
            this.txtInfoDay.Size = new System.Drawing.Size(278, 191);
            this.txtInfoDay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInfoNight);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Night";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInfoNight
            // 
            this.txtInfoNight.Location = new System.Drawing.Point(0, 0);
            this.txtInfoNight.Multiline = true;
            this.txtInfoNight.Name = "txtInfoNight";
            this.txtInfoNight.Size = new System.Drawing.Size(278, 191);
            this.txtInfoNight.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtInfoNextDay);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(278, 191);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NextDay";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtInfoNextDay
            // 
            this.txtInfoNextDay.Location = new System.Drawing.Point(0, 0);
            this.txtInfoNextDay.Multiline = true;
            this.txtInfoNextDay.Name = "txtInfoNextDay";
            this.txtInfoNextDay.Size = new System.Drawing.Size(278, 191);
            this.txtInfoNextDay.TabIndex = 1;
            // 
            // MainPogoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 295);
            this.Controls.Add(this.tabControlInformation);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pictureBoxConnectionStatus);
            this.Controls.Add(this.lblNetConnection);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.buttonGet);
            this.MaximizeBox = false;
            this.Name = "MainPogoda";
            this.Text = "Pogoda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnectionStatus)).EndInit();
            this.tabControlInformation.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label lblNetConnection;
        private System.Windows.Forms.PictureBox pictureBoxConnectionStatus;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TabControl tabControlInformation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtInfoDay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInfoNight;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtInfoNextDay;
    }
}

