using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomListApp
{
    public class CustomFormsListView : ListView 
    {
        protected override void SetupContent(Cell pContent, int pIndex)
        {
            base.SetupContent(pContent, pIndex);
            var currentViewCell = pContent as ViewCell;

            if (currentViewCell != null)
            {
                currentViewCell.View.BackgroundColor = pIndex % 2 == 0 ? Color.LightPink : Color.LightBlue;
            }
        }
    }
}
