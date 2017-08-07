using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ExtendControl
{
    public class BaseBox :UserControl
    {
        public Grid GridContent { get; set; }

        public BaseBox()
        {
            Grid gridBox = new Grid();
            Brush brush = new SolidColorBrush(Color.FromRgb(0, 255, 255));
            gridBox.Background = brush;
            gridBox.ShowGridLines = true;

            RowDefinition row1 = new RowDefinition();
            gridBox.RowDefinitions.Add(row1);
            gridBox.RowDefinitions.Add(new RowDefinition());

            TextBlock txtTitle = new TextBlock();
            txtTitle.Text = "标题3";
            gridBox.Children.Add(txtTitle);
            Grid.SetRow(txtTitle,0);

            GridContent = new Grid();
            Brush brush1 = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            GridContent.Background = brush1;

            TextBlock txtTitle1 = new TextBlock();
            txtTitle1.Text = "内容";
            GridContent.Children.Add(txtTitle1);


            gridBox.Children.Add(GridContent);
            Grid.SetRow(GridContent, 1);



            this.AddChild(gridBox);
        }
    }
}
