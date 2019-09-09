using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Vlaggen_van_de_wereld
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        #region Set Images and Labels empty
        private void Empty()
        {
            var Images = Container.Children.OfType<Image>();
            foreach (var Image in Images)
            Image.Source = null;

            var Labels = Container.Children.OfType<Label>();
            foreach (var Label in Labels)
            Label.Content = String.Empty;
        }
        #endregion

        #region Buttons
        #region Quiz Button
        private void Quiz_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
        #endregion

        //Letter Buttons
        #region Letter A
        private void A_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 0;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter B
        private void B_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 11;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_3.Source = bitmap;
            Label_2_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 3
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_0.Source = bitmap;
            Label_3_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_1.Source = bitmap;
            Label_3_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_2.Source = bitmap;
            Label_3_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_3.Source = bitmap;
            Label_3_3.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter C
        private void C_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 27;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_3.Source = bitmap;
            Label_2_3.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter D
        private void D_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 39;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter E
        private void E_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 44;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter F
        private void F_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 51;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter G
        private void G_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 55;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;           
            #endregion
        }
        #endregion
        #region Letter H
        private void H_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 11;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter I
        private void I_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 68;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;            
            #endregion
        }
        #endregion
        #region Letter J
        private void J_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 77;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter K
        private void K_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 81;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter L
        private void L_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 90;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter M
        private void M_1_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 99;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_3.Source = bitmap;
            Label_2_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 3
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_0.Source = bitmap;
            Label_3_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_1.Source = bitmap;
            Label_3_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_2.Source = bitmap;
            Label_3_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_3.Source = bitmap;
            Label_3_3.Content = afbeelding;
            i++;
            #endregion
        }
        private void M_2_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 115;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter N
        private void N_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 117;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter O
        private void O_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 128;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter P
        private void P_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 134;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter Q
        private void Q_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 142;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter R
        private void R_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 143;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter S
        private void S_1_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 146;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_3.Source = bitmap;
            Label_2_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 3
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_0.Source = bitmap;
            Label_3_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_1.Source = bitmap;
            Label_3_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_2.Source = bitmap;
            Label_3_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_3.Source = bitmap;
            Label_3_3.Content = afbeelding;
            i++;
            #endregion
        }
        private void S_2_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 162;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter T
        private void T_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 168;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_3.Source = bitmap;
            Label_1_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 2
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_0.Source = bitmap;
            Label_2_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_1.Source = bitmap;
            Label_2_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_2.Source = bitmap;
            Label_2_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_2_3.Source = bitmap;
            Label_2_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 3
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_3_0.Source = bitmap;
            Label_3_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter S
        private void U_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 181;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter V
        private void V_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 182;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_2.Source = bitmap;
            Label_1_2.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter W
        private void W_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 189;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
        #region Letter Z
        private void Z_Click(object sender, RoutedEventArgs e)
        {
            Empty();
            int i = 190;

            #region Row 0
            string afbeelding = Class1.List2[i];
            var uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            var bitmap = new BitmapImage(uri);
            Image_0_0.Source = bitmap;
            Label_0_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_1.Source = bitmap;
            Label_0_1.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_2.Source = bitmap;
            Label_0_2.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_0_3.Source = bitmap;
            Label_0_3.Content = afbeelding;
            i++;
            #endregion
            #region Row 1
            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_0.Source = bitmap;
            Label_1_0.Content = afbeelding;
            i++;

            afbeelding = Class1.List2[i];
            uri = new Uri("pack://application:,,,/Images/" + afbeelding + ".png");
            bitmap = new BitmapImage(uri);
            Image_1_1.Source = bitmap;
            Label_1_1.Content = afbeelding;
            i++;
            #endregion
        }
        #endregion
    #endregion
    }
}

