namespace MarvelPong
{
    partial class Pong
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.BxPlayer1 = new System.Windows.Forms.PictureBox();
            this.BxPlayer2 = new System.Windows.Forms.PictureBox();
            this.BxPongBall = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScorePly1Label = new System.Windows.Forms.Label();
            this.ScorePly2Label = new System.Windows.Forms.Label();
            this.PongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxPongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BxPlayer1
            // 
            this.BxPlayer1.Location = new System.Drawing.Point(13, 236);
            this.BxPlayer1.Name = "BxPlayer1";
            this.BxPlayer1.Size = new System.Drawing.Size(18, 148);
            this.BxPlayer1.TabIndex = 0;
            this.BxPlayer1.TabStop = false;
            // 
            // BxPlayer2
            // 
            this.BxPlayer2.BackColor = System.Drawing.Color.LightPink;
            this.BxPlayer2.Location = new System.Drawing.Point(940, 236);
            this.BxPlayer2.Name = "BxPlayer2";
            this.BxPlayer2.Size = new System.Drawing.Size(18, 148);
            this.BxPlayer2.TabIndex = 1;
            this.BxPlayer2.TabStop = false;
            // 
            // BxPongBall
            // 
            this.BxPongBall.BackColor = System.Drawing.Color.Transparent;
            this.BxPongBall.Image = ((System.Drawing.Image)(resources.GetObject("BxPongBall.Image")));
            this.BxPongBall.Location = new System.Drawing.Point(426, 254);
            this.BxPongBall.Name = "BxPongBall";
            this.BxPongBall.Size = new System.Drawing.Size(61, 67);
            this.BxPongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BxPongBall.TabIndex = 2;
            this.BxPongBall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(389, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ScorePly1Label
            // 
            this.ScorePly1Label.BackColor = System.Drawing.Color.Transparent;
            this.ScorePly1Label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePly1Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ScorePly1Label.Location = new System.Drawing.Point(330, 38);
            this.ScorePly1Label.Name = "ScorePly1Label";
            this.ScorePly1Label.Size = new System.Drawing.Size(55, 55);
            this.ScorePly1Label.TabIndex = 4;
            this.ScorePly1Label.Text = "0";
            // 
            // ScorePly2Label
            // 
            this.ScorePly2Label.BackColor = System.Drawing.Color.Transparent;
            this.ScorePly2Label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePly2Label.ForeColor = System.Drawing.Color.MediumPurple;
            this.ScorePly2Label.Location = new System.Drawing.Point(604, 38);
            this.ScorePly2Label.Name = "ScorePly2Label";
            this.ScorePly2Label.Size = new System.Drawing.Size(55, 55);
            this.ScorePly2Label.TabIndex = 5;
            this.ScorePly2Label.Text = "0";
            // 
            // PongTimer
            // 
            this.PongTimer.Enabled = true;
            this.PongTimer.Interval = 10;
            this.PongTimer.Tick += new System.EventHandler(this.PongTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 631);
            this.Controls.Add(this.ScorePly2Label);
            this.Controls.Add(this.ScorePly1Label);
            this.Controls.Add(this.BxPongBall);
            this.Controls.Add(this.BxPlayer2);
            this.Controls.Add(this.BxPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1069, 687);
            this.MinimumSize = new System.Drawing.Size(1069, 687);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxPongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BxPlayer1;
        private System.Windows.Forms.PictureBox BxPlayer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ScorePly1Label;
        private System.Windows.Forms.Label ScorePly2Label;
        public System.Windows.Forms.PictureBox BxPongBall;
        public System.Windows.Forms.Timer PongTimer;
    }
}

