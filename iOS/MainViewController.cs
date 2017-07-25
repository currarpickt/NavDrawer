// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using ReactiveUI;
using UIKit;

namespace NavDrawer.iOS
{
	public partial class MainViewController : ReactiveViewController, IViewFor<NavDrawerViewModel>
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.OneWayBind(this.ViewModel, vm => vm.MenuDescription, vc => vc.DescriptionLabel.Text);
			this.MenuButton.Events().TouchUpInside
				.Subscribe(result =>
				{
					RootViewController.SidebarController.ToggleMenu();
				});
		}

		NavDrawerViewModel _ViewModel;

		public NavDrawerViewModel ViewModel
		{
		get { return _ViewModel; }
		set { this.RaiseAndSetIfChanged(ref _ViewModel, value); }
		}

		object IViewFor.ViewModel
		{
			get { return ViewModel; }
			set { ViewModel = (NavDrawerViewModel)value; }
		}
	}
}