
namespace Sarcina1
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
            this.btAfiseazaOra = new System.Windows.Forms.Button();
            this.btAfiseazaData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAfiseazaOra
            // 
            this.btAfiseazaOra.BackColor = System.Drawing.Color.Aqua;
            this.btAfiseazaOra.FlatAppearance.BorderSize = 0;
            this.btAfiseazaOra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAfiseazaOra.Location = new System.Drawing.Point(44, 149);
            this.btAfiseazaOra.Name = "btAfiseazaOra";
            this.btAfiseazaOra.Size = new System.Drawing.Size(260, 55);
            this.btAfiseazaOra.TabIndex = 2;
            this.btAfiseazaOra.Text = "Afișează Ora";
            this.btAfiseazaOra.UseVisualStyleBackColor = false;
            this.btAfiseazaOra.Click += new System.EventHandler(this.btAfiseazaOra_Click);
            // 
            // btAfiseazaData
            // 
            this.btAfiseazaData.BackColor = System.Drawing.Color.Aqua;
            this.btAfiseazaData.FlatAppearance.BorderSize = 0;
            this.btAfiseazaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAfiseazaData.Location = new System.Drawing.Point(339, 149);
            this.btAfiseazaData.Name = "btAfiseazaData";
            this.btAfiseazaData.Size = new System.Drawing.Size(260, 55);
            this.btAfiseazaData.TabIndex = 3;
            this.btAfiseazaData.Text = "Afișează Data";
            this.btAfiseazaData.UseVisualStyleBackColor = false;
            this.btAfiseazaData.Click += new System.EventHandler(this.btAfiseazaData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 366);
            this.Controls.Add(this.btAfiseazaData);
            this.Controls.Add(this.btAfiseazaOra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAfiseazaOra;
        private System.Windows.Forms.Button btAfiseazaData;
    }
}

