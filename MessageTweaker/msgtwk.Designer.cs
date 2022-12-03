
namespace MessageTweaker
{
    partial class msgtwk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgtwk));
            this.Settings = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.InfoPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Start = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.Image = global::MessageTweaker.Properties.Resources.settingsx16;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(12, 41);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(90, 23);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Настройки";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoPanel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InfoPanel
            // 
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(384, 17);
            this.InfoPanel.Spring = true;
            this.InfoPanel.Text = "Пусто.";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Запустить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // OrderList
            // 
            this.OrderList.Location = new System.Drawing.Point(108, 12);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(90, 23);
            this.OrderList.TabIndex = 3;
            this.OrderList.Text = "Заказы";
            this.OrderList.UseVisualStyleBackColor = true;
            this.OrderList.Click += new System.EventHandler(this.OrderList_Click);
            // 
            // msgtwk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 182);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "msgtwk";
            this.Text = "Market Tweaker";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel InfoPanel;
        private System.Windows.Forms.Button OrderList;
        internal System.Windows.Forms.Button Start;
    }
}

