namespace Moomoo_Client
{
    partial class SpawnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.colorSpinner = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.spawnBonusCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorSpinner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(79, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Moocarina";
            // 
            // colorSpinner
            // 
            this.colorSpinner.Location = new System.Drawing.Point(79, 31);
            this.colorSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSpinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSpinner.Name = "colorSpinner";
            this.colorSpinner.Size = new System.Drawing.Size(100, 20);
            this.colorSpinner.TabIndex = 2;
            this.colorSpinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSpinner.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color Preview:";
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(79, 57);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(100, 34);
            this.colorPanel.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(22, 139);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // spawnBonusCheckbox
            // 
            this.spawnBonusCheckbox.AutoSize = true;
            this.spawnBonusCheckbox.Location = new System.Drawing.Point(22, 97);
            this.spawnBonusCheckbox.Name = "spawnBonusCheckbox";
            this.spawnBonusCheckbox.Size = new System.Drawing.Size(169, 17);
            this.spawnBonusCheckbox.TabIndex = 8;
            this.spawnBonusCheckbox.Text = "Spawn Bonus? (100 each res)";
            this.spawnBonusCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.spawnBonusCheckbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.colorSpinner);
            this.panel1.Controls.Add(this.colorPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 171);
            this.panel1.TabIndex = 9;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(104, 139);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SpawnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 193);
            this.Controls.Add(this.panel1);
            this.Name = "SpawnForm";
            this.Text = "SpawnForm";
            ((System.ComponentModel.ISupportInitialize)(this.colorSpinner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown colorSpinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.CheckBox spawnBonusCheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
    }
}