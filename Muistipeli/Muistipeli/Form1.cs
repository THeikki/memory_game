using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form1 : Form
    {
        List<Button> levelButtons = new List<Button>();
        List<Button> lockedButtons = new List<Button>();
        List<int> levelNumbers = new List<int>();

        bool isFirstPress = true;
        int movesTaken = 0;
        int level1Pairs = 3;
        int level2Pairs = 10;
        int level3Pairs = 21;
        int difficulty;
        object guess1;
        object guess2;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            restartButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /**********************************************************************************/
        /*  Print number of pairs left at start */
        /**********************************************************************************/
        public void PrintNumberOfPairsAtStart()
        {
            if(difficulty == 1)
            {
                textBox2.Visible = true;
                textBox2.Text = "Pareja jäljellä " + level1Pairs;
            }
            else if (difficulty == 2)
            {
                textBox2.Visible = true;
                textBox2.Text = "Pareja jäljellä " + level2Pairs;
            }
            else if (difficulty == 3)
            {
                textBox2.Visible = true;
                textBox2.Text = "Pareja jäljellä " + level3Pairs;
            }
        }
        /**********************************************************************************/
        /*  Setup buttons depending on difficulty level */
        /**********************************************************************************/
        public void SetupLevel1Buttons()
        {
            levelButtons.Add(button1);
            levelButtons.Add(button2);
            levelButtons.Add(button3);
            levelButtons.Add(button4);
            levelButtons.Add(button5);
            levelButtons.Add(button6);
        }
        public void SetupLevel2Buttons()
        {
            levelButtons.Add(button7);
            levelButtons.Add(button8);
            levelButtons.Add(button9);
            levelButtons.Add(button10);
            levelButtons.Add(button11);
            levelButtons.Add(button12);
            levelButtons.Add(button13);
            levelButtons.Add(button14);
            levelButtons.Add(button15);
            levelButtons.Add(button16);
            levelButtons.Add(button17);
            levelButtons.Add(button18);
            levelButtons.Add(button19);
            levelButtons.Add(button20);
            levelButtons.Add(button21);
            levelButtons.Add(button22);
            levelButtons.Add(button23);
            levelButtons.Add(button24);
            levelButtons.Add(button25);
            levelButtons.Add(button26);
        }
        public void SetupLevel3Buttons()
        {
            levelButtons.Add(button27);
            levelButtons.Add(button28);
            levelButtons.Add(button29);
            levelButtons.Add(button30);
            levelButtons.Add(button31);
            levelButtons.Add(button32);
            levelButtons.Add(button33);
            levelButtons.Add(button34);
            levelButtons.Add(button35);
            levelButtons.Add(button36);
            levelButtons.Add(button37);
            levelButtons.Add(button38);
            levelButtons.Add(button39);
            levelButtons.Add(button40);
            levelButtons.Add(button41);
            levelButtons.Add(button42);
            levelButtons.Add(button43);
            levelButtons.Add(button44);
            levelButtons.Add(button45);
            levelButtons.Add(button46);
            levelButtons.Add(button47);
            levelButtons.Add(button48);
            levelButtons.Add(button49);
            levelButtons.Add(button50);
            levelButtons.Add(button51);
            levelButtons.Add(button52);
            levelButtons.Add(button53);
            levelButtons.Add(button54);
            levelButtons.Add(button55);
            levelButtons.Add(button56);
            levelButtons.Add(button57);
            levelButtons.Add(button58);
            levelButtons.Add(button59);
            levelButtons.Add(button60);
            levelButtons.Add(button61);
            levelButtons.Add(button62);
            levelButtons.Add(button63);
            levelButtons.Add(button64);
            levelButtons.Add(button65);
            levelButtons.Add(button66);
            levelButtons.Add(button67);
            levelButtons.Add(button68);
        }
        /**********************************************************************************/
        /*  Give prompts to user    */
        /**********************************************************************************/
        public void PrintFirstprompt()
        {
            textBox1.Text = "Valitse 1. ruutu.";
        }
        public void PrintSecondprompt()
        {
            textBox1.Text = "Valitse 2. ruutu.";
        }
        /**********************************************************************************/
        /*  Get random numbers  */
        /**********************************************************************************/
        public void GetRandomNumbersForLevel1()
        {
            int num1 = 0, num2 = 0, num3 = 0;
            int number;
            Random rnd = new Random();
         
            for (int i = 0; i < 6; i++)
            {
                number = rnd.Next(1, 4);
                if (number == 1 && num1 != 2)
                {
                    levelNumbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    levelNumbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    levelNumbers.Add(number);
                    num3++;
                }
                else
                {
                    i--;
                }
            }
            SetupLevel1Buttons();        
        }
        public void GetRandomNumbersForLevel2()
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0 , num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0;
            int number;
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                number = rnd.Next(1, 11);
                if (number == 1 && num1 != 2)
                {
                    levelNumbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    levelNumbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    levelNumbers.Add(number);
                    num3++;
                }
                else if (number == 4 && num4 != 2)
                {
                    levelNumbers.Add(number);
                    num4++;
                }
                else if (number ==5 && num5 != 2)
                {
                    levelNumbers.Add(number);
                    num5++;
                }
                else if (number == 6 && num6 != 2)
                {
                    levelNumbers.Add(number);
                    num6++;
                }
                else if (number == 7 && num7 != 2)
                {
                    levelNumbers.Add(number);
                    num7++;
                }
                else if (number == 8 && num8 != 2)
                {
                    levelNumbers.Add(number);
                    num8++;
                }
                else if (number == 9 && num9 != 2)
                {
                    levelNumbers.Add(number);
                    num9++;
                }
                else if (number == 10 && num10 != 2)
                {
                    levelNumbers.Add(number);
                    num10++;
                }
                else
                {
                    i--;
                }
            }
            SetupLevel2Buttons();        
        }
        public void GetRandomNumbersForLevel3()
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0,
                num11 = 0, num12 = 0, num13 = 0, num14 = 0, num15 = 0, num16 = 0, num17 = 0, num18 = 0, num19 = 0, num20 = 0, num21 = 0;
            int number;
            Random rnd = new Random();

            for (int i = 0; i < 42; i++)
            {
                number = rnd.Next(1, 22);
                if (number == 1 && num1 != 2)
                {
                    levelNumbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    levelNumbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    levelNumbers.Add(number);
                    num3++;
                }
                else if (number == 4 && num4 != 2)
                {
                    levelNumbers.Add(number);
                    num4++;
                }
                else if (number == 5 && num5 != 2)
                {
                    levelNumbers.Add(number);
                    num5++;
                }
                else if (number == 6 && num6 != 2)
                {
                    levelNumbers.Add(number);
                    num6++;
                }
                else if (number == 7 && num7 != 2)
                {
                    levelNumbers.Add(number);
                    num7++;
                }
                else if (number == 8 && num8 != 2)
                {
                    levelNumbers.Add(number);
                    num8++;
                }
                else if (number == 9 && num9 != 2)
                {
                    levelNumbers.Add(number);
                    num9++;
                }
                else if (number == 10 && num10 != 2)
                {
                    levelNumbers.Add(number);
                    num10++;
                }
                else if (number == 11 && num11 != 2)
                {
                    levelNumbers.Add(number);
                    num11++;
                }
                else if (number == 12 && num12 != 2)
                {
                    levelNumbers.Add(number);
                    num12++;
                }
                else if (number == 13 && num13 != 2)
                {
                    levelNumbers.Add(number);
                    num13++;
                }
                else if (number == 14 && num14 != 2)
                {
                    levelNumbers.Add(number);
                    num14++;
                }
                else if (number == 15 && num15 != 2)
                {
                    levelNumbers.Add(number);
                    num15++;
                }
                else if (number == 16 && num16 != 2)
                {
                    levelNumbers.Add(number);
                    num16++;
                }
                else if (number == 17 && num17 != 2)
                {
                    levelNumbers.Add(number);
                    num17++;
                }
                else if (number == 18 && num18 != 2)
                {
                    levelNumbers.Add(number);
                    num18++;
                }
                else if (number == 19 && num19 != 2)
                {
                    levelNumbers.Add(number);
                    num19++;
                }
                else if (number == 20 && num20 != 2)
                {
                    levelNumbers.Add(number);
                    num20++;
                }
                else if (number == 21 && num21 != 2)
                {
                    levelNumbers.Add(number);
                    num21++;
                }
                else
                {
                    i--;
                }
            }
            SetupLevel3Buttons();
        }
        /**********************************************************************************/
        /*  Button clicks Handle    */
        /**********************************************************************************/
        private void restartButton_Click(object sender, EventArgs e)
        {
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void easyButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
            restartButton.Visible = true;
            PrintFirstprompt();
            difficulty = 1;
            GetRandomNumbersForLevel1();
            PrintNumberOfPairsAtStart();
        }
        private void averageButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
            restartButton.Visible = true;
            PrintFirstprompt();
            difficulty = 2;
            GetRandomNumbersForLevel2();
            PrintNumberOfPairsAtStart();
        }
        private void hardButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
            restartButton.Visible = true;
            PrintFirstprompt();
            difficulty = 3;
            GetRandomNumbersForLevel3();
            PrintNumberOfPairsAtStart();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            textBox3.Text = "";
            Button button = sender as Button;
            if (isFirstPress)
            {
                if (difficulty == 1)
                {
                    switch (button.Name)
                    {
                        case "button1":
                            button1.Text = levelNumbers[0].ToString();
                            break;
                        case "button2":
                            button2.Text = levelNumbers[1].ToString();
                            break;
                        case "button3":
                            button3.Text = levelNumbers[2].ToString();
                            break;
                        case "button4":
                            button4.Text = levelNumbers[3].ToString();
                            break;
                        case "button5":
                            button5.Text = levelNumbers[4].ToString();
                            break;
                        case "button6":
                            button6.Text = levelNumbers[5].ToString();
                            break;
                    }
                }
                else if (difficulty == 2)
                {
                    switch (button.Name)
                    {
                        case "button7":
                            button7.Text = levelNumbers[0].ToString();
                            break;
                        case "button8":
                            button8.Text = levelNumbers[1].ToString();
                            break;
                        case "button9":
                            button9.Text = levelNumbers[2].ToString();
                            break;
                        case "button10":
                            button10.Text = levelNumbers[3].ToString();
                            break;
                        case "button11":
                            button11.Text = levelNumbers[4].ToString();
                            break;
                        case "button12":
                            button12.Text = levelNumbers[5].ToString();
                            break;
                        case "button13":
                            button13.Text = levelNumbers[6].ToString();
                            break;
                        case "button14":
                            button14.Text = levelNumbers[7].ToString();
                            break;
                        case "button15":
                            button15.Text = levelNumbers[8].ToString();
                            break;
                        case "button16":
                            button16.Text = levelNumbers[9].ToString();
                            break;
                        case "button17":
                            button17.Text = levelNumbers[10].ToString();
                            break;
                        case "button18":
                            button18.Text = levelNumbers[11].ToString();
                            break;
                        case "button19":
                            button19.Text = levelNumbers[12].ToString();
                            break;
                        case "button20":
                            button20.Text = levelNumbers[13].ToString();
                            break;
                        case "button21":
                            button21.Text = levelNumbers[14].ToString();
                            break;
                        case "button22":
                            button22.Text = levelNumbers[15].ToString();
                            break;
                        case "button23":
                            button23.Text = levelNumbers[16].ToString();
                            break;
                        case "button24":
                            button24.Text = levelNumbers[17].ToString();
                            break;
                        case "button25":
                            button25.Text = levelNumbers[18].ToString();
                            break;
                        case "button26":
                            button26.Text = levelNumbers[19].ToString();
                            break;
                    }
                }
                else if (difficulty == 3)
                {
                    switch (button.Name)
                    {
                        case "button27":
                            button27.Text = levelNumbers[0].ToString();
                            break;
                        case "button28":
                            button28.Text = levelNumbers[1].ToString();
                            break;
                        case "button29":
                            button29.Text = levelNumbers[2].ToString();
                            break;
                        case "button30":
                            button30.Text = levelNumbers[3].ToString();
                            break;
                        case "button31":
                            button31.Text = levelNumbers[4].ToString();
                            break;
                        case "button32":
                            button32.Text = levelNumbers[5].ToString();
                            break;
                        case "button33":
                            button33.Text = levelNumbers[6].ToString();
                            break;
                        case "button34":
                            button34.Text = levelNumbers[7].ToString();
                            break;
                        case "button35":
                            button35.Text = levelNumbers[8].ToString();
                            break;
                        case "button36":
                            button36.Text = levelNumbers[9].ToString();
                            break;
                        case "button37":
                            button37.Text = levelNumbers[10].ToString();
                            break;
                        case "button38":
                            button38.Text = levelNumbers[11].ToString();
                            break;
                        case "button39":
                            button39.Text = levelNumbers[12].ToString();
                            break;
                        case "button40":
                            button40.Text = levelNumbers[13].ToString();
                            break;
                        case "button41":
                            button41.Text = levelNumbers[14].ToString();
                            break;
                        case "button42":
                            button42.Text = levelNumbers[15].ToString();
                            break;
                        case "button43":
                            button43.Text = levelNumbers[16].ToString();
                            break;
                        case "button44":
                            button44.Text = levelNumbers[17].ToString();
                            break;
                        case "button45":
                            button45.Text = levelNumbers[18].ToString();
                            break;
                        case "button46":
                            button46.Text = levelNumbers[19].ToString();
                            break;
                        case "button47":
                            button47.Text = levelNumbers[20].ToString();
                            break;
                        case "button48":
                            button48.Text = levelNumbers[21].ToString();
                            break;
                        case "button49":
                            button49.Text = levelNumbers[22].ToString();
                            break;
                        case "button50":
                            button50.Text = levelNumbers[23].ToString();
                            break;
                        case "button51":
                            button51.Text = levelNumbers[24].ToString();
                            break;
                        case "button52":
                            button52.Text = levelNumbers[25].ToString();
                            break;
                        case "button53":
                            button53.Text = levelNumbers[26].ToString();
                            break;
                        case "button54":
                            button54.Text = levelNumbers[27].ToString();
                            break;
                        case "button55":
                            button55.Text = levelNumbers[28].ToString();
                            break;
                        case "button56":
                            button56.Text = levelNumbers[29].ToString();
                            break;
                        case "button57":
                            button57.Text = levelNumbers[30].ToString();
                            break;
                        case "button58":
                            button58.Text = levelNumbers[31].ToString();
                            break;
                        case "button59":
                            button59.Text = levelNumbers[32].ToString();
                            break;
                        case "button60":
                            button60.Text = levelNumbers[33].ToString();
                            break;
                        case "button61":
                            button61.Text = levelNumbers[34].ToString();
                            break;
                        case "button62":
                            button62.Text = levelNumbers[35].ToString();
                            break;
                        case "button63":
                            button63.Text = levelNumbers[36].ToString();
                            break;
                        case "button64":
                            button64.Text = levelNumbers[37].ToString();
                            break;
                        case "button65":
                            button65.Text = levelNumbers[38].ToString();
                            break;
                        case "button66":
                            button66.Text = levelNumbers[39].ToString();
                            break;
                        case "button67":
                            button67.Text = levelNumbers[40].ToString();
                            break;
                        case "button68":
                            button68.Text = levelNumbers[41].ToString();
                            break;
                    }
                }
                guess1 = button.Text;
                lockedButtons.Add(button);
                lockedButtons[0].Enabled = false;
                isFirstPress = false;
                PrintSecondprompt();
            }
            else
            {
                ButtonClick2(button, e);
            }
        }
        private void ButtonClick2(object sender, EventArgs e)
        {
            Button buttonX = sender as Button;
            if (difficulty == 1)
            {
                switch (buttonX.Name)
                {
                    case "button1":
                        button1.Text = levelNumbers[0].ToString();
                        break;
                    case "button2":
                        button2.Text = levelNumbers[1].ToString();
                        break;
                    case "button3":
                        button3.Text = levelNumbers[2].ToString();
                        break;
                    case "button4":
                        button4.Text = levelNumbers[3].ToString();
                        break;
                    case "button5":
                        button5.Text = levelNumbers[4].ToString();
                        break;
                    case "button6":
                        button6.Text = levelNumbers[5].ToString();
                        break;
                }
            }
            else if (difficulty == 2)
            {
                switch (buttonX.Name)
                {
                    case "button7":
                        button7.Text = levelNumbers[0].ToString();
                        break;
                    case "button8":
                        button8.Text = levelNumbers[1].ToString();
                        break;
                    case "button9":
                        button9.Text = levelNumbers[2].ToString();
                        break;
                    case "button10":
                        button10.Text = levelNumbers[3].ToString();
                        break;
                    case "button11":
                        button11.Text = levelNumbers[4].ToString();
                        break;
                    case "button12":
                        button12.Text = levelNumbers[5].ToString();
                        break;
                    case "button13":
                        button13.Text = levelNumbers[6].ToString();
                        break;
                    case "button14":
                        button14.Text = levelNumbers[7].ToString();
                        break;
                    case "button15":
                        button15.Text = levelNumbers[8].ToString();
                        break;
                    case "button16":
                        button16.Text = levelNumbers[9].ToString();
                        break;
                    case "button17":
                        button17.Text = levelNumbers[10].ToString();
                        break;
                    case "button18":
                        button18.Text = levelNumbers[11].ToString();
                        break;
                    case "button19":
                        button19.Text = levelNumbers[12].ToString();
                        break;
                    case "button20":
                        button20.Text = levelNumbers[13].ToString();
                        break;
                    case "button21":
                        button21.Text = levelNumbers[14].ToString();
                        break;
                    case "button22":
                        button22.Text = levelNumbers[15].ToString();
                        break;
                    case "button23":
                        button23.Text = levelNumbers[16].ToString();
                        break;
                    case "button24":
                        button24.Text = levelNumbers[17].ToString();
                        break;
                    case "button25":
                        button25.Text = levelNumbers[18].ToString();
                        break;
                    case "button26":
                        button26.Text = levelNumbers[19].ToString();
                        break;
                }
            }
            else if (difficulty == 3)
            {
                switch (buttonX.Name)
                {
                    case "button27":
                        button27.Text = levelNumbers[0].ToString();
                        break;
                    case "button28":
                        button28.Text = levelNumbers[1].ToString();
                        break;
                    case "button29":
                        button29.Text = levelNumbers[2].ToString();
                        break;
                    case "button30":
                        button30.Text = levelNumbers[3].ToString();
                        break;
                    case "button31":
                        button31.Text = levelNumbers[4].ToString();
                        break;
                    case "button32":
                        button32.Text = levelNumbers[5].ToString();
                        break;
                    case "button33":
                        button33.Text = levelNumbers[6].ToString();
                        break;
                    case "button34":
                        button34.Text = levelNumbers[7].ToString();
                        break;
                    case "button35":
                        button35.Text = levelNumbers[8].ToString();
                        break;
                    case "button36":
                        button36.Text = levelNumbers[9].ToString();
                        break;
                    case "button37":
                        button37.Text = levelNumbers[10].ToString();
                        break;
                    case "button38":
                        button38.Text = levelNumbers[11].ToString();
                        break;
                    case "button39":
                        button39.Text = levelNumbers[12].ToString();
                        break;
                    case "button40":
                        button40.Text = levelNumbers[13].ToString();
                        break;
                    case "button41":
                        button41.Text = levelNumbers[14].ToString();
                        break;
                    case "button42":
                        button42.Text = levelNumbers[15].ToString();
                        break;
                    case "button43":
                        button43.Text = levelNumbers[16].ToString();
                        break;
                    case "button44":
                        button44.Text = levelNumbers[17].ToString();
                        break;
                    case "button45":
                        button45.Text = levelNumbers[18].ToString();
                        break;
                    case "button46":
                        button46.Text = levelNumbers[19].ToString();
                        break;
                    case "button47":
                        button47.Text = levelNumbers[20].ToString();
                        break;
                    case "button48":
                        button48.Text = levelNumbers[21].ToString();
                        break;
                    case "button49":
                        button49.Text = levelNumbers[22].ToString();
                        break;
                    case "button50":
                        button50.Text = levelNumbers[23].ToString();
                        break;
                    case "button51":
                        button51.Text = levelNumbers[24].ToString();
                        break;
                    case "button52":
                        button52.Text = levelNumbers[25].ToString();
                        break;
                    case "button53":
                        button53.Text = levelNumbers[26].ToString();
                        break;
                    case "button54":
                        button54.Text = levelNumbers[27].ToString();
                        break;
                    case "button55":
                        button55.Text = levelNumbers[28].ToString();
                        break;
                    case "button56":
                        button56.Text = levelNumbers[29].ToString();
                        break;
                    case "button57":
                        button57.Text = levelNumbers[30].ToString();
                        break;
                    case "button58":
                        button58.Text = levelNumbers[31].ToString();
                        break;
                    case "button59":
                        button59.Text = levelNumbers[32].ToString();
                        break;
                    case "button60":
                        button60.Text = levelNumbers[33].ToString();
                        break;
                    case "button61":
                        button61.Text = levelNumbers[34].ToString();
                        break;
                    case "button62":
                        button62.Text = levelNumbers[35].ToString();
                        break;
                    case "button63":
                        button63.Text = levelNumbers[36].ToString();
                        break;
                    case "button64":
                        button64.Text = levelNumbers[37].ToString();
                        break;
                    case "button65":
                        button65.Text = levelNumbers[38].ToString();
                        break;
                    case "button66":
                        button66.Text = levelNumbers[39].ToString();
                        break;
                    case "button67":
                        button67.Text = levelNumbers[40].ToString();
                        break;
                    case "button68":
                        button68.Text = levelNumbers[41].ToString();
                        break;
                }
            }
            guess2 = buttonX.Text;
            lockedButtons.Add(buttonX);
            lockedButtons[1].Enabled = false;
            isFirstPress = true;
            CheckIfBlocksMatches(guess1, guess2);
        }
        /**********************************************************************************/
        /*  Game events handling    */
        /**********************************************************************************/
        private async void DisableButtons()
        {
            if(difficulty == 1)
            {
                panel1.Enabled = false;
                await Task.Delay(2020);
                panel1.Enabled = true;
            }
            else if (difficulty == 2)
            {
                panel2.Enabled = false;
                await Task.Delay(2020);
                panel2.Enabled = true;
            }
            else if (difficulty == 3)
            {
                panel3.Enabled = false;
                await Task.Delay(2020);
                panel3.Enabled = true;
            }
        }
        
        private void CheckIfPlayerHasWon()
        {
            if (difficulty == 1)
            {
                if (level1Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "VAIKEUSTASO 1 SUORITETTU!" + "\r\n\r\n\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
            else if (difficulty == 2)
            {
                if (level2Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "VAIKEUSTASO 2 SUORITETTU!" + "\r\n\r\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
            else if (difficulty == 3)
            {
                if (level3Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "VAIKEUSTASO 3 SUORITETTU!" + "\r\n\r\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
            PrintFirstprompt();
        }

        private void CheckIfBlocksMatches(object guess1, object guess2)
        {
            if (difficulty == 1)
            {
                if (guess1.ToString() == guess2.ToString())
                {
                    level1Pairs--;
                    for (int i = 0; i < levelButtons.Count; i++)
                    {
                        if (lockedButtons.Contains(levelButtons[i]))
                        {
                            levelButtons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    DisableButtons();
                    System.Threading.Thread.Sleep(2000);
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    lockedButtons[0].Text = "";
                    lockedButtons[1].Text = "";
                }
                movesTaken++;
                lockedButtons.Clear();
                textBox2.Text = "Pareja jäljellä " + level1Pairs;
            }
            else if (difficulty == 2)
            {
                if (guess1.ToString() == guess2.ToString())
                {
                    level2Pairs--;
                    for (int i = 0; i < levelButtons.Count; i++)
                    {
                        if (lockedButtons.Contains(levelButtons[i]))
                        {
                            levelButtons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    DisableButtons();
                    System.Threading.Thread.Sleep(2000);
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    lockedButtons[0].Text = "";
                    lockedButtons[1].Text = "";
                }
                movesTaken++;
                lockedButtons.Clear();
                textBox2.Text = "Pareja jäljellä " + level2Pairs;
            }
            else if (difficulty == 3)
            {
                if (guess1.ToString() == guess2.ToString())
                {
                    level3Pairs--;
                    for (int i = 0; i < levelButtons.Count; i++)
                    {
                        if (lockedButtons.Contains(levelButtons[i]))
                        {
                            levelButtons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    DisableButtons();
                    System.Threading.Thread.Sleep(2000);
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    lockedButtons[0].Text = "";
                    lockedButtons[1].Text = "";
                }
                movesTaken++;
                lockedButtons.Clear();
                textBox2.Text = "Pareja jäljellä " + level3Pairs;
            }
            CheckIfPlayerHasWon();
        }
    }
}
