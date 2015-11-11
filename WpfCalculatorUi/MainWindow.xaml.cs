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
using Calculator;

namespace WpfCalculatorUi
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private readonly MyCalculatorViewModel _viewModel;
      public MainWindow()
      {
         InitializeComponent();
         _viewModel = new MyCalculatorViewModel();
      }

      private void button_one_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_two_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_three_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_four_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_five_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_six_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_seven_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_eight_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_nine_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_addition_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_subtraction_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_multiplication_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_division_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_equals_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_zero_Click( object sender, RoutedEventArgs e )
      {

      }

      private void button_decimalPoint_Click( object sender, RoutedEventArgs e )
      {

      }
   }
}
