using System;

using Foundation;
using ReactiveUI;
using UIKit;

namespace NavDrawer.iOS
{
    public partial class MenuViewCell : ReactiveTableViewCell, IViewFor<MenuViewModel>
    {
        public static readonly NSString Key = new NSString("MenuViewCell");
        public static readonly UINib Nib = UINib.FromName("MenuViewCell", NSBundle.MainBundle);

        protected MenuViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            this.OneWayBind(this.ViewModel, vm => vm.Description, vc => vc.MenuDescriptionLabel.Text);
            this.OneWayBind(this.ViewModel, vm => vm.IconName, vc => vc.MenuImageView.Image,
                            x => UIImage.FromBundle(x));
        }

        public MenuViewModel _viewModel;

		public MenuViewModel ViewModel
		{
			get { return _viewModel; }
			set { this.RaiseAndSetIfChanged(ref _viewModel, value); }
		}

		object IViewFor.ViewModel
		{
			get { return ((IViewFor<MenuViewModel>)this).ViewModel; }
			set { ((IViewFor<MenuViewModel>)this).ViewModel = (MenuViewModel)value; }
		}
    }
}
