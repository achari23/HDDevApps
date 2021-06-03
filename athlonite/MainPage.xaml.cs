using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace athlonite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<UserProfile> _Profiles = new ObservableCollection<UserProfile>();
        public MainPage()
        {
            InitializeComponent();
            CardBinding();
            BindingContext = this;
        }
        //binding the cards. is also the dataset for the cards
        public void CardBinding()
        {
            Profiles.Add(new UserProfile(){ Name = "Anand", Age = "19", Photo = "promprofile.jpg" });
            Profiles.Add(new UserProfile(){ Name = "Joy", Age = "184", Photo = "helps.PNG" });
            Profiles.Add(new UserProfile(){ Name = "Vasu", Age = "185", Photo = "promprofile.jpg" });
            Profiles.Add(new UserProfile(){ Name = "Rylan", Age = "198", Photo = "Screenshot (3).png" });
            Profiles.Add(new UserProfile(){ Name = "Maya", Age = "168", Photo = "promprofile.jpg" });
            Profiles.Add(new UserProfile(){ Name = "Johnnie", Age = "128", Photo = "promprofile.jpg" });
            Profiles.Add(new UserProfile(){ Name = "Jackie", Age = "138", Photo = "promprofile.jpg" });
        }
        //Gives values to the profile, allows profile to retrieve inputs
        public ObservableCollection<UserProfile> Profiles
        {
            get => _Profiles;
            set
            {
                _Profiles = value;
            }
        }
        //user profile: has name, age, photo currently. Very easy to change from here
        public class UserProfile 
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Photo { get; set; }

        }
        //Handlers for buttons
        private void OnDislikeClicked(object sender, EventArgs e)
        {

        }
        private void OnLikeClicked(object sender, EventArgs e)
        {

        }
    }
}
