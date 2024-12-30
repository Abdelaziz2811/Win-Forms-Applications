namespace PizzaApp
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.BTNOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNOrder
            // 
            this.BTNOrder.BackColor = System.Drawing.Color.Tomato;
            this.BTNOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNOrder.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.BTNOrder.FlatAppearance.BorderSize = 2;
            this.BTNOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.BTNOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.BTNOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNOrder.Location = new System.Drawing.Point(145, 438);
            this.BTNOrder.Name = "BTNOrder";
            this.BTNOrder.Size = new System.Drawing.Size(205, 46);
            this.BTNOrder.TabIndex = 0;
            this.BTNOrder.Text = "Order Now";
            this.BTNOrder.UseVisualStyleBackColor = false;
            this.BTNOrder.Click += new System.EventHandler(this.BTNOrder_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 617);
            this.Controls.Add(this.BTNOrder);
            this.DoubleBuffered = true;
            this.Name = "OrderScreen";
            this.Text = "Order Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNOrder;
    }
}

