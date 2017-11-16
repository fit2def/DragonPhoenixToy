namespace DragonPhoenixToy
{
    partial class MainForm
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.UpdateInventoryButton = new System.Windows.Forms.Button();
            this.DisplayInventoryButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(79, 263);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(298, 207);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "&Add New Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // UpdateInventoryButton
            // 
            this.UpdateInventoryButton.Location = new System.Drawing.Point(530, 263);
            this.UpdateInventoryButton.Name = "UpdateInventoryButton";
            this.UpdateInventoryButton.Size = new System.Drawing.Size(298, 207);
            this.UpdateInventoryButton.TabIndex = 1;
            this.UpdateInventoryButton.Text = "&Update Inventory";
            this.UpdateInventoryButton.UseVisualStyleBackColor = true;
            this.UpdateInventoryButton.Click += new System.EventHandler(this.UpdateInventoryButton_Click);
            // 
            // DisplayInventoryButton
            // 
            this.DisplayInventoryButton.Location = new System.Drawing.Point(981, 263);
            this.DisplayInventoryButton.Name = "DisplayInventoryButton";
            this.DisplayInventoryButton.Size = new System.Drawing.Size(298, 207);
            this.DisplayInventoryButton.TabIndex = 2;
            this.DisplayInventoryButton.Text = "&Display All Products";
            this.DisplayInventoryButton.UseVisualStyleBackColor = true;
            this.DisplayInventoryButton.Click += new System.EventHandler(this.DisplayInventoryButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(1432, 263);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(298, 207);
            this.CheckOutButton.TabIndex = 3;
            this.CheckOutButton.Text = "&Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(346, 659);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(1139, 162);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1649, 97);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dragon Phoenix Toy Inventory System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1802, 1013);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.DisplayInventoryButton);
            this.Controls.Add(this.UpdateInventoryButton);
            this.Controls.Add(this.AddProductButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button UpdateInventoryButton;
        private System.Windows.Forms.Button DisplayInventoryButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}