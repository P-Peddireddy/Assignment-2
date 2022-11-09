using Assignment2.ViewModel;
namespace Assignment2.Views;

public partial class HolidayDetailView : ContentPage
{
	public HolidayDetailView()
	{
		InitializeComponent();
        this.BindingContext = new HolidayDetailsViewModel();
    }
}
