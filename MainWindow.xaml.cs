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

namespace Toplivo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            TbOst.Text = "В хранилище есть " + hranilishe.ObyemToplivaEnd().ToString() +" запаса топлива";
            mass = toplivo.Massa(hranilishe.ObyemToplivaEnd()).ToString();
            TbMassa.Text = $"Масса топлива составляет {mass} масса топлива";
            TbLitr.Text = $"Литров топлива осталось {hranilishe.Amount} л";
            toplObyem.Text = hranilishe.ObyemTopliva.ToString();
            
        }
        string mass;
        Hranilishe hranilishe = new Hranilishe();
        Station station = new Station();
        Toplivo12 toplivo = new Toplivo12();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TbToplivo.Text, out double minusToplivo))
            {
                station.Zapravit(hranilishe, minusToplivo);
                MessageBox.Show($"Машина заправлена на {minusToplivo}");
            }
            else
                MessageBox.Show("Введите корректное значение!");

            Change();

        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(toplivoAm.Text, out double plusToplivo))
            {
                station.AddTop(hranilishe, plusToplivo);
                MessageBox.Show($"Добавлено топливо {plusToplivo} л");
            }
            else
                MessageBox.Show("Введите корректное значение!");
            Change();
        }

        public void Change()
        {
            TbOst.Text = "В хранилище есть " + hranilishe.ObyemToplivaEnd().ToString() + " запаса топлива";
            TbMassa.Text = $"Масса топлива составляет {mass} масса топлива";
            TbLitr.Text = $"Литров топлива осталось {hranilishe.Amount} л";
        }

        private void Button_ClickChangeOb(object sender, RoutedEventArgs e)
        {
            hranilishe.ObyemTopliva = Convert.ToDouble(toplObyem.Text);
            Change();
        }
    }
}
