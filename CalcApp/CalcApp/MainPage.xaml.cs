using System;
using System.Collections.Generic;
using System.ComponentModel;
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

		public void Update()
		{
			result.Text = buffer;
		}

		public void Equals()
        {


			result.Text = ((int)0).ToString();
        }

		#region handlers

		/* Numbers */
		private void keypad0_Clicked(object sender, EventArgs e) { buffer += "0"; Update(); }
		private void keypad1_Clicked(object sender, EventArgs e) { buffer += "1"; Update(); }
		private void keypad2_Clicked(object sender, EventArgs e) { buffer += "2"; Update(); }
		private void keypad3_Clicked(object sender, EventArgs e) { buffer += "3"; Update(); }
		private void keypad4_Clicked(object sender, EventArgs e) { buffer += "4"; Update(); }
		private void keypad5_Clicked(object sender, EventArgs e) { buffer += "5"; Update(); }
		private void keypad6_Clicked(object sender, EventArgs e) { buffer += "6"; Update(); }
		private void keypad7_Clicked(object sender, EventArgs e) { buffer += "7"; Update(); }
		private void keypad8_Clicked(object sender, EventArgs e) { buffer += "8"; Update(); }
		private void keypad9_Clicked(object sender, EventArgs e) { buffer += "9"; Update(); }

		private void keypadDecimal_Clicked(object sender, EventArgs e) { buffer += "."; Update(); }

		/* Operations */
		private void keypadAddition_Clicked(object sender, EventArgs e)		  { buffer += "+"; Update(); }
		private void keypadSubtraction_Clicked(object sender, EventArgs e)	  { buffer += "−"; Update(); }
		private void keypadMultiplication_Clicked(object sender, EventArgs e) { buffer += "×"; Update(); }
		private void keypadDivision_Clicked(object sender, EventArgs e)		  { buffer += "÷"; Update(); }
		private void keypadPower_Clicked(object sender, EventArgs e)		  { buffer += "^"; Update(); }
		private void keypadRoot_Clicked(object sender, EventArgs e)			  { buffer += "√"; Update(); }

        /* Actions */
        private void keypadClear_Clicked(object sender, EventArgs e)  { buffer = ""; Update(); }
        private void keypadErase_Clicked(object sender, EventArgs e)  { if (buffer.Length != 0) { buffer = buffer.Substring(0, buffer.Length - 1); Update(); } }
        private void keypadEquals_Clicked(object sender, EventArgs e) { Equals(); }

		#endregion
	}
}
