namespace DragonPhoenixToy
{
    partial class CheckOutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.ReadyToPayButton = new System.Windows.Forms.Button();
            this.PrintReceiptButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ReceiptListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(124, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(740, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to Order";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Units Sold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id:";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(124, 335);
            this.AddToOrderButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(150, 87);
            this.AddToOrderButton.TabIndex = 1;
            this.AddToOrderButton.Text = "&Add To Order";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // ReadyToPayButton
            // 
            this.ReadyToPayButton.Location = new System.Drawing.Point(330, 335);
            this.ReadyToPayButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ReadyToPayButton.Name = "ReadyToPayButton";
            this.ReadyToPayButton.Size = new System.Drawing.Size(150, 87);
            this.ReadyToPayButton.TabIndex = 2;
            this.ReadyToPayButton.Text = "&Ready To Pay";
            this.ReadyToPayButton.UseVisualStyleBackColor = true;
            this.ReadyToPayButton.Click += new System.EventHandler(this.ReadyToPayButton_Click);
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.Location = new System.Drawing.Point(554, 335);
            this.PrintReceiptButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Size = new System.Drawing.Size(150, 87);
            this.PrintReceiptButton.TabIndex = 3;
            this.PrintReceiptButton.Text = "&Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = true;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(758, 335);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 87);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReceiptListBox
            // 
            this.ReceiptListBox.FormattingEnabled = true;
            this.ReceiptListBox.ItemHeight = 25;
            this.ReceiptListBox.Location = new System.Drawing.Point(124, 458);
            this.ReceiptListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ReceiptListBox.Name = "ReceiptListBox";
            this.ReceiptListBox.Size = new System.Drawing.Size(780, 179);
            this.ReceiptListBox.TabIndex = 5;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 663);
            this.Controls.Add(this.ReceiptListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PrintReceiptButton);
            this.Controls.Add(this.ReadyToPayButton);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button ReadyToPayButton;
        private System.Windows.Forms.Button PrintReceiptButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox ReceiptListBox;
    }
}