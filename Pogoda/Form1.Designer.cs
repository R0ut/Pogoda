namespace Pogoda
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
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxInformation = new System.Windows.Forms.RichTextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxConnectionStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnectionStatus)).BeginInit();
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
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(33, 97);
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.Size = new System.Drawing.Size(260, 186);
            this.textBoxInformation.TabIndex = 1;
            this.textBoxInformation.Text = "";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(49, 12);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(200, 21);
            this.comboBoxState.TabIndex = 2;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(49, 40);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCity.TabIndex = 3;
            this.comboBoxCity.Visible = false;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Internet connection";
            // 
            // pictureBoxConnectionStatus
            // 
            this.pictureBoxConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConnectionStatus.Image = global::Pogoda.Properties.Resources.unknown;
            this.pictureBoxConnectionStatus.Location = new System.Drawing.Point(354, 132);
            this.pictureBoxConnectionStatus.Name = "pictureBoxConnectionStatus";
            this.pictureBoxConnectionStatus.Size = new System.Drawing.Size(31, 29);
            this.pictureBoxConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxConnectionStatus.TabIndex = 5;
            this.pictureBoxConnectionStatus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 295);
            this.Controls.Add(this.pictureBoxConnectionStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.buttonGet);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pogoda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.RichTextBox textBoxInformation;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxConnectionStatus;
    }
}

