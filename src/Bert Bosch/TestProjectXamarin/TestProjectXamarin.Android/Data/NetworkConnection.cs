using Android.App;
using Android.Content;
using Android.Net;
using TestProjectXamarin.Data;
using TestProjectXamarin.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]
namespace TestProjectXamarin.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
           
            var current = Connectivity.NetworkAccess;

			if (current == NetworkAccess.Internet)
			{
				IsConnected = true;
			}
			else IsConnected = false;
        }
    }
}
