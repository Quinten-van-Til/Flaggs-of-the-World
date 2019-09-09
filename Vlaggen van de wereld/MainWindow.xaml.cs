using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Brushes = System.Windows.Media.Brushes;

namespace Vlaggen_van_de_wereld
{
    public partial class MainWindow : Window
    {
        #region Public Variables
        private string afbeelding;
        private bool Remove = false;
        private int Count = 0;
        public int Max = 196;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Start, End functions
        private void End()
        {
            MessageBox.Show("Finished");
            Count = 0;
        }
        private void Start()
        {
            #region Start
            Button0.Background = Button1.Background = Button2.Background = Button3.Background = Brushes.Silver;

            if (Count == 0)
            {
                Class1.List2 = new List<string>(Class1.List);
            }
            #endregion

            #region Remove Flag
            if (Remove == true)
            {
                Class1.List2.Remove(this.afbeelding);
                Count++;
                Label1.Content = Count;
            }
            else
            {
                Class1.List3.Add(this.afbeelding);
            }
            Remove = true;
            #endregion

            #region How many Flags left
            Max = Class1.List2.Count;
            Label2.Content = Max;
            if (Max == 0)
            {
                End();
                return;
            }
            #endregion

            #region Load Image
            Random random = new Random();
            int r = random.Next(0, Max);
                        
            afbeelding = Class1.List2[r];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image.Source = bitmap;
            #endregion

            #region Random Multiple Choice options
                #region Variables to calculate random Buttons
                int rnd = random.Next(0, 4);
                int a;
                int b;
                int c;
                int d;
                string afbeelding2;
            #endregion
                #region Make sure each Mulitple Choice is Unique
                do
                {
                    a = random.Next(0, 196);
                    afbeelding2 = Class1.List[a];
                }
                while (afbeelding2 == afbeelding);
                do
                {
                    b = random.Next(0, 196);
                    afbeelding2 = Class1.List[b];
                }
                while ((b == a) || (afbeelding2 == afbeelding));
                do
                {
                    c = random.Next(0, 196);
                    afbeelding2 = Class1.List[c];
                }
                while ((c == a) || (c == b) || (afbeelding2 == afbeelding));
                do
                {
                    d = random.Next(0, 196);
                    afbeelding2 = Class1.List[d];
                }
                while ((d == a) || (d == b) || (d == c) || (afbeelding2 == afbeelding));
            #endregion
                #region Set Values to Buttons
                if (rnd == 0)
                    Button0.Content = afbeelding;
                else
                    Button0.Content = Class1.List[a];

                if (rnd == 1)
                    Button1.Content = afbeelding;
                else
                    Button1.Content = Class1.List[b];

                if (rnd == 2)
                    Button2.Content = afbeelding;
                else
                    Button2.Content = Class1.List[c];

                if (rnd == 3)
                    Button3.Content = afbeelding;
                else
                    Button3.Content = Class1.List[d];
                #endregion
            #endregion
        }
        #endregion

        #region Buttons
        #region Start button
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            Count = 0;
            Label1.Content = Count;
            Max = 196;
            Remove = false;
            Start();
        }
        #endregion
        #region Overview button
        private void Overview_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }
        #endregion

        #region Multiple Choice Buttons
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (Button0.Content == afbeelding)
            {
                Button0.Background = Brushes.LawnGreen;
                Start();
            }
            else
            {
                Button0.Background = Brushes.Red;
                Remove = false;
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Button1.Content == afbeelding)
            {
                Button1.Background = Brushes.LawnGreen;
                Start();
            }
            else
            {
                Button1.Background = Brushes.Red;
                Remove = false;
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Button2.Content == afbeelding)
            {
                Button2.Background = Brushes.LawnGreen;
                Start();
            }
            else
            { Button2.Background = Brushes.Red;
                Remove = false;
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Button3.Content == afbeelding)
            {
                Button3.Background = Brushes.LawnGreen;
                Start();
            }
            else
            {
                Button3.Background = Brushes.Red;
                Remove = false;
            }
                
        }
        #endregion
        #endregion
    }
}


