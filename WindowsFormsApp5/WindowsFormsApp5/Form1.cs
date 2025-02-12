using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int total = 0;
        int totalB = 0;
        int totalC= 0;
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void Calc()
        {
            //clear the total
            total = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0)
                {
                    total +=(int) Math.Pow(2, i);
                }
            }
            TotalLabel.Text = total.ToString();
        }

        private void bit8_TextChanged(object sender, EventArgs e)
        {
            {
               
            }
        }

        private void bitb8_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Calc2()
        {
            //clear the total
            totalB = 0;
            for (int i = 0; i < bitsB.Length; i++)
            {
                if (bitsB[i] != 0)
                {
                    totalB += (int)Math.Pow(2, i);
                }
            }  
                TotalLabelb.Text = totalB.ToString();
        }

        private void bitb8_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            
                ((TextBox)sender).Text = "0";
            

             else
                ((TextBox)sender).Text = "1";
            
            //bit1
            if (bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //bit2
            if (bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //bit3
            if (bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //bit4
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //bit5
            if (bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //bit6
            if (bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //bit7
            if (bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //bit8
            if (bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            Calc();

            //bitB1
            if (bitb1.Text == "1")
                bitsB[0] = 1;
            else
                bitsB[0] = 0;
            //bitB2
            if (bitb2.Text == "1")
                bitsB[1] = 1;
            else
                bitsB[1] = 0;
            //bitB3
            if (bitb3.Text == "1")
                bitsB[2] = 1;
            else
                bitsB[2] = 0;
            //bitB4
            if (bitb4.Text == "1")
                bitsB[3] = 1;
            else
                bitsB[3] = 0;
            //bitB5
            if (bitb5.Text == "1")
                bitsB[4] = 1;
            else
                bitsB[4] = 0;
            //bitB6
            if (bitb6.Text == "1")
                bitsB[5] = 1;
            else
                bitsB[5] = 0;
            //bitB7
            if (bitb7.Text == "1")
                bitsB[6] = 1;
            else
                bitsB[6] = 0;
            //bitB8
            if (bitb8.Text == "1")
                bitsB[7] = 1;
            else
                bitsB[7] = 0;
            Calc2();    
        }
        private void Calc3()
        {
            //clear the total
            totalC = 0;
            for (int i = 0; i < bitsC.Length; i++)
            {
                if (bitsC[i] != 0)
                {
                    totalC += (int)Math.Pow(2, i);
                }
            }
            TotalLabelc.Text = totalC.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                bits[i] = 0;
            }
            Update();
        }
        private void Update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[1] == 1 ? "1" : "0");
            bit3.Text = (bits[2] == 1 ? "1" : "0");
            bit4.Text = (bits[3] == 1 ? "1" : "0");
            bit5.Text = (bits[4] == 1 ? "1" : "0");
            bit6.Text = (bits[5] == 1 ? "1" : "0");
            bit7.Text = (bits[6] == 1 ? "1" : "0");
            bit8.Text = (bits[7] == 1 ? "1" : "0");
            bitb1.Text = (bitsB[0] == 1 ? "1" : "0");
            bitb2.Text = (bitsB[1] == 1 ? "1" : "0");
            bitb3.Text = (bitsB[2] == 1 ? "1" : "0");
            bitb4.Text = (bitsB[3] == 1 ? "1" : "0");
            bitb5.Text = (bitsB[4] == 1 ? "1" : "0");
            bitb6.Text = (bitsB[5] == 1 ? "1" : "0");
            bitb7.Text = (bitsB[6] == 1 ? "1" : "0");
            bitb8.Text = (bitsB[7] == 1 ? "1" : "0");
            bitc1.Text = (bitsC[0] == 1 ? "1" : "0");
            bitc2.Text = (bitsC[1] == 1 ? "1" : "0");
            bitc3.Text = (bitsC[2] == 1 ? "1" : "0");
            bitc4.Text = (bitsC[3] == 1 ? "1" : "0");
            bitc5.Text = (bitsC[4] == 1 ? "1" : "0");
            bitc6.Text = (bitsC[5] == 1 ? "1" : "0");
            bitc7.Text = (bitsC[6] == 1 ? "1" : "0");
            bitc8.Text = (bitsC[7] == 1 ? "1" : "0");
            Calc();
            Calc2();
            Calc3();
        }

        private void shiftrightbutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bits.Length; i++)
            {
                bits[i - 1] = bits[i];
            }
            bits[7] = 0;
            Update();
        }

        private void ClearBbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                bitsB[i] = 0;
            }
            Update();
        }

        private void ClearCbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            { 
                bitsC[i] = 0;
            }
            Update();
        }

        private void shiftrightbbutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bitsB.Length; i++)
            {
                bitsB[i - 1] = bitsB[i];
            }
            bitsB[7] = 0;
            Update();
        }

        private void shiftrightcbutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bitsC.Length; i++)
            {
                bitsC[i - 1] = bitsC[i];
            }
            bitsC[7] = 0;
            Update();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
                bits[i] = 0;
            for (int i = 0; i < bitsB.Length; i++)
                bitsB[i] = 0;
            for (int i = 0; i < bitsC.Length; i++)
                bitsC[i] = 0;
            Update();
        }

        private void shiftleftbutton_Click(object sender, EventArgs e)
        {
            for (int i = 6; i >= 0; i--)
            {
                bits[i + 1] = bits[i];
            }
            bits[0] = 0;
            Update();
        }

        private void shiftleftbbutton_Click(object sender, EventArgs e)
        {
            for (int i = 6; i >= 0; i--)
            {
                bitsB[i + 1] = bitsB[i];
            }
            bitsB[0] = 0;
            Update();
        }

        private void shiftleftcbutton_Click(object sender, EventArgs e)
        {
            for (int i = 6; i >= 0; i--)
            {
                bitsC[i + 1] = bitsC[i];
            }
            bitsC[0] = 0;
            Update();
        }

        private void andbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bitsC[i] = bits[i] & bitsB[i];
            }
            Update();
        }

        private void orbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
