namespace Medicamente
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
            this.SortareAlfabetica_CheckBox = new System.Windows.Forms.CheckBox();
            this.SortareAlfabetica_label = new System.Windows.Forms.Label();
            this.Id_label = new System.Windows.Forms.Label();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Filtru_label = new System.Windows.Forms.Label();
            this.Filtru_textBox = new System.Windows.Forms.TextBox();
            this.Tip_label = new System.Windows.Forms.Label();
            this.Tip_comboBox = new System.Windows.Forms.ComboBox();
            this.DataExpirarii_Picker = new System.Windows.Forms.DateTimePicker();
            this.Imagine_pictureBox = new System.Windows.Forms.PictureBox();
            this.DataExpirarii_label = new System.Windows.Forms.Label();
            this.Bucati_label = new System.Windows.Forms.Label();
            this.Nume_label = new System.Windows.Forms.Label();
            this.Bucati_textBox = new System.Windows.Forms.TextBox();
            this.Nume_textBox = new System.Windows.Forms.TextBox();
            this.listBoxMedicamente = new System.Windows.Forms.ListBox();
            this.Upgrade_group = new System.Windows.Forms.GroupBox();
            this.Tip_Upgrade_label = new System.Windows.Forms.Label();
            this.Tip_Upgrade_comboBox = new System.Windows.Forms.ComboBox();
            this.DataExpirarii_Upgrade_Picker = new System.Windows.Forms.DateTimePicker();
            this.Imagine_Upgrade_pictureBox = new System.Windows.Forms.PictureBox();
            this.Restart_button = new System.Windows.Forms.Button();
            this.Upgrade_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Upload_button_Upgrade = new System.Windows.Forms.Button();
            this.DataExpirarii_Upgrade_label = new System.Windows.Forms.Label();
            this.Bucati_Upgrade_label = new System.Windows.Forms.Label();
            this.Nume_Upgrade_label = new System.Windows.Forms.Label();
            this.Bucati_Upgrade_textBox = new System.Windows.Forms.TextBox();
            this.Nume_Upgrade_textBox = new System.Windows.Forms.TextBox();
            this.medicament_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine_pictureBox)).BeginInit();
            this.Upgrade_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine_Upgrade_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // medicament_Group
            // 
            this.medicament_Group.Controls.Add(this.SortareAlfabetica_CheckBox);
            this.medicament_Group.Controls.Add(this.SortareAlfabetica_label);
            this.medicament_Group.Controls.Add(this.Id_label);
            this.medicament_Group.Controls.Add(this.Id_textBox);
            this.medicament_Group.Controls.Add(this.Filtru_label);
            this.medicament_Group.Controls.Add(this.Filtru_textBox);
            this.medicament_Group.Controls.Add(this.Tip_label);
            this.medicament_Group.Controls.Add(this.Tip_comboBox);
            this.medicament_Group.Controls.Add(this.DataExpirarii_Picker);
            this.medicament_Group.Controls.Add(this.Imagine_pictureBox);
            this.medicament_Group.Controls.Add(this.DataExpirarii_label);
            this.medicament_Group.Controls.Add(this.Bucati_label);
            this.medicament_Group.Controls.Add(this.Nume_label);
            this.medicament_Group.Controls.Add(this.Bucati_textBox);
            this.medicament_Group.Controls.Add(this.Nume_textBox);
            this.medicament_Group.Controls.Add(this.listBoxMedicamente);
            this.medicament_Group.Location = new System.Drawing.Point(22, 20);
            this.medicament_Group.Name = "medicament_Group";
            this.medicament_Group.Size = new System.Drawing.Size(942, 402);
            this.medicament_Group.TabIndex = 0;
            this.medicament_Group.TabStop = false;
            this.medicament_Group.Text = "Medicament";
            // 
            // SortareAlfabetica_CheckBox
            // 
            this.SortareAlfabetica_CheckBox.AutoSize = true;
            this.SortareAlfabetica_CheckBox.Location = new System.Drawing.Point(510, 195);
            this.SortareAlfabetica_CheckBox.Name = "SortareAlfabetica_CheckBox";
            this.SortareAlfabetica_CheckBox.Size = new System.Drawing.Size(18, 17);
            this.SortareAlfabetica_CheckBox.TabIndex = 49;
            this.SortareAlfabetica_CheckBox.UseVisualStyleBackColor = true;
            this.SortareAlfabetica_CheckBox.CheckedChanged += new System.EventHandler(this.SortareAlfabetica_CheckBox_CheckedChanged);
            // 
            // SortareAlfabetica_label
            // 
            this.SortareAlfabetica_label.AutoSize = true;
            this.SortareAlfabetica_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortareAlfabetica_label.Location = new System.Drawing.Point(302, 188);
            this.SortareAlfabetica_label.Name = "SortareAlfabetica_label";
            this.SortareAlfabetica_label.Size = new System.Drawing.Size(201, 29);
            this.SortareAlfabetica_label.TabIndex = 48;
            this.SortareAlfabetica_label.Text = "Sortare alfabetica";
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
            this.Filtru_label.Location = new System.Drawing.Point(302, 140);
            this.Filtru_label.Name = "Filtru_label";
            this.Filtru_label.Size = new System.Drawing.Size(81, 29);
            this.Filtru_label.TabIndex = 47;
            this.Filtru_label.Text = "Cauta:";
            // 
            // Filtru_textBox
            // 
            this.Filtru_textBox.Location = new System.Drawing.Point(389, 147);
            this.Filtru_textBox.Name = "Filtru_textBox";
            this.Filtru_textBox.Size = new System.Drawing.Size(147, 22);
            this.Filtru_textBox.TabIndex = 46;
            this.Filtru_textBox.TextChanged += new System.EventHandler(this.Filtru_textBox_TextChanged);
            // 
            // Tip_label
            // 
            this.Tip_label.AutoSize = true;
            this.Tip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_label.Location = new System.Drawing.Point(693, 79);
            this.Tip_label.Name = "Tip_label";
            this.Tip_label.Size = new System.Drawing.Size(55, 29);
            this.Tip_label.TabIndex = 45;
            this.Tip_label.Text = "Tip:";
            // 
            // Tip_comboBox
            // 
            this.Tip_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_comboBox.FormattingEnabled = true;
            this.Tip_comboBox.Items.AddRange(new object[] {
            "Pastila",
            "Crema",
            "Ceai",
            "Spray"});
            this.Tip_comboBox.Location = new System.Drawing.Point(757, 84);
            this.Tip_comboBox.Name = "Tip_comboBox";
            this.Tip_comboBox.Size = new System.Drawing.Size(105, 24);
            this.Tip_comboBox.TabIndex = 44;
            // 
            // DataExpirarii_Picker
            // 
            this.DataExpirarii_Picker.Location = new System.Drawing.Point(507, 84);
            this.DataExpirarii_Picker.Name = "DataExpirarii_Picker";
            this.DataExpirarii_Picker.Size = new System.Drawing.Size(163, 22);
            this.DataExpirarii_Picker.TabIndex = 22;
            // 
            // Imagine_image
            // 
            this.Imagine_pictureBox.Location = new System.Drawing.Point(587, 130);
            this.Imagine_pictureBox.Name = "Imagine_image";
            this.Imagine_pictureBox.Size = new System.Drawing.Size(344, 214);
            this.Imagine_pictureBox.TabIndex = 19;
            this.Imagine_pictureBox.TabStop = false;
            // 
            // DataExpirarii_label
            // 
            this.DataExpirarii_label.AutoSize = true;
            this.DataExpirarii_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataExpirarii_label.Location = new System.Drawing.Point(322, 79);
            this.DataExpirarii_label.Name = "DataExpirarii_label";
            this.DataExpirarii_label.Size = new System.Drawing.Size(162, 29);
            this.DataExpirarii_label.TabIndex = 16;
            this.DataExpirarii_label.Text = "Data Expirarii:";
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
            this.Bucati_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bucati_textBox_KeyPress);
            // 
            // Nume_textBox
            // 
            this.Nume_textBox.Location = new System.Drawing.Point(536, 28);
            this.Nume_textBox.Name = "Nume_textBox";
            this.Nume_textBox.Size = new System.Drawing.Size(197, 22);
            this.Nume_textBox.TabIndex = 10;
            // 
            // listBoxMedicamente
            // 
            this.listBoxMedicamente.FormattingEnabled = true;
            this.listBoxMedicamente.ItemHeight = 16;
            this.listBoxMedicamente.Location = new System.Drawing.Point(16, 20);
            this.listBoxMedicamente.Name = "listBoxMedicamente";
            this.listBoxMedicamente.Size = new System.Drawing.Size(280, 372);
            this.listBoxMedicamente.TabIndex = 0;
            this.listBoxMedicamente.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxMedicamente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // Upgrade_group
            // 
            this.Upgrade_group.Controls.Add(this.Tip_Upgrade_label);
            this.Upgrade_group.Controls.Add(this.Tip_Upgrade_comboBox);
            this.Upgrade_group.Controls.Add(this.DataExpirarii_Upgrade_Picker);
            this.Upgrade_group.Controls.Add(this.Imagine_Upgrade_pictureBox);
            this.Upgrade_group.Controls.Add(this.Restart_button);
            this.Upgrade_group.Controls.Add(this.Upgrade_button);
            this.Upgrade_group.Controls.Add(this.Delete_button);
            this.Upgrade_group.Controls.Add(this.Add_button);
            this.Upgrade_group.Controls.Add(this.Upload_button_Upgrade);
            this.Upgrade_group.Controls.Add(this.DataExpirarii_Upgrade_label);
            this.Upgrade_group.Controls.Add(this.Bucati_Upgrade_label);
            this.Upgrade_group.Controls.Add(this.Nume_Upgrade_label);
            this.Upgrade_group.Controls.Add(this.Bucati_Upgrade_textBox);
            this.Upgrade_group.Controls.Add(this.Nume_Upgrade_textBox);
            this.Upgrade_group.Location = new System.Drawing.Point(22, 438);
            this.Upgrade_group.Name = "Upgrade_group";
            this.Upgrade_group.Size = new System.Drawing.Size(942, 327);
            this.Upgrade_group.TabIndex = 1;
            this.Upgrade_group.TabStop = false;
            this.Upgrade_group.Text = "Upgrade";
            // 
            // Tip_Upgrade_label
            // 
            this.Tip_Upgrade_label.AutoSize = true;
            this.Tip_Upgrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Upgrade_label.Location = new System.Drawing.Point(669, 30);
            this.Tip_Upgrade_label.Name = "Tip_Upgrade_label";
            this.Tip_Upgrade_label.Size = new System.Drawing.Size(55, 29);
            this.Tip_Upgrade_label.TabIndex = 43;
            this.Tip_Upgrade_label.Text = "Tip:";
            // 
            // Tip_Upgrade_comboBox
            // 
            this.Tip_Upgrade_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_Upgrade_comboBox.FormattingEnabled = true;
            this.Tip_Upgrade_comboBox.Items.AddRange(new object[] {
            "Pastila",
            "Crema",
            "Ceai",
            "Spray"});
            this.Tip_Upgrade_comboBox.Location = new System.Drawing.Point(739, 37);
            this.Tip_Upgrade_comboBox.Name = "Tip_Upgrade_comboBox";
            this.Tip_Upgrade_comboBox.Size = new System.Drawing.Size(157, 24);
            this.Tip_Upgrade_comboBox.TabIndex = 42;
            // 
            // DataExpirarii_Upgrade_Picker
            // 
            this.DataExpirarii_Upgrade_Picker.Location = new System.Drawing.Point(389, 85);
            this.DataExpirarii_Upgrade_Picker.Name = "DataExpirarii_Upgrade_Picker";
            this.DataExpirarii_Upgrade_Picker.Size = new System.Drawing.Size(167, 22);
            this.DataExpirarii_Upgrade_Picker.TabIndex = 37;
            // 
            // pictureBox_Add
            // 
            this.Imagine_Upgrade_pictureBox.Location = new System.Drawing.Point(426, 125);
            this.Imagine_Upgrade_pictureBox.Name = "pictureBox_Add";
            this.Imagine_Upgrade_pictureBox.Size = new System.Drawing.Size(229, 179);
            this.Imagine_Upgrade_pictureBox.TabIndex = 36;
            this.Imagine_Upgrade_pictureBox.TabStop = false;
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
            // DataExpirarii_Upgrade_label
            // 
            this.DataExpirarii_Upgrade_label.AutoSize = true;
            this.DataExpirarii_Upgrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataExpirarii_Upgrade_label.Location = new System.Drawing.Point(212, 78);
            this.DataExpirarii_Upgrade_label.Name = "DataExpirarii_Upgrade_label";
            this.DataExpirarii_Upgrade_label.Size = new System.Drawing.Size(162, 29);
            this.DataExpirarii_Upgrade_label.TabIndex = 26;
            this.DataExpirarii_Upgrade_label.Text = "Data Expirarii:";
            // 
            // Bucati_Upgrade_label
            // 
            this.Bucati_Upgrade_label.AutoSize = true;
            this.Bucati_Upgrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bucati_Upgrade_label.Location = new System.Drawing.Point(487, 31);
            this.Bucati_Upgrade_label.Name = "Bucati_Upgrade_label";
            this.Bucati_Upgrade_label.Size = new System.Drawing.Size(85, 29);
            this.Bucati_Upgrade_label.TabIndex = 24;
            this.Bucati_Upgrade_label.Text = "Bucati:";
            // 
            // Nume_Upgrade_label
            // 
            this.Nume_Upgrade_label.AutoSize = true;
            this.Nume_Upgrade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_Upgrade_label.Location = new System.Drawing.Point(212, 31);
            this.Nume_Upgrade_label.Name = "Nume_Upgrade_label";
            this.Nume_Upgrade_label.Size = new System.Drawing.Size(84, 29);
            this.Nume_Upgrade_label.TabIndex = 23;
            this.Nume_Upgrade_label.Text = "Nume:";
            // 
            // Bucati_Upgrade_textBox
            // 
            this.Bucati_Upgrade_textBox.Location = new System.Drawing.Point(587, 37);
            this.Bucati_Upgrade_textBox.Name = "Bucati_Upgrade_textBox";
            this.Bucati_Upgrade_textBox.Size = new System.Drawing.Size(56, 22);
            this.Bucati_Upgrade_textBox.TabIndex = 21;
            this.Bucati_Upgrade_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bucati_textbox_Upgrade_KeyPress);
            // 
            // Nume_Upgrade_textBox
            // 
            this.Nume_Upgrade_textBox.Location = new System.Drawing.Point(302, 37);
            this.Nume_Upgrade_textBox.Name = "Nume_Upgrade_textBox";
            this.Nume_Upgrade_textBox.Size = new System.Drawing.Size(167, 22);
            this.Nume_Upgrade_textBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 771);
            this.Controls.Add(this.Upgrade_group);
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
            ((System.ComponentModel.ISupportInitialize)(this.Imagine_pictureBox)).EndInit();
            this.Upgrade_group.ResumeLayout(false);
            this.Upgrade_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine_Upgrade_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox medicament_Group;
        private System.Windows.Forms.PictureBox Imagine_pictureBox;
        private System.Windows.Forms.Label DataExpirarii_label;
        private System.Windows.Forms.Label Bucati_label;
        private System.Windows.Forms.Label Nume_label;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.TextBox Bucati_textBox;
        private System.Windows.Forms.TextBox Nume_textBox;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.ListBox listBoxMedicamente;
        private System.Windows.Forms.GroupBox Upgrade_group;
        private System.Windows.Forms.Button Upgrade_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Upload_button_Upgrade;
        private System.Windows.Forms.Label DataExpirarii_Upgrade_label;
        private System.Windows.Forms.Label Bucati_Upgrade_label;
        private System.Windows.Forms.Label Nume_Upgrade_label;
        private System.Windows.Forms.TextBox Bucati_Upgrade_textBox;
        private System.Windows.Forms.TextBox Nume_Upgrade_textBox;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.PictureBox Imagine_Upgrade_pictureBox;
        private System.Windows.Forms.DateTimePicker DataExpirarii_Picker;
        private System.Windows.Forms.DateTimePicker DataExpirarii_Upgrade_Picker;
        private System.Windows.Forms.Label Tip_Upgrade_label;
        private System.Windows.Forms.ComboBox Tip_Upgrade_comboBox;
        private System.Windows.Forms.Label Tip_label;
        private System.Windows.Forms.ComboBox Tip_comboBox;
        private System.Windows.Forms.TextBox Filtru_textBox;
        private System.Windows.Forms.Label Filtru_label;
        private System.Windows.Forms.CheckBox SortareAlfabetica_CheckBox;
        private System.Windows.Forms.Label SortareAlfabetica_label;
    }
}

