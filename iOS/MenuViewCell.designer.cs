// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NavDrawer.iOS
{
	[Register ("MenuViewCell")]
	partial class MenuViewCell
	{
		[Outlet]
		UIKit.UILabel MenuDescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIImageView MenuImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MenuImageView != null) {
				MenuImageView.Dispose ();
				MenuImageView = null;
			}

			if (MenuDescriptionLabel != null) {
				MenuDescriptionLabel.Dispose ();
				MenuDescriptionLabel = null;
			}
		}
	}
}
