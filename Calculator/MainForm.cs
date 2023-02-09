/*
 * Created by SharpDevelop.
 * User: Flint
 * Date: 17.10.2020
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public string operation = "";
		public double lastnum = 0.0;
		public double result = 0.0;
		int abacuses = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            greenCheckBox.BackColor = Color.Green;
            greenCheckBox.Font = new Font("Arial", 12);
            greenCheckBox.Checked = true;

            redCheckBox.BackColor = Color.Red;
            redCheckBox.Font = new Font("Serif", 12);
            redCheckBox.Checked = true;


            blueCheckBox.BackColor = Color.Blue;
            blueCheckBox.Font = new Font("Arial", 12);
            blueCheckBox.Checked = true;


            yellowCheckBox.BackColor = Color.Yellow;
            yellowCheckBox.Font = new Font("Serif", 12);
            yellowCheckBox.Checked = true;
        }
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}
		void Button11Click(object sender, EventArgs e)
		{
			textBox1.Text += ".";
		}		
		void PlusButtonClick(object sender, EventArgs e)
		{
			operation = "+";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
			}
			textBox1.Text = textBox1.Text + "+";
		}
		void MinusButtonClick(object sender, EventArgs e)
		{
			operation = "-";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
			}
			textBox1.Text = textBox1.Text + "-";
		}
		void MultiplyButtonClick(object sender, EventArgs e)
		{
			operation = "*";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
			}
			textBox1.Text = textBox1.Text + "*";
		}
		void DevideButtonClick(object sender, EventArgs e)
		{
			operation = "/";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
			}
			textBox1.Text = textBox1.Text + "/";
		}
		void PowerButtonClick(object sender, EventArgs e)
		{
			operation = "x²";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
				lastnum = lastnum * lastnum;
				textBox1.Text = lastnum.ToString();
			}			
		}
		void squareRootButtonClick(object sender, EventArgs e)
		{
			operation = "√‾x";
			if (textBox1.Text.Length != 0) {
				lastnum = double.Parse(textBox1.Text); // !
				lastnum = Math.Sqrt(lastnum);
				textBox1.Text = lastnum.ToString();
			}
			
		}
		void deleteButtonClick(object sender, EventArgs e)
		{
			operation = "xy";
			lastnum = 0;
			result = 0;			
			textBox1.Text = "";
		}
		
		void ResultButtonClick(object sender, EventArgs e)
		{
			double num2 = 0;
			int scit, odcit, nas, del = 0;
			bool iscount = false;
			
			if (textBox1.Text.Length != 0) {

				scit  = textBox1.Text.IndexOf('+');
				if (scit != -1) {
					num2 = double.Parse(textBox1.Text.Substring(scit + 1));
					iscount = true;					
				}
				
				odcit = textBox1.Text.IndexOf('-');
				if (odcit != -1) {
					num2 = double.Parse(textBox1.Text.Substring(odcit + 1));
					iscount = true;	
				}
				
				nas   = textBox1.Text.IndexOf('*');
				if (nas != -1) {
					num2 = double.Parse(textBox1.Text.Substring(nas + 1));
					iscount = true;	
				}
				
				del   = textBox1.Text.IndexOf('/');
				if (del != -1) {
					num2 = double.Parse(textBox1.Text.Substring(del + 1));
					iscount = true;	
				}					
				if(!iscount) {
					num2 = double.Parse(textBox1.Text);
				}				
			}
			switch (operation) {
				case "+":
					result = lastnum + num2;
					break;
				case "-":
					result = lastnum - num2;
					break;
				case "*":
					result = lastnum * num2;
					break;
				case "/":
					result = lastnum / num2;
					break;				
				default:
					break;
			}
			textBox1.Text = result.ToString();
		}

        private void buttonBarvy_Click(object sender, EventArgs e)
        {
            if (greenCheckBox.Checked)
            {
                MessageBox.Show("Green");
            }
            if (blueCheckBox.Checked)
            {
                MessageBox.Show("Blue");
            }
            if (redCheckBox.Checked)
            {
                MessageBox.Show("Red");
            }
            if (yellowCheckBox.Checked)
            {
                MessageBox.Show("Yellow");
            }
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvoren update pro git", "Název okna", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
			Graphics gra = this.panel1.CreateGraphics();
			Pen blackpen = new Pen(Color.Black, 3);

			PointF pnt1 = new PointF(0, 15000);
            PointF pnt2 = new PointF(50, 0);
			e.Graphics.DrawLine(blackpen, pnt1, pnt2);
        }

        private void buttonPocitadlo_Click(object sender, EventArgs e)
        {
            abacuses++;
            buttonPocitadlo.Text = "Počet kliknutí: " + abacuses;
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
			pictureBox1.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
			abacuses = 0;
			buttonPocitadlo.Text = string.Empty;
			buttonPocitadlo.Text = "Klikej";
        }
    }
}
