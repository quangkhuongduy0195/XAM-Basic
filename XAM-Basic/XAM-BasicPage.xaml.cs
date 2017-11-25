using Xamarin.Forms;
using System;
namespace XAMBasic
{
    public partial class XAM_BasicPage : ContentPage
    {
        //int i = 0;
        public XAM_BasicPage()
        {
            InitializeComponent();
            picker.Items.Add("Picker 1");
            picker.Items.Add("Picker 2");
            picker.Items.Add("Picker 3");
            picker.Items.Add("Picker 4");
            picker.Items.Add("Picker 5");
            picker.Items.Add("Picker 6");
            picker.Items.Add("Picker 7");
            picker.Items.Add("Picker 8");
            picker.SelectedIndex = 0;
        }

        void BtnClickMe(object sender, System.EventArgs e)
        {
            //if (i % 2 == 0)
            //{
            //    lblName.Text = "Email: quangkhuongduy@outlook.com";
            //    lblName.TextColor = Color.Red;
            //}
            //else 
            //{
            //    lblName.Text = "Quảng Khương Duy";
            //    lblName.TextColor = Color.Green;
            //}
            //i++;

            lblName.Text = edt.Text.ToString();
            lblName.TextColor = Color.Green;

        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //Text change
            lblName.Text = e.NewTextValue;
            lblName.TextColor = Color.Yellow;

        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            int value = Convert.ToInt32(e.NewValue);
            lblValue.Text = "Value: " + value.ToString();
        }
    }
}
