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
        List<Button> level1Buttons = new List<Button>();
        List<Button> level2Buttons = new List<Button>();
        List<Button> level3Buttons = new List<Button>();
        List<Button> lockedButtons = new List<Button>();
        List<int> level1Numbers = new List<int>(6);
        List<int> level2Numbers = new List<int>(20);
        List<int> level3Numbers = new List<int>(42);

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }
        /**********************************************************************************/
        /*  Print number of pairs lewft at start */
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
            level1Buttons.Add(button1);
            level1Buttons.Add(button2);
            level1Buttons.Add(button3);
            level1Buttons.Add(button4);
            level1Buttons.Add(button5);
            level1Buttons.Add(button6);
        }
        public void SetupLevel2Buttons()
        {
            level2Buttons.Add(button7);
            level2Buttons.Add(button8);
            level2Buttons.Add(button9);
            level2Buttons.Add(button10);
            level2Buttons.Add(button11);
            level2Buttons.Add(button12);
            level2Buttons.Add(button13);
            level2Buttons.Add(button14);
            level2Buttons.Add(button15);
            level2Buttons.Add(button16);
            level2Buttons.Add(button17);
            level2Buttons.Add(button18);
            level2Buttons.Add(button19);
            level2Buttons.Add(button20);
            level2Buttons.Add(button21);
            level2Buttons.Add(button22);
            level2Buttons.Add(button23);
            level2Buttons.Add(button24);
            level2Buttons.Add(button25);
            level2Buttons.Add(button26);
        }
        public void SetupLevel3Buttons()
        {
            level3Buttons.Add(button27);
            level3Buttons.Add(button28);
            level3Buttons.Add(button29);
            level3Buttons.Add(button30);
            level3Buttons.Add(button31);
            level3Buttons.Add(button32);
            level3Buttons.Add(button33);
            level3Buttons.Add(button34);
            level3Buttons.Add(button35);
            level3Buttons.Add(button36);
            level3Buttons.Add(button37);
            level3Buttons.Add(button38);
            level3Buttons.Add(button39);
            level3Buttons.Add(button40);
            level3Buttons.Add(button41);
            level3Buttons.Add(button42);
            level3Buttons.Add(button43);
            level3Buttons.Add(button44);
            level3Buttons.Add(button45);
            level3Buttons.Add(button46);
            level3Buttons.Add(button47);
            level3Buttons.Add(button48);
            level3Buttons.Add(button49);
            level3Buttons.Add(button50);
            level3Buttons.Add(button51);
            level3Buttons.Add(button52);
            level3Buttons.Add(button53);
            level3Buttons.Add(button54);
            level3Buttons.Add(button55);
            level3Buttons.Add(button56);
            level3Buttons.Add(button57);
            level3Buttons.Add(button58);
            level3Buttons.Add(button59);
            level3Buttons.Add(button60);
            level3Buttons.Add(button61);
            level3Buttons.Add(button62);
            level3Buttons.Add(button63);
            level3Buttons.Add(button64);
            level3Buttons.Add(button65);
            level3Buttons.Add(button66);
            level3Buttons.Add(button67);
            level3Buttons.Add(button68);
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
                    level1Numbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    level1Numbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    level1Numbers.Add(number);
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
                    level2Numbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    level2Numbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    level2Numbers.Add(number);
                    num3++;
                }
                else if (number == 4 && num4 != 2)
                {
                    level2Numbers.Add(number);
                    num4++;
                }
                else if (number ==5 && num5 != 2)
                {
                    level2Numbers.Add(number);
                    num5++;
                }
                else if (number == 6 && num6 != 2)
                {
                    level2Numbers.Add(number);
                    num6++;
                }
                else if (number == 7 && num7 != 2)
                {
                    level2Numbers.Add(number);
                    num7++;
                }
                else if (number == 8 && num8 != 2)
                {
                    level2Numbers.Add(number);
                    num8++;
                }
                else if (number == 9 && num9 != 2)
                {
                    level2Numbers.Add(number);
                    num9++;
                }
                else if (number == 10 && num10 != 2)
                {
                    level2Numbers.Add(number);
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
                    level3Numbers.Add(number);
                    num1++;
                }
                else if (number == 2 && num2 != 2)
                {
                    level3Numbers.Add(number);
                    num2++;
                }
                else if (number == 3 && num3 != 2)
                {
                    level3Numbers.Add(number);
                    num3++;
                }
                else if (number == 4 && num4 != 2)
                {
                    level3Numbers.Add(number);
                    num4++;
                }
                else if (number == 5 && num5 != 2)
                {
                    level3Numbers.Add(number);
                    num5++;
                }
                else if (number == 6 && num6 != 2)
                {
                    level3Numbers.Add(number);
                    num6++;
                }
                else if (number == 7 && num7 != 2)
                {
                    level3Numbers.Add(number);
                    num7++;
                }
                else if (number == 8 && num8 != 2)
                {
                    level3Numbers.Add(number);
                    num8++;
                }
                else if (number == 9 && num9 != 2)
                {
                    level3Numbers.Add(number);
                    num9++;
                }
                else if (number == 10 && num10 != 2)
                {
                    level3Numbers.Add(number);
                    num10++;
                }
                else if (number == 11 && num11 != 2)
                {
                    level3Numbers.Add(number);
                    num11++;
                }
                else if (number == 12 && num12 != 2)
                {
                    level3Numbers.Add(number);
                    num12++;
                }
                else if (number == 13 && num13 != 2)
                {
                    level3Numbers.Add(number);
                    num13++;
                }
                else if (number == 14 && num14 != 2)
                {
                    level3Numbers.Add(number);
                    num14++;
                }
                else if (number == 15 && num15 != 2)
                {
                    level3Numbers.Add(number);
                    num15++;
                }
                else if (number == 16 && num16 != 2)
                {
                    level3Numbers.Add(number);
                    num16++;
                }
                else if (number == 17 && num17 != 2)
                {
                    level3Numbers.Add(number);
                    num17++;
                }
                else if (number == 18 && num18 != 2)
                {
                    level3Numbers.Add(number);
                    num18++;
                }
                else if (number == 19 && num19 != 2)
                {
                    level3Numbers.Add(number);
                    num19++;
                }
                else if (number == 20 && num20 != 2)
                {
                    level3Numbers.Add(number);
                    num20++;
                }
                else if (number == 21 && num21 != 2)
                {
                    level3Numbers.Add(number);
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
            PrintFirstprompt();
            easyButton.Enabled = false;
            averageButton.Enabled = false;
            hardButton.Enabled = false;
            difficulty = 1;
            GetRandomNumbersForLevel1();
            PrintNumberOfPairsAtStart();
        }
        private void averageButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            PrintFirstprompt();
            averageButton.Enabled = false;
            easyButton.Enabled = false;
            hardButton.Enabled = false;
            difficulty = 2;
            GetRandomNumbersForLevel2();
            PrintNumberOfPairsAtStart();
        }
        private void hardButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            PrintFirstprompt();
            hardButton.Enabled = false;
            averageButton.Enabled = false;
            easyButton.Enabled = false;
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
                if(difficulty == 1)
                {
                    switch (button.Name)
                    {
                        case "button1":
                            button1.Text = level1Numbers[0].ToString();
                            break;
                        case "button2":
                            button2.Text = level1Numbers[1].ToString();
                            break;
                        case "button3":
                            button3.Text = level1Numbers[2].ToString();
                            break;
                        case "button4":
                            button4.Text = level1Numbers[3].ToString();
                            break;
                        case "button5":
                            button5.Text = level1Numbers[4].ToString();
                            break;
                        case "button6":
                            button6.Text = level1Numbers[5].ToString();
                            break;
                    }
                }
                else if(difficulty == 2)
                {
                    switch (button.Name)
                    {
                        case "button7":
                            button7.Text = level2Numbers[0].ToString();
                            break;
                        case "button8":
                            button8.Text = level2Numbers[1].ToString();
                            break;
                        case "button9":
                            button9.Text = level2Numbers[2].ToString();
                            break;
                        case "button10":
                            button10.Text = level2Numbers[3].ToString();
                            break;
                        case "button11":
                            button11.Text = level2Numbers[4].ToString();
                            break;
                        case "button12":
                            button12.Text = level2Numbers[5].ToString();
                            break;
                        case "button13":
                            button13.Text = level2Numbers[6].ToString();
                            break;
                        case "button14":
                            button14.Text = level2Numbers[7].ToString();
                            break;
                        case "button15":
                            button15.Text = level2Numbers[8].ToString();
                            break;
                        case "button16":
                            button16.Text = level2Numbers[9].ToString();
                            break;
                        case "button17":
                            button17.Text = level2Numbers[10].ToString();
                            break;
                        case "button18":
                            button18.Text = level2Numbers[11].ToString();
                            break;
                        case "button19":
                            button19.Text = level2Numbers[12].ToString();
                            break;
                        case "button20":
                            button20.Text = level2Numbers[13].ToString();
                            break;
                        case "button21":
                            button21.Text = level2Numbers[14].ToString();
                            break;
                        case "button22":
                            button22.Text = level2Numbers[15].ToString();
                            break;
                        case "button23":
                            button23.Text = level2Numbers[16].ToString();
                            break;
                        case "button24":
                            button24.Text = level2Numbers[17].ToString();
                            break;
                        case "button25":
                            button25.Text = level2Numbers[18].ToString();
                            break;
                        case "button26":
                            button26.Text = level2Numbers[19].ToString();
                            break;
                    }
                }
                else if (difficulty == 3)
                {
                    switch (button.Name)
                    {
                        case "button27":
                            button27.Text = level3Numbers[0].ToString();
                            break;
                        case "button28":
                            button28.Text = level3Numbers[1].ToString();
                            break;
                        case "button29":
                            button29.Text = level3Numbers[2].ToString();
                            break;
                        case "button30":
                            button30.Text = level3Numbers[3].ToString();
                            break;
                        case "button31":
                            button31.Text = level3Numbers[4].ToString();
                            break;
                        case "button32":
                            button32.Text = level3Numbers[5].ToString();
                            break;
                        case "button33":
                            button33.Text = level3Numbers[6].ToString();
                            break;
                        case "button34":
                            button34.Text = level3Numbers[7].ToString();
                            break;
                        case "button35":
                            button35.Text = level3Numbers[8].ToString();
                            break;
                        case "button36":
                            button36.Text = level3Numbers[9].ToString();
                            break;
                        case "button37":
                            button37.Text = level3Numbers[10].ToString();
                            break;
                        case "button38":
                            button38.Text = level3Numbers[11].ToString();
                            break;
                        case "button39":
                            button39.Text = level3Numbers[12].ToString();
                            break;
                        case "button40":
                            button40.Text = level3Numbers[13].ToString();
                            break;
                        case "button41":
                            button41.Text = level3Numbers[14].ToString();
                            break;
                        case "button42":
                            button42.Text = level3Numbers[15].ToString();
                            break;
                        case "button43":
                            button43.Text = level3Numbers[16].ToString();
                            break;
                        case "button44":
                            button44.Text = level3Numbers[17].ToString();
                            break;
                        case "button45":
                            button45.Text = level3Numbers[18].ToString();
                            break;
                        case "button46":
                            button46.Text = level3Numbers[19].ToString();
                            break;
                        case "button47":
                            button47.Text = level3Numbers[20].ToString();
                            break;
                        case "button48":
                            button48.Text = level3Numbers[21].ToString();
                            break;
                        case "button49":
                            button49.Text = level3Numbers[22].ToString();
                            break;
                        case "button50":
                            button50.Text = level3Numbers[23].ToString();
                            break;
                        case "button51":
                            button51.Text = level3Numbers[24].ToString();
                            break;
                        case "button52":
                            button52.Text = level3Numbers[25].ToString();
                            break;
                        case "button53":
                            button53.Text = level3Numbers[26].ToString();
                            break;
                        case "button54":
                            button54.Text = level3Numbers[27].ToString();
                            break;
                        case "button55":
                            button55.Text = level3Numbers[28].ToString();
                            break;
                        case "button56":
                            button56.Text = level3Numbers[29].ToString();
                            break;
                        case "button57":
                            button57.Text = level3Numbers[30].ToString();
                            break;
                        case "button58":
                            button58.Text = level3Numbers[31].ToString();
                            break;
                        case "button59":
                            button59.Text = level3Numbers[32].ToString();
                            break;
                        case "button60":
                            button60.Text = level3Numbers[33].ToString();
                            break;
                        case "button61":
                            button61.Text = level3Numbers[34].ToString();
                            break;
                        case "button62":
                            button62.Text = level3Numbers[35].ToString();
                            break;
                        case "button63":
                            button63.Text = level3Numbers[36].ToString();
                            break;
                        case "button64":
                            button64.Text = level3Numbers[37].ToString();
                            break;
                        case "button65":
                            button65.Text = level3Numbers[38].ToString();
                            break;
                        case "button66":
                            button66.Text = level3Numbers[39].ToString();
                            break;
                        case "button67":
                            button67.Text = level3Numbers[40].ToString();
                            break;
                        case "button68":
                            button68.Text = level3Numbers[41].ToString();
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
            if(difficulty == 1)
            {
                switch (buttonX.Name)
                {
                    case "button1":
                        button1.Text = level1Numbers[0].ToString();
                        break;
                    case "button2":
                        button2.Text = level1Numbers[1].ToString();
                        break;
                    case "button3":
                        button3.Text = level1Numbers[2].ToString();
                        break;
                    case "button4":
                        button4.Text = level1Numbers[3].ToString();
                        break;
                    case "button5":
                        button5.Text = level1Numbers[4].ToString();
                        break;
                    case "button6":
                        button6.Text = level1Numbers[5].ToString();
                        break;
                }
            }
            else if(difficulty == 2)
            {
                switch (buttonX.Name)
                {
                    case "button7":
                        button7.Text = level2Numbers[0].ToString();
                        break;
                    case "button8":
                        button8.Text = level2Numbers[1].ToString();
                        break;
                    case "button9":
                        button9.Text = level2Numbers[2].ToString();
                        break;
                    case "button10":
                        button10.Text = level2Numbers[3].ToString();
                        break;
                    case "button11":
                        button11.Text = level2Numbers[4].ToString();
                        break;
                    case "button12":
                        button12.Text = level2Numbers[5].ToString();
                        break;
                    case "button13":
                        button13.Text = level2Numbers[6].ToString();
                        break;
                    case "button14":
                        button14.Text = level2Numbers[7].ToString();
                        break;
                    case "button15":
                        button15.Text = level2Numbers[8].ToString();
                        break;
                    case "button16":
                        button16.Text = level2Numbers[9].ToString();
                        break;
                    case "button17":
                        button17.Text = level2Numbers[10].ToString();
                        break;
                    case "button18":
                        button18.Text = level2Numbers[11].ToString();
                        break;
                    case "button19":
                        button19.Text = level2Numbers[12].ToString();
                        break;
                    case "button20":
                        button20.Text = level2Numbers[13].ToString();
                        break;
                    case "button21":
                        button21.Text = level2Numbers[14].ToString();
                        break;
                    case "button22":
                        button22.Text = level2Numbers[15].ToString();
                        break;
                    case "button23":
                        button23.Text = level2Numbers[16].ToString();
                        break;
                    case "button24":
                        button24.Text = level2Numbers[17].ToString();
                        break;
                    case "button25":
                        button25.Text = level2Numbers[18].ToString();
                        break;
                    case "button26":
                        button26.Text = level2Numbers[19].ToString();
                        break;
                }
            }
            else if (difficulty == 3)
            {
                switch (buttonX.Name)
                {
                    case "button27":
                        button27.Text = level3Numbers[0].ToString();
                        break;
                    case "button28":
                        button28.Text = level3Numbers[1].ToString();
                        break;
                    case "button29":
                        button29.Text = level3Numbers[2].ToString();
                        break;
                    case "button30":
                        button30.Text = level3Numbers[3].ToString();
                        break;
                    case "button31":
                        button31.Text = level3Numbers[4].ToString();
                        break;
                    case "button32":
                        button32.Text = level3Numbers[5].ToString();
                        break;
                    case "button33":
                        button33.Text = level3Numbers[6].ToString();
                        break;
                    case "button34":
                        button34.Text = level3Numbers[7].ToString();
                        break;
                    case "button35":
                        button35.Text = level3Numbers[8].ToString();
                        break;
                    case "button36":
                        button36.Text = level3Numbers[9].ToString();
                        break;
                    case "button37":
                        button37.Text = level3Numbers[10].ToString();
                        break;
                    case "button38":
                        button38.Text = level3Numbers[11].ToString();
                        break;
                    case "button39":
                        button39.Text = level3Numbers[12].ToString();
                        break;
                    case "button40":
                        button40.Text = level3Numbers[13].ToString();
                        break;
                    case "button41":
                        button41.Text = level3Numbers[14].ToString();
                        break;
                    case "button42":
                        button42.Text = level3Numbers[15].ToString();
                        break;
                    case "button43":
                        button43.Text = level3Numbers[16].ToString();
                        break;
                    case "button44":
                        button44.Text = level3Numbers[17].ToString();
                        break;
                    case "button45":
                        button45.Text = level3Numbers[18].ToString();
                        break;
                    case "button46":
                        button46.Text = level3Numbers[19].ToString();
                        break;
                    case "button47":
                        button47.Text = level3Numbers[20].ToString();
                        break;
                    case "button48":
                        button48.Text = level3Numbers[21].ToString();
                        break;
                    case "button49":
                        button49.Text = level3Numbers[22].ToString();
                        break;
                    case "button50":
                        button50.Text = level3Numbers[23].ToString();
                        break;
                    case "button51":
                        button51.Text = level3Numbers[24].ToString();
                        break;
                    case "button52":
                        button52.Text = level3Numbers[25].ToString();
                        break;
                    case "button53":
                        button53.Text = level3Numbers[26].ToString();
                        break;
                    case "button54":
                        button54.Text = level3Numbers[27].ToString();
                        break;
                    case "button55":
                        button55.Text = level3Numbers[28].ToString();
                        break;
                    case "button56":
                        button56.Text = level3Numbers[29].ToString();
                        break;
                    case "button57":
                        button57.Text = level3Numbers[30].ToString();
                        break;
                    case "button58":
                        button58.Text = level3Numbers[31].ToString();
                        break;
                    case "button59":
                        button59.Text = level3Numbers[32].ToString();
                        break;
                    case "button60":
                        button60.Text = level3Numbers[33].ToString();
                        break;
                    case "button61":
                        button61.Text = level3Numbers[34].ToString();
                        break;
                    case "button62":
                        button62.Text = level3Numbers[35].ToString();
                        break;
                    case "button63":
                        button63.Text = level3Numbers[36].ToString();
                        break;
                    case "button64":
                        button64.Text = level3Numbers[37].ToString();
                        break;
                    case "button65":
                        button65.Text = level3Numbers[38].ToString();
                        break;
                    case "button66":
                        button66.Text = level3Numbers[39].ToString();
                        break;
                    case "button67":
                        button67.Text = level3Numbers[40].ToString();
                        break;
                    case "button68":
                        button68.Text = level3Numbers[41].ToString();
                        break;
                }
            }
            guess2 = buttonX.Text;
            lockedButtons.Add(buttonX);
            lockedButtons[1].Enabled = false;
            isFirstPress = true;
            CheckIfBlocksMatches(guess1, guess2);
            CheckIfPlayerHasWon();
            PrintFirstprompt();
        }
        /**********************************************************************************/
        /*  Game events handling    */
        /**********************************************************************************/
        private void CheckIfPlayerHasWon()
        {
            if(difficulty == 1)
            {
                if (level1Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "Vaikeustaso 1 suoritettu!" + "\r\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
            else if (difficulty == 2)
            {
                if (level2Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "Vaikeustaso 2 suoritettu!" + "\r\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
            else if (difficulty == 3)
            {
                if (level3Pairs == 0)
                {
                    textBox3.Visible = true;
                    textBox3.Text = "Vaikeustaso 3 suoritettu!" + "\r\n" + "Pelaaja käänsi " + movesTaken + " paria";
                }
            }
        }
        private void CheckIfBlocksMatches(object guess1, object guess2)
        {
            if(difficulty == 1)
            {
                if (guess1.ToString() == guess2.ToString())
                {
                    level1Pairs--;
                    for (int i = 0; i < level1Buttons.Count; i++)
                    {
                        if (lockedButtons.Contains(level1Buttons[i]))
                        {
                            level1Buttons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    System.Threading.Thread.Sleep(2000);
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
                    for (int i = 0; i < level2Buttons.Count; i++)
                    {
                        if (lockedButtons.Contains(level2Buttons[i]))
                        {
                            level2Buttons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    System.Threading.Thread.Sleep(2000);
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
                    for (int i = 0; i < level3Buttons.Count; i++)
                    {
                        if (lockedButtons.Contains(level3Buttons[i]))
                        {
                            level3Buttons.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    lockedButtons[0].Enabled = true;
                    lockedButtons[1].Enabled = true;
                    System.Threading.Thread.Sleep(2000);
                    lockedButtons[0].Text = "";
                    lockedButtons[1].Text = "";
                }
                movesTaken++;
                lockedButtons.Clear();
                textBox2.Text = "Pareja jäljellä " + level3Pairs;
            }
        }
    }
}
