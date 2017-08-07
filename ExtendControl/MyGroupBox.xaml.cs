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

namespace ExtendControl
{
    /// <summary>
    /// MyGroupBox.xaml 的交互逻辑
    /// </summary>
    public partial class MyGroupBox : GroupBox
    {
        public static readonly DependencyProperty pro1 = DependencyProperty.Register("MyHeader", typeof(String), typeof(MyGroupBox));

        public String MyHeader
        {
            get
            {
                return (String)GetValue(pro1);
            }
            set
            {
                SetValue(pro1, value);
            }
        }

        public MyGroupBox()
        {
            InitializeComponent();
        }
    }
}
