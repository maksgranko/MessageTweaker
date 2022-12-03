
namespace MessageTweaker
{
    partial class OrderList
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
            this.Datatable_0 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Refresh_btn = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Datatable_0)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datatable_0
            // 
            this.Datatable_0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.Datatable_0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Datatable_0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datatable_0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Number,
            this.Status,
            this.Date,
            this.PayState,
            this.Cost,
            this.Address,
            this.Product,
            this.comment,
            this.Total_Price});
            this.Datatable_0.Location = new System.Drawing.Point(-30, -5);
            this.Datatable_0.Name = "Datatable_0";
            this.Datatable_0.RowTemplate.Height = 25;
            this.Datatable_0.Size = new System.Drawing.Size(1165, 511);
            this.Datatable_0.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.Width = 115;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата оформления";
            this.Date.Name = "Date";
            this.Date.Width = 110;
            // 
            // PayState
            // 
            this.PayState.HeaderText = "Статус оплаты";
            this.PayState.Name = "PayState";
            this.PayState.Width = 90;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена заказа";
            this.Cost.Name = "Cost";
            this.Cost.Width = 75;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес доставки";
            this.Address.Name = "Address";
            this.Address.Width = 200;
            // 
            // Product
            // 
            this.Product.HeaderText = "Товар";
            this.Product.Name = "Product";
            this.Product.Width = 50;
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.Width = 250;
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Итого";
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refresh_btn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Image = global::MessageTweaker.Properties.Resources.refreshx16;
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Refresh_btn.Size = new System.Drawing.Size(77, 17);
            this.Refresh_btn.Text = "Обновить";
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Datatable_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Order List";
            ((System.ComponentModel.ISupportInitialize)(this.Datatable_0)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datatable_0;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Refresh_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
    }
}