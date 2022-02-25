
namespace CoursOpenCVBase
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbTraitement = new System.Windows.Forms.PictureBox();
            this.tbSeuil = new System.Windows.Forms.TrackBar();
            this.tbType = new System.Windows.Forms.TrackBar();
            this.pbTraitement2 = new System.Windows.Forms.PictureBox();
            this.btnVisage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSeuil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(79, 74);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(256, 256);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // pbTraitement
            // 
            this.pbTraitement.Location = new System.Drawing.Point(413, 74);
            this.pbTraitement.Name = "pbTraitement";
            this.pbTraitement.Size = new System.Drawing.Size(256, 256);
            this.pbTraitement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraitement.TabIndex = 1;
            this.pbTraitement.TabStop = false;
            // 
            // tbSeuil
            // 
            this.tbSeuil.Location = new System.Drawing.Point(79, 336);
            this.tbSeuil.Maximum = 255;
            this.tbSeuil.Name = "tbSeuil";
            this.tbSeuil.Size = new System.Drawing.Size(256, 45);
            this.tbSeuil.TabIndex = 2;
            this.tbSeuil.Scroll += new System.EventHandler(this.tbSeuil_Scroll);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(79, 387);
            this.tbType.Maximum = 4;
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(256, 45);
            this.tbType.TabIndex = 3;
            this.tbType.Scroll += new System.EventHandler(this.tbType_Scroll);
            // 
            // pbTraitement2
            // 
            this.pbTraitement2.Location = new System.Drawing.Point(731, 74);
            this.pbTraitement2.Name = "pbTraitement2";
            this.pbTraitement2.Size = new System.Drawing.Size(256, 256);
            this.pbTraitement2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraitement2.TabIndex = 4;
            this.pbTraitement2.TabStop = false;
            // 
            // btnVisage
            // 
            this.btnVisage.Location = new System.Drawing.Point(731, 346);
            this.btnVisage.Name = "btnVisage";
            this.btnVisage.Size = new System.Drawing.Size(256, 23);
            this.btnVisage.TabIndex = 5;
            this.btnVisage.Text = "visage";
            this.btnVisage.UseVisualStyleBackColor = true;
            this.btnVisage.Click += new System.EventHandler(this.btnVisage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 450);
            this.Controls.Add(this.btnVisage);
            this.Controls.Add(this.pbTraitement2);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbSeuil);
            this.Controls.Add(this.pbTraitement);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSeuil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbTraitement;
        private System.Windows.Forms.TrackBar tbSeuil;
        private System.Windows.Forms.TrackBar tbType;
        private System.Windows.Forms.PictureBox pbTraitement2;
        private System.Windows.Forms.Button btnVisage;
    }
}

