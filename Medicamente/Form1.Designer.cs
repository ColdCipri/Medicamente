﻿namespace Medicamente
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
            this.medicament_Group = new System.Windows.Forms.GroupBox();
            this.Id_label = new System.Windows.Forms.Label();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Filtru_label = new System.Windows.Forms.Label();
            this.Filtru_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Data_label = new System.Windows.Forms.Label();
            this.Bucati_label = new System.Windows.Forms.Label();
            this.Nume_label = new System.Windows.Forms.Label();
            this.Bucati_textBox = new System.Windows.Forms.TextBox();
            this.Nume_textBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tip_label_Upgrade = new System.Windows.Forms.Label();
            this.comboBox_Upgrade = new System.Windows.Forms.ComboBox();
            this.Upgrade_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_Add = new System.Windows.Forms.PictureBox();
            this.Restart_button = new System.Windows.Forms.Button();
            this.Upgrade_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Upload_button_Upgrade = new System.Windows.Forms.Button();
            this.Data_label_Upgrade = new System.Windows.Forms.Label();
            this.Bucati_label_Upgrade = new System.Windows.Forms.Label();
            this.Nume_label_Upgrade = new System.Windows.Forms.Label();
            this.Bucati_textbox_Upgrade = new System.Windows.Forms.TextBox();
            this.Nume_textBox_Upgrade = new System.Windows.Forms.TextBox();
            this.medicament_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // medicament_Group
            // 
            this.medicament_Group.Controls.Add(this.Id_label);
            this.medicament_Group.Controls.Add(this.Id_textBox);
            this.medicament_Group.Controls.Add(this.Filtru_label);
            this.medicament_Group.Controls.Add(this.Filtru_textBox);
            this.medicament_Group.Controls.Add(this.label1);
            this.medicament_Group.Controls.Add(this.comboBox);
            this.medicament_Group.Controls.Add(this.dateTimePicker1);
            this.medicament_Group.Controls.Add(this.pictureBox1);
            this.medicament_Group.Controls.Add(this.Data_label);
            this.medicament_Group.Controls.Add(this.Bucati_label);
            this.medicament_Group.Controls.Add(this.Nume_label);
            this.medicament_Group.Controls.Add(this.Bucati_textBox);
            this.medicament_Group.Controls.Add(this.Nume_textBox);
            this.medicament_Group.Controls.Add(this.listBox1);
            this.medicament_Group.Location = new System.Drawing.Point(22, 20);
            this.medicament_Group.Name = "medicament_Group";
            this.medicament_Group.Size = new System.Drawing.Size(942, 402);
            this.medicament_Group.TabIndex = 0;
            this.medicament_Group.TabStop = false;
            this.medicament_Group.Text = "Medicament";
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_label.Location = new System.Drawing.Point(322, 21);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(39, 29);
            this.Id_label.TabIndex = 12;
            this.Id_label.Text = "Id:";
            // 
            // Id_textBox
            // 
            this.Id_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Id_textBox.Location = new System.Drawing.Point(367, 28);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.ReadOnly = true;
            this.Id_textBox.Size = new System.Drawing.Size(50, 22);
            this.Id_textBox.TabIndex = 9;
            // 
            // Filtru_label
            // 
            this.Filtru_label.AutoSize = true;
            this.Filtru_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtru_label.Location = new System.Drawing.Point(11, 361);
            this.Filtru_label.Name = "Filtru_label";
            this.Filtru_label.Size = new System.Drawing.Size(81, 29);
            this.Filtru_label.TabIndex = 47;
            this.Filtru_label.Text = "Cauta:";
            // 
            // Filtru_textBox
            // 
            this.Filtru_textBox.Location = new System.Drawing.Point(103, 368);
            this.Filtru_textBox.Name = "Filtru_textBox";
            this.Filtru_textBox.Size = new System.Drawing.Size(193, 22);
            this.Filtru_textBox.TabIndex = 46;
            this.Filtru_textBox.TextChanged += new System.EventHandler(this.Filtru_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tip:";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Pastila",
            "Crema",
            "Ceai",
            "Spray"});
            this.comboBox.Location = new System.Drawing.Point(757, 84);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(105, 24);
            this.comboBox.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 214);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Data_label
            // 
            this.Data_label.AutoSize = true;
            this.Data_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_label.Location = new System.Drawing.Point(322, 79);
            this.Data_label.Name = "Data_label";
            this.Data_label.Size = new System.Drawing.Size(162, 29);
            this.Data_label.TabIndex = 16;
            this.Data_label.Text = "Data Expirarii:";
            // 
            // Bucati_label
            // 
            this.Bucati_label.AutoSize = true;
            this.Bucati_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bucati_label.Location = new System.Drawing.Point(751, 21);
            this.Bucati_label.Name = "Bucati_label";
            this.Bucati_label.Size = new System.Drawing.Size(85, 29);
            this.Bucati_label.TabIndex = 14;
            this.Bucati_label.Text = "Bucati:";
            // 
            // Nume_label
            // 
            this.Nume_label.AutoSize = true;
            this.Nume_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_label.Location = new System.Drawing.Point(446, 21);
            this.Nume_label.Name = "Nume_label";
            this.Nume_label.Size = new System.Drawing.Size(84, 29);
            this.Nume_label.TabIndex = 13;
            this.Nume_label.Text = "Nume:";
            // 
            // Bucati_textBox
            // 
            this.Bucati_textBox.Location = new System.Drawing.Point(842, 28);
            this.Bucati_textBox.Name = "Bucati_textBox";
            this.Bucati_textBox.Size = new System.Drawing.Size(36, 22);
            this.Bucati_textBox.TabIndex = 11;
            // 
            // Nume_textBox
            // 
            this.Nume_textBox.Location = new System.Drawing.Point(536, 28);
            this.Nume_textBox.Name = "Nume_textBox";
            this.Nume_textBox.Size = new System.Drawing.Size(197, 22);
            this.Nume_textBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tip_label_Upgrade);
            this.groupBox1.Controls.Add(this.comboBox_Upgrade);
            this.groupBox1.Controls.Add(this.Upgrade_dateTimePicker);
            this.groupBox1.Controls.Add(this.pictureBox_Add);
            this.groupBox1.Controls.Add(this.Restart_button);
            this.groupBox1.Controls.Add(this.Upgrade_button);
            this.groupBox1.Controls.Add(this.Delete_button);
            this.groupBox1.Controls.Add(this.Add_button);
            this.groupBox1.Controls.Add(this.Upload_button_Upgrade);
            this.groupBox1.Controls.Add(this.Data_label_Upgrade);
            this.groupBox1.Controls.Add(this.Bucati_label_Upgrade);
            this.groupBox1.Controls.Add(this.Nume_label_Upgrade);
            this.groupBox1.Controls.Add(this.Bucati_textbox_Upgrade);
            this.groupBox1.Controls.Add(this.Nume_textBox_Upgrade);
            this.groupBox1.Location = new System.Drawing.Point(22, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrade";
            // 
            // Tip_label_Upgrade
            // 
            this.Tip_label_Upgrade.AutoSize = true;
            this.Tip_label_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_label_Upgrade.Location = new System.Drawing.Point(669, 30);
            this.Tip_label_Upgrade.Name = "Tip_label_Upgrade";
            this.Tip_label_Upgrade.Size = new System.Drawing.Size(55, 29);
            this.Tip_label_Upgrade.TabIndex = 43;
            this.Tip_label_Upgrade.Text = "Tip:";
            // 
            // comboBox_Upgrade
            // 
            this.comboBox_Upgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Upgrade.FormattingEnabled = true;
            this.comboBox_Upgrade.Items.AddRange(new object[] {
            "Pastila",
            "Crema",
            "Ceai",
            "Spray"});
            this.comboBox_Upgrade.Location = new System.Drawing.Point(739, 37);
            this.comboBox_Upgrade.Name = "comboBox_Upgrade";
            this.comboBox_Upgrade.Size = new System.Drawing.Size(157, 24);
            this.comboBox_Upgrade.TabIndex = 42;
            // 
            // Upgrade_dateTimePicker
            // 
            this.Upgrade_dateTimePicker.Location = new System.Drawing.Point(389, 85);
            this.Upgrade_dateTimePicker.Name = "Upgrade_dateTimePicker";
            this.Upgrade_dateTimePicker.Size = new System.Drawing.Size(167, 22);
            this.Upgrade_dateTimePicker.TabIndex = 37;
            // 
            // pictureBox_Add
            // 
            this.pictureBox_Add.Location = new System.Drawing.Point(430, 125);
            this.pictureBox_Add.Name = "pictureBox_Add";
            this.pictureBox_Add.Size = new System.Drawing.Size(229, 179);
            this.pictureBox_Add.TabIndex = 36;
            this.pictureBox_Add.TabStop = false;
            // 
            // Restart_button
            // 
            this.Restart_button.Location = new System.Drawing.Point(16, 256);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(147, 48);
            this.Restart_button.TabIndex = 35;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // Upgrade_button
            // 
            this.Upgrade_button.Location = new System.Drawing.Point(16, 180);
            this.Upgrade_button.Name = "Upgrade_button";
            this.Upgrade_button.Size = new System.Drawing.Size(147, 48);
            this.Upgrade_button.TabIndex = 34;
            this.Upgrade_button.Text = "Update";
            this.Upgrade_button.UseVisualStyleBackColor = true;
            this.Upgrade_button.Click += new System.EventHandler(this.Upgrade_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(16, 105);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(147, 48);
            this.Delete_button.TabIndex = 33;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(16, 30);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(147, 48);
            this.Add_button.TabIndex = 32;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Upload_button_Upgrade
            // 
            this.Upload_button_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_button_Upgrade.Location = new System.Drawing.Point(587, 77);
            this.Upload_button_Upgrade.Name = "Upload_button_Upgrade";
            this.Upload_button_Upgrade.Size = new System.Drawing.Size(131, 30);
            this.Upload_button_Upgrade.TabIndex = 31;
            this.Upload_button_Upgrade.Text = "Upload picture";
            this.Upload_button_Upgrade.UseVisualStyleBackColor = true;
            this.Upload_button_Upgrade.Click += new System.EventHandler(this.Upload_button_Upgrade_Click);
            // 
            // Data_label_Upgrade
            // 
            this.Data_label_Upgrade.AutoSize = true;
            this.Data_label_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_label_Upgrade.Location = new System.Drawing.Point(212, 78);
            this.Data_label_Upgrade.Name = "Data_label_Upgrade";
            this.Data_label_Upgrade.Size = new System.Drawing.Size(162, 29);
            this.Data_label_Upgrade.TabIndex = 26;
            this.Data_label_Upgrade.Text = "Data Expirarii:";
            // 
            // Bucati_label_Upgrade
            // 
            this.Bucati_label_Upgrade.AutoSize = true;
            this.Bucati_label_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bucati_label_Upgrade.Location = new System.Drawing.Point(487, 31);
            this.Bucati_label_Upgrade.Name = "Bucati_label_Upgrade";
            this.Bucati_label_Upgrade.Size = new System.Drawing.Size(85, 29);
            this.Bucati_label_Upgrade.TabIndex = 24;
            this.Bucati_label_Upgrade.Text = "Bucati:";
            // 
            // Nume_label_Upgrade
            // 
            this.Nume_label_Upgrade.AutoSize = true;
            this.Nume_label_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_label_Upgrade.Location = new System.Drawing.Point(212, 31);
            this.Nume_label_Upgrade.Name = "Nume_label_Upgrade";
            this.Nume_label_Upgrade.Size = new System.Drawing.Size(84, 29);
            this.Nume_label_Upgrade.TabIndex = 23;
            this.Nume_label_Upgrade.Text = "Nume:";
            // 
            // Bucati_textbox_Upgrade
            // 
            this.Bucati_textbox_Upgrade.Location = new System.Drawing.Point(587, 37);
            this.Bucati_textbox_Upgrade.Name = "Bucati_textbox_Upgrade";
            this.Bucati_textbox_Upgrade.Size = new System.Drawing.Size(56, 22);
            this.Bucati_textbox_Upgrade.TabIndex = 21;
            // 
            // Nume_textBox_Upgrade
            // 
            this.Nume_textBox_Upgrade.Location = new System.Drawing.Point(302, 37);
            this.Nume_textBox_Upgrade.Name = "Nume_textBox_Upgrade";
            this.Nume_textBox_Upgrade.Size = new System.Drawing.Size(167, 22);
            this.Nume_textBox_Upgrade.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 771);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.medicament_Group);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.medicament_Group.ResumeLayout(false);
            this.medicament_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox medicament_Group;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Data_label;
        private System.Windows.Forms.Label Bucati_label;
        private System.Windows.Forms.Label Nume_label;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.TextBox Bucati_textBox;
        private System.Windows.Forms.TextBox Nume_textBox;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Upgrade_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Upload_button_Upgrade;
        private System.Windows.Forms.Label Data_label_Upgrade;
        private System.Windows.Forms.Label Bucati_label_Upgrade;
        private System.Windows.Forms.Label Nume_label_Upgrade;
        private System.Windows.Forms.TextBox Bucati_textbox_Upgrade;
        private System.Windows.Forms.TextBox Nume_textBox_Upgrade;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.PictureBox pictureBox_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker Upgrade_dateTimePicker;
        private System.Windows.Forms.Label Tip_label_Upgrade;
        private System.Windows.Forms.ComboBox comboBox_Upgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox Filtru_textBox;
        private System.Windows.Forms.Label Filtru_label;
    }
}

