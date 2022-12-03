
namespace MessageTweaker
{
    partial class Settings
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
            this.lb_0 = new System.Windows.Forms.Label();
            this.Timeout_TextBox = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.UTC_offset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_0
            // 
            this.lb_0.AutoSize = true;
            this.lb_0.Location = new System.Drawing.Point(13, 13);
            this.lb_0.Name = "lb_0";
            this.lb_0.Size = new System.Drawing.Size(115, 15);
            this.lb_0.TabIndex = 0;
            this.lb_0.Text = "Время обновления:";
            // 
            // Timeout_TextBox
            // 
            this.Timeout_TextBox.Location = new System.Drawing.Point(143, 9);
            this.Timeout_TextBox.MaxLength = 5;
            this.Timeout_TextBox.Name = "Timeout_TextBox";
            this.Timeout_TextBox.Size = new System.Drawing.Size(273, 23);
            this.Timeout_TextBox.TabIndex = 1;
            this.Timeout_TextBox.Text = "15";
            this.Timeout_TextBox.TextChanged += new System.EventHandler(this.Timeout_TextBox_TextChanged);
            // 
            // Save_btn
            // 
            this.Save_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save_btn.Location = new System.Drawing.Point(0, 143);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(428, 23);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Применить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // UTC_offset
            // 
            this.UTC_offset.Location = new System.Drawing.Point(143, 38);
            this.UTC_offset.MaxLength = 5;
            this.UTC_offset.Name = "UTC_offset";
            this.UTC_offset.Size = new System.Drawing.Size(273, 23);
            this.UTC_offset.TabIndex = 6;
            this.UTC_offset.Text = "3";
            this.UTC_offset.TextChanged += new System.EventHandler(this.UTC_offset_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оффсет времени:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 166);
            this.Controls.Add(this.UTC_offset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Timeout_TextBox);
            this.Controls.Add(this.lb_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_0;
        private System.Windows.Forms.TextBox Timeout_TextBox;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox UTC_offset;
        private System.Windows.Forms.Label label1;
    }
}