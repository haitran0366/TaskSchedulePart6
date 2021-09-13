﻿using System;
using System.IO;
using TaskSchedulePart6.Services;
using TaskSchedulePart6.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskSchedulePart6
{
    public partial class App : Application
    {
        static TaskDatabaseService taskDatabase;

        public static TaskDatabaseService TaskDatabase
        {
            get
            {
                if (taskDatabase == null)
                {
                    taskDatabase = new TaskDatabaseService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinAppDb.db3"));
                }
                return taskDatabase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new TaskView();
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
