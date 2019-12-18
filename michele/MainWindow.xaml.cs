using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace michele
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            var birthday = int.Parse(txtgiorno.Text);
            var birthmonth = int.Parse(txtmese.Text);
            var birthyear = int.Parse(txtanno.Text);
            var birthdate = new DateTime(birthyear, birthmonth, birthday);
            var today = DateTime.Today;
            if(birthdate>today)
            {
                lblresult.Content = "impossibile,non puoi essere nato nel futuro";
            }
            else
            {
                var age = today.Year - birthdate.Year;
                var days = (today - birthdate).TotalDays;
                lblresult.Content = $"hai circa {age} anni e esattamente {days} giorni";
            }
        }
    }
}
