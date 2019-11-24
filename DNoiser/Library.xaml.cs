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
using System.Windows.Forms;
using System.IO;

namespace DNoiser
{
    /// <summary>
    /// Interaction logic for Library.xaml
    /// </summary>
    public partial class Library : Page
    {
        private List<string> PATHS = new List<string>();
        public string[] paths_inarray;

        public Library()
        {
            InitializeComponent();

            System.Windows.Controls.Label empty_queue = new System.Windows.Controls.Label();
            empty_queue.Foreground = new SolidColorBrush(Colors.White);
            empty_queue.Content = "Empty Queue...";
            queue_list.Items.Add(empty_queue);
        }

        private void renderList()
        {
            queue_list.Items.Clear();
            for (int i = 0; i < PATHS.Count(); ++i)
            {
                System.Windows.Controls.Label labeli = new System.Windows.Controls.Label();
                labeli.Foreground = new SolidColorBrush(Colors.White);
                labeli.Content = PATHS[i];
                queue_list.Items.Add(labeli);
            }

            paths_inarray = PATHS.ToArray();
        }

        private void import_dir_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    PATHS.Add(FBD.SelectedPath);
                    renderList();
                }
            }
        }

        private void import_img_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Multiselect = true;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string[] file_names = OFD.FileNames;
                    for (int i = 0; i < file_names.Length; ++i)
                    {
                        PATHS.Add(file_names[i]);
                    }

                    renderList();
                }
            }
        }

        private void clear_lib_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (PATHS.Count() == 0) return;

            PATHS.Clear();
            renderList();
        }
    }
}
