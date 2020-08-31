using RhezomFac.Views.PageConditions;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.SignUp
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleSignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSignUpPage" /> class.
        /// </summary>
        public SimpleSignUpPage()
        {
            InitializeComponent();
        }

        //private void CheckBox_CheckedChanged(object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        //{
        //    //if(!cb.IsChecked)
        //    Device.BeginInvokeOnMainThread(async () =>
        //    {
        //        var check = await this.DisplayAlert("Confirm Exit", "Do you really want to exit the application?", "Yes", "No").ConfigureAwait(false);
        //        if (check)
        //            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        //        return;
        //    });
        //}

        private void SfButton_Clicked(object sender, System.EventArgs e)
        {
            if (!cb.IsChecked)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                await this.DisplayAlert("Erreur", "Veuillez cocher la case si vous êtes d'accord avec les Conditions Générales d'Utilisation afin de pouvoir vous inscrire", "Ok").ConfigureAwait(false);
                });
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Conditions clicked");
            await App.Current.MainPage.Navigation.PushAsync(new PageConditionsPage());
        }
    }
}