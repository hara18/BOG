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
using System.Windows.Shapes;

namespace BOG
{
    /// <summary>
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Window
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void goback_reg_Click(object sender, RoutedEventArgs e)
        {
            RegForm regForm = new RegForm();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
