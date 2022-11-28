namespace YAHTZEE
{
    public partial class Form1 : Form
    {
        Dice dice1=new Dice();
        Dice dice2=new Dice();
        Dice dice3=new Dice();
        Dice dice4=new Dice();
        Dice dice5=new Dice();
        Dice dice6=new Dice();

        private bool firstPlayerTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void rollDicebutton_Click(object sender, EventArgs e)
        {

            GameControl.buttonRollCounter++;
            if (GameControl.buttonRollCounter % 4 == 0)
            {
                GameControl.thirdRoll = true;
                rollDicebutton.BackColor = Color.Red;
            }

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

            if (firstPlayerTurn)
            {
                
                GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

                if (onesResultLabel.Text=="")
                {
                    onesResultLabel.Text = GameControl.OnesToSixesCalculationResult(1).ToString();
                }

                GameControl.DiceRollReset(player1Label,player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                          holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

                if (player2OnesResult.Text !="")
                {
                    onesCalculationButton.Enabled = false;
                    onesCalculationButton.BackColor = Color.Red;
                }
                // player1Label.BackColor = Color.Ivory;
                //player1Label.BackColor = Color.Gold;
            }
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
                player1Label.BackColor = Color.Ivory;
                player2Label.BackColor = Color.Gold;

                firstPlayerTurn = false; 
            }

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
            int onesResult = int.Parse(onesResultLabel.Text);
            int twosResult = int.Parse(twosResultLabel.Text);
            int threesResult = int.Parse(threesResultLabel.Text);
            int foursResult = int.Parse(foursResultLabel.Text);
            int fivesResult = int.Parse(fivesResultLabel.Text);
            int sixesResult = int.Parse(sixesResultLabel.Text);

            smallGameResult = onesResult + twosResult + threesResult + foursResult + fivesResult + sixesResult;
            sumResultLabel.Text = smallGameResult.ToString();

            GameControl.DiceRollReset(player1Label, player2Label, dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            sumCalculationButton.Enabled = false;
            sumCalculationButton.BackColor = Color.Red;
        }

        private void bonusCalculationButton_Click(object sender, EventArgs e)
        {
            int bonusResult;

            int smallGameResult=int.Parse(sumResultLabel.Text);
            if (smallGameResult >= 63)
            {
                bonusResult = smallGameResult + 35;
                bonusResultLabel.Text = bonusResult.ToString();
            }
            else { bonusResultLabel.Text = "000"; }

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            bonusCalculationButton.Enabled = false;
            bonusCalculationButton.BackColor = Color.Red;
        }

        private void threeOfKindCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            threeOfKindResultLabel.Text = GameControl.ThreesCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            threeOfKindCalculationButton.Enabled = false;
            threeOfKindCalculationButton.BackColor = Color.Red;
        }

        private void fourOfKindCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            fourOfKindResultLabel.Text = GameControl.FourOfKindCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            fourOfKindCalculationButton.Enabled = false;
            fourOfKindCalculationButton.BackColor = Color.Red;
        }

        private void fullHouseCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            fullHouseResultLabel.Text = GameControl.FullHouseCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            fullHouseCalculationButton.Enabled = false;
            fullHouseCalculationButton.BackColor = Color.Red;
        }

        private void largeStraightCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            largeStraightResultLabel.Text = GameControl.LargeStraightCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            largeStraightCalculationButton.Enabled = false;
            largeStraightCalculationButton.BackColor = Color.Red;
        }

        private void smallStraightCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            smallStraightResultLabel.Text = GameControl.SmallStraightCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            smallStraightCalculationButton.Enabled = false;
            smallStraightCalculationButton.BackColor = Color.Red;
        }

        private void chanceCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            chanceResultLabel.Text = GameControl.ChanceCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            chanceCalculationButton.Enabled = false;
            chanceCalculationButton.BackColor = Color.Red;
        }

        private void yahtzeCalculationButton_Click(object sender, EventArgs e)
        {
            GameControl.AddDiceToList(GameControl.diceValueList, dice1, dice2, dice3, dice4, dice5);

            yahtzeResultLabel.Text = GameControl.YahtzeeCalculationResult().ToString();

            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                      holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            yahtzeCalculationButton.Enabled = false;
            yahtzeCalculationButton.BackColor = Color.Red;
        }

        private void totalScoreCalculationButton_Click(object sender, EventArgs e)
        {
            int totalScoreResult;
            int sumResult = int.Parse(sumResultLabel.Text);
            int bonusResult = int.Parse(bonusResultLabel.Text);
            int threeOfKindResult = int.Parse(threeOfKindResultLabel.Text);
            int fourOfKindResult = int.Parse(fourOfKindResultLabel.Text);
            int fullHouseResult = int.Parse(fullHouseResultLabel.Text);
            int smallStraightResult = int.Parse(smallStraightResultLabel.Text);
            int largeStraightResult = int.Parse(largeStraightResultLabel.Text);
            int chanceResult = int.Parse(chanceResultLabel.Text);
            int yahtzeeResult = int.Parse(yahtzeResultLabel.Text);

            totalScoreResult = sumResult + bonusResult + threeOfKindResult + fourOfKindResult + fullHouseResult + smallStraightResult + largeStraightResult +
                 chanceResult + yahtzeeResult;

            totalScoreResultLabel.Text = totalScoreResult.ToString();


            GameControl.DiceRollReset(player1Label, player2Label,dice1, dice2, dice3, dice4, dice5, dice6, rollDicebutton, holdDice1Button,
                     holdDice2Button, holdDice3Button, holdDice4Button, holdDice5Button);

            totalScoreCalculationButton.Enabled = false;
            totalScoreCalculationButton.BackColor = Color.Red;
        }

        
    }
}


           
    
