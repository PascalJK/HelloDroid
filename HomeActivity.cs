using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace HelloDroid
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        EditText txt1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Home);

            txt1 = FindViewById<EditText>(Resource.Id.welcomeText);

            string name = Intent.GetStringExtra("name");

            txt1.Text = $"Welcome to homePage {name}";

        }
    }
}