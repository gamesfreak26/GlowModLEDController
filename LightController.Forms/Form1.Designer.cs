namespace LightController.Forms
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
            this.btnChooseColour = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picSelectedColour = new System.Windows.Forms.PictureBox();
            this.btnSendColour = new System.Windows.Forms.Button();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseColour
            // 
            this.btnChooseColour.Enabled = false;
            this.btnChooseColour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChooseColour.Location = new System.Drawing.Point(387, 155);
            this.btnChooseColour.Name = "btnChooseColour";
            this.btnChooseColour.Size = new System.Drawing.Size(189, 78);
            this.btnChooseColour.TabIndex = 0;
            this.btnChooseColour.Text = "Choose Colour";
            this.btnChooseColour.UseVisualStyleBackColor = true;
            this.btnChooseColour.Click += new System.EventHandler(this.btnChooseColour_Click);
            // 
            // picSelectedColour
            // 
            this.picSelectedColour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picSelectedColour.Location = new System.Drawing.Point(13, 13);
            this.picSelectedColour.Name = "picSelectedColour";
            this.picSelectedColour.Size = new System.Drawing.Size(356, 313);
            this.picSelectedColour.TabIndex = 1;
            this.picSelectedColour.TabStop = false;
            // 
            // btnSendColour
            // 
            this.btnSendColour.Enabled = false;
            this.btnSendColour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSendColour.Location = new System.Drawing.Point(387, 248);
            this.btnSendColour.Name = "btnSendColour";
            this.btnSendColour.Size = new System.Drawing.Size(189, 78);
            this.btnSendColour.TabIndex = 2;
            this.btnSendColour.Text = "Send Colour";
            this.btnSendColour.UseVisualStyleBackColor = true;
            this.btnSendColour.Click += new System.EventHandler(this.btnSendColour_Click);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(387, 13);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(196, 33);
            this.cmbSerialPorts.TabIndex = 3;
            this.cmbSerialPorts.SelectedValueChanged += new System.EventHandler(this.cmbSerialPorts_SelectedValueChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(387, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(189, 72);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbSerialPorts);
            this.Controls.Add(this.btnSendColour);
            this.Controls.Add(this.picSelectedColour);
            this.Controls.Add(this.btnChooseColour);
            this.Name = "Form1";
            this.Text = "Electra Colour Picker";
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picSelectedColour;
        private System.Windows.Forms.Button btnSendColour;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button btnConnect;
    }
}

