namespace MarvelPong
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.TittleLabel = new System.Windows.Forms.Label();
            this.ThanosFace = new System.Windows.Forms.PictureBox();
            this.TonyFace = new System.Windows.Forms.PictureBox();
            this.ThorGordaoFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThanosFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonyFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThorGordaoFace)).BeginInit();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.Location = new System.Drawing.Point(-23, -5);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(849, 110);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = "ESCOLHA SEU CAMPEÃO";
            this.TittleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThanosFace
            // 
            this.ThanosFace.Image = ((System.Drawing.Image)(resources.GetObject("ThanosFace.Image")));
            this.ThanosFace.Location = new System.Drawing.Point(115, 149);
            this.ThanosFace.Name = "ThanosFace";
            this.ThanosFace.Size = new System.Drawing.Size(160, 160);
            this.ThanosFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThanosFace.TabIndex = 1;
            this.ThanosFace.TabStop = false;
            this.ThanosFace.Click += new System.EventHandler(this.ThanosFace_Click);
            // 
            // TonyFace
            // 
            this.TonyFace.BackColor = System.Drawing.Color.Plum;
            this.TonyFace.Image = ((System.Drawing.Image)(resources.GetObject("TonyFace.Image")));
            this.TonyFace.Location = new System.Drawing.Point(312, 149);
            this.TonyFace.Name = "TonyFace";
            this.TonyFace.Size = new System.Drawing.Size(160, 160);
            this.TonyFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TonyFace.TabIndex = 2;
            this.TonyFace.TabStop = false;
            this.TonyFace.Click += new System.EventHandler(this.TonyFace_Click);
            // 
            // ThorGordaoFace
            // 
            this.ThorGordaoFace.Image = ((System.Drawing.Image)(resources.GetObject("ThorGordaoFace.Image")));
            this.ThorGordaoFace.Location = new System.Drawing.Point(512, 149);
            this.ThorGordaoFace.Name = "ThorGordaoFace";
            this.ThorGordaoFace.Size = new System.Drawing.Size(160, 160);
            this.ThorGordaoFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThorGordaoFace.TabIndex = 3;
            this.ThorGordaoFace.TabStop = false;
            this.ThorGordaoFace.Click += new System.EventHandler(this.ThorGordaoFace_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThorGordaoFace);
            this.Controls.Add(this.TonyFace);
            this.Controls.Add(this.ThanosFace);
            this.Controls.Add(this.TittleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CharacterForm";
            this.Text = "Faça uma escolha sábia";
            ((System.ComponentModel.ISupportInitialize)(this.ThanosFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonyFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThorGordaoFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.PictureBox ThanosFace;
        private System.Windows.Forms.PictureBox TonyFace;
        private System.Windows.Forms.PictureBox ThorGordaoFace;
    }
}