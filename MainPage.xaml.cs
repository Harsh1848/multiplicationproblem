using Microsoft.Maui.Controls;
using System.Text;
namespace multiplicationproblem;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void GenerateTableButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(NumberEntry.Text, out int number) && number >= -50 && number <= 50)
        {
            int upperLimit = 12;

            if (int.TryParse(UpperLimitEntry.Text, out int customUpperLimit))
            {
                if (customUpperLimit > 0)
                    upperLimit = customUpperLimit;
                else
                    DisplayAlert("Invalid Upper Limit", "Please enter a positive integer for the upper limit.", "OK");
            }

            StringBuilder tableBuilder = new StringBuilder();

            for (int i = 1; i <= upperLimit; i++)
            {
                tableBuilder.Append($"{number} x {i} = {number * i}");
                tableBuilder.AppendLine();
            }

            TableLabel.Text = tableBuilder.ToString();
        }
        else
        {
            DisplayAlert("Invalid Number", "Please enter a valid integer between -50 and 50.", "OK");
        }
    }
}

