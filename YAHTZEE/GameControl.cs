using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEE
{
    internal class GameControl
    {
        //counting how many times hold button is pressed,so we know if it is OFF or ON
       private static int diceHoldCounter = 0;
        //Counting number of rolls,we can have max 3 rolls per player
       public static int buttonRollCounter=0;
        //Determing if we had reach 3 roll
       public static bool thirdRoll=false;
        //Determin if the hold button is pressed
       private static bool holdButtonIsPressed=false;
        //List to save values of all five dice
       public static List<int> diceValueList = new List<int>();



        //Method to reset dice roll Button so we could start with new sesion for new player
        public static void DiceRollReset(Label player1,Label player2,Dice dice1, Dice dice2, Dice dice3, Dice dice4,Dice dice5, Dice dice6,
                             Button rollButton,Button hold1,Button hold2,Button hold3,Button hold4,Button hold5)
        {
            //reset 3 roll info
            GameControl.thirdRoll = false;
            //reset button color to original value
            rollButton.BackColor = Color.Gold;
            //reset counter to 0
            GameControl.buttonRollCounter = 0;
            //reset hold button info
            GameControl.holdButtonIsPressed = false;
            //change the player 1 label color to Gold,Gold represent player on hold
            player1.BackColor = Color.Gold;
            //change player 2 label color to Ivory,Ivory represent activ player at the moment
            player2.BackColor = Color.Ivory;
            //reset dice info before next roll
            dice1.diceHold = false;
            dice2.diceHold = false;
            dice3.diceHold = false;
            dice4.diceHold = false;
            dice5.diceHold = false;
           
            
            //reset hold button color,Gold is original color(not pressed button)
            hold1.BackColor = Color.Gold;
            hold2.BackColor = Color.Gold;
            hold3.BackColor = Color.Gold;
            hold4.BackColor = Color.Gold;
            hold5.BackColor = Color.Gold;
            //Clear the list so we could set new roll dice value in to it
            diceValueList.Clear();
           
        }

        //Method to determin if certain dice is put on hold for next roll
        public static void HoldDice(Dice diceName,Button holdDiceNameButton)
        {  

            //adding number of hold button clicks so we could determin if it is Off or On
            diceHoldCounter++;
           //Checking if player has made first roll
            if (buttonRollCounter>0)
            {   //checking to see if the hold button is activ or not,1 activ(button is pressed), 0 not activ
                if (diceHoldCounter % 2 != 0)
                {
                    GameControl.holdButtonIsPressed = true;
                }
                else { GameControl.holdButtonIsPressed = false; }

                //if hold button is pressed,color is change and dice status is changed
                if (GameControl.holdButtonIsPressed == true)
                {
                    diceName.diceHold = true;
                    holdDiceNameButton.BackColor = Color.Red;
                }
                else
                {
                    diceName.diceHold = false;
                    holdDiceNameButton.BackColor = Color.Gold;
                }
            }






        }

        //Adding dice values for each dice in to the List 
        public static void AddDiceToList(List<int> diceList, Dice dice1, Dice dice2, Dice dice3, Dice dice4, Dice dice5) 
        {
            // checking if at least one Roll was made
            if (buttonRollCounter>0)
            {
                diceList.Add(dice1.rollValue);
                diceList.Add(dice2.rollValue);
                diceList.Add(dice3.rollValue);
                diceList.Add(dice4.rollValue);
                diceList.Add(dice5.rollValue);
            }
        }

       //Calculating method for ones,twos,threes,fours,fives and sixes by using int parametar for each individual calculation 
        public static int OnesToSixesCalculationResult(int diceValue)
        {
            //determin variabel to store total value of particular dice value
            int diceValueTotal = 0;
            //Check if we have that particular dice valu in our List and if we have it add and return diceValueTotal
            foreach (var number in diceValueList)
            {
                if (number == diceValue)
                {
                    diceValueTotal = diceValueTotal + number;
                }
            }
            return diceValueTotal
;        }

       //Calculation method for three of kind,same three dices plus two diferent  
        public static int ThreesCalculationResult()
        {// variables to help us with calculation 
            int sameDiceValue = 0;
            int diferentDiceValue = 0;
            int totalDiceValue = 0;
         // holds the value of one of thres same dice values
            int valueOneOfThreeDice = 0;
         // count how many ones,twos...sixes have we in that particular roll
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
         // we sort the List with dice values
            diceValueList.Sort();
            // we check for each dice value in List,count how many we have with same dice value and
            //  determin exact value one of three dice
            foreach (var diceValue in diceValueList )
            {
                if (diceValue==1)
                {
                    count1++;
                    if (count1 > 2)
                    {
                        valueOneOfThreeDice = 1;
                    }
                }
                else if (diceValue == 2)
                {
                    count2++;
                    if (count2 > 2)
                    {
                        valueOneOfThreeDice = 2;
                    }
                }
                else if (diceValue == 3)
                {
                    count3++;
                    if (count3 > 2)
                    {
                        valueOneOfThreeDice = 3;
                    }
                }
                else if (diceValue == 4)
                {
                    count4++;
                    if (count4 > 2)
                    {
                        valueOneOfThreeDice = 4;
                    }
                }
                else if (diceValue == 5)
                {
                    count5++;
                    if (count5 > 2)
                    {
                        valueOneOfThreeDice = 5;
                    }
                }
                else if (diceValue == 6)
                {
                    count6++;
                    if (count6 > 2)
                    {
                        valueOneOfThreeDice = 6;
                    }
                }

            }

         //check if we have same three dice in the List 
            if ((diceValueList[0] == diceValueList[1]) && (diceValueList[1] == diceValueList[2]) || (diceValueList[1] == diceValueList[2]) && (diceValueList[2] == diceValueList[3]) || (diceValueList[2] == diceValueList[3]) && (diceValueList[3] == diceValueList[4]))
            {  // loop thrue the list and add dices with same dice value
                foreach (var diceValue in diceValueList)
                { // check to add only if we have three same dice and add them
                    if (diceValue==valueOneOfThreeDice)
                    {
                        sameDiceValue = sameDiceValue + diceValue;
                    }
                }
                // check for remaining two dices with diferent dice value and add them
                foreach (var diceValue in diceValueList)
                {
                    if (diceValue != valueOneOfThreeDice)
                    {
                        diferentDiceValue = diferentDiceValue + diceValue;
                    }
                }
                //finaly add all dice values and return totalDiceValue on the end
                totalDiceValue = sameDiceValue + diferentDiceValue;
            }
            //if we dont have three dices with same value in this roll 
            else 
            {
                totalDiceValue = 0;
            }

            return totalDiceValue;


        }

        //Calculation method for four of a kind,four dices with same value plus one diferent
        public static int FourOfKindCalculationResult()
        {
            // Everything is the same as i ThreesCalculationResult() just in thes case we are going to check if
            // we have 4 dices vith same dice value
            int sameDiceValue = 0;
            int diferentDiceValue = 0;
            int totalDiceValue = 0;

            int valueOneOfThreeDice = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            diceValueList.Sort();

            foreach (var diceValue in diceValueList)
            {
                if (diceValue == 1)
                {
                    //checking if we have more than 3 same dice values
                    count1++;
                    if (count1 > 3)
                    {
                        valueOneOfThreeDice = 1;
                    }
                }
                else if (diceValue == 2)
                {
                    count2++;
                    if (count2 > 3)
                    {
                        valueOneOfThreeDice = 2;
                    }
                }
                else if (diceValue == 3)
                {
                    count3++;
                    if (count3 > 3)
                    {
                        valueOneOfThreeDice = 3;
                    }
                }
                else if (diceValue == 4)
                {
                    count4++;
                    if (count4 > 3)
                    {
                        valueOneOfThreeDice = 4;
                    }
                }
                else if (diceValue == 5)
                {
                    count5++;
                    if (count5 > 3)
                    {
                        valueOneOfThreeDice = 5;
                    }
                }
                else if (diceValue == 6)
                {
                    count6++;
                    if (count6 > 3)
                    {
                        valueOneOfThreeDice = 6;
                    }
                }

            }

            //check for condition, we should have four dices with same dice values
            if (count1==4|| count2 == 4 || count3 == 4 || count4 == 4 || count5 == 4 || count6 == 4)
            {
                foreach (var diceValue in diceValueList)
                {
                    if (diceValue == valueOneOfThreeDice)
                    {
                        sameDiceValue = sameDiceValue + diceValue;
                    }
                }
                foreach (var diceValue in diceValueList)
                {
                    if (diceValue != valueOneOfThreeDice)
                    {
                        diferentDiceValue = diferentDiceValue + diceValue;
                    }
                }

                totalDiceValue = sameDiceValue + diferentDiceValue;
            }
            else
            {
                totalDiceValue = 0;
            }

            return totalDiceValue;


        }

        //Calculation method for full house,three dices with same value plus two dices with same value
        public static int FullHouseCalculationResult()
        {
         // variabel to store full house value
            int fullHouseTotal = 0;
          
         //  variabel count shows how many dices of same dice value we have,for each of 6 dice combination
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
         //Sorting the list of dice values
            diceValueList.Sort();
         //determin the number of dices with same values
            foreach (var diceValue in diceValueList)
            {
                if (diceValue == 1)
                {
                    count1++;
                   
                }
                else if (diceValue == 2)
                {
                    count2++;
                    
                }
                else if (diceValue == 3)
                {
                    count3++;
                    
                }
                else if (diceValue == 4)
                {
                    count4++;
                    
                }
                else if (diceValue == 5)
                {
                    count5++;
                   
                }
                else if (diceValue == 6)
                {
                    count6++;
                   
                }

            }

         // check for condition if we have three same dices plus two same dices and return full house result
            if ((count1 == 3 || count2 == 3 || count3 == 3 || count4 == 3 || count5 == 3 || count6 == 3)&& (count1 == 2 || count2 == 2 || count3 == 2 || count4 == 2 || count5 == 2 || count6 == 2))
            {
                fullHouseTotal = 25;
            }
            else
            {
                fullHouseTotal = 0;
            }

            return fullHouseTotal;

        }

        //Calculation method for Large straight,five dices med dice valu from 1-5 or 2-6
        public static int LargeStraightCalculationResult()
        {
            int largeStraightTotal = 0;

            // same counters like i previous method
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            diceValueList.Sort();

            foreach (var diceValue in diceValueList)
            {
                if (diceValue == 1)
                {
                    count1++;

                }
                else if (diceValue == 2)
                {
                    count2++;

                }
                else if (diceValue == 3)
                {
                    count3++;

                }
                else if (diceValue == 4)
                {
                    count4++;

                }
                else if (diceValue == 5)
                {
                    count5++;

                }
                else if (diceValue == 6)
                {
                    count6++;

                }

            }

         //cheking fof straight combination 1,2,3,4,5 or 2,3,4,5,6
            if ((count1 == 1 && count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1) || (count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1 && count6 == 1))
            {
                largeStraightTotal=40;
            }
            else
            {
                largeStraightTotal = 0;
            }

            return largeStraightTotal;
        }

        //Calculation method for Small straight,four dices med dice valu from 1-4 or 2-5 or 3-6
        public static int SmallStraightCalculationResult()
        {
            // Everything is the same like i largestraight method just a diferent check out
            int smallStraightTotal = 0;


            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            diceValueList.Sort();

            foreach (var diceValue in diceValueList)
            {
                if (diceValue == 1)
                {
                    count1++;

                }
                else if (diceValue == 2)
                {
                    count2++;

                }
                else if (diceValue == 3)
                {
                    count3++;

                }
                else if (diceValue == 4)
                {
                    count4++;

                }
                else if (diceValue == 5)
                {
                    count5++;

                }
                else if (diceValue == 6)
                {
                    count6++;

                }

            }

            // checking for small staright combination and returning small straight result
            if ((count1 >= 1 && count2 >= 1 && count3 >= 1 && count4 >= 1) || (count2 >= 1 && count3 >= 1 && count4 >= 1 && count5 >= 1) || (count3 >= 1 && count4 >= 1 && count5 >= 1 && count6 >= 1))
            {
                smallStraightTotal = 35;
            }
            else
            {
                smallStraightTotal = 0;
            }

            return smallStraightTotal;
        }

        // Calculation method for Chance,total value of all five dices
        public static int ChanceCalculationResult()
        {//variabel to store chance result
            int chanceTotal = 0;
            // sorting the list with Sort()
            diceValueList.Sort();
            //Adding value of all dicese(dice values) from the List with help of Sum()
            chanceTotal=diceValueList.Sum();
            // return chance result
            return chanceTotal;
        }

        //Calculation method for Yahtzee,five dices with same dice valu
        public static int YahtzeeCalculationResult()
        {
            int yahtzeeTotal;

            // same as in previus methods determin number of same dices
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            // sort the List
            diceValueList.Sort();
            //check for dice values
            foreach (var diceValue in diceValueList)
            {
                if (diceValue == 1)
                {
                    count1++;

                }
                else if (diceValue == 2)
                {
                    count2++;

                }
                else if (diceValue == 3)
                {
                    count3++;

                }
                else if (diceValue == 4)
                {
                    count4++;

                }
                else if (diceValue == 5)
                {
                    count5++;

                }
                else if (diceValue == 6)
                {
                    count6++;

                }

            }

            // check for yahtzee condition,we must have 5 dices with same dice value and if we have return result
            if (count1 == 5 || count2 == 5 || count3 == 5 || count4 == 5 || count5 == 5 || count6==5)
            {
                yahtzeeTotal = 50;
            }
            else
            {
                yahtzeeTotal = 0;
            }

            return yahtzeeTotal;
        }

        




    }
    }


