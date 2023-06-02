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

namespace wild_animals
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int imageId = 0;

        private void changeImage(int imageId)
        {
            if (imageId == 0)
            {
                imageElement.Source = new BitmapImage(new Uri("..\\Pictures\\elephant.jpg", UriKind.Relative));
                imageDesc.Text = "Слоно́вые, или слоны́ - высокие толстокожие животные тропических областей Азии и Африки, которые питаются молодыми побегами деревьев и кустарников. У слонов массивные голова и туловище, длинный хобот, большие веерообразные уши и бивни из т.н. слоновой кости. Семейство относится к отряду хоботных (Proboscidea).";
                imageElement.Height = 450;
            }
            else if (imageId == 1)
            {
                imageElement.Source = new BitmapImage(new Uri("..\\Pictures\\giraffe.jpg", UriKind.Relative));
                imageDesc.Text = "Жира́ф — парнокопытное млекопитающее из семейства жирафовых. Является самым высоким наземным животным планеты.";
                imageElement.Height = 500;
            }
            else
            {
                imageElement.Source = new BitmapImage(new Uri("..\\Pictures\\tiger.jpg", UriKind.Relative));
                imageDesc.Text = "Тигр — хищное млекопитающее семейства кошачьих, один из пяти видов рода пантер, принадлежащего к подсемейству больших кошек. Слово «тигр» происходит от др.-греч. τίγρις, которое в свою очередь восходит к др.-перс. *tigri от корня «*taig» со значением «острый; быстрый».";
                imageElement.Height = 350;
            }
        }

        private void leftArrow_Click(object sender, RoutedEventArgs e)
        {
            if (imageId == 0)
                imageId = 2;
            else
                imageId--;

            changeImage(imageId);
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
            if (imageId == 2)
                imageId = 0;
            else
                imageId++;

            changeImage(imageId);
        }
    }
}
