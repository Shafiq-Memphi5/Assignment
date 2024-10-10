using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //the txtName.Text is used to collect the content of the txtName text box
        private async void btn_Reg(object sender, RoutedEventArgs e)
        {
            if(txtPw1.Text == txtPw2.Text)
            {
                var messageInterface = new MessageDialog(txtName.Text + " has successfully registered!");
                await messageInterface.ShowAsync();
            }
            else
            {
                var messageInterface = new MessageDialog(txtName.Text + " input matching passwords");
                await messageInterface.ShowAsync();
            }
        }
        //all text box are made empty
        private async void btn_Clear(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPw1.Text = "";
            txtPw2.Text = "";
            var messageInterface = new MessageDialog("Clearing is successful");
            await messageInterface.ShowAsync();
        }
    }
}
