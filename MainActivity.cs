using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace HelloDroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText username;
        Button greetMeBtn, homeButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            username = FindViewById<EditText>(Resource.Id.usernameEditText);
            greetMeBtn = FindViewById<Button>(Resource.Id.greetMeButton1);
            homeButton = FindViewById<Button>(Resource.Id.homeButton);

            greetMeBtn.Click += GreetMeBtn_Click;
            homeButton.Click += HomeButton_Click;
        }

        private void HomeButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(HomeActivity));
            intent.PutExtra("name", username.Text);
            StartActivity(intent);
        }

        private void GreetMeBtn_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, $"Hello World\nWelcomes {username.Text}", ToastLength.Long).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}