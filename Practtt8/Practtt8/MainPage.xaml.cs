using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practtt8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Image image = new Image();
            image.Source = "mqdefault.jpg";
        }

        private void dataBirth_DateSelected(object sender, DateChangedEventArgs e)
        {
            int ag = DateTime.Now.Year - dataBirth.Date.Year;
            if (DateTime.Now.Month < dataBirth.Date.Month || (DateTime.Now.Month == dataBirth.Date.Month &&
                DateTime.Now.Month < dataBirth.Date.Month))
            {
                ag--;
            }
            age.Text = "Возраст-" + ag.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            EntryCell entry = new EntryCell();
            entry.Placeholder = "";
            entry.Keyboard = Keyboard.Numeric;
            phone.Add(entry);
        }
    }
}
