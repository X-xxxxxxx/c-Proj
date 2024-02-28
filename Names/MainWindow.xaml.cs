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

namespace Names
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

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            //1.确保文本框包含名称。
            //2.验证文本框中输入的名称是否已经存在。
            //3.将名称添加到列表框。

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !ListNames.Items.Contains(txtName.Text))
            {
                ListNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }
    }
}