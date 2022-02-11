using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Android.Support.V4.App;
using Android.Speech.Tts;
using Java.Util;

namespace TextToSpeechDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,TextToSpeech.IOnInitListener
    {
        private Button btnSpeak;
        private EditText edtSpeak;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.activity_main);
            
            btnSpeak = FindViewById<Button>(Resource.Id.btnSpeak);
            edtSpeak = FindViewById<EditText>(Resource.Id.edtSpeak);

            btnSpeak.Click += BtnSpeak_Click;
            
        }
    }
}