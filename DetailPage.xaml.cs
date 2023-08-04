using MAUIBeginnerApp.ViewModel;

namespace MAUIBeginnerApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}