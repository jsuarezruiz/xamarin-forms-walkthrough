using Walkthrough.Views.Walkthrough;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Walkthrough.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WalkthroughView : ContentPage
	{
		private View[] _views;

		public WalkthroughView()
		{
			InitializeComponent();

			_views = new View[]
			{
				new BikingHardView(),
				new AcrobaticsView(),
				new SoExcitedView(),
				new BikingCoolView()
			};

			Carousel.ItemsSource = _views;
		}


		private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
		{
			var currentView = _views[e.NewValue];

			if (currentView is IAnimatedView animatedView)
			{
				animatedView.StartAnimation();
			}
		}
	}
}