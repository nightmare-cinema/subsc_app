﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Services;
using App2.Views;

namespace App2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
/*tanaka kouta*/
