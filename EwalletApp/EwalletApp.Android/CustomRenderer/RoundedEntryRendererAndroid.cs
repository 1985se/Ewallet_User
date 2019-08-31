using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EwalletApp.Control;
using EwalletApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererAndroid))]

namespace EwalletApp.Droid.CustomRenderer
{
    [Obsolete]
    class RoundedEntryRendererAndroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(30f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.GhostWhite);
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);
                Control.SetPadding(Control.PaddingLeft+20, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
    }
}