namespace BankAccount
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(383, 558);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(505, 53);
            this.txtInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.EnabledChanged += new System.EventHandler(this.btnWithdraw_Click);
            this.button1.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(505, 89);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.EnabledChanged += new System.EventHandler(this.btnDeposit);
            this.button2.Click += new System.EventHandler(this.btnDeposit);
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccBalance.Location = new System.Drawing.Point(383, 653);
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.Size = new System.Drawing.Size(505, 53);
            this.txtAccBalance.TabIndex = 3;
            this.txtAccBalance.VisibleChanged += new System.EventHandler(this.btnBalance_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(505, 89);
            this.button3.TabIndex = 4;
            this.button3.Text = "Balance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.SystemColors.Control;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(13, 558);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(303, 53);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Input Amount";
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(13, 653);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(303, 53);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Account Balance";
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 758);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 55);
            this.lblError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(949, 867);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtAccBalance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Simba World Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblError;
    }
}

