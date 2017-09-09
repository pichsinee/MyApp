using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;   //เมื่อมีการคลิกปุ่ม ok จากนั้นเรียก method OkButton_Clicked()
            firstNameEntry.TextChanged += FirstNameEntry_TextChanged;   //เมื่อมีการเปลี่ยนข้อความใน extry จากนั้นเรียก method FirstNameEntry_TextChanged()
            ageSlider.ValueChanged += AgeSlider_ValueChanged;   //เมื่อมีการ slide เลือกอายุ จากนั้นเรียก method geSlider_ValueChanged()
            myStepper.ValueChanged += MyStepper_ValueChanged;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");
        }

        private void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = ((int)e.NewValue).ToString(); 
        }

        private void AgeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = ((int)e.NewValue).ToString();  //เนื่องจาก e.NewValue ที่เป็น double ให้เปลี่ยนเป็น string โดยทำการ cast ให้เป็น int ก่อน เพื่อตัดทศนิยม
        }

        private void FirstNameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;  //เมื่อข้อความใน entry เปลี่ยน จะปรากฏข้อความนั้นบน Label เลย
        }

        private void OkButton_Clicked(object sender, EventArgs e)
        {

            firstNameLabel.Text = firstNameEntry.Text;  //เมื่อพิมพ์ข้อความใน entry แล้วกดปุ่ม OK จะปรากฏข้อความนั้นบน Label 
        }
    }
}
