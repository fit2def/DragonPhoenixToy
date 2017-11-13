namespace DragonPhoenixToy
{
    partial class ProductEntryForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productOnHandInput = new System.Windows.Forms.TextBox();
            this.productPriceInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.productIdInput = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(83, 181);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(154, 25);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(429, 175);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(234, 31);
            this.productNameInput.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(88, 548);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(214, 94);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(101, 96);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(118, 25);
            this.ProductID.TabIndex = 3;
            this.ProductID.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product On Hand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Price:";
            // 
            // productOnHandInput
            // 
            this.productOnHandInput.Location = new System.Drawing.Point(429, 425);
            this.productOnHandInput.Name = "productOnHandInput";
            this.productOnHandInput.Size = new System.Drawing.Size(234, 31);
            this.productOnHandInput.TabIndex = 7;
            // 
            // productPriceInput
            // 
            this.productPriceInput.Location = new System.Drawing.Point(429, 341);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.Size = new System.Drawing.Size(234, 31);
            this.productPriceInput.TabIndex = 8;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(429, 265);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(234, 31);
            this.descriptionInput.TabIndex = 9;
            // 
            // productIdInput
            // 
            this.productIdInput.Location = new System.Drawing.Point(429, 96);
            this.productIdInput.Name = "productIdInput";
            this.productIdInput.Size = new System.Drawing.Size(234, 31);
            this.productIdInput.TabIndex = 10;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(337, 548);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(203, 94);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clea&r";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(581, 548);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(197, 94);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ProductEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 676);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.productIdInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.productPriceInput);
            this.Controls.Add(this.productOnHandInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.productNameInput);
            this.Controls.Add(this.productNameLabel);
            this.Name = "ProductEntryForm";
            this.Text = "Product Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameInput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productOnHandInput;
        private System.Windows.Forms.TextBox productPriceInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox productIdInput;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

