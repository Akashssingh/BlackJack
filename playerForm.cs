using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Group 19 - Justina Le and Akash Singh

namespace G19BlackJack
{
    public partial class playerForm : Form
    {
        bool betSet = false;
        int playerSeed = 999; //default seed value
        int betVal = 0; //intial value of bet
        int totalVal = 100; //intial value of total

        //intialize all cards and num is the index of cards
        aCard[] playerCards = new aCard[11];
        aCard[] dealerCards = new aCard[11];
        int numPlayerCards = 0;
        int numDealerCards = 0;

        //initialize points to 0
        int playerPoints = 0;
        int dealerPoints = 0;

        //global aShoe variable
        aShoe shoe;
    
        //creating an array of images of size [13][4] to look up images
        System.Drawing.Image[,] resources = new System.Drawing.Image[,] { 
            {BlackJackAkash.Properties.Resources.AH, BlackJackAkash.Properties.Resources.AD, BlackJackAkash.Properties.Resources.AC, BlackJackAkash.Properties.Resources.AS},
            {BlackJackAkash.Properties.Resources._2H, BlackJackAkash.Properties.Resources._2D, BlackJackAkash.Properties.Resources._2C, BlackJackAkash.Properties.Resources._2S},
            {BlackJackAkash.Properties.Resources._3H, BlackJackAkash.Properties.Resources._3D, BlackJackAkash.Properties.Resources._3C, BlackJackAkash.Properties.Resources._3S},
            {BlackJackAkash.Properties.Resources._4H, BlackJackAkash.Properties.Resources._4D, BlackJackAkash.Properties.Resources._4C, BlackJackAkash.Properties.Resources._4S},
            {BlackJackAkash.Properties.Resources._5H, BlackJackAkash.Properties.Resources._5D, BlackJackAkash.Properties.Resources._5C, BlackJackAkash.Properties.Resources._5S},
            {BlackJackAkash.Properties.Resources._6H, BlackJackAkash.Properties.Resources._6D, BlackJackAkash.Properties.Resources._6C, BlackJackAkash.Properties.Resources._6S},
            {BlackJackAkash.Properties.Resources._7H, BlackJackAkash.Properties.Resources._7D, BlackJackAkash.Properties.Resources._7C, BlackJackAkash.Properties.Resources._7S},
            {BlackJackAkash.Properties.Resources._8H, BlackJackAkash.Properties.Resources._8D, BlackJackAkash.Properties.Resources._8C, BlackJackAkash.Properties.Resources._8S},
            {BlackJackAkash.Properties.Resources._9H, BlackJackAkash.Properties.Resources._9D, BlackJackAkash.Properties.Resources._9C, BlackJackAkash.Properties.Resources._9S},
            {BlackJackAkash.Properties.Resources._10H, BlackJackAkash.Properties.Resources._10D, BlackJackAkash.Properties.Resources._10C, BlackJackAkash.Properties.Resources._10S},
            {BlackJackAkash.Properties.Resources.JH, BlackJackAkash.Properties.Resources.JD, BlackJackAkash.Properties.Resources.JC, BlackJackAkash.Properties.Resources.JS},
            {BlackJackAkash.Properties.Resources.QH, BlackJackAkash.Properties.Resources.QD, BlackJackAkash.Properties.Resources.QC, BlackJackAkash.Properties.Resources.QS},
            {BlackJackAkash.Properties.Resources.KH, BlackJackAkash.Properties.Resources.KD, BlackJackAkash.Properties.Resources.KC, BlackJackAkash.Properties.Resources.KS}
        };
        System.Drawing.Image emptyImg = BlackJackAkash.Properties.Resources._null;

        //these are the cards displayed on the table 
        PictureBox playerBoxes;
        PictureBox dealerBoxes;

        int playingDecks = 0;

        //keep track of Aces
        int numPlayerAces = 0;
        int numDealerAces = 0;

        public playerForm(int seed, bool mode, int numDecks)
        {
            InitializeComponent();

            //store the value of numdecks for when the player resets 
            playingDecks = numDecks;

            //set the player seed text to the value input on the startup from
            playerSeedText.Text = seed.ToString();

            //the mode of the depends on the mode passed in as a parameter where true = S17 and false = H17
            if (mode == true)
                s17PlayerRadioBtn.Checked = true;
            else
                h17PlayerRadioBtn.Checked = true;

            //intialize the shoe and shuffle cards with deck of size 52*numDecks
            shoe = new aShoe(seed, numDecks);

            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

       

        //set totalVal to value specified by user
        private void totalBox_TextChanged(object sender, EventArgs e)
        {
            totalVal = Convert.ToInt32(totalBox.Text);
        }

        //set the player and dealer card images on the table 
        private void setPlayerCard(int index)
        {
            playerBoxes = Controls["playerCard" + index.ToString()] as PictureBox;
            playerBoxes.Image = resources[playerCards[index - 1].Face-1, Convert.ToInt32(playerCards[index - 1].Suit)];
        }
        private void setDealerCard(int index)
        {
            dealerBoxes = Controls["dealerCard" + index.ToString()] as PictureBox;
            dealerBoxes.Image = resources[dealerCards[index - 1].Face-1, Convert.ToInt32(dealerCards[index - 1].Suit)];
        }

        //clear the cards on the table
        private void clearPlayerCards(int index)
        {
            
            for (int i = 1; i <= index; i++)
            {
                playerBoxes = Controls["playerCard" + i.ToString()] as PictureBox;
                playerBoxes.Image = null;
            }
        }
        private void clearDealerCards(int index)
        {

            for (int i = 1; i <= index; i++)
            {
                dealerBoxes = Controls["dealerCard" + i.ToString()] as PictureBox;
                dealerBoxes.Image = null;
            }
        }

        //update player and dealer scores
        private void updatePlayerScore(int index)
        {
            //if ace, increase score by 11 and increment numPlayerAces 
            if (playerCards[index - 1].Face == 1)
            {
                numPlayerAces += 1;
                playerPoints += 11;
            }
            else if (playerCards[index - 1].Face >= 10) //if a face value (Jack, Queen, King) add 10
                playerPoints += 10;
            else//else add the face values
                playerPoints += playerCards[index - 1].Face;
            //if points is greater than 21, check the hand for an ace and change the value to 1 
            if(playerPoints > 21)
            {
                for (int i = 0; playerPoints > 21; i++)
                {
                    //break if the player has no ace cards
                    if (i == numPlayerCards)
                        break;
                    try
                    {
                        //if the value is an ace and the you haven't changed the value of the ace before 
                        if (playerCards[i].Face == 1 && numPlayerAces > 0)
                        {
                            //set ace value to 1 instead of 11 by subtracting the value of 10 from the player points 
                            playerPoints -= 10;
                            numPlayerAces -= 1;

                            
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            //update player score in textbox
            playerPointsValue.Text = playerPoints.ToString();
        }
        private void updateDealerScore(int index)
        {
            //if ace then add 11 and increment numDealer aces 
            if (dealerCards[index - 1].Face == 1) 
            {
                dealerPoints += 11;
                numDealerAces += 1;
            }
            else if (dealerCards[index - 1].Face >= 10) //if a face value (Jack, Queen, King) add 10
                dealerPoints += 10;
            else //else add the face values 
                dealerPoints += dealerCards[index - 1].Face;

            //if points is greater than 21, check the hand for an ace and change the value to 1 
            if (dealerPoints > 21)
            {
                for (int i = 0; dealerPoints > 21; i++)
                {
                    //break if the dealer has no ace cards
                    if (i == numDealerCards)
                        break;
                    try
                    {
                        //if the value is an ace and the you haven't changed the value of the ace before 
                        if (dealerCards[i].Face == 1 && numDealerAces > 0)
                        {
                            //set ace value to 1 instead of 11 by subtracting the value of 10 from the player points 
                            dealerPoints -= 10;
                            numDealerAces--;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            //update dealer score in textbox
            dealerPointsValue.Text = dealerPoints.ToString();

            //cannot click the hit or stand button until the game begins 
        }

        //read for bet value
        private void betText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                betVal = Convert.ToInt32(betText.Text);
                //make sure betVal is greater than 0 before beginning the game
                if (betVal > 0)
                {
                    betSet = true;
                }
            }
            catch
            {
                if (betText.Text == "")
                {
                    betVal = 0;
                    betSet = false;
                }
            }
        }

        private void betGoButton_Click(object sender, EventArgs e)
        {
            //begin the game by hitting the go button
            if (betVal > 0 && betSet)
            {
                //once the player bets, they can no longer change the bet, total value, seed, or dealer mode
                totalBox.ReadOnly = true;
                betText.ReadOnly = true;
                playerSeedText.ReadOnly = true;
                s17PlayerRadioBtn.Enabled = false;
                h17PlayerRadioBtn.Enabled = false;
                resetButton.Enabled = false;

                //have the player draw two cards after betting and update score accordingly
                playerCards[numPlayerCards++] = shoe.Draw();
                setPlayerCard(numPlayerCards);
                updatePlayerScore(numPlayerCards);

                playerCards[numPlayerCards++] = shoe.Draw();
                setPlayerCard(numPlayerCards);
                updatePlayerScore(numPlayerCards);

                //have the dealer draw a card after the player and update score accordingly
                dealerCards[numDealerCards++] = shoe.Draw();
                setDealerCard(numDealerCards);
                updateDealerScore(numDealerCards);
                betSet = false;
                hitButton.Enabled = true;
                standButton.Enabled = true;
            }
        }

        //when the player hits the hit button, they draw another card but when their points are greater than 21, then they bust 
        private void hitButton_Click(object sender, EventArgs e)
        {
            if (betVal > 0)
            {
                //when the player hits, they draw another card 
                playerCards[numPlayerCards++] = shoe.Draw();
                setPlayerCard(numPlayerCards);
                updatePlayerScore(numPlayerCards);
                if (playerPoints > 21)
                {
                    //player has busted, can no longer hit, and loses their bet value 
                    roundResultText.Text = "BUST";
                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    earnings(false);
                    resetButton.Enabled = true;
                }
            }
        }
        private void standButton_Click(object sender, EventArgs e)
        {
            //disable the hit button
            hitButton.Enabled = false;
            standButton.Enabled = false;
            //have the dealer draw their cards
            dealerDraws();
        }

        //dealer draws after hitting stand or busting
        private void dealerDraws()
        {
            //if soft17, the dealer stands on 17
            if (s17PlayerRadioBtn.Checked)
            {
                while (dealerPoints < 17)
                {
                    if (dealerPoints == 17)
                    {
                        break;
                    }
                    else
                    {
                        dealerCards[numDealerCards++] = shoe.Draw();
                        setDealerCard(numDealerCards);
                        updateDealerScore(numDealerCards);
                    }
                }
            }
            //if hard17, the dealer hits on 17
            else if(h17PlayerRadioBtn.Checked)
            {
                while (dealerPoints <= 17)
                {
                    dealerCards[numDealerCards++] = shoe.Draw();
                    setDealerCard(numDealerCards);
                    updateDealerScore(numDealerCards);
                }
            }
            //determine the winner based on their points
            Winner(dealerPoints, playerPoints);
            resetButton.Enabled = true;
        }

        //returns 1 if player is the winner, 0 if it is a tie, and -1 if the dealer won
        void Winner(int dealerpts, int playerpts)
        {
            if ((dealerpts > 21 && playerpts <= 21)) //if the player wins because the dealer busted but the player did not bust
            {
                earnings(true);
                roundResultText.Text = "Win";
            }
            else if (dealerpts <= 21 && playerpts <= 21)
            {
                if (dealerpts > playerpts) //dealer has higher score so player loses
                {
                    earnings(false);
                    roundResultText.Text = "Lose";
                }
                else if (playerpts > dealerpts) //player has higher score so dealer loses
                {
                    earnings(true);
                    roundResultText.Text = "Win";
                }
                else //if (playerpts == dealerpts)
                {
                    //if both are at 21, the one with a natural blackjack wins 
                    if (playerpts == 21 && numPlayerAces == 1 && numPlayerCards == 2) //the player has an ace and a card that adds to 10 so the player wins
                    {
                        earnings(true);
                        roundResultText.Text = "Win";
                    }
                    else if (dealerpts == 21 && numDealerAces == 1 && numDealerCards == 2) //the dealer has an ace and a card that adds to 10 so the dealer wins
                    {
                        earnings(false);
                        roundResultText.Text = "Lose";
                    }
                    else //they are tied and the player loses; this also covers if both are 21 but neither have a natural black jack
                    {
                        earnings(false);
                        roundResultText.Text = "Tie";
                    }

                }
            }
            else if (dealerpts < 21 && playerpts > 21) //if the player loses and busted
            {
                earnings(false);
                roundResultText.Text = "BUST";
            }
            else if((dealerpts > 21 && playerpts > 21) || dealerpts == playerpts) //both lose (tie)
            {
                earnings(false);
                roundResultText.Text = "Tie";
            }
        }

        //earnings for the player 
        void earnings(bool updateVal)
        {
            if (updateVal)
            {
                totalVal += (betVal * 3 / 2);
                updateLabel.ForeColor = System.Drawing.Color.LawnGreen;
                updateLabel.Text = "+" + (betVal * 3 / 2).ToString();
            }
            else
            {
                totalVal -= betVal;
                updateLabel.ForeColor = System.Drawing.Color.Red;
                updateLabel.Text = "-" + betVal.ToString();
            }
            totalBox.Text = totalVal.ToString();
            betVal = 0;
            betText.Text = betVal.ToString();
            betGoButton.Enabled = false;
        }

        private void mainWinSeedLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playerSeedLabel_Click(object sender, EventArgs e)
        {

        }

        //store the value if the player changes the seed
        private void playerSeedText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                playerSeed = int.Parse(playerSeedText.Text);
            }
            catch
            {
                //if the user enters an empty string or characters then the seed default is 999
                playerSeed = 999;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //re-enable all features
            roundResultText.Text = "";
            betGoButton.Enabled = true;
            betText.ReadOnly = false;
            s17PlayerRadioBtn.Enabled = true;
            h17PlayerRadioBtn.Enabled = true;
            hitButton.Enabled = true;
            standButton.Enabled = true;
            playerSeedText.ReadOnly = false;
            betSet = false;
            clearPlayerCards(numPlayerCards);
            clearDealerCards(numDealerCards);
            numPlayerCards = 0;
            numDealerCards = 0;
            playerPoints = 0;
            playerPointsValue.Text = playerPoints.ToString();
            dealerPoints = 0;
            dealerPointsValue.Text = dealerPoints.ToString();
            numPlayerAces = 0;
            numDealerAces = 0;
            Array.Clear(playerCards, 0, 11);
            Array.Clear(dealerCards, 0, 11);
            updateLabel.Text = "";
            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (s17PlayerRadioBtn.Checked)
            {
                playerForm newPlayerForm = new playerForm(playerSeed, true, playingDecks);
                newPlayerForm.ShowDialog();
            }
            else if (h17PlayerRadioBtn.Checked)
            {
                playerForm newPlayerForm = new playerForm(playerSeed, false, playingDecks);
                newPlayerForm.ShowDialog();
            }
        }

        
    }
}
