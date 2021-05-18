namespace MyUsers
{
    partial class ShopForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addproduct = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(334, 3);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(61, 30);
            this.addproduct.TabIndex = 1;
            this.addproduct.Text = "+";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(401, 3);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(61, 30);
            this.Pay.TabIndex = 3;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // MakeOrder
            // 
            this.MakeOrder.Location = new System.Drawing.Point(468, 3);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(334, 67);
            this.MakeOrder.TabIndex = 4;
            this.MakeOrder.Text = "Check out";
            this.MakeOrder.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(-2, 3);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(330, 67);
            this.Cart.TabIndex = 5;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(334, 39);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(128, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.MakeOrder);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.Button Cart;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}