using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Auth;
using Xamarin.Forms.Xaml;
using TravelExperience.Models;
using TravelExperience.ViewModels;
using System.Diagnostics;
namespace TravelExperience.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
		//Account account;
		//AccountStore store;
		public LoginPage()
        {
            InitializeComponent();
			//store = AccountStore.Create();
		}

        private async void FBLoginButton_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Alert", "Face Book login is not supported with this Version.", "OK");
		}

        private async void GoogleLoginButton_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Alert","Google login is not supported with this Version.","OK");
			//string clientId = null;
			//string redirectUri = null;

			//switch (Device.RuntimePlatform)
			//{
			//	case Device.iOS:
			//		clientId = APPConstants.iOSClientId;
			//		redirectUri = APPConstants.iOSRedirectUrl;
			//		break;

			//	case Device.Android:
			//		clientId = APPConstants.AndroidClientId;
			//		redirectUri = APPConstants.AndroidRedirectUrl;
			//		break;
			//}

			//account = store.FindAccountsForService(APPConstants.AppName).FirstOrDefault();

			//var authenticator = new OAuth2Authenticator(
			//	clientId,
			//	null,
			//	APPConstants.Scope,
			//	new Uri(APPConstants.AuthorizeUrl),
			//	new Uri(redirectUri),
			//	new Uri(APPConstants.AccessTokenUrl),
			//	null,
			//	true);

			//authenticator.Completed += OnAuthCompleted;
			//authenticator.Error += OnAuthError;

			//AuthenticationState.Authenticator = authenticator;

			//var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
			//presenter.Login(authenticator);
		}

		//async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
		//{
		//	var authenticator = sender as OAuth2Authenticator;
		//	if (authenticator != null)
		//	{
		//		authenticator.Completed -= OnAuthCompleted;
		//		authenticator.Error -= OnAuthError;
		//	}

		//	UserInfo user = null;
		//	if (e.IsAuthenticated)
		//	{
		//		// If the user is authenticated, request their basic user data from Google
		//		// UserInfoUrl = https://www.googleapis.com/oauth2/v2/userinfo
		//		var request = new OAuth2Request("GET", new Uri(APPConstants.UserInfoUrl), null, e.Account);
		//		var response = await request.GetResponseAsync();
		//		if (response != null)
		//		{
		//			// Deserialize the data and store it in the account store
		//			// The users email address will be used to identify data in SimpleDB
		//			string userJson = await response.GetResponseTextAsync();
		//			user = JsonConvert.DeserializeObject<UserInfo>(userJson);
		//		}

		//		if (account != null)
		//		{
		//			store.Delete(account, APPConstants.AppName);
		//		}

		//		await store.SaveAsync(account = e.Account, APPConstants.AppName);
		//		await DisplayAlert("Email address", user.Email, "OK");
		//	}
		//}

		//void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
		//{
		//	var authenticator = sender as OAuth2Authenticator;
		//	if (authenticator != null)
		//	{
		//		authenticator.Completed -= OnAuthCompleted;
		//		authenticator.Error -= OnAuthError;
		//	}

		//	DisplayAlert("Authentication Failed","Authentication error: " + e.Message,"OK");
		//}
	}
}