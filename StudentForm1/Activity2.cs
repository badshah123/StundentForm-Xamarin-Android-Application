using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentForm1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Activity2 : AppCompatActivity
    {
        Button btnLoadFile, btnClose;
        ScrollView scrollView;
        TextView textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout3);
            btnLoadFile = FindViewById<Button>(Resource.Id.buttonLoadFile);
            btnClose = FindViewById<Button>(Resource.Id.buttonClose);
            scrollView = FindViewById<ScrollView>(Resource.Id.scrollView1);
            textView = FindViewById<TextView>(Resource.Id.textViewFile);
            btnLoadFile.Click += btnLoadFile_Clicked;
            btnClose.Click += btnClose_Clicked;
        }

        private void btnLoadFile_Clicked(object sender, EventArgs e)
        {
            StreamReader streamReader = File.OpenText(Activity1.fullNameFile);
            string s = "";
            string entireText = "";

            while((s = streamReader.ReadLine()) != null)
            {
                entireText += s+"\n";
            }
            streamReader.Close();
            scrollView.Enabled = true;
            textView.Text = entireText;
        }
        private void btnClose_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

    }
}