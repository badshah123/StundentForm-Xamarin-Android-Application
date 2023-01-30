using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace StudentForm1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        Button btnSubmit;
        EditText editText_name, editText_surname, editText_studentno, editText_email, editText_faculty, editText_phoneno;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            editText_name = FindViewById<EditText>(Resource.Id.editTextName);
            editText_surname = FindViewById<EditText>(Resource.Id.editTextSurname);
            editText_studentno = FindViewById<EditText>(Resource.Id.editTextStudentNo);
            editText_email = FindViewById<EditText>(Resource.Id.editTextEmail);
            editText_faculty = FindViewById<EditText>(Resource.Id.editTextFaculty);
            editText_phoneno = FindViewById<EditText>(Resource.Id.editTextPhoneNo);
            btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            btnSubmit.Click += btnSubmit_Clicked;

        }

        private void btnSubmit_Clicked(object sender, EventArgs e) {
            Student.setName(editText_name.Text);
            Student.setSurname(editText_surname.Text);
            Student.setStudentNo(Convert.ToInt32(editText_studentno.Text));
            Student.setEmail(editText_email.Text);
            Student.setFaculty(editText_faculty.Text);
            Student.setPhoneNo(editText_phoneno.Text);
            StartActivity(typeof(Activity1));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}