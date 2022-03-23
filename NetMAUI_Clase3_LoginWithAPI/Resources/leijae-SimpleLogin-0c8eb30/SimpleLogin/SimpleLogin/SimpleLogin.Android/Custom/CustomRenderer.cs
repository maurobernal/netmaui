using System;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using SimpleLogin;
using SimpleLogin.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace SimpleLogin.Droid.Custom
{
    class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID (IntPtrtextViewClass, "mCursorDrawableRes", "I");
                JNIEnv.SetField (Control.Handle, mCursorDrawableResProperty, 0); 
            }
        }
    }
}