
namespace Exemplul1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbSport = new System.Windows.Forms.TextBox();
            this.tbHobby = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescriere = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.rbCasatorit = new System.Windows.Forms.RadioButton();
            this.rbNecasatorit = new System.Windows.Forms.RadioButton();
            this.btTrimite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sportul preferat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hobby";
            // 
            // tbSport
            // 
            this.tbSport.Location = new System.Drawing.Point(34, 44);
            this.tbSport.Name = "tbSport";
            this.tbSport.Size = new System.Drawing.Size(148, 26);
            this.tbSport.TabIndex = 2;
            // 
            // tbHobby
            // 
            this.tbHobby.Location = new System.Drawing.Point(34, 112);
            this.tbHobby.Name = "tbHobby";
            this.tbHobby.Size = new System.Drawing.Size(148, 26);
            this.tbHobby.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrierea dumneavoastră ca persoană";
            // 
            // rtbDescriere
            // 
            this.rtbDescriere.Location = new System.Drawing.Point(34, 185);
            this.rtbDescriere.Name = "rtbDescriere";
            this.rtbDescriere.Size = new System.Drawing.Size(329, 85);
            this.rtbDescriere.TabIndex = 5;
            this.rtbDescriere.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFeminin);
            this.panel1.Controls.Add(this.rbMasculin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(234, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 108);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNecasatorit);
            this.panel2.Controls.Add(this.rbCasatorit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(388, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 108);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Starea civila";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(3, 34);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(89, 24);
            this.rbMasculin.TabIndex = 10;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Location = new System.Drawing.Point(3, 64);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(83, 24);
            this.rbFeminin.TabIndex = 11;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "Feminin";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // rbCasatorit
            // 
            this.rbCasatorit.AutoSize = true;
            this.rbCasatorit.Location = new System.Drawing.Point(7, 34);
            this.rbCasatorit.Name = "rbCasatorit";
            this.rbCasatorit.Size = new System.Drawing.Size(91, 24);
            this.rbCasatorit.TabIndex = 12;
            this.rbCasatorit.TabStop = true;
            this.rbCasatorit.Text = "Casatorit";
            this.rbCasatorit.UseVisualStyleBackColor = true;
            // 
            // rbNecasatorit
            // 
            this.rbNecasatorit.AutoSize = true;
            this.rbNecasatorit.Checked = true;
            this.rbNecasatorit.Location = new System.Drawing.Point(7, 64);
            this.rbNecasatorit.Name = "rbNecasatorit";
            this.rbNecasatorit.Size = new System.Drawing.Size(108, 24);
            this.rbNecasatorit.TabIndex = 13;
            this.rbNecasatorit.TabStop = true;
            this.rbNecasatorit.Text = "Necasatorit";
            this.rbNecasatorit.UseVisualStyleBackColor = true;
            // 
            // btTrimite
            // 
            this.btTrimite.Location = new System.Drawing.Point(461, 238);
            this.btTrimite.Name = "btTrimite";
            this.btTrimite.Size = new System.Drawing.Size(75, 32);
            this.btTrimite.TabIndex = 9;
            this.btTrimite.Text = "Trimite";
            this.btTrimite.UseVisualStyleBackColor = true;
            this.btTrimite.Click += new System.EventHandler(this.btTrimite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 290);
            this.Controls.Add(this.btTrimite);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbHobby);
            this.Controls.Add(this.rtbDescriere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSport;
        private System.Windows.Forms.TextBox tbHobby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescriere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFeminin;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNecasatorit;
        private System.Windows.Forms.RadioButton rbCasatorit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTrimite;
    }
}

