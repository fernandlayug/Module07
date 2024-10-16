using Module07.Services;
using Module07.ViewModel;

namespace Module07.View;

public partial class ViewPersonal : ContentPage
{
	public ViewPersonal()
	{
		InitializeComponent();

        // Initialize the ViewModel and set it as the BindingContext
        var personalViewModel = new PersonalViewwModel();
        BindingContext = personalViewModel;
    }
}