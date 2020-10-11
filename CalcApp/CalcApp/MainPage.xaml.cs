using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CalcApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public string buffer = "";

		public void AddChar(char ch)
		{
			buffer += ch;

			UpdateDisplay(buffer);
		}

		public void RemoveLastChar()
		{
			if (buffer.Length != 0)
				buffer = buffer.Substring(0, buffer.Length - 1);

			UpdateDisplay(buffer);
		}

		public void ClearBuffer()
		{
			buffer = "";

			UpdateDisplay(buffer);
		}
		
		public void EvalBuffer()
		{
			// Error checking
			if (String.IsNullOrWhiteSpace(buffer))
			{
				result.Text = "";
				return;
			}

			// Evaluation
			try
			{
				DataTable dataTable = new DataTable();
				decimal resultValue = Convert.ToDecimal(dataTable.Compute(buffer, ""));

				buffer = resultValue.ToString();
				UpdateDisplay(buffer);
			}
			catch (Exception e)
			{
				buffer = "";
				UpdateDisplay(e.Message);
			}
		}

		public void UpdateDisplay(string text)
		{
			result.Text = text.Replace('+', '+')
							  .Replace('-', '−')
							  .Replace('*', '×')
							  .Replace('/', '÷')
							  .Replace('^', '^')
							  .Replace('√', '√');
		}

		#region handlers

		/* Numbers */
		private void keypad0_Clicked(object sender, EventArgs e) { AddChar('0'); }
		private void keypad1_Clicked(object sender, EventArgs e) { AddChar('1'); }
		private void keypad2_Clicked(object sender, EventArgs e) { AddChar('2'); }
		private void keypad3_Clicked(object sender, EventArgs e) { AddChar('3'); }
		private void keypad4_Clicked(object sender, EventArgs e) { AddChar('4'); }
		private void keypad5_Clicked(object sender, EventArgs e) { AddChar('5'); }
		private void keypad6_Clicked(object sender, EventArgs e) { AddChar('6'); }
		private void keypad7_Clicked(object sender, EventArgs e) { AddChar('7'); }
		private void keypad8_Clicked(object sender, EventArgs e) { AddChar('8'); }
		private void keypad9_Clicked(object sender, EventArgs e) { AddChar('9'); }

		private void keypadDecimal_Clicked(object sender, EventArgs e) { AddChar('.'); }

		/* Operations */
		private void keypadAddition_Clicked(object sender, EventArgs e)		  { AddChar('+'); }
		private void keypadSubtraction_Clicked(object sender, EventArgs e)	  { AddChar('-'); }
		private void keypadMultiplication_Clicked(object sender, EventArgs e) { AddChar('*'); }
		private void keypadDivision_Clicked(object sender, EventArgs e)		  { AddChar('/'); }
		private void keypadPower_Clicked(object sender, EventArgs e)		  { AddChar('^'); }
		private void keypadRoot_Clicked(object sender, EventArgs e)			  { AddChar('√'); }

		/* Actions */
		private void keypadClear_Clicked(object sender, EventArgs e)  { ClearBuffer(); }
		private void keypadErase_Clicked(object sender, EventArgs e)  { RemoveLastChar(); }
		private void keypadEquals_Clicked(object sender, EventArgs e) { EvalBuffer(); }

		#endregion
	}
}
