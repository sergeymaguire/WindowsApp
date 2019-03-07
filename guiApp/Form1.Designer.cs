namespace guiApp
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
            this.txtPatronAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.lblDoesUserGetDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatronAge
            // 
            this.txtPatronAge.Location = new System.Drawing.Point(172, 54);
            this.txtPatronAge.Name = "txtPatronAge";
            this.txtPatronAge.Size = new System.Drawing.Size(99, 20);
            this.txtPatronAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Patron Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Movie Rating";
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(172, 112);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(99, 20);
            this.txtMovieRating.TabIndex = 3;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(172, 175);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "discount?";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // lblDoesUserGetDiscount
            // 
            this.lblDoesUserGetDiscount.AutoSize = true;
            this.lblDoesUserGetDiscount.Location = new System.Drawing.Point(172, 264);
            this.lblDoesUserGetDiscount.Name = "lblDoesUserGetDiscount";
            this.lblDoesUserGetDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDoesUserGetDiscount.Size = new System.Drawing.Size(111, 13);
            this.lblDoesUserGetDiscount.TabIndex = 5;
            this.lblDoesUserGetDiscount.Text = "doesUserGetDiscount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDoesUserGetDiscount);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txtMovieRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatronAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatronAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lblDoesUserGetDiscount;
    }
}

