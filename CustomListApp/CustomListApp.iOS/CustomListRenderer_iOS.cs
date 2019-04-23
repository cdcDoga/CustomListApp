using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreGraphics;
using CustomListApp;
using CustomListApp.iOS;
using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomList), typeof(CustomListRenderer_iOS))]

namespace CustomListApp.iOS
{
    public class CustomListRenderer_iOS : ViewCellRenderer
    {
        public CustomListRenderer_iOS()
        {

        }

        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            
            // cell.BackgroundColor = UIColor.FromRGBA(226, 166, 166, 1); // light pink
            // ell.BackgroundColor = UIColor.FromRGBA(166, 219, 226, 1); // light blue

            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0)
            };

            return cell;
        }
    }
}