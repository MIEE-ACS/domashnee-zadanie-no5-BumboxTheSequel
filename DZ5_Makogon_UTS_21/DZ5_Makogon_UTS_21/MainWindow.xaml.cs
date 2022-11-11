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

namespace DZ5_Makogon_UTS_21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class room
        {
            private int X;
            public int size_x
            {
                get
                {
                    return X;
                }
                set
                {
                    X = value;
                    if (X <= 1.0)
                    {
                        throw new Exception("Ошибка: длина пола не может быть меньше метра");
                    }
                }
            }
            private int Y;
            public int size_y
            {
                get
                {
                    return Y;
                }
                set
                {
                    Y = value;
                    if (size_y <= 1.0)
                    {
                        throw new Exception("Ошибка: ширина пола не может быть меньше метра");
                    }
                }
            }
            private int H;
            public int h
            {
                get
                {
                    return H;
                }
                set
                {
                    H = value;
                    if (H <= 1.0)
                    {
                        throw new Exception("Ошибка: высота комнаты не может быть меньше метра");
                    }
                }
            }
            private int n;
            public int N
            {
                get
                {
                    return n;
                }
                set
                {
                    n = value;
                    if (n <= 1)
                    {
                        throw new Exception("Ошибка: кол-во окон не может быть меньше одного");
                    }
                }
            }
        }
        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            room Room = new room();
            Room.size_x = int.Parse(tb_size_x.Text);
            Room.size_y = int.Parse(tb_size_y.Text);
            Room.h = int.Parse(tb_height.Text);
            Room.N = int.Parse(tb_windows.Text);
            calculate_S(Room, tb_S);
            calculate_V(Room, tb_V);
        }
        static void calculate_S(room n, TextBox k)
        {
            double S = 2 * (n.size_x * n.size_y + n.size_x * n.h + n.size_y * n.h)*1.00;
            k.Text = String.Format("{0:00}", S);
        }
        static void calculate_V(room n, TextBox k)
        {
            double V = n.size_x * n.h * n.size_y*1.00;
            k.Text = String.Format("{0:00}", V);
        }
    }
}
