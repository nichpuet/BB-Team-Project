using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys
        Boolean leftArrowDown, rightArrowDown, ADown, DDown;

        // Paddle and Ball objects
        public static Paddle paddle;
        public static List<Ball> ballList = new List<Ball>();
        public static int paddleWidth = 80;
        public static int paddleHeight = 20;
        public static int ballNumber = 0;

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        //Powerups
        List<Powerups> powerup = new List<Powerups>();
        Boolean activated = false;
        public static int randomPowerupChance;

        SolidBrush powerups3Brush = new SolidBrush(Color.Green);
        SolidBrush powerupsLBrush = new SolidBrush(Color.Yellow);
        SolidBrush powerupslBrush = new SolidBrush(Color.Red);
        SolidBrush powerupsBSBrush = new SolidBrush(Color.Purple);
        SolidBrush powerupsbsBrush = new SolidBrush(Color.OrangeRed);

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush blockBrush = new SolidBrush(Color.Red);

        // Lives
        public int player1Lives = 3;
        public int? player2Lives = null;
        #endregion

        // Creates a new ball
        int xSpeed = 6;
        int ySpeed = 6;
        int ballSize = 20;

        public GameScreen(bool multiplayer = false)
        {
            InitializeComponent();
            OnStart();
            if (multiplayer)
                player2Lives = 3;
        }

        // angle change buttons
        int angleposition = 3;
        bool start = false;

        bool Akeydown = false;
        bool Dkeydown = false;
        Font textFont;
        SolidBrush sb = new SolidBrush(Color.White);

        public void OnStart()
        {
            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // create text graphics
            textFont = new Font("Verdana", 14, FontStyle.Regular);

            // setup starting paddle values and create paddle object
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight);
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = ((paddle.x - ballSize) + (paddle.width / 2));
            int ballY = paddle.y - 21;
            ballList.Clear();
            ballList.Add(new Ball(ballX, ballY, xSpeed, ySpeed, ballSize, 1, -1));
            ballNumber += 1;

            #region Creates blocks for generic level. Need to replace with code that loads levels.

            blocks.Clear();
            int x = 10;

            while (blocks.Count < 12)
            {
                x += 57;
                Block b1 = new Block(x, 10, 1, Color.White);
                blocks.Add(b1);
            }

            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    start = true;
                    break;
                case Keys.Escape:
                    break;
                default:
                    break;
            }

            if (!start)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        // move left
                        if (angleposition > 1)
                        {
                            angleposition++;
                        }
                        break;
                    case Keys.D:
                        // move right
                        if (angleposition < 6)
                        {
                            angleposition--;
                        }
                        break;
                }
            }
        }

        private void anglechange()
        {
            switch (angleposition)
            {
                case 1:
                    ballList[0].Xangle = 1;
                    ballList[0].Yangle = -0.5;
                    break;
                case 2:
                    ballList[0].Xangle = 1;
                    ballList[0].Yangle = -1;
                    break;
                case 3:
                    ballList[0].Xangle = 0.5;
                    ballList[0].Yangle = -1;
                    break;
                case 4:
                    ballList[0].Xangle = -1;
                    ballList[0].Yangle = -0.5;
                    break;
                case 5:
                    ballList[0].Xangle = -1;
                    ballList[0].Yangle = -1;
                    break;
                case 6:
                    ballList[0].Xangle = -0.5;
                    ballList[0].Yangle = -1;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move the paddle
            if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            if (start)
            {
                // Move ball
                foreach (Ball b in ballList)
                {
                    anglechange();

                    // Move ball
                    b.Move();

                    // Check for collision with top and side walls
                    b.WallCollision(this);

                    // Check for ball hitting bottom of screen
                    if (b.BottomCollision(this, paddle) && ballNumber == 1)
                    {
                        // decrease player 1 lives
                        player1Lives--;

                        // move the ball and paddle back
                        start = false;

                        ballList[0].x = ((paddle.x - ballSize) + (paddle.width / 2));
                        ballList[0].y = paddle.y - 40;
                        ballList[0].Yangle *= -1;

                        // reset x and y speeds
                        ballList[0].xSpeed = xSpeed;
                        ballList[0].ySpeed = ySpeed;

                        if (player1Lives <= 0)
                        {
                            start = false;

                            if (player2Lives == 0)
                            {
                                gameTimer.Enabled = false;
                                OnEnd();
                            }
                            gameTimer.Enabled = false;
                            OnEnd();
                        }
                    }
                    else if (b.BottomCollision(this, paddle))
                    {
                        //Remove ball that hit bottom from list
                        ballNumber -= 1;
                        ballList.Remove(b);
                        break;
                    }

                    // Check for collision of ball with paddle, (incl. paddle movement)
                    b.PaddleCollision(paddle, leftArrowDown, rightArrowDown);
                }

                // Check if ball has collided with any blocks
                foreach (Ball ba in ballList)
                {
                    foreach (Block b in blocks)
                    {
                        if (ba.BlockCollision(b))
                        {
                            blocks.Remove(b);

                            //Powerup Chance 
                            Random randPower = new Random();
                            randomPowerupChance = randPower.Next(1, 7);

                            if (randomPowerupChance == 1)
                            {
                                Powerups p = new Powerups(b.x, b.y, 5, "3");
                                powerup.Add(p);
                                activated = false;
                            }
                            if (randomPowerupChance == 2)
                            {
                                Powerups p = new Powerups(b.x, b.y, 5, "L");
                                powerup.Add(p);
                                activated = false;
                            }
                            if (randomPowerupChance == 3)
                            {
                                Powerups p = new Powerups(b.x, b.y, 5, "l");
                                powerup.Add(p);
                                activated = false;
                            }
                            if (randomPowerupChance == 4)
                            {
                                Powerups p = new Powerups(b.x, b.y, 5, "BS");
                                powerup.Add(p);
                                activated = false;
                            }
                            if (randomPowerupChance == 5)
                            {
                                Powerups p = new Powerups(b.x, b.y, 5, "bs");
                                powerup.Add(p);
                                activated = false;
                            }


                            if (blocks.Count == 0)
                            {
                                gameTimer.Enabled = false;
                                OnEnd();
                            }

                            break;
                        }
                    }
                }
            }
            else
            {
                // center the ball over the paddle
                ballList[0].x = paddle.x + (paddle.width / 2) - (ballList[0].size / 2);
                ballList[0].y = paddle.y - 21;
            }

            //Move powerups down
            foreach (Powerups p in powerup)
            {
                p.powerupMove();
            }

            //Check for collision of powerups
            foreach (Powerups p in powerup)
            {
                if (p.PowerupCollision() == true && activated == false)
                {
                    if (p.type == "3")
                    {
                        //activate powerup
                        Ball b2 = new Ball(200, 100, xSpeed, ySpeed, ballSize, 1, -1);
                        ballList.Add(b2);
                        ballNumber += 1;

                        Ball b3 = new Ball(100, 200, xSpeed, ySpeed, ballSize, 1, -1);
                        ballList.Add(b3);
                        ballNumber += 1;
                    }
                    else if (p.type == "L")
                    {
                        paddle.width += 25;
                    }
                    else if (p.type == "l")
                    {
                        paddle.width -= 25;
                    }
                    else if (p.type == "BS")
                    {
                        xSpeed -= 6;
                        ySpeed -= 6;
                    }
                    else if (p.type == "bs")
                    {
                        xSpeed += 6;
                        ySpeed += 6;
                    }

                    activated = true;
                }
            }

            //redraw the screen
            Refresh();
        }

        public void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();
            MenuScreen ps = new MenuScreen();

            ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

            form.Controls.Add(ps);
            form.Controls.Remove(this);
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);
            //paddleBrush.Color = newPaddle.colour;
            //e.Graphics.FillRectangle(paddleBrush, newPaddle.x, newPaddle.y, newPaddle.width, newPaddle.height);

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(blockBrush, b.x, b.y, b.width, b.height);
            }

            // Draws ball
            foreach (Ball b in ballList)
            {
                e.Graphics.FillEllipse(ballBrush, Convert.ToSingle(b.x), Convert.ToInt32(b.y), b.size, b.size);
            }

            //Draws Powerups
            foreach (Powerups p in powerup)
            {
                if (p.type == "3")
                {
                    e.Graphics.FillRectangle(powerups3Brush, p.x, p.y, p.width, p.height);
                }
                else if (p.type == "L")
                {
                    e.Graphics.FillRectangle(powerupsLBrush, p.x, p.y, p.width, p.height);
                }
                else if (p.type == "l")
                {
                    e.Graphics.FillRectangle(powerupslBrush, p.x, p.y, p.width, p.height);
                }
                else if (p.type == "BS")
                {
                    e.Graphics.FillRectangle(powerupsBSBrush, p.x, p.y, p.width, p.height);
                }
                else if (p.type == "bs")
                {
                    e.Graphics.FillRectangle(powerupsbsBrush, p.x, p.y, p.width, p.height);
                }
                else
                {
                    e.Graphics.FillRectangle(ballBrush, p.x, p.y, p.width, p.height);
                }
            }

            // Draw lives and font
            e.Graphics.DrawString("Lives: " + player1Lives.ToString(), textFont, sb, new Point(25, this.Height - 25));
            //e.Graphics.DrawString(scoe.ToString(), textFont, sb, new Point(25, 75));
            // TODO: Draw score (Rie)
        }

        public void NickMethod()
        {
            //set all button presses to false.
            leftArrowDown = rightArrowDown = ADown = DDown = false;

            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2)) - ((this.Width / 2) / 2);
            int newPaddleX = ((this.Width / 2) - (paddleWidth / 2)) + ((this.Width / 2) / 2);
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.Firebrick);
            //newPaddle = new Paddle(newPaddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.RoyalBlue);

            // setup starting ball values
            int ballX = (this.Width / 2 - 10) - ((this.Width / 2) / 2);
            int ballY = this.Height - paddle.height - 80;

            /// BallList[0] is P1
            /// BallList[1] is P2
            ballList.Clear();
            ballList.Add(new Ball(ballX, ballY, 6, 6, 20, 1, 1));
            ballList.Add(new Ball(ballX, this.Height - ballY, 6, 6, 20, 1, 1));
            // Creates a new ball

            #region Creates blocks for generic level. Need to replace with code that loads levels.

            blocks.Clear();
            int x = 10;

            while (blocks.Count < 12)
            {
                x += 57;
                Block b1 = new Block(x, 10, 1, Color.White);
                blocks.Add(b1);
            }

            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }
    }
}