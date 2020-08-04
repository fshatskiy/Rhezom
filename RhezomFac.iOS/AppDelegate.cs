using Syncfusion.XForms.iOS.ComboBox;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.XForms.iOS.Graphics;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.XForms.iOS.Border;
using Syncfusion.XForms.iOS.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace RhezomFac.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk4NjY3QDMxMzgyZTMyMmUzMGRRWXBhU0ZOWWwzb3FvUFJmRFBTRVdQaUprODhxNUtIampXWUlKN3lyWFk9;Mjk4NjY4QDMxMzgyZTMyMmUzMEJ0ZTZJOTJtY2N1Z2w2MGEvTEVFWnNocjJRZVk0UnIyRUpPVDkyTkJWZE09");

            global::Xamarin.Forms.Forms.Init();
            SfComboBoxRenderer.Init();
            SfRatingRenderer.Init();
            Core.Init();
            SfGradientViewRenderer.Init();
            SfListViewRenderer.Init();
            SfBorderRenderer.Init();
            SfButtonRenderer.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
