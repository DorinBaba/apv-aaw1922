
namespace Sarcina2
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
            this.tbInitial = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.cmbInitial = new System.Windows.Forms.ComboBox();
            this.cmbFinal = new System.Windows.Forms.ComboBox();
            this.btConvertire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInitial
            // 
            this.tbInitial.Location = new System.Drawing.Point(32, 57);
            this.tbInitial.Name = "tbInitial";
            this.tbInitial.Size = new System.Drawing.Size(130, 29);
            this.tbInitial.TabIndex = 0;
            // 
            // tbFinal
            // 
            this.tbFinal.Enabled = false;
            this.tbFinal.Location = new System.Drawing.Point(214, 57);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(130, 29);
            this.tbFinal.TabIndex = 1;
            // 
            // cmbInitial
            // 
            this.cmbInitial.FormattingEnabled = true;
            this.cmbInitial.Location = new System.Drawing.Point(32, 92);
            this.cmbInitial.Name = "cmbInitial";
            this.cmbInitial.Size = new System.Drawing.Size(130, 32);
            this.cmbInitial.TabIndex = 2;
            // 
            // cmbFinal
            // 
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.Location = new System.Drawing.Point(214, 92);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.Size = new System.Drawing.Size(130, 32);
            this.cmbFinal.TabIndex = 3;
            // 
            // btConvertire
            // 
            this.btConvertire.Location = new System.Drawing.Point(32, 130);
            this.btConvertire.Name = "btConvertire";
            this.btConvertire.Size = new System.Drawing.Size(312, 34);
            this.btConvertire.TabIndex = 4;
            this.btConvertire.Text = "Converteste";
            this.btConvertire.UseVisualStyleBackColor = true;
            this.btConvertire.Click += new System.EventHandler(this.btConvertire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 221);
            this.Controls.Add(this.btConvertire);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInitial);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbInitial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInitial;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.ComboBox cmbInitial;
        private System.Windows.Forms.ComboBox cmbFinal;
        private System.Windows.Forms.Button btConvertire;
    }
}

