using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exercise5_vp
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

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int nexIndex = tcSample.SelectedIndex - 1;
            if (nexIndex < 0) nexIndex = tcSample.Items.Count - 1;
            tcSample.SelectedIndex = nexIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int nexIndex = tcSample.SelectedIndex + 1;
            if (nexIndex >= tcSample.Items.Count) nexIndex = 0;
            tcSample.SelectedIndex = nexIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab: " + (tcSample.SelectedItem as TabItem).Header);
        }
    }
}