
namespace Exemplul2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLatura = new System.Windows.Forms.TextBox();
            this.btCalculeaza = new System.Windows.Forms.Button();
            this.lbAria = new System.Windows.Forms.Label();
            this.lbPerimetru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latura patratului";
            // 
            // tbLatura
            // 
            this.tbLatura.Location = new System.Drawing.Point(50, 86);
            this.tbLatura.Name = "tbLatura";
            this.tbLatura.Size = new System.Drawing.Size(144, 26);
            this.tbLatura.TabIndex = 1;
            // 
            // btCalculeaza
            // 
            this.btCalculeaza.Location = new System.Drawing.Point(50, 137);
            this.btCalculeaza.Name = "btCalculeaza";
            this.btCalculeaza.Size = new System.Drawing.Size(144, 39);
            this.btCalculeaza.TabIndex = 2;
            this.btCalculeaza.Text = "Calculeaza";
            this.btCalculeaza.UseVisualStyleBackColor = true;
            this.btCalculeaza.Click += new System.EventHandler(this.btCalculeaza_Click);
            // 
            // lbAria
            // 
            this.lbAria.AutoSize = true;
            this.lbAria.Location = new System.Drawing.Point(46, 225);
            this.lbAria.Name = "lbAria";
            this.lbAria.Size = new System.Drawing.Size(54, 20);
            this.lbAria.TabIndex = 3;
            this.lbAria.Text = "Aria: 0";
            // 
            // lbPerimetru
            // 
            this.lbPerimetru.AutoSize = true;
            this.lbPerimetru.Location = new System.Drawing.Point(46, 255);
            this.lbPerimetru.Name = "lbPerimetru";
            this.lbPerimetru.Size = new System.Drawing.Size(97, 20);
            this.lbPerimetru.TabIndex = 4;
            this.lbPerimetru.Text = "Perimetrul: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.lbPerimetru);
            this.Controls.Add(this.lbAria);
            this.Controls.Add(this.btCalculeaza);
            this.Controls.Add(this.tbLatura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLatura;
        private System.Windows.Forms.Button btCalculeaza;
        private System.Windows.Forms.Label lbAria;
        private System.Windows.Forms.Label lbPerimetru;
    }
}

