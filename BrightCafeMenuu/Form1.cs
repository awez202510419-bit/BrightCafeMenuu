using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrightCafeMenuu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int total = 0;
			string receipt = "=== پسوڵەی بڕایت کافێ (Bright Cafe) ===\n\n";

			if (checkBox1.Checked)
			{
				int qty = (int)numericUpDown1.Value;
				int cost = 2500 * qty;
				total += cost;
				receipt += $"• ئیسپرێسۆ (x{qty}) : {cost} دینار\n";
			}

			if (checkBox2.Checked)
			{
				int qty = (int)numericUpDown2.Value;
				int cost = 3000 * qty;
				total += cost;
				receipt += $"• ئەمریکانۆ (x{qty}) : {cost} دینار\n";
			}

			if (checkBox3.Checked)
			{
				int qty = (int)numericUpDown3.Value;
				int cost = 4000 * qty;
				total += cost;
				receipt += $"• قاوەی تورکی (x{qty}) : {cost} دینار\n";
			}

			if (checkBox4.Checked)
			{
				int qty = (int)numericUpDown4.Value;
				int cost = 4000 * qty;
				total += cost;
				receipt += $"• قاوەی قەزوان (x{qty}) : {cost} دینار\n";
			}

			if (checkBox5.Checked)
			{
				int qty = (int)numericUpDown5.Value;
				int cost = 4000 * qty;
				total += cost;
				receipt += $"• لاتێ (x{qty}) : {cost} دینار\n";
			}

			label2.Text = "کۆی گشتی: " + total + " دینار";

			if (total > 0)
			{
				receipt += "\n------------------------------------\n";
				receipt += $"کۆی گشتی پارە: {total} دینار\n";
				receipt += "سوپاس بۆ سەردانەکەت!";
				MessageBox.Show(receipt, "پسوڵەی کڕین", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("تکایە سەرەتا جۆرێک قاوە هەڵبژێرە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
