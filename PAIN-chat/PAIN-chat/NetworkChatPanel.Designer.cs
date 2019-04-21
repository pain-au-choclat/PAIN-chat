using System;

namespace PAIN_chat
{
    partial class NetworkChatPanel
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkChatPanel));
            this.comboBoxInputDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxCodecs = new System.Windows.Forms.ComboBox();
            this.buttonStartStreaming = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInputDevices
            // 
            this.comboBoxInputDevices.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxInputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxInputDevices.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxInputDevices.FormattingEnabled = true;
            this.comboBoxInputDevices.Location = new System.Drawing.Point(117, 94);
            this.comboBoxInputDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInputDevices.Name = "comboBoxInputDevices";
            this.comboBoxInputDevices.Size = new System.Drawing.Size(321, 24);
            this.comboBoxInputDevices.TabIndex = 2;
            // 
            // comboBoxCodecs
            // 
            this.comboBoxCodecs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCodecs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCodecs.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxCodecs.FormattingEnabled = true;
            this.comboBoxCodecs.Location = new System.Drawing.Point(117, 126);
            this.comboBoxCodecs.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCodecs.Name = "comboBoxCodecs";
            this.comboBoxCodecs.Size = new System.Drawing.Size(321, 24);
            this.comboBoxCodecs.TabIndex = 3;
            // 
            // buttonStartStreaming
            // 
            this.buttonStartStreaming.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStartStreaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStreaming.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStartStreaming.Location = new System.Drawing.Point(17, 212);
            this.buttonStartStreaming.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartStreaming.Name = "buttonStartStreaming";
            this.buttonStartStreaming.Size = new System.Drawing.Size(172, 28);
            this.buttonStartStreaming.TabIndex = 4;
            this.buttonStartStreaming.Text = "Connect";
            this.buttonStartStreaming.UseVisualStyleBackColor = false;
            this.buttonStartStreaming.Click += new System.EventHandler(this.buttonStartStreaming_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input Device:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compression";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Protocol";
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxProtocol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProtocol.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Location = new System.Drawing.Point(117, 160);
            this.comboBoxProtocol.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(81, 24);
            this.comboBoxProtocol.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PAIN_chat.Properties.Resources.audio_and_sound_megaphone_512px;
            this.pictureBox1.Location = new System.Drawing.Point(208, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(301, 171);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(139, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(268, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 55);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "PAIN-chat";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 302);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 28);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(20, 271);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 22);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Change input sensitivity";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.Location = new System.Drawing.Point(312, 234);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(121, 28);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "Output volume";
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PAIN_chat.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPort.Location = new System.Drawing.Point(117, 57);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(129, 22);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = global::PAIN_chat.Properties.Settings.Default.Port;
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIPAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PAIN_chat.Properties.Settings.Default, "IP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxIPAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxIPAddress.Location = new System.Drawing.Point(117, 25);
            this.textBoxIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(129, 22);
            this.textBoxIPAddress.TabIndex = 0;
            this.textBoxIPAddress.Text = global::PAIN_chat.Properties.Settings.Default.IP;
            // 
            // trackBar2
            // 
            this.trackBar2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PAIN_chat.Properties.Settings.Default, "Tracklock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar2.Location = new System.Drawing.Point(7, 337);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(447, 56);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Value = global::PAIN_chat.Properties.Settings.Default.Tracklock;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // NetworkChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(471, 394);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProtocol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartStreaming);
            this.Controls.Add(this.comboBoxCodecs);
            this.Controls.Add(this.comboBoxInputDevices);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIPAddress);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NetworkChatPanel";
            this.Text = "PAIN-chat P2P";
            this.Load += new System.EventHandler(this.NetworkChatPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBoxIPAddress;
    private System.Windows.Forms.TextBox textBoxPort;
    private System.Windows.Forms.ComboBox comboBoxInputDevices;
    private System.Windows.Forms.ComboBox comboBoxCodecs;
    private System.Windows.Forms.Button buttonStartStreaming;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
    }
}