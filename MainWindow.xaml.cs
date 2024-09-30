using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace SleepyPC
{
   //Чтож.. Начнем
    public partial class MainWindow : Window
    {
        private int time;
        private DispatcherTimer timer;
        private bool isStop = false;

        public MainWindow()
        {
            InitializeComponent();

           TextBoxOne.IsReadOnly = true;
           TextBoxTwo.IsReadOnly = true;
           TextBoxThree.IsReadOnly = true;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }




        void Timer_Tick(Object sender, EventArgs e)
        { 

            TimerCount.Content = TimeSpan.FromSeconds(time).ToString(@"hh\:mm\:ss");
            time--;
            if (time <= -1 ) 
            {
                timer.Stop();
                isStop = false;
                Startbtn.Content = "START";
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void TextBoxOne_PreviewMouseWheel(object sender, MouseWheelEventArgs e) 
        {
            TextBox textBox = sender as TextBox;
            if (e.Delta > 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue + 1).ToString();
                    if (currentValue >= 24)
                    {
                        currentValue = 24;
                        textBox.Text = currentValue.ToString();
                    }
                }
                else
                {
                    
                }
            }

            else if (e.Delta < 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue - 1).ToString();
                    if (currentValue <= 0)
                    {
                        currentValue = 0;
                        textBox.Text = currentValue.ToString();
                    }
                }
            }


            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void TextBoxTwo_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.Delta > 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue + 1).ToString();
                    if (currentValue >= 60)
                    {
                        currentValue = 60;
                        textBox.Text = currentValue.ToString();
                    }
                }
                else
                {

                }
            }

            else if (e.Delta < 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue - 1).ToString();
                    if (currentValue <= 0)
                    {
                        currentValue = 0;
                        textBox.Text = currentValue.ToString();
                    }
                }
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void TextBoxThree_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.Delta > 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue + 1).ToString();
                    if (currentValue >= 60)
                    {
                        currentValue = 60;
                        textBox.Text = currentValue.ToString();
                    }
                }
                else
                {

                }
            }

            else if (e.Delta < 0)
            {
                if (int.TryParse(textBox.Text, out int currentValue))
                {
                    textBox.Text = (currentValue - 1).ToString();
                    if (currentValue <= 0)
                    {
                        currentValue = 0;
                        textBox.Text = currentValue.ToString();
                    }
                }
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxOne.Text, out int currentValue);

            TextBoxOne.Text = (currentValue + 1).ToString() ;
            if (currentValue >= 24)
            {
                currentValue = 24;
                TextBoxOne.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxOne.Text, out int currentValue);

            TextBoxOne.Text = (currentValue - 1).ToString();
            if (currentValue <= 0)
            {
                currentValue = 0;
                TextBoxOne.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxTwo.Text, out int currentValue);

            TextBoxTwo.Text = (currentValue + 1).ToString();
            if (currentValue >= 60)
            {
                currentValue = 60;
                TextBoxTwo.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxTwo.Text, out int currentValue);

            TextBoxTwo.Text = (currentValue - 1).ToString();
            if (currentValue <= 0)
            {
                currentValue = 0;
                TextBoxTwo.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxThree.Text, out int currentValue);

            TextBoxThree.Text = (currentValue + 1).ToString();
            if (currentValue >= 60)
            {
                currentValue = 60;
                TextBoxThree.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int.TryParse(TextBoxThree.Text, out int currentValue);

            TextBoxThree.Text = (currentValue - 1).ToString();
            if (currentValue <= 0)
            {
                currentValue = 0;
                TextBoxThree.Text = currentValue.ToString();
            }

            if (TextBoxOne.Text == "24")
            {
                TextBoxTwo.Text = "0";
                TextBoxThree.Text = "0";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            

            if (isStop)
            {
                isStop = false;

                timer.Stop();

                Startbtn.Content = "START";
                TimerCount.Content = "00:00:00";
            }
            else 
            {
                Startbtn.Content = "STOP";
                int.TryParse(TextBoxOne.Text, out int hValue);
                int.TryParse(TextBoxTwo.Text, out int mValue);
                int.TryParse(TextBoxThree.Text, out int sValue);

                time = ((hValue * 60) * 60) + (mValue * 60) + sValue;

                timer.Start();

                isStop = true;
            }

        }
    }
}
