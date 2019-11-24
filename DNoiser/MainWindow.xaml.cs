using System;
using System.Collections.Generic;
using System.IO;
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

namespace DNoiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum WINDOW {
            Library = 1,
            Denoise = 2
        }

        int CURRENT_WINDOW = (int)WINDOW.Library;

        Library library_page = new Library();
        Denoise denoise_page;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            main_frame.NavigationService.Navigate(library_page);
        }

        private void library_label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CURRENT_WINDOW != (int)WINDOW.Library)
            {
                main_frame.NavigationService.Navigate(library_page);
                library_label.FontWeight = FontWeights.Bold;
                denoise_label.FontWeight = FontWeights.Regular;
                CURRENT_WINDOW = (int)WINDOW.Library;
            }
        }

        private void denoise_label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CURRENT_WINDOW != (int)WINDOW.Denoise)
            {
                if (library_page.paths_inarray == null) return;

                denoise_page = new Denoise(findAllPaths(library_page.paths_inarray));
                main_frame.NavigationService.Navigate(denoise_page);
                library_label.FontWeight = FontWeights.Regular;
                denoise_label.FontWeight = FontWeights.Bold;
                CURRENT_WINDOW = (int)WINDOW.Denoise;
            }
        }

        private string[] findAllPaths(string[] paths)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < paths.Length; ++i)
            {
                if (Directory.Exists(paths[i]) || File.Exists(paths[i])) {
                    FileAttributes attr = File.GetAttributes(paths[i]);

                    //detect whether its a directory or file
                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        string[] files = System.IO.Directory.GetFiles(paths[i], "*.jpg");
                        for (int f = 0; f < files.Length; ++f)
                        {
                            list.Add(files[f]);
                        }
                    }
                    else
                    {
                        list.Add(paths[i]);
                    }
                }
            }

            return list.ToArray();
        }
    }
}
