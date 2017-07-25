// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NavDrawer.iOS
{
    [Register ("DrawerViewController")]
    partial class DrawerViewController
    {
        [Outlet]
        UIKit.UILabel DisplayNameLabel { get; set; }


        [Outlet]
        UIKit.UILabel EmailLabel { get; set; }


        [Outlet]
        UIKit.UITableView MenuTableView { get; set; }


        [Outlet]
        UIKit.UIImageView UserImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DisplayNameLabel != null) {
                DisplayNameLabel.Dispose ();
                DisplayNameLabel = null;
            }

            if (EmailLabel != null) {
                EmailLabel.Dispose ();
                EmailLabel = null;
            }

            if (MenuTableView != null) {
                MenuTableView.Dispose ();
                MenuTableView = null;
            }

            if (UserImageView != null) {
                UserImageView.Dispose ();
                UserImageView = null;
            }
        }
    }
}