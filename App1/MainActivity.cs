using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ReplaceFont1.SetDefaultFont(this, "DEFAULT", "Fonts/RIKY2vamp.ttf");
            ReplaceFont1.SetDefaultFont(this, "MONOSPACE", "Fonts/RIKY2vamp.ttf");
            ReplaceFont1.SetDefaultFont(this, "SERIF", "Fonts/RIKY2vamp.ttf");
            ReplaceFont1.SetDefaultFont(this, "SANS_SERIF", "Fonts/RIKY2vamp.ttf");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

         

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

