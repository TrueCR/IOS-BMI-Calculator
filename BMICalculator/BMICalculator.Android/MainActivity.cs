using Android.App;
using Android.Widget;
using Android.OS;

namespace BMICalculator.Android
{
    [Activity (Label = "BMICalculator.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button calculateButton;
        TextView resultTextView;
        EditText heightEditText, weightEditText;

        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from "main" layout resource
            SetContentView(Resource.Layout.Main);

            calculateButton = FindViewById<Button>(BMICalculator.Android.Resource.Id.calculateButton);
            resultTextView = FindViewById<TextView>(BMICalculator.Android.Resource.Id.resultTextView);
            heightEditText = FindViewById<EditText>(BMICalculator.Android.Resource.Id.heightEditText);
            weightEditText = FindViewById<EditText>(BMICalculator.Android.Resource.Id.weightEditText);

            calculateButton.Click += CalculateButton_Click;
        }

        void CalculateButton_Click (object sender, System.EventArgs e)
        {
            float height = float.Parse(heightEditText.Text);
            float weight = float.Parse(weightEditText.Text);

            float bmi = (weight / (height * height));

            resultTextView.Text = bmi.ToString();
        }
    }
}                       