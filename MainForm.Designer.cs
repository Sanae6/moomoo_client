namespace Moomoo_Client
{
    partial class MainWindow
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
            this.connect = new System.Windows.Forms.Button();
            this.partyKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.indicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.msgLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jsonField = new System.Windows.Forms.TextBox();
            this.sendJsonButton = new System.Windows.Forms.Button();
            this.spinMoverPanel = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.connect.Location = new System.Drawing.Point(179, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 20);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            this.partyKey.Location = new System.Drawing.Point(73, 12);
            this.partyKey.Name = "partyKey";
            this.partyKey.Size = new System.Drawing.Size(100, 20);
            this.partyKey.TabIndex = 1;
            this.partyKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.partyKey_KeyPress);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Party Key:";
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.indicator});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(143, 17);
            this.indicator.Text = "Getting available servers...";
            this.pictureBox1.Location = new System.Drawing.Point(15, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.groupBox1.Controls.Add(this.spinMoverPanel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(261, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 291);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Actions";
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spawn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimap:";
            this.msgLog.Enabled = false;
            this.msgLog.Location = new System.Drawing.Point(484, 33);
            this.msgLog.Multiline = true;
            this.msgLog.Name = "msgLog";
            this.msgLog.Size = new System.Drawing.Size(304, 271);
            this.msgLog.TabIndex = 7;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message Log";
            this.jsonField.Location = new System.Drawing.Point(13, 311);
            this.jsonField.Name = "jsonField";
            this.jsonField.Size = new System.Drawing.Size(775, 20);
            this.jsonField.TabIndex = 9;
            this.jsonField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jsonField_KeyPress);
            this.sendJsonButton.Enabled = false;
            this.sendJsonButton.Location = new System.Drawing.Point(13, 338);
            this.sendJsonButton.Name = "sendJsonButton";
            this.sendJsonButton.Size = new System.Drawing.Size(75, 23);
            this.sendJsonButton.TabIndex = 10;
            this.sendJsonButton.Text = "Send Json";
            this.sendJsonButton.UseVisualStyleBackColor = true;
            this.sendJsonButton.Click += new System.EventHandler(this.sendJsonButton_Click);
            this.spinMoverPanel.Location = new System.Drawing.Point(7, 51);
            this.spinMoverPanel.Name = "spinMoverPanel";
            this.spinMoverPanel.Size = new System.Drawing.Size(100, 100);
            this.spinMoverPanel.TabIndex = 1;
            this.spinMoverPanel.TabStop = false;
            this.spinMoverPanel.Text = "Movement";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendJsonButton);
            this.Controls.Add(this.jsonField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partyKey);
            this.Controls.Add(this.connect);
            this.Enabled = false;
            this.Name = "MainWindow";
            this.Text = "Moomoo.io Bot Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EFormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox partyKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel indicator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox msgLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jsonField;
        private System.Windows.Forms.Button sendJsonButton;
        private System.Windows.Forms.GroupBox spinMoverPanel;
    }
}

