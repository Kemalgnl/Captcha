using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
	public partial class captch : Form
	{
		public captch()
		{
			InitializeComponent();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			char[] MyArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			Random x = new Random();

				int random1 = x.Next(0, MyArray.Length);
				textBox1.Text= Convert.ToString(MyArray[random1]);

				int random2 = x.Next(0, MyArray.Length);
				textBox2.Text = Convert.ToString(MyArray[random2]);

				int random3 = x.Next(0, MyArray.Length);
				textBox3.Text = Convert.ToString(MyArray[random3]);

				int random4 = x.Next(0, MyArray.Length);
				textBox4.Text = Convert.ToString(MyArray[random4]);
	
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox5.Text.ToUpper() == textBox1.Text && textBox6.Text.ToUpper() == textBox2.Text &&
				textBox7.Text.ToUpper() == textBox3.Text && textBox8.Text.ToUpper() == textBox4.Text)
				MessageBox.Show("Login successful");
			else
			{
				MessageBox.Show("you made a mistake");
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
