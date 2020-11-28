using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsApp
{
    public partial class MainPage : ContentPage
    {
        private Person person = new Person();
        public MainPage()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            entLastName.TextChanged += EntLastName_TextChanged;
            entFirstName.TextChanged += EntFirstName_TextChanged;
            entPhoneNumber.TextChanged += EntPhoneNumber_TextChanged;
            btnCamera.Clicked += async (object sender, EventArgs e) => 
            {
                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() {
                
                });

                if (photo != null)
                {
                    imgPhoto.Source = ImageSource.FromStream(() => photo.GetStream());
                }
            };
        }

        private void EntPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.person.PhoneNumber = e.NewTextValue;
        }

        private void EntFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.person.PhoneNumber = e.NewTextValue;
        }

        private void EntLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.person.PhoneNumber = e.NewTextValue;
        }

    }
}
