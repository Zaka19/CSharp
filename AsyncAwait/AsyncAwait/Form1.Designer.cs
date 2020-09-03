namespace AsyncAwait
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB2 = new System.Windows.Forms.ListBox();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.btnListBox2 = new System.Windows.Forms.Button();
            this.btnListBox1 = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbTimeLB1 = new System.Windows.Forms.TextBox();
            this.tbTimeLB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.ItemHeight = 16;
            this.LB2.Location = new System.Drawing.Point(412, 32);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(295, 196);
            this.LB2.TabIndex = 0;
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 16;
            this.LB1.Location = new System.Drawing.Point(93, 32);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(297, 196);
            this.LB1.TabIndex = 1;
            // 
            // btnListBox2
            // 
            this.btnListBox2.Location = new System.Drawing.Point(713, 32);
            this.btnListBox2.Name = "btnListBox2";
            this.btnListBox2.Size = new System.Drawing.Size(75, 23);
            this.btnListBox2.TabIndex = 2;
            this.btnListBox2.Text = "button1";
            this.btnListBox2.UseVisualStyleBackColor = true;
            this.btnListBox2.Click += new System.EventHandler(this.btnListBox2_Click);
            // 
            // btnListBox1
            // 
            this.btnListBox1.Location = new System.Drawing.Point(12, 32);
            this.btnListBox1.Name = "btnListBox1";
            this.btnListBox1.Size = new System.Drawing.Size(75, 23);
            this.btnListBox1.TabIndex = 3;
            this.btnListBox1.Text = "button2";
            this.btnListBox1.UseVisualStyleBackColor = true;
            this.btnListBox1.Click += new System.EventHandler(this.btnListBox1_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(110, 376);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "button3";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(216, 377);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(398, 22);
            this.tbTime.TabIndex = 5;
            // 
            // tbTimeLB1
            // 
            this.tbTimeLB1.Location = new System.Drawing.Point(93, 255);
            this.tbTimeLB1.Name = "tbTimeLB1";
            this.tbTimeLB1.Size = new System.Drawing.Size(297, 22);
            this.tbTimeLB1.TabIndex = 6;
            // 
            // tbTimeLB2
            // 
            this.tbTimeLB2.Location = new System.Drawing.Point(412, 255);
            this.tbTimeLB2.Name = "tbTimeLB2";
            this.tbTimeLB2.Size = new System.Drawing.Size(295, 22);
            this.tbTimeLB2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTimeLB2);
            this.Controls.Add(this.tbTimeLB1);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnListBox1);
            this.Controls.Add(this.btnListBox2);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.LB2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button btnListBox2;
        private System.Windows.Forms.Button btnListBox1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbTimeLB1;
        private System.Windows.Forms.TextBox tbTimeLB2;
    }
}

