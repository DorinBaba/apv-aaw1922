
namespace LabelComponent
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
            this.lblContor = new System.Windows.Forms.Label();
            this.btIncrement = new System.Windows.Forms.Button();
            this.btDecrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContor
            // 
            this.lblContor.AutoSize = true;
            this.lblContor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContor.Location = new System.Drawing.Point(140, 93);
            this.lblContor.Name = "lblContor";
            this.lblContor.Size = new System.Drawing.Size(74, 20);
            this.lblContor.TabIndex = 0;
            this.lblContor.Text = "Contor: 0";
            // 
            // btIncrement
            // 
            this.btIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btIncrement.Location = new System.Drawing.Point(218, 164);
            this.btIncrement.Name = "btIncrement";
            this.btIncrement.Size = new System.Drawing.Size(75, 61);
            this.btIncrement.TabIndex = 1;
            this.btIncrement.Text = "+1";
            this.btIncrement.UseVisualStyleBackColor = true;
            this.btIncrement.Click += new System.EventHandler(this.btIncrement_Click);
            // 
            // btDecrement
            // 
            this.btDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecrement.Location = new System.Drawing.Point(63, 164);
            this.btDecrement.Name = "btDecrement";
            this.btDecrement.Size = new System.Drawing.Size(75, 61);
            this.btDecrement.TabIndex = 2;
            this.btDecrement.Text = "-1";
            this.btDecrement.UseVisualStyleBackColor = true;
            this.btDecrement.Click += new System.EventHandler(this.btDecrement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 310);
            this.Controls.Add(this.btDecrement);
            this.Controls.Add(this.btIncrement);
            this.Controls.Add(this.lblContor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContor;
        private System.Windows.Forms.Button btIncrement;
        private System.Windows.Forms.Button btDecrement;
    }
}

