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
            this.pbPrev1 = new System.Windows.Forms.PictureBox();
            this.pbPrev2 = new System.Windows.Forms.PictureBox();
            this.pbPrev3 = new System.Windows.Forms.PictureBox();
            this.pbPrev4 = new System.Windows.Forms.PictureBox();
            this.pbPrev5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev5)).BeginInit();
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
            // pbPrev1
            // 
            this.pbPrev1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPrev1.Location = new System.Drawing.Point(13, 343);
            this.pbPrev1.Name = "pbPrev1";
            this.pbPrev1.Size = new System.Drawing.Size(93, 95);
            this.pbPrev1.TabIndex = 5;
            this.pbPrev1.TabStop = false;
            this.pbPrev1.Click += new System.EventHandler(this.pbPrev1_Click);
            // 
            // pbPrev2
            // 
            this.pbPrev2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPrev2.Location = new System.Drawing.Point(123, 343);
            this.pbPrev2.Name = "pbPrev2";
            this.pbPrev2.Size = new System.Drawing.Size(93, 95);
            this.pbPrev2.TabIndex = 6;
            this.pbPrev2.TabStop = false;
            this.pbPrev2.Click += new System.EventHandler(this.pbPrev2_Click);
            // 
            // pbPrev3
            // 
            this.pbPrev3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPrev3.Location = new System.Drawing.Point(236, 343);
            this.pbPrev3.Name = "pbPrev3";
            this.pbPrev3.Size = new System.Drawing.Size(93, 95);
            this.pbPrev3.TabIndex = 7;
            this.pbPrev3.TabStop = false;
            this.pbPrev3.Click += new System.EventHandler(this.pbPrev3_Click);
            // 
            // pbPrev4
            // 
            this.pbPrev4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPrev4.Location = new System.Drawing.Point(347, 343);
            this.pbPrev4.Name = "pbPrev4";
            this.pbPrev4.Size = new System.Drawing.Size(93, 95);
            this.pbPrev4.TabIndex = 8;
            this.pbPrev4.TabStop = false;
            this.pbPrev4.Click += new System.EventHandler(this.pbPrev4_Click);
            // 
            // pbPrev5
            // 
            this.pbPrev5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPrev5.Location = new System.Drawing.Point(458, 343);
            this.pbPrev5.Name = "pbPrev5";
            this.pbPrev5.Size = new System.Drawing.Size(93, 95);
            this.pbPrev5.TabIndex = 9;
            this.pbPrev5.TabStop = false;
            this.pbPrev5.Click += new System.EventHandler(this.pbPrev5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPrev5);
            this.Controls.Add(this.pbPrev4);
            this.Controls.Add(this.pbPrev3);
            this.Controls.Add(this.pbPrev2);
            this.Controls.Add(this.pbPrev1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbSerialPorts);
            this.Controls.Add(this.btnSendColour);
            this.Controls.Add(this.picSelectedColour);
            this.Controls.Add(this.btnChooseColour);
            this.Name = "Form1";
            this.Text = "Electra Colour Picker";
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picSelectedColour;
        private System.Windows.Forms.Button btnSendColour;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pbPrev1;
        private System.Windows.Forms.PictureBox pbPrev2;
        private System.Windows.Forms.PictureBox pbPrev3;
        private System.Windows.Forms.PictureBox pbPrev4;
        private System.Windows.Forms.PictureBox pbPrev5;
    }
}

