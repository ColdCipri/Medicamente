namespace Medicamente
{
    partial class Medicamente_Expirate
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
            this.exit_button = new System.Windows.Forms.Button();
            this.Pick_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.text_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.exit_button.Location = new System.Drawing.Point(338, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(27, 23);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Pick_monthCalendar
            // 
            this.Pick_monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Pick_monthCalendar.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pick_monthCalendar.Location = new System.Drawing.Point(17, 107);
            this.Pick_monthCalendar.MaxSelectionCount = 1;
            this.Pick_monthCalendar.Name = "Pick_monthCalendar";
            this.Pick_monthCalendar.TabIndex = 3;
            this.Pick_monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Pick_monthCalendar_DateChanged);
            // 
            // text_label
            // 
            this.text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_label.Location = new System.Drawing.Point(12, 9);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(320, 89);
            this.text_label.TabIndex = 4;
            this.text_label.Text = "Va rugam selectati data in jurul careia va intereseaza daca un medicament expira." +
    " ";
            // 
            // Medicamente_Expirate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(365, 323);
            this.ControlBox = false;
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.Pick_monthCalendar);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Medicamente_Expirate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamente_Expirate";
            this.Load += new System.EventHandler(this.Medicamente_Expirate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Medicamente_Expirate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Medicamente_Expirate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Medicamente_Expirate_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.MonthCalendar Pick_monthCalendar;
        private System.Windows.Forms.Label text_label;
    }
}