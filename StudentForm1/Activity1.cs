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
    public class Activity1 : AppCompatActivity
    {
        TextView textViewStudentInfo;
        Button btnSave, btnNext, btnBack;
        StreamWriter streamWriter;
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        public static string fullNameFile;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout2);
            textViewStudentInfo = FindViewById<TextView>(Resource.Id.textViewDisplayInfos);
            btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            textViewStudentInfo.Text = Student.StudentDetails();

            fullNameFile = System.IO.Path.Combine(path, "Students3.txt");
            if (!File.Exists(fullNameFile))
            {
                streamWriter = File.CreateText(fullNameFile);
                streamWriter.WriteLine("Students");// the header
                streamWriter.WriteLine("-----------------");// the separating line
            }else streamWriter = new StreamWriter(fullNameFile, true);

            btnSave.Click += btnSave_Clicked;
            btnNext.Click += btnNext_Clicked;
            btnBack.Click += btnBack_Clicked;

        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            string student = Student.StudentDetails();
            string[] studentProperties = student.Split("\n");

            for(int i=0; i<studentProperties.Length; i++)
                streamWriter.WriteLine(studentProperties[i]);

            streamWriter.WriteLine("-----------------");
            streamWriter.Close();

        }
        private void btnNext_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(Activity2));
        }
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}