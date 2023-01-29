namespace SpaceWars
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(this);
            //this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            if (game.GameOver) timer1.Stop();
            //Update();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            { 
                game.Ship.SpeedY = -10;
            }
            if(e.KeyCode == Keys.S)
            {
                game.Ship.SpeedY = 10;
            }
            if(e.KeyCode==Keys.Space)
            {
                game.Shot();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            game.Ship.SpeedY = 0;
        }
    }
}