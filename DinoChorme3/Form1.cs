namespace DinoChorme3
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        bool crouch = false;
        int crouchSpeed;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            dino1.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if(jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;

            }
            else
            {
                jumpSpeed = 12;
            }

            if(dino1.Top > 361 && jumping == false)
            {
                force = 12;
                dino1.Top = 362;
                jumpSpeed = 0;
            }

            if (crouch== true)
            {
                dinocrouch.Visible = true;
                dino1.Visible = false;
            }
            else 
            {
                
                crouch= false;
                dinocrouch.Visible = false;
                dino1.Visible = true;
                

            }
            




            if (score > 5)
            {
                obstacleSpeed = 15;
            }
            
            if(score > 15)
            {
                obstacleSpeed = 21;
            }
            
        }

        private void MainGameTimer2(object sender, EventArgs e)
        {
            dino1.Top += crouchSpeed;

            txtScore.Text = "Score: " + score;

            

            
            

            




            if (score > 5)
            {
                obstacleSpeed = 15;
            }

            if (score > 15)
            {
                obstacleSpeed = 21;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            
               
                if(e.KeyCode == Keys.Space && jumping == false )
                {
                    jumping = true;
                }
           
            
            
                
                if (e.KeyCode == Keys.C && crouch == false)
                {
                    crouch = true;
                      
                }
            
            
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(jumping == true)
            {
                jumping = false;    
            }

            if(crouch == true)
            {
                crouch = false;
            }

            if(e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();    
            }
        }

        public void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            dino1.Image = Properties.Resources.running_1_;
            dino1.Top = 362;
            


            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag  == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left= position;  

                }


            }

            gametimer.Start(); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void dino1_Click(object sender, EventArgs e)
        {

        }

        private void dinocrouch_Click(object sender, EventArgs e)
        {
            dinocrouch.Visible = false;
        }
    }
}