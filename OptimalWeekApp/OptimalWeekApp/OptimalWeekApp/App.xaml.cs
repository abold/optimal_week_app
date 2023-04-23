﻿using OptimalWeekApp.Services;
using OptimalWeekApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OptimalWeekApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockEventStore>();
            MainPage = new NavigationPage(new WeekPage());
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
