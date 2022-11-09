namespace Assignment2;
using Assignment2.ViewModel;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new HolidayListViewModel();

	}


}


