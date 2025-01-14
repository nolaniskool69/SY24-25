using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();

            Reset();

        }
        private Button getButton(int r, int c)
        {
            int idx = (r - 1) * 10 + (c - 1);
            return btnGrid[idx];
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void getRC(Button b, out int r, out int c)
        {
            int i = getIndex(b);
            r = i / 10 + 1;
            c = i % 10 + 1;
        }
        
        private void setCounts()
        {
            //for every tile on the board
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    getButton(r, c).BackColor = Color.Honeydew;
                }
            }
        }
        //add one for each adjacent mine
        //set the count into the tile
        private int countadjacent(int r, int c)
        {
        int count = 0;
            
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c - 1))].GetMine()) count++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c))].GetMine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r - 1, c + 1))].GetMine()) count++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(getButton(r, c - 1))].GetMine()) count++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(getButton(r, c + 1))].GetMine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r + 1, c - 1))].GetMine()) count++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c))].GetMine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c + 1))].GetMine()) count++;
            }
            return count;
        }
        private int countFlag(int r, int c)
        {
        int countf = 0;
            
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c - 1))].GetFlag()) countf++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c))].GetFlag()) countf++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r - 1, c + 1))].GetFlag()) countf++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(getButton(r, c - 1))].GetFlag()) countf++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(getButton(r, c + 1))].GetFlag()) countf++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r + 1, c - 1))].GetFlag()) countf++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c))].GetFlag()) countf++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c + 1))].GetFlag()) countf++;
            }
            return countf;
        }
        private void button101_Click(object sender, EventArgs e)
        {

        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if(e.Button == MouseButtons.Right)
                t.SetFlag();
            else
                t.SetDug();
            if (e.Button == MouseButtons.Left)
                t.SetDug();
            if(e.Button == MouseButtons.Middle)
            {
                int r = 0;
                int c = 0;
                getRC(b, out r, out c);
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void createMines(int numMines)
        {
            int mineCount = 0;
            //until we have enough mines
            while (mineCount < numMines)
            {
                //generate num from 1-100
                int rNum = Random.Next(0, 100);
                // set mine on that tile if it doesnt already have a mine.
                if (tileGrid[rNum].GetMine() == false) 
                {
                    mineCount++;
                    tileGrid[rNum].SetMine(true);
                }
            }
        }

        private void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                tileGrid[i].SetFlagImage(FlagpictureBox.Image);
                tileGrid[i].SetMineImage(MinepictureBox.Image);
                btnGrid[i].BackgroundImage = null;
            }
            createMines(5);
            //countadjacent(4, 5);
            //countadjacent(1, 1);
            //countadjacent(10, 10);
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    tileGrid[getIndex(getButton(r, c))].SetNearby(countadjacent(r, c));
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
