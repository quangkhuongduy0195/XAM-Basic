﻿using Xamarin.Forms;

namespace XAMBasic
{
    public partial class XAM_BasicPage : ContentPage
    {
        int i = 0;
        public XAM_BasicPage()
        {
            InitializeComponent();
        }

        void BtnClickMe(object sender, System.EventArgs e)
        {
            if (i % 2 == 0)
            {
                lblName.Text = "Email: quangkhuongduy95@gmail.com";
                lblName.TextColor = Color.Red;
            }
            else 
            {
                lblName.Text = "Quảng Khương Duy";
                lblName.TextColor = Color.Green;
            }
            i++;
        }
    }
}
