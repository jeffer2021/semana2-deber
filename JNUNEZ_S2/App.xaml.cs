﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JNUNEZ_S2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new ventana());
          
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}