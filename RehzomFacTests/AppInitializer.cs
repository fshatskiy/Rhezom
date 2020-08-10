﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RehzomFacTests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.App1").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}