using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelPong
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void ThanosFace_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).BxPongBall.Image = Image.FromFile(@"C:\Users\Windows\Downloads\THANOSball.png");
            (this.Owner as Pong).PongTimer.Start();
            this.Hide();
        }

        private void TonyFace_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).BxPongBall.Image = Image.FromFile(@"C:\Users\Windows\Downloads\tonyyy-removebg-preview.png");
            (this.Owner as Pong).PongTimer.Start();
            this.Hide();
        }

        private void ThorGordaoFace_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).BxPongBall.Image = Image.FromFile(@"C:\Users\Windows\Downloads\thorgordasso-removebg-preview.png");
            (this.Owner as Pong).PongTimer.Start();
            this.Hide();
        }
    }
}
