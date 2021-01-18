
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeheBoi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            bool c1 = (tbDela.TabIndex < tbMax.TabIndex && tbMax.TabIndex < btExtrage.TabIndex);
            bool c2 = (btExtrage.Parent == this && btExtrage.Dock == DockStyle.Bottom);

            if (c1 && c2)
            {
                this.BackgroundImage = new Bitmap(HeheBoi.Properties.Resources.ric);
                panelContent.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lbNumar = new System.Windows.Forms.Label();
            this.btExtrage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDela = new System.Windows.Forms.TextBox();
            this.label1G = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.DimGray;
            this.panelContent.Controls.Add(this.lbNumar);
            this.panelContent.Controls.Add(this.btExtrage);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.tbMax);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.tbDela);
            this.panelContent.Controls.Add(this.label1G);
            this.panelContent.ForeColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(375, 355);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // lbNumar
            // 
            this.lbNumar.AutoSize = true;
            this.lbNumar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumar.Location = new System.Drawing.Point(35, 175);
            this.lbNumar.Name = "lbNumar";
            this.lbNumar.Size = new System.Drawing.Size(270, 25);
            this.lbNumar.TabIndex = 6;
            this.lbNumar.Text = "Aici va aparea numarul aleator";
            // 
            // btExtrage
            // 
            this.btExtrage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btExtrage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExtrage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExtrage.Location = new System.Drawing.Point(0, 324);
            this.btExtrage.Name = "btExtrage";
            this.btExtrage.Size = new System.Drawing.Size(375, 31);
            this.btExtrage.TabIndex = 2;
            this.btExtrage.Text = "Extrage";
            this.btExtrage.UseVisualStyleBackColor = true;
            this.btExtrage.Click += new System.EventHandler(this.btExtrage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pana la";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(222, 105);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 23);
            this.tbMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "De la";
            // 
            // tbDela
            // 
            this.tbDela.Location = new System.Drawing.Point(35, 105);
            this.tbDela.Name = "tbDela";
            this.tbDela.Size = new System.Drawing.Size(100, 23);
            this.tbDela.TabIndex = 1;
            // 
            // label1G
            // 
            this.label1G.AutoSize = true;
            this.label1G.Location = new System.Drawing.Point(112, 33);
            this.label1G.Name = "label1G";
            this.label1G.Size = new System.Drawing.Size(143, 15);
            this.label1G.TabIndex = 0;
            this.label1G.Text = "Generare numere aleatorii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 357);
            this.Controls.Add(this.panelContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1G;
        private System.Windows.Forms.Label lbNumar;
        private System.Windows.Forms.Button btExtrage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDela;
    }
}

