using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarvelPong
{
    public partial class Pong : Form
    {
        // Variáveis locais
        int ballXCoordinate = 10; // Velocidade da bola
        int ballYCoordinate = 10; // Velocidade da bola

        // Variáveis de pontuação
        int ScorePly1 = 0;
        int ScorePly2 = 0;

        // Variáveis de tamanho
        int bottomBoundary;
        int xMidpoint;

        // Variáveis de detecção
        bool BxPlayer1DetectedUp;
        bool BxPlayer2DetectedUp;
        bool BxPlayer1DetectedDown;
        bool BxPlayer2DetectedDown;

        // Clique especial
        int spaceBarClicked = 0;

        public Pong()
        {
            InitializeComponent();

            // Permitir que o formulário capture eventos de teclado
            KeyPreview = true;

            // Habilitar o DoubleBuffered para reduzir o rastro
            this.DoubleBuffered = true;

            // Corrigindo inicialização de limites e posições
            bottomBoundary = ClientSize.Height - BxPlayer1.Height;
            xMidpoint = ClientSize.Width / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Iniciar o timer assim que o formulário carregar
            PongTimer.Start();
        }

        private void PongTimer_Tick(object sender, EventArgs e)
        {
            // Ajustando a posição da bola
            BxPongBall.Top -= ballYCoordinate;
            BxPongBall.Left -= ballXCoordinate;

            // Verificar se a bola saiu pelo lado esquerdo (marcar ponto para o Player 2)
            if (BxPongBall.Left < 0)
            {
                ResetBall();
                ScorePly2++;
                ScorePly2Label.Text = ScorePly2.ToString();
            }

            // Verificar se a bola saiu pelo lado direito (marcar ponto para o Player 1)
            if (BxPongBall.Left + BxPongBall.Width > ClientSize.Width)
            {
                ResetBall();
                ScorePly1++;
                ScorePly1Label.Text = ScorePly1.ToString();
            }

            // Garantir que a bola fique dentro dos limites verticais
            if (BxPongBall.Top < 0 || BxPongBall.Top + BxPongBall.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate; // Inverter a direção vertical
            }

            // Verificar colisão com as raquetes dos jogadores
            if (BxPongBall.Bounds.IntersectsWith(BxPlayer1.Bounds) || BxPongBall.Bounds.IntersectsWith(BxPlayer2.Bounds))
            {
                // Inverter a direção da bola ao colidir
                if (BxPongBall.Bounds.IntersectsWith(BxPlayer1.Bounds))
                {
                    // A bola colidiu com o Player 1, inverter a direção X e ajustar a velocidade
                    ballXCoordinate = -Math.Abs(ballXCoordinate); // Certifique-se de que a bola vai para a direita
                }
                else if (BxPongBall.Bounds.IntersectsWith(BxPlayer2.Bounds))
                {

                    //gerar uma nova com para o player 1
                    Random rand = new Random();
                    int max = byte.MaxValue + 1;
                    int r = rand.Next(max);
                    int g = rand.Next(max);
                    int b = rand.Next(max);
                    Color c = Color.FromArgb(r, g, b);

                    // gerar uma nova cor para o player 2
                    int r1 = rand.Next(max);
                    int g1 = rand.Next(max);
                    int b1 = rand.Next(max);
                    Color c2 = Color.FromArgb(r1, g1, b1);

                    // mudar a cor das raquetes
                    BxPlayer1.BackColor = c;
                    BxPlayer2.BackColor = c2;

                    // Inverter a direção da bola ao colidir
                    ballXCoordinate = -ballXCoordinate;

                    // A bola colidiu com o Player 2, inverter a direção X e ajustar a velocidade
                    ballXCoordinate = Math.Abs(ballXCoordinate); // Certifique-se de que a bola vai para a esquerda
                }
            }

            // Mover jogadores para cima (aumentar a velocidade do movimento)
            if (BxPlayer1DetectedUp && BxPlayer1.Top > 0) { BxPlayer1.Top -= 15; }
            if (BxPlayer2DetectedUp && BxPlayer2.Top > 0) { BxPlayer2.Top -= 15; }

            // Mover jogadores para baixo (aumentar a velocidade do movimento)
            if (BxPlayer1DetectedDown && BxPlayer1.Top < bottomBoundary) { BxPlayer1.Top += 15; }
            if (BxPlayer2DetectedDown && BxPlayer2.Top < bottomBoundary) { BxPlayer2.Top += 15; }

            // Verificar o vencedor
            if (ScorePly1 >= 10 || ScorePly2 >= 10) { PongTimer.Stop(); }
        }

        private void ResetBall()
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            BxPongBall.Left = xMidpoint;
            BxPongBall.Top = newSpot;
            ballXCoordinate = -ballXCoordinate; // Inverter a direção da bola
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            // Detecção de teclas soltas
            if (e.KeyCode == Keys.W) { BxPlayer1DetectedUp = false; }
            if (e.KeyCode == Keys.S) { BxPlayer1DetectedDown = false; }
            if (e.KeyCode == Keys.Up) { BxPlayer2DetectedUp = false; }
            if (e.KeyCode == Keys.Down) { BxPlayer2DetectedDown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecção de teclas pressionadas
            if (e.KeyCode == Keys.W) { BxPlayer1DetectedUp = true; }
            if (e.KeyCode == Keys.S) { BxPlayer1DetectedDown = true; }
            if (e.KeyCode == Keys.Up) { BxPlayer2DetectedUp = true; }
            if (e.KeyCode == Keys.Down) { BxPlayer2DetectedDown = true; }

            // Se os jogadores apertarem a letra C, abre a escolha de personagem
            if (e.KeyCode == Keys.C)
            {
                Form character = new CharacterForm();
                character.Owner = this;
                PongTimer.Stop();
                character.Show();
            }

            // Barra de espaço para pausar e retomar o jogo
            if (e.KeyCode == Keys.Space)
            {
                spaceBarClicked++;
                if (spaceBarClicked % 2 == 1)
                {
                    PongTimer.Stop();
                }
                else
                {
                    PongTimer.Start();
                }
            }
        }
    }
}