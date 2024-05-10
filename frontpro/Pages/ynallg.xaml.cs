namespace frontpro.Pages;

public partial class ynallg : ContentPage
{
	public ynallg()
	{
		InitializeComponent();
	}
    

    private async void YesButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AllergiesPage());
    }


    private async void NoButton_Clicked(object sender, EventArgs e)
    {
        // Handle No button click event
        await DisplayAlert("Allergies", "You don't suffer from allergies.", "OK");
    }
}