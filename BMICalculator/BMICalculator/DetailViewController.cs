using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
	public partial class DetailViewController : UIViewController
	{
		public float bmi = 21.5f;

		public DetailViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			EvaluateBMI();
		}

		void EvaluateBMI()
		{
			string test = String.Empty;

			if (bmi <= 16)
				test = "very low";
			else if (bmi < 18.5)
				test = "low";
			else if (bmi < 25)
				test = "normal";
			else if (bmi < 30)
				test = "high";
			else
				test = "too high";

			resultLabel.Text = test;
		}
	}
}