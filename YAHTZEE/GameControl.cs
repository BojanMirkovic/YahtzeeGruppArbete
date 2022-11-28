using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEE
{
    internal class GameControl
    {
       public static int diceHoldCounter = 0;
       public static int buttonRollCounter=0;
       public static bool thirdRoll=false;

       public static bool holdButtonIsPressed=false;

        public static List<int> diceValueList = new List<int>();





        public static void DiceRollReset(Dice dice1, Dice dice2, Dice dice3, Dice dice4,Dice dice5, Dice dice6,
                             Button rollButton,Button hold1,Button hold2,Button hold3,Button hold4,Button hold5)
        {
            GameControl.thirdRoll = false;
            rollButton.BackColor = Color.Gold;
            GameControl.buttonRollCounter = 0;
            GameControl.holdButtonIsPressed = false;

            dice1.diceHold = false;
            dice2.diceHold = false;
            dice3.diceHold = false;
            dice4.diceHold = false;
            dice5.diceHold = false;
           
            

            hold1.BackColor = Color.Gold;
            hold2.BackColor = Color.Gold;
            hold3.BackColor = Color.Gold;
            hold4.BackColor = Color.Gold;
            hold5.BackColor = Color.Gold;

            diceValueList.Clear();
            

            ////////////////////////////////////////////////////////////

           
        }
        public static void HoldDice(Dice diceName,Button holdDiceNameButton)
        {  

            
            diceHoldCounter++;
            
            if (diceHoldCounter % 2 != 0)
            {
                GameControl.holdButtonIsPressed = true;
            }
            else { GameControl.holdButtonIsPressed = false; }


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

        public static void AddDiceToList(List<int> diceList, Dice dice1, Dice dice2, Dice dice3, Dice dice4, Dice dice5) 
        {
            diceList.Add(dice1.rollValue);
            diceList.Add(dice2.rollValue);
            diceList.Add(dice3.rollValue);
            diceList.Add(dice4.rollValue);
            diceList.Add(dice5.rollValue);
        }
        public static int OnesToSixesCalculationResult(int diceValue)
        {
            int diceValueTotal = 0;
            //List<int> brojevi = new List<int> { 1, 3, 5, 1, 1, 1, 1 };
            foreach (var number in diceValueList)
            {
                if (number == diceValue)
                {
                    diceValueTotal = diceValueTotal + number;
                }
            }
            return diceValueTotal
;        }
      
        public static int ThreesCalculationResult()
        {
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

            
            if ((diceValueList[0] == diceValueList[1]) && (diceValueList[1] == diceValueList[2]) || (diceValueList[1] == diceValueList[2]) && (diceValueList[2] == diceValueList[3]) || (diceValueList[2] == diceValueList[3]) && (diceValueList[3] == diceValueList[4]))
            {
                foreach (var diceValue in diceValueList)
                {
                    if (diceValue==valueOneOfThreeDice)
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
        public static int FourOfKindCalculationResult()
        {

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
        public static int FullHouseCalculationResult()
        {
            int fullHouseTotal = 0;

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
        public static int LargeStraightCalculationResult()
        {
            int largeStraightTotal = 0;

            
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

        public static int SmallStraightCalculationResult()
        {
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
        public static int ChanceCalculationResult()
        {
            int chanceTotal = 0;
            diceValueList.Sort();
            chanceTotal=diceValueList.Sum();
            return chanceTotal;
        }
        public static int YahtzeeCalculationResult()
        {
            int yahtzeeTotal = 0;


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


