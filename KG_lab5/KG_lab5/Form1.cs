using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KG_lab5
{
    public partial class Form1 : Form
    {
        private Draw draw = new Draw();

        public Form1()
        {
            InitializeComponent();
        }

        private List<int> ParseInput()
        {
            List<int> input = new List<int>();
            string[] splitted = inputTb.Text.
                Replace('\n', ' ').
                Replace('\r', ' ').
                Replace('\t', ' ').
                Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in splitted)
            {
                int val;
                if (!Int32.TryParse(str, out val))
                {
                    MessageBox.Show("Unable to parse " + str);
                    return null;
                }

                input.Add(val);
            }

            return input;
        }

        private List<Point> parseRectangle(List<int> input)
        {
            List<Point> points = new List<Point>();
            
            points.Add(new Point(input[input.Count - 4], input[input.Count - 3]));
            points.Add(new Point(input[input.Count - 2], input[input.Count - 3]));
            points.Add(new Point(input[input.Count - 2], input[input.Count - 1]));
            points.Add(new Point(input[input.Count - 4], input[input.Count - 1]));

            return points;
        }

        private List<Point> parsePolygon(List<int> input, int n)
        {
            List<Point> points = new List<Point>();
            for(int i = n; i >= 1; i--)
            {
                points.Add(new Point(input[input.Count - 2 * i], input[input.Count - 2 * i + 1]));
            }

            return points;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbBtn_Click(object sender, EventArgs e)
        {
            List<int> input = ParseInput();
           
            int start = 0;

            if (input == null)
            {
                return;
            }

            if (input.Count % 4 != 0 || input.Count < 8)
            {
                MessageBox.Show("Incorrect format");
                return;
            }

            List<Point> parsed = parseRectangle(input);
            draw.Start(parsed);
            
            while (start < input.Count - 4)
            {
                draw.LiangBarsky(input[start],
                    input[start + 1],
                    input[start + 2],
                    input[start + 3]);
                start += 4;
            }

            pictureBox.Image = draw.End();
            pictureBox.Invalidate();
        }

        private void cbBtn_Click(object sender, EventArgs e)
        {
            List<int> input = ParseInput();
            
            int start = 0;
            if (input == null)
            {
                return;
            }
     
            int n = input[0];
            input.RemoveAt(0);

            if (input.Count % 2 != 0 || input.Count < 10)
            {
                MessageBox.Show("Incorrectformat");
                return;
            }

            List<Point> parsed = parsePolygon(input, n);
            draw.Start(parsed);
            
            while (start < input.Count - n * 2)
            {
                draw.DrawLinePoly(input[start],
                    input[start + 1],
                    input[start + 2],
                    input[start + 3]);
                start += 4;
            }

            pictureBox.Image = draw.End();
            pictureBox.Invalidate();
        }

        private void inputTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
