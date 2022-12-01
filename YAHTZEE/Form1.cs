using System.Drawing.Text;

namespace YAHTZEE
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        private Label[] labels;
        //creating an insatnce of Dice class,which we are going to use in this game
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();
        Dice dice3 = new Dice();
        Dice dice4 = new Dice();
        Dice dice5 = new Dice();
        Dice dice6 = new Dice();

        // Determin if is player 1 turn to act
        private bool firstPlayerTurn = true;
        public Form1()
        {
            
            InitializeComponent();
            //Save ref to all buttons inside buttons
            buttons = new Button[] {rollDicebutton,holdDice1Button,holdDice2Button,holdDice3Button,holdDice4Button,holdDice5Button,
            onesCalculationButton,twosCalculationButton,threesCalculationButton,foursCalculationButton,fivesCalculationButton,sixesCalculationButton,
            sumCalculationButton,bonusCalculationButton,threeOfKindCalculationButton,fourOfKindCalculationButton,fullHouseCalculationButton,
            smallStraightCalculationButton,largeStraightCalculationButton,chanceCalculationButton,yahtzeCalculationButton,totalScoreCalculationButton};
            //Save ref to all labels inside labels
            labels = new Label[] { onesResultLabel,twosResultLabel,threesResultLabel,foursResultLabel,fivesResultLabel,sixesResultLabel,
            sumResultLabel,bonusResultLabel,threeOfKindResultLabel,fourOfKindResultLabel,fullHouseResultLabel,
            smallStraightResultLabel,largeStraightResultLabel,chanceResultLabel,yahtzeResultLabel,totalScoreResultLabel,
                player2OnesResult,player2TwosResult,player2ThreesResult,player2FoursResult,player2FivesResult,player2SixesResult,
            player2SumResult,player2BonusResult,player2ThreeOfKindResult,player2FourOfKindResult,player2FullHouseResult,
            player2SmallStraightResult,player2LargeStraightResult,player2ChanceResult,player2YahtzeResult,player2TotalScoreResult,gameWinerLabel};
        }

        
        private void rollDicebutton_Click(object sender, EventArgs e)
        {
            //when we click on the button counter increase for one
            GameControl.buttonRollCounter++;
            //check for roll number,max 3 roll per player
            if (GameControl.buttonRollCounter % 4 == 0)
            {
                GameControl.thirdRoll = true;
                rollDicebutton.BackColor = Color.Red;
            }
            //checking if the roll is still valid,and for each dice individualy assigns dice image 
            //for that particular dice roll value
            if (GameControl.thirdRoll == false)
            {
                if (dice1.diceHold == false)
                {
                    dice1.rollValue = dice1.dice.Next(1, 7);
                }
                if (dice2.diceHold == false)
                {
                    dice2.rollValue = dice2.dice.Next(1, 7);
                }
                if (dice3.diceHold == false)
                {
                    dice3.rollValue = dice3.dice.Next(1, 7);
                }
                if (dice4.diceHold == false)
                {
                    dice4.rollValue = dice4.dice.Next(1, 7);
                }
                if (dice5.diceHold == false)
                {
                    dice5.rollValue = dice5.dice.Next(1, 7);
                }
                if (dice6.diceHold == false)
                {
                    dice6.rollValue = dice6.dice.Next(1, 7);
                }
            }
            switch (dice1.rollValue)
            {
                case 1:
                    dice1PictureBox.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    dice1PictureBox.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    dice1PictureBox.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    dice1PictureBox.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    dice1PictureBox.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    dice1PictureBox.Image = Properties.Resources.dice_6;
                    break;

                default:
                    break;
            }
            switch (dice2.rollValue)
            {
                case 1:
                    dice2PictureBox.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    dice2PictureBox.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    dice2PictureBox.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    dice2PictureBox.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    dice2PictureBox.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    dice2PictureBox.Image = Properties.Resources.dice_6;
                    break;

                default:
                    break;
            }
            switch (dice3.rollValue)
            {
                case 1:
                    dice3PictureBox.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    dice3PictureBox.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    dice3PictureBox.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    dice3PictureBox.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    dice3PictureBox.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    dice3PictureBox.Image = Properties.Resources.dice_6;
                    break;

                default:
                    break;
            }
            switch (dice4.rollValue)
            {
                case 1:
                    dice4PictureBox.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    dice4PictureBox.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    dice4PictureBox.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    dice4PictureBox.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    dice4PictureBox.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    dice4PictureBox.Image = Properties.Resources.dice_6;
                    break;

                default:
                    break;
            }
            switch (dice5.rollValue)
            {
                case 1:
                    dice5PictureBox.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    dice5PictureBox.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    dice5PictureBox.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    dice5PictureBox.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    dice5PictureBox.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    dice5PictureBox.Image = Properties.Resources.dice_6;
                    break;

                default:
                    break;
            }

            

            

           
        }
        private void holdDice1Button_Click(object sender, EventArgs e)
        {
            //coling for HoldDice(),we are pasing parametars for that particular dice and
            //bool for that dice button
            GameControl.HoldDice(dice1, holdDice1Button);
        }

        private void holdDice2Button_Click(object sender, EventArgs e)
        {
             GameControl.HoldDice(dice2, holdDice2Button);
        }

        private void holdDice3Button_Click(object sender, EventArgs e)
        {
            GameControl.HoldDice(dice3, holdDice3Button);
        }

        private void holdDice4Button_Click(object sender, EventArgs e)
        {
            GameControl.HoldDice(dice4, holdDice4Button);
        }

        private void holdDice5Button_Click(object sender, EventArgs e)
        {
            GameControl.HoldDice(dice5, holdDice5Button);
        }



        private void onesCalculationButton_Click(object sender, EventArgs e)
        {
            //determin whos turn to play is...game starts with Player 1 turn!
            if (firstPlayerTurn)
            {
                //we have already made a roll,now we can add dice values to the list
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);
                //check if we already have something in this label,we can only have one enter per game
                if (onesResultLabel.Text=="")
                { // Calulate desired combination if we want total of ones pass number 1 as diceValue
                  // and convert to string 
                    onesResultLabel.Text = GameControl.OnesToSixesCalculationResult(1).ToString();
                }
                //Reset all dices with DiceRollRest() so you can start new roll
                GameControl.DiceRollReset(player1Label,player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);
                // When bouth players are finish disable button and change color to red
                if (player2OnesResult.Text !="")
                {
                    onesCalculationButton.Enabled = false;
                    onesCalculationButton.BackColor = Color.Red;
                }
               
            }
            //same as above just on the end we swap the players
            else
            {
               
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2OnesResult.Text=="")
                {
                    player2OnesResult.Text = GameControl.OnesToSixesCalculationResult(1).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (onesResultLabel.Text!="")
                {
                    onesCalculationButton.Enabled = false;
                    onesCalculationButton.BackColor = Color.Red;
                }
                //Swap the players color, Ivory indicate curent player
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;
                //player one is finished
                firstPlayerTurn = false; 
            }
            //Swap the players turn
            firstPlayerTurn = !firstPlayerTurn;
            
        }
        private void twosCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (twosResultLabel.Text == "")
                {
                    twosResultLabel.Text = GameControl.OnesToSixesCalculationResult(2).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2TwosResult.Text != "")
                {
                    twosCalculationButton.Enabled = false;
                    twosCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2TwosResult.Text == "")
                {
                    player2TwosResult.Text = GameControl.OnesToSixesCalculationResult(2).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (twosResultLabel.Text != "")
                {
                    twosCalculationButton.Enabled = false;
                    twosCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void threesCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (threesResultLabel.Text == "")
                {
                    threesResultLabel.Text = GameControl.OnesToSixesCalculationResult(3).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2ThreesResult.Text != "")
                {
                    threesCalculationButton.Enabled = false;
                    threesCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2ThreesResult.Text == "")
                {
                    player2ThreesResult.Text = GameControl.OnesToSixesCalculationResult(3).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (threesResultLabel.Text != "")
                {
                    threesCalculationButton.Enabled = false;
                    threesCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void FoursCalculationButton_Click(object sender, EventArgs e)
        {


            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (foursResultLabel.Text == "")
                {
                    foursResultLabel.Text = GameControl.OnesToSixesCalculationResult(4).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2FoursResult.Text != "")
                {
                    foursCalculationButton.Enabled = false;
                    foursCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2FoursResult.Text == "")
                {
                    player2FoursResult.Text = GameControl.OnesToSixesCalculationResult(4).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (foursResultLabel.Text != "")
                {
                    foursCalculationButton.Enabled = false;
                    foursCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;

        }

        private void fivesCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (fivesResultLabel.Text == "")
                {
                    fivesResultLabel.Text = GameControl.OnesToSixesCalculationResult(5).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2FivesResult.Text != "")
                {
                    fivesCalculationButton.Enabled = false;
                    fivesCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2FivesResult.Text == "")
                {
                    player2FivesResult.Text = GameControl.OnesToSixesCalculationResult(5).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (fivesResultLabel.Text != "")
                {
                    fivesCalculationButton.Enabled = false;
                    fivesCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void SixesCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (sixesResultLabel.Text == "")
                {
                    sixesResultLabel.Text = GameControl.OnesToSixesCalculationResult(6).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2SixesResult.Text != "")
                {
                    sixesCalculationButton.Enabled = false;
                    sixesCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2SixesResult.Text == "")
                {
                    player2SixesResult.Text = GameControl.OnesToSixesCalculationResult(6).ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (sixesResultLabel.Text != "")
                {
                    sixesCalculationButton.Enabled = false;
                    sixesCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void sumCalculationButton_Click(object sender, EventArgs e)
        {
            int smallGameResult;
            int player2SmallGameResult;
         //check if all small game results are filled in and if not total sum will be 0
          if (onesResultLabel.Text != "" && twosResultLabel.Text != "" && threesResultLabel.Text != "" && foursResultLabel.Text != "" &&
              fivesResultLabel.Text != "" && sixesResultLabel.Text != "" && player2OnesResult.Text != "" && player2TwosResult.Text != ""
              && player2ThreesResult.Text != "" && player2FoursResult.Text != "" && player2FivesResult.Text != "" && player2SixesResult.Text != "")
          { 
            //convert string result value to int so we could calculate all
            int onesResult = int.Parse(onesResultLabel.Text);
            int twosResult = int.Parse(twosResultLabel.Text);
            int threesResult = int.Parse(threesResultLabel.Text);
            int foursResult = int.Parse(foursResultLabel.Text);
            int fivesResult = int.Parse(fivesResultLabel.Text);
            int sixesResult = int.Parse(sixesResultLabel.Text);

            int player2onesResult = int.Parse(player2OnesResult.Text);
            int player2twosResult = int.Parse(player2TwosResult.Text);
            int player2threesResult = int.Parse(player2ThreesResult.Text);
            int player2foursResult = int.Parse(player2FoursResult.Text);
            int player2fivesResult = int.Parse(player2FivesResult.Text);
            int player2sixesResult = int.Parse(player2SixesResult.Text);

            
            
                smallGameResult = onesResult + twosResult + threesResult + foursResult + fivesResult + sixesResult;
                sumResultLabel.Text = smallGameResult.ToString();

                player2SmallGameResult = player2onesResult + player2twosResult + player2threesResult + player2foursResult + player2fivesResult + player2sixesResult;
                player2SumResult.Text = player2SmallGameResult.ToString();

          }
          else
          {
                smallGameResult = 0;
                player2SmallGameResult = 0;
          }
            GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            sumCalculationButton.Enabled = false;
            sumCalculationButton.BackColor = Color.Red;
        }

        private void bonusCalculationButton_Click(object sender, EventArgs e)
        {
            int bonusResult;
            int player2bonusResult;

            int smallGameResult=int.Parse(sumResultLabel.Text);
            if (smallGameResult >= 63)
            {
                bonusResult = smallGameResult + 35;
                bonusResultLabel.Text = bonusResult.ToString();
            }
            else { bonusResultLabel.Text = "000"; }

            int player2SmallGameResult = int.Parse(player2SumResult.Text);
            if (player2SmallGameResult >= 63)
            {
                player2bonusResult = player2SmallGameResult + 35;
                player2BonusResult.Text = player2bonusResult.ToString();
            }
            else { player2BonusResult.Text = "000"; }

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            bonusCalculationButton.Enabled = false;
            bonusCalculationButton.BackColor = Color.Red;
        }

        private void threeOfKindCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (threeOfKindResultLabel.Text=="")
                {
                    threeOfKindResultLabel.Text = GameControl.ThreesCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2ThreeOfKindResult.Text != "")
                {
                    threeOfKindCalculationButton.Enabled = false;
                    threeOfKindCalculationButton.BackColor = Color.Red;
                }
               
            }
            else
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2ThreeOfKindResult.Text == "")
                {
                    player2ThreeOfKindResult.Text = GameControl.ThreesCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (threeOfKindResultLabel.Text != "")
                {
                    threeOfKindCalculationButton.Enabled = false;
                    threeOfKindCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }
    

        private void fourOfKindCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (fourOfKindResultLabel.Text == "")
                {
                    fourOfKindResultLabel.Text = GameControl.FourOfKindCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2FourOfKindResult.Text != "")
                {
                    fourOfKindCalculationButton.Enabled = false;
                    fourOfKindCalculationButton.BackColor = Color.Red;
                }

            }
            else
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2FourOfKindResult.Text == "")
                {
                    player2FourOfKindResult.Text = GameControl.FourOfKindCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (fourOfKindResultLabel.Text != "")
                {
                    fourOfKindCalculationButton.Enabled = false;
                    fourOfKindCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void fullHouseCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (fullHouseResultLabel.Text == "")
                {
                    fullHouseResultLabel.Text = GameControl.FullHouseCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2FullHouseResult.Text != "")
                {
                    fullHouseCalculationButton.Enabled = false;
                    fullHouseCalculationButton.BackColor = Color.Red;
                }

            }
            else
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2FullHouseResult.Text == "")
                {
                    player2FullHouseResult.Text = GameControl.FullHouseCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (fullHouseResultLabel.Text != "")
                {
                    fullHouseCalculationButton.Enabled = false;
                    fullHouseCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void largeStraightCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (largeStraightResultLabel.Text == "")
                {
                    largeStraightResultLabel.Text = GameControl.LargeStraightCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2LargeStraightResult.Text != "")
                {
                    largeStraightCalculationButton.Enabled = false;
                    largeStraightCalculationButton.BackColor = Color.Red;
                }

            }
            else
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2LargeStraightResult.Text == "")
                {
                    player2LargeStraightResult.Text = GameControl.LargeStraightCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (largeStraightResultLabel.Text != "")
                {
                    largeStraightCalculationButton.Enabled = false;
                    largeStraightCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void smallStraightCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (smallStraightResultLabel.Text == "")
                {
                    smallStraightResultLabel.Text = GameControl.SmallStraightCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2SmallStraightResult.Text != "")
                {
                    smallStraightCalculationButton.Enabled = false;
                    smallStraightCalculationButton.BackColor = Color.Red;
                }

            }
            else
            {
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2SmallStraightResult.Text == "")
                {
                    player2SmallStraightResult.Text = GameControl.SmallStraightCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (smallStraightResultLabel.Text != "")
                {
                    smallStraightCalculationButton.Enabled = false;
                    smallStraightCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void chanceCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (chanceResultLabel.Text == "")
                {
                    chanceResultLabel.Text = GameControl.ChanceCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2ChanceResult.Text != "")
                {
                    chanceCalculationButton.Enabled = false;
                    chanceCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2ChanceResult.Text == "")
                {
                    player2ChanceResult.Text = GameControl.ChanceCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (chanceResultLabel.Text != "")
                {
                    chanceCalculationButton.Enabled = false;
                    chanceCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void yahtzeCalculationButton_Click(object sender, EventArgs e)
        {
            if (firstPlayerTurn)
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (yahtzeResultLabel.Text == "")
                {
                    yahtzeResultLabel.Text = GameControl.YahtzeeCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2YahtzeResult.Text != "")
                {
                    yahtzeCalculationButton.Enabled = false;
                    yahtzeCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
            else
            {

                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (player2YahtzeResult.Text == "")
                {
                    player2YahtzeResult.Text = GameControl.YahtzeeCalculationResult().ToString();
                }

                GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (yahtzeResultLabel.Text != "")
                {
                    yahtzeCalculationButton.Enabled = false;
                    yahtzeCalculationButton.BackColor = Color.Red;
                }
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false;
            }

            firstPlayerTurn = !firstPlayerTurn;
        }

        private void totalScoreCalculationButton_Click(object sender, EventArgs e)
        {
            int totalScoreResult;
            int player2totalScoreResult;
          //checking all result labels,all results must be filled in
            if (sumResultLabel.Text!=""&& bonusResultLabel.Text!=""&& threeOfKindResultLabel.Text!=""&& fourOfKindResultLabel.Text!=""
                && fullHouseResultLabel.Text!=""&& smallStraightResultLabel.Text!=""&& largeStraightResultLabel.Text!=""
                && chanceResultLabel.Text!=""&& yahtzeResultLabel.Text!=""&& player2SumResult.Text != "" && player2BonusResult.Text != "" && player2ThreeOfKindResult.Text != "" && player2FourOfKindResult.Text != ""
                && player2FullHouseResult.Text != "" && player2SmallStraightResult.Text != "" && player2LargeStraightResult.Text != ""
                && player2ChanceResult.Text != "" && player2YahtzeResult.Text != "")
            {
                int sumResult = int.Parse(sumResultLabel.Text);
                int bonusResult = int.Parse(bonusResultLabel.Text);
                int threeOfKindResult = int.Parse(threeOfKindResultLabel.Text);
                int fourOfKindResult = int.Parse(fourOfKindResultLabel.Text);
                int fullHouseResult = int.Parse(fullHouseResultLabel.Text);
                int smallStraightResult = int.Parse(smallStraightResultLabel.Text);
                int largeStraightResult = int.Parse(largeStraightResultLabel.Text);
                int chanceResult = int.Parse(chanceResultLabel.Text);
                int yahtzeeResult = int.Parse(yahtzeResultLabel.Text);

                int player2sumResult = int.Parse(player2SumResult.Text);
                int player2bonusResult = int.Parse(player2BonusResult.Text);
                int player2threeOfKindResult = int.Parse(player2ThreeOfKindResult.Text);
                int player2fourOfKindResult = int.Parse(player2FourOfKindResult.Text);
                int player2fullHouseResult = int.Parse(player2FullHouseResult.Text);
                int player2smallStraightResult = int.Parse(player2SmallStraightResult.Text);
                int player2largeStraightResult = int.Parse(player2LargeStraightResult.Text);
                int player2chanceResult = int.Parse(player2ChanceResult.Text);
                int player2yahtzeeResult = int.Parse(player2YahtzeResult.Text);

                totalScoreResult = sumResult + bonusResult + threeOfKindResult + fourOfKindResult + fullHouseResult + smallStraightResult + largeStraightResult +
                     chanceResult + yahtzeeResult;

                player2totalScoreResult = player2sumResult + player2bonusResult + player2threeOfKindResult + player2fourOfKindResult + player2fullHouseResult + player2smallStraightResult + player2largeStraightResult +
                     player2chanceResult + player2yahtzeeResult;

                totalScoreResultLabel.Text = totalScoreResult.ToString();
                player2TotalScoreResult.Text = player2totalScoreResult.ToString();
            }
            else 
            {
                totalScoreResult = 0;
                player2totalScoreResult = 0;
            }


            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            totalScoreCalculationButton.Enabled = false;
            totalScoreCalculationButton.BackColor = Color.Red;

            if (totalScoreResult> player2totalScoreResult)
            {
                gameWinerLabel.Text = "THE WINNER IS: PLAYER 1";
            }
            else if(player2totalScoreResult>totalScoreResult)
            {
                gameWinerLabel.Text = "THE WINNER IS: PLAYER 2";
            }
            else
            {
                gameWinerLabel.Text = "NO WINNERS IN THIS GAME";
            }
        }
        
        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            //reset all buttons 
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.BackColor = Color.Gold;
            }
            //clear all results from labels
            foreach (Label label in labels)
            {
                label.Text = "";
            }
            // becouse we reset all labels we must set back to original values
            sumResultLabel.Text = "000";
            player2SumResult.Text = "000";
            bonusResultLabel.Text = "000";
            player2BonusResult.Text = "000";           
            totalScoreResultLabel.Text = "000";
            player2TotalScoreResult.Text = "000";
            
            //reset dice roll
            GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);
            //set player 1 as a first player to act
            firstPlayerTurn = true;
        }
    }
}



           
    
