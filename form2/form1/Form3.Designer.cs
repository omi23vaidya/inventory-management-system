namespace form1
{
    partial class store2
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
            this.food = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // food
            // 
            this.food.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food.Location = new System.Drawing.Point(64, 90);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(153, 63);
            this.food.TabIndex = 1;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = true;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // store2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.food);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "store2";
            this.Text = "store2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button food;
    }
}