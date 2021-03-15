
namespace ComboBox
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
            this.numar1 = new System.Windows.Forms.TextBox();
            this.numar2 = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperatia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // numar1
            // 
            this.numar1.Location = new System.Drawing.Point(130, 163);
            this.numar1.Name = "numar1";
            this.numar1.Size = new System.Drawing.Size(100, 38);
            this.numar1.TabIndex = 0;
            // 
            // numar2
            // 
            this.numar2.Location = new System.Drawing.Point(335, 163);
            this.numar2.Name = "numar2";
            this.numar2.Size = new System.Drawing.Size(100, 38);
            this.numar2.TabIndex = 1;
            // 
            // rezultat
            // 
            this.rezultat.Enabled = false;
            this.rezultat.Location = new System.Drawing.Point(504, 163);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(100, 38);
            this.rezultat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // cmbOperatia
            // 
            this.cmbOperatia.FormattingEnabled = true;
            this.cmbOperatia.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperatia.Location = new System.Drawing.Point(253, 162);
            this.cmbOperatia.Name = "cmbOperatia";
            this.cmbOperatia.Size = new System.Drawing.Size(59, 39);
            this.cmbOperatia.TabIndex = 4;
            this.cmbOperatia.Text = "+";
            this.cmbOperatia.SelectedIndexChanged += new System.EventHandler(this.cmbOperatia_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmbOperatia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.numar2);
            this.Controls.Add(this.numar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numar1;
        private System.Windows.Forms.TextBox numar2;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperatia;
    }
}

