using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Common.Apis;
using Firebase.Auth;

namespace PushNotification.Droid
{
    [Activity(Label = "PushNotification", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        Button signinButton;
        TextView displayNameText;
        TextView emailText;
        TextView photourlText;

        GoogleSignInOptions gso;
        GoogleApiClient googleApiClient;
        FirebaseAuth firebaseAuth;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //signinButton = (Button)FindViewById(Resource.Id.signinButton);
            //displayNameText = (TextView)FindViewById(Resource.Id.displayNameText);
            //emailText = (TextView)FindViewById(Resource.Id.emailText);
            //photourlText = (TextView)FindViewById(Resource.Id.photourlText);

            //gso = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
            //    .RequestIdToken("1070736765023-j1o6a0bjio6c63njsc8mojk78q49mjuf.apps.googleusercontent.com")
            //    .RequestEmail()
            //    .Build();
            //googleApiClient = new GoogleApiClient.Builder(this)
            //    .AddApi(Auth.GOOGLE_SIGN_IN_API, gso).Build();
            //googleApiClient.Connect();

            //firebaseAuth = GetFirebaseAuth();
            //UpdateUI();
        }

        //private FirebaseAuth GetFirebaseAuth()
        //{
        //    var app = FirebaseApp.InitializeApp(this);
        //    FirebaseAuth mAuth;

        //    if (app == null)
        //    {
        //        var options = new FirebaseOptions.Builder()
        //            .SetProjectId("loginwith-79490")
        //            .SetApplicationId("loginwith-79490")
        //            .SetApiKey("AIzaSyA22eZ56ISG1j3NSFNpUBa-as7FhIi_OSg")
        //            .SetDatabaseUrl("https://loginwith-79490.firebaseio.com")
        //            .SetStorageBucket("loginwith-79490.appspot.com")
        //            .Build();

        //        app = FirebaseApp.InitializeApp(this, options);
        //        mAuth = FirebaseAuth.Instance;
        //    }
        //    else
        //    {
        //        mAuth = FirebaseAuth.Instance;
        //    }
        //    return mAuth;
        //}

    }
}