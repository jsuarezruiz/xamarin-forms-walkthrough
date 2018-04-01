using Xamanimation;

namespace Walkthrough.Views.Walkthrough
{
	public partial class AcrobaticsView : IAnimatedView
	{
		public AcrobaticsView()
		{
			InitializeComponent();
		}

		public void StartAnimation()
		{
			if (Resources["BackgroundColorAnimation"] is ColorAnimation backgroundColorAnimation)
			{
				backgroundColorAnimation.Begin();
			}

			if (Resources["InfoPanelAnimation"] is StoryBoard infoPanelAnimation)
			{
				infoPanelAnimation.Begin();
			}
		}
	}
}