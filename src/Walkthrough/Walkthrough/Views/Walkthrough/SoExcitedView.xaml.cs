using Xamanimation;

namespace Walkthrough.Views.Walkthrough
{
	public partial class SoExcitedView : IAnimatedView
	{
		public SoExcitedView ()
		{
			InitializeComponent ();
		}

		public void StartAnimation()
		{
			if (Resources["BackgroundColorAnimation"] is ColorAnimation backgroundColorAnimation)
			{
				backgroundColorAnimation.Begin();
			}

			if (Resources["InfoPanelAnimation"] is StoryBoard animation)
			{
				animation.Begin();
			}
		}
	}
}