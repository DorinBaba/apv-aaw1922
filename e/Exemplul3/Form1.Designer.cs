
namespace Exemplul3
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
            this.btMareste = new System.Windows.Forms.Button();
            this.btMicsoreaza = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btSus = new System.Windows.Forms.Button();
            this.btCentru = new System.Windows.Forms.Button();
            this.btJos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btMareste
            // 
            this.btMareste.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMareste.Location = new System.Drawing.Point(153, 355);
            this.btMareste.Name = "btMareste";
            this.btMareste.Size = new System.Drawing.Size(181, 39);
            this.btMareste.TabIndex = 0;
            this.btMareste.Text = "+";
            this.btMareste.UseVisualStyleBackColor = true;
            this.btMareste.Click += new System.EventHandler(this.btMareste_Click);
            // 
            // btMicsoreaza
            // 
            this.btMicsoreaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMicsoreaza.Location = new System.Drawing.Point(386, 355);
            this.btMicsoreaza.Name = "btMicsoreaza";
            this.btMicsoreaza.Size = new System.Drawing.Size(181, 39);
            this.btMicsoreaza.TabIndex = 1;
            this.btMicsoreaza.Text = "-";
            this.btMicsoreaza.UseVisualStyleBackColor = true;
            this.btMicsoreaza.Click += new System.EventHandler(this.btMicsoreaza_Click);
            // 
            // picture
            // 
            this.picture.Image = global::Exemplul3.Properties.Resources.Screenshot_2021_04_12_102457;
            this.picture.Location = new System.Drawing.Point(271, 59);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(189, 240);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // btSus
            // 
            this.btSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSus.Location = new System.Drawing.Point(26, 22);
            this.btSus.Name = "btSus";
            this.btSus.Size = new System.Drawing.Size(181, 39);
            this.btSus.TabIndex = 3;
            this.btSus.Text = "Sus";
            this.btSus.UseVisualStyleBackColor = true;
            this.btSus.Click += new System.EventHandler(this.btSus_Click);
            // 
            // btCentru
            // 
            this.btCentru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCentru.Location = new System.Drawing.Point(26, 162);
            this.btCentru.Name = "btCentru";
            this.btCentru.Size = new System.Drawing.Size(181, 39);
            this.btCentru.TabIndex = 4;
            this.btCentru.Text = "Centru";
            this.btCentru.UseVisualStyleBackColor = true;
            this.btCentru.Click += new System.EventHandler(this.btCentru_Click);
            // 
            // btJos
            // 
            this.btJos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJos.Location = new System.Drawing.Point(26, 287);
            this.btJos.Name = "btJos";
            this.btJos.Size = new System.Drawing.Size(181, 39);
            this.btJos.TabIndex = 5;
            this.btJos.Text = "Jos";
            this.btJos.UseVisualStyleBackColor = true;
            this.btJos.Click += new System.EventHandler(this.btJos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.btJos);
            this.Controls.Add(this.btCentru);
            this.Controls.Add(this.btSus);
            this.Controls.Add(this.btMicsoreaza);
            this.Controls.Add(this.btMareste);
            this.Controls.Add(this.picture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMareste;
        private System.Windows.Forms.Button btMicsoreaza;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btSus;
        private System.Windows.Forms.Button btCentru;
        private System.Windows.Forms.Button btJos;
    }
}

