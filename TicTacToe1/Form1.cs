namespace TicTacToe1
//The title/ name of the code & game. 
{
    public partial class Form1 : Form
    {
        //This states if the user can change the code when the game is in process and changing any default code. 

        private enum Player
        {
            X, O //These are the constants characters for the game. The protagonist is the 'X' and the 'O' is the antagonist. 

        }

        Player currentPlayer;
        Random random = new Random(); // The "random" makes sure the player gets the deserved points throughout the game rather than having it go up
                                      // where it pleases.
        int playerWinCount = 0;
        int CPUWinCount = 0; // Points start at the bottom "0".
        List<Button> buttons; //This goes connects to the buttons listed below 
                              //This goes connects to the buttons listed below "buttons = new List<Button> { button1, button2, button3, button4, button5,
                              //button6, button7, button8, button9" to create an estimated point system."
        bool waitingforcpu = false;

        //The code above allows the user to see the points changing when one player scores a point. 

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        } // Form1 is a class that can be effected by the user, making sure the user can restart the game when requested however (); it is further coded below.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0) // any code in this class will only affect the buttons above 0 so anything from 1-9. (the onlyh buttons activated as false).
            {
                int index = random.Next(buttons.Count); //This is the command to count up on non-negative numbers to a random class that wins a round. 
                buttons[index].Enabled = false;         //To allow the user to press the button to activate the next move. In other terms, the button works !
                currentPlayer = Player.X;               //For this 'if' class it belongs to player x to make sure each character knows what it is supposed to be doing.
                buttons[index].Text = currentPlayer.ToString(); //When restarting the game, everything goes back to the original state, including the points
                                                                //except for the board that is showed at the top of the game. 
                buttons[index].BackColor = Color.Purple;//This colors the character x during the game and throughout.

                buttons.RemoveAt(index); //When restarting the game, the character x will remove itself and start fresh - Except for the point board.
                CheckGame();             //Activating the code above and making sure everything moves to how it has been designed to do, restart and place the characters.
                CPUwatch.Stop();
                waitingforcpu = false;//Stopping the CPUwatch allows the character to stop activating buttons when the game and the player O has finished selecting.

            } //All the code in the class of CPUmove is all effecting the characters and buttons when it is the antagonist's turn to make a move
        }


        private void PlayerClickButton(object sender, EventArgs e)
        {
            if
                (!waitingforcpu)
            {

                var button = (Button)sender;

                currentPlayer = Player.O;
                button.Text = currentPlayer.ToString();

                button.Enabled = false;
                button.BackColor = Color.LightBlue;
                buttons.Remove(button);

                CheckGame();
                CPUwatch.Start();
                waitingforcpu = true;
            }
        } //Everything in the PlayerClickButton class is the exact same code for the CPU. 

        private void CheckGame()
        {

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button6.Text == "O" && button5.Text == "O" && button4.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button7.Text == "O" //This code here allows the studio to know what makes the player O win the game.
                || button3.Text == "O" && button4.Text == "O" && button7.Text == "O" //Otherwise the player will either always or never win.
                )
            {
                CPUwatch.Stop();
                MessageBox.Show("YOU MADE IT SOLDIER", "Commander Comments"); //If the player O wins then they will receive this comment on the left.
                playerWinCount++;
                label1.Text = "" + playerWinCount; //This recognises the count update and will change the scoreboard and add 1 point per win.
                RestartGame(); //Makes the game start from the beginning except for the point system 
            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button6.Text == "X" && button5.Text == "X" && button4.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button6.Text == "X" && button9.Text == "X" //Exactly the same as above.
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button7.Text == "X"
                || button3.Text == "X" && button4.Text == "X" && button7.Text == "X"
                )
            {
                CPUwatch.Stop();
                MessageBox.Show("...", "Commander Left"); //This comment will be received to the player if they lose a round.
                CPUWinCount++;
                label2.Text = "" + CPUWinCount;
                RestartGame();
            }
        }
        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5,
                button6, button7, button8, button9 }; //Buttons from 1-9 are the only buttons to be used in game for the characters to take place.

            foreach (Button x in buttons) //this means every button in the perimeters of 1-9
            {
                x.Enabled = true; //This allows the player to SELECT a button 

                x.Text = ""; //Nothing will be displayed in each button when a character has not selected a button.

                x.BackColor = DefaultBackColor;  //The colour is similar to white. A basic background to identify the lining of each square and not
                                                 // to confuse the player where the buttons are placed for those who are colour blinded.

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) // this is the player O's profile picture
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) // this is the player X's profile picture
        {

        }
    }




}