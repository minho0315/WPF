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

namespace OracleApp
{
    /// <summary>
    /// EmpWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EmpWindow : Window
    {
        public EmpWindow()
        {
            InitializeComponent();
        }

        private void cmdGetEmployee_Click(object sender, RoutedEventArgs e)
        {
            long id;
            if(Int64.TryParse(txtID.Text, out id))
            {
                try
                {
                    gridEmployeeDetails.DataContext = HrDAO.Instance.getEmployee(id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error contacting database.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID. ");
            }

        }

        private void cmdConfirm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
