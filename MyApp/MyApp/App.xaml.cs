﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new NavPage1());

            MainPage = np;
            //MainPage = new MyApp.Page1();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
