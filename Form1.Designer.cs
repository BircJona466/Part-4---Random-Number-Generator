
namespace Part_4___Random_Number_Generator
{
    partial class RandomNumberGenerator
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
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.btnInteger = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numMaximum = new System.Windows.Forms.NumericUpDown();
            this.numMinimum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinimum.Location = new System.Drawing.Point(9, 21);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(223, 20);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "Please enter a minimum number";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaximum.Location = new System.Drawing.Point(9, 74);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(226, 20);
            this.lblMaximum.TabIndex = 3;
            this.lblMaximum.Text = "Please enter a maximum number";
            this.lblMaximum.Click += new System.EventHandler(this.lblMaximum_Click);
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(12, 127);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(130, 32);
            this.btnInteger.TabIndex = 4;
            this.btnInteger.Text = "Get Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(148, 127);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(131, 32);
            this.btnDouble.TabIndex = 5;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 196);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label1";
            // 
            // numMaximum
            // 
            this.numMaximum.Location = new System.Drawing.Point(246, 76);
            this.numMaximum.Name = "numMaximum";
            this.numMaximum.Size = new System.Drawing.Size(40, 23);
            this.numMaximum.TabIndex = 7;
            // 
            // numMinimum
            // 
            this.numMinimum.Location = new System.Drawing.Point(246, 23);
            this.numMinimum.Name = "numMinimum";
            this.numMinimum.Size = new System.Drawing.Size(40, 23);
            this.numMinimum.TabIndex = 8;
            // 
            // RandomNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 242);
            this.Controls.Add(this.numMinimum);
            this.Controls.Add(this.numMaximum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInteger);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Name = "RandomNumberGenerator";
            this.Text = "RNG";
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numMaximum;
        private System.Windows.Forms.NumericUpDown numMinimum;
    }
}

