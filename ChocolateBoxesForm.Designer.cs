namespace ChocolateBarToluA
{
    partial class frmChocolateBar
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
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.lblStatement = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(370, 77);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumber.TabIndex = 0;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(12, 77);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(352, 20);
            this.lblStatement.TabIndex = 1;
            this.lblStatement.Text = "Enter The Number Of Boxes You Sold";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(370, 126);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.Location = new System.Drawing.Point(12, 129);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(0, 20);
            this.lblPrizes.TabIndex = 3;
            // 
            // frmChocolateBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 229);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.txtBoxNumber);
            this.Name = "frmChocolateBar";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPrizes;
    }
}

