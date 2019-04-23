using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using CustomListApp;
using CustomListApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomList), typeof(CustomListRenderer_Droid))]

namespace CustomListApp.Droid
{
    public class CustomListRenderer_Droid : ViewCellRenderer
    {
        public CustomListRenderer_Droid()
        {

        }

        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell  = base.GetCellCore(item, convertView, parent, context);

            // cell.SetBackgroundColor(Android.Graphics.Color.LightBlue);
            // cell.SetBackgroundColor(Android.Graphics.Color.LightPink);
            
            if (cell.Selected)
            {
                cell.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }

            return cell;
        }

        
    }
}