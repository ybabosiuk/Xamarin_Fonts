using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Java.Lang.Reflect;

namespace App1
{
    class ReplaceFont1
    {


        public static void SetDefaultFont(Context context, String staticTypefaceFieldName, String fontAssetName)
        {
            Typeface regular = Typeface.CreateFromAsset(context.Assets, fontAssetName);
            ReplaceFont(staticTypefaceFieldName, regular);
        }

        protected static void ReplaceFont(String staticTypefaceFieldName, Typeface newTypeface)
        {
            try
            {
                var javaType = Java.Lang.Class.FromType(typeof(Typeface));
                var staticField = javaType.GetDeclaredField(staticTypefaceFieldName);

                staticField.Accessible = true;
                staticField.Set(null, newTypeface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
    }
    }



}