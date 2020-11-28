using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

            var content = (StackLayout)this.Content;

            this.loginButton.Clicked += (sender, e) => {
                Debug.WriteLine("Clicked !");
            };
        }

    }
}