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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.medicament_Group = new System.Windows.Forms.GroupBox();
            this.MedicamenteExpirate_checkBox = new System.Windows.Forms.CheckBox();
            this.FiltruExpirat_label = new System.Windows.Forms.Label();
            this.Restart_button = new System.Windows.Forms.Button();
            this.ID_text_label = new System.Windows.Forms.Label();
            this.SortareAlfabetica_CheckBox = new System.Windows.Forms.CheckBox();
            this.SortareAlfabetica_label = new System.Windows.Forms.Label();
            this.Id_label = new System.Windows.Forms.Label();
            this.Filtru_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Upload_button_Upgrade = new System.Windows.Forms.Button();
            this.Filtru_textBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
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
            this.exit_button = new System.Windows.Forms.Button();
            this.EasterEgg_button = new System.Windows.Forms.Button();
            this.medicament_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // medicament_Group
            // 
            this.medicament_Group.Controls.Add(this.MedicamenteExpirate_checkBox);
            this.medicament_Group.Controls.Add(this.FiltruExpirat_label);
            this.medicament_Group.Controls.Add(this.Restart_button);
            this.medicament_Group.Controls.Add(this.ID_text_label);
            this.medicament_Group.Controls.Add(this.SortareAlfabetica_CheckBox);
            this.medicament_Group.Controls.Add(this.SortareAlfabetica_label);
            this.medicament_Group.Controls.Add(this.Id_label);
            this.medicament_Group.Controls.Add(this.Filtru_label);
            this.medicament_Group.Controls.Add(this.Delete_button);
            this.medicament_Group.Controls.Add(this.Upload_button_Upgrade);
            this.medicament_Group.Controls.Add(this.Filtru_textBox);
            this.medicament_Group.Controls.Add(this.Update_button);
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
            this.medicament_Group.Location = new System.Drawing.Point(12, 32);
            this.medicament_Group.Name = "medicament_Group";
            this.medicament_Group.Size = new System.Drawing.Size(885, 581);
            this.medicament_Group.TabIndex = 0;
            this.medicament_Group.TabStop = false;
            this.medicament_Group.Text = "Medicament";
            // 
            // MedicamenteExpirate_checkBox
            // 
            this.MedicamenteExpirate_checkBox.AutoSize = true;
            this.MedicamenteExpirate_checkBox.Location = new System.Drawing.Point(278, 516);
            this.MedicamenteExpirate_checkBox.Name = "MedicamenteExpirate_checkBox";
            this.MedicamenteExpirate_checkBox.Size = new System.Drawing.Size(18, 17);
            this.MedicamenteExpirate_checkBox.TabIndex = 52;
            this.MedicamenteExpirate_checkBox.UseVisualStyleBackColor = true;
            this.MedicamenteExpirate_checkBox.CheckedChanged += new System.EventHandler(this.MedicamenteExpirate_checkBox_CheckedChanged);
            // 
            // FiltruExpirat_label
            // 
            this.FiltruExpirat_label.AutoSize = true;
            this.FiltruExpirat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltruExpirat_label.Location = new System.Drawing.Point(11, 505);
            this.FiltruExpirat_label.Name = "FiltruExpirat_label";
            this.FiltruExpirat_label.Size = new System.Drawing.Size(251, 29);
            this.FiltruExpirat_label.TabIndex = 51;
            this.FiltruExpirat_label.Text = "Medicamente expirate";
            // 
            // Restart_button
            // 
            this.Restart_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Restart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Restart_button.FlatAppearance.BorderSize = 0;
            this.Restart_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart_button.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart_button.Location = new System.Drawing.Point(767, 532);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(112, 43);
            this.Restart_button.TabIndex = 35;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = false;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // ID_text_label
            // 
            this.ID_text_label.AutoSize = true;
            this.ID_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_text_label.Location = new System.Drawing.Point(302, 21);
            this.ID_text_label.Name = "ID_text_label";
            this.ID_text_label.Size = new System.Drawing.Size(39, 29);
            this.ID_text_label.TabIndex = 50;
            this.ID_text_label.Text = "Id:";
            // 
            // SortareAlfabetica_CheckBox
            // 
            this.SortareAlfabetica_CheckBox.AutoSize = true;
            this.SortareAlfabetica_CheckBox.Location = new System.Drawing.Point(227, 467);
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
            this.SortareAlfabetica_label.Location = new System.Drawing.Point(11, 456);
            this.SortareAlfabetica_label.Name = "SortareAlfabetica_label";
            this.SortareAlfabetica_label.Size = new System.Drawing.Size(201, 29);
            this.SortareAlfabetica_label.TabIndex = 48;
            this.SortareAlfabetica_label.Text = "Sortare alfabetica";
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_label.Location = new System.Drawing.Point(337, 21);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(0, 29);
            this.Id_label.TabIndex = 12;
            // 
            // Filtru_label
            // 
            this.Filtru_label.AutoSize = true;
            this.Filtru_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtru_label.Location = new System.Drawing.Point(11, 408);
            this.Filtru_label.Name = "Filtru_label";
            this.Filtru_label.Size = new System.Drawing.Size(81, 29);
            this.Filtru_label.TabIndex = 47;
            this.Filtru_label.Text = "Cauta:";
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Gold;
            this.Delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(311, 341);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(115, 51);
            this.Delete_button.TabIndex = 33;
            this.Delete_button.Text = "Sterge";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Upload_button_Upgrade
            // 
            this.Upload_button_Upgrade.BackColor = System.Drawing.Color.Gold;
            this.Upload_button_Upgrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Upload_button_Upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload_button_Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_button_Upgrade.Location = new System.Drawing.Point(311, 129);
            this.Upload_button_Upgrade.Name = "Upload_button_Upgrade";
            this.Upload_button_Upgrade.Size = new System.Drawing.Size(115, 48);
            this.Upload_button_Upgrade.TabIndex = 31;
            this.Upload_button_Upgrade.Text = "Incarca poza";
            this.Upload_button_Upgrade.UseVisualStyleBackColor = false;
            this.Upload_button_Upgrade.Click += new System.EventHandler(this.Upload_button_Upgrade_Click);
            // 
            // Filtru_textBox
            // 
            this.Filtru_textBox.Location = new System.Drawing.Point(98, 415);
            this.Filtru_textBox.Name = "Filtru_textBox";
            this.Filtru_textBox.Size = new System.Drawing.Size(147, 22);
            this.Filtru_textBox.TabIndex = 46;
            this.Filtru_textBox.TextChanged += new System.EventHandler(this.Filtru_textBox_TextChanged);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.Gold;
            this.Update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(311, 259);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(115, 51);
            this.Update_button.TabIndex = 34;
            this.Update_button.Text = "Adauga";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Upgrade_button_Click);
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
            this.Tip_comboBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tip_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tip_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tip_comboBox.ForeColor = System.Drawing.Color.Black;
            this.Tip_comboBox.FormattingEnabled = true;
            this.Tip_comboBox.Items.AddRange(new object[] {
            "Pastila",
            "Crema",
            "Ceai",
            "Spray",
            "Sirop",
            "Supozitor",
            "Picaturi",
            "Gel",
            "Efervescent",
            "Null"});
            this.Tip_comboBox.Location = new System.Drawing.Point(757, 84);
            this.Tip_comboBox.Name = "Tip_comboBox";
            this.Tip_comboBox.Size = new System.Drawing.Size(105, 24);
            this.Tip_comboBox.TabIndex = 44;
            // 
            // DataExpirarii_Picker
            // 
            this.DataExpirarii_Picker.Location = new System.Drawing.Point(490, 84);
            this.DataExpirarii_Picker.Name = "DataExpirarii_Picker";
            this.DataExpirarii_Picker.Size = new System.Drawing.Size(163, 22);
            this.DataExpirarii_Picker.TabIndex = 22;
            // 
            // Imagine_pictureBox
            // 
            this.Imagine_pictureBox.Location = new System.Drawing.Point(490, 145);
            this.Imagine_pictureBox.Name = "Imagine_pictureBox";
            this.Imagine_pictureBox.Size = new System.Drawing.Size(372, 247);
            this.Imagine_pictureBox.TabIndex = 19;
            this.Imagine_pictureBox.TabStop = false;
            // 
            // DataExpirarii_label
            // 
            this.DataExpirarii_label.AutoSize = true;
            this.DataExpirarii_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataExpirarii_label.Location = new System.Drawing.Point(306, 79);
            this.DataExpirarii_label.Name = "DataExpirarii_label";
            this.DataExpirarii_label.Size = new System.Drawing.Size(162, 29);
            this.DataExpirarii_label.TabIndex = 16;
            this.DataExpirarii_label.Text = "Data Expirarii:";
            // 
            // Bucati_label
            // 
            this.Bucati_label.AutoSize = true;
            this.Bucati_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bucati_label.Location = new System.Drawing.Point(693, 21);
            this.Bucati_label.Name = "Bucati_label";
            this.Bucati_label.Size = new System.Drawing.Size(85, 29);
            this.Bucati_label.TabIndex = 14;
            this.Bucati_label.Text = "Bucati:";
            // 
            // Nume_label
            // 
            this.Nume_label.AutoSize = true;
            this.Nume_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_label.Location = new System.Drawing.Point(384, 21);
            this.Nume_label.Name = "Nume_label";
            this.Nume_label.Size = new System.Drawing.Size(84, 29);
            this.Nume_label.TabIndex = 13;
            this.Nume_label.Text = "Nume:";
            // 
            // Bucati_textBox
            // 
            this.Bucati_textBox.Location = new System.Drawing.Point(800, 28);
            this.Bucati_textBox.Name = "Bucati_textBox";
            this.Bucati_textBox.Size = new System.Drawing.Size(36, 22);
            this.Bucati_textBox.TabIndex = 11;
            this.Bucati_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bucati_textBox_KeyPress);
            // 
            // Nume_textBox
            // 
            this.Nume_textBox.Location = new System.Drawing.Point(490, 28);
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
            this.listBoxMedicamente.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicamente_SelectedIndexChanged);
            this.listBoxMedicamente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMedicamente_MouseDown);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(872, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(27, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // EasterEgg_button
            // 
            this.EasterEgg_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EasterEgg_button.Cursor = System.Windows.Forms.Cursors.No;
            this.EasterEgg_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.EasterEgg_button.FlatAppearance.BorderSize = 0;
            this.EasterEgg_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EasterEgg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasterEgg_button.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasterEgg_button.Location = new System.Drawing.Point(12, 3);
            this.EasterEgg_button.Name = "EasterEgg_button";
            this.EasterEgg_button.Size = new System.Drawing.Size(92, 23);
            this.EasterEgg_button.TabIndex = 36;
            this.EasterEgg_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 625);
            this.ControlBox = false;
            this.Controls.Add(this.EasterEgg_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.medicament_Group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ListBox listBoxMedicamente;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Upload_button_Upgrade;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.DateTimePicker DataExpirarii_Picker;
        private System.Windows.Forms.Label Tip_label;
        private System.Windows.Forms.ComboBox Tip_comboBox;
        private System.Windows.Forms.TextBox Filtru_textBox;
        private System.Windows.Forms.Label Filtru_label;
        private System.Windows.Forms.CheckBox SortareAlfabetica_CheckBox;
        private System.Windows.Forms.Label SortareAlfabetica_label;
        private System.Windows.Forms.Label ID_text_label;
        private System.Windows.Forms.Label FiltruExpirat_label;
        private System.Windows.Forms.CheckBox MedicamenteExpirate_checkBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button EasterEgg_button;
    }
}

