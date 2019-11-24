using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.IO;
using System.Windows.Forms;

namespace DNoiser
{
    /// <summary>
    /// Interaction logic for Denoise.xaml
    /// </summary>
    public partial class Denoise : Page
    {
        public string[] processed_paths;
        public int denoised_photos = 0;
        public int denoised_photos_procents = 0;

        public string output_path = "Not set...";
        public int HDR_training = 1;

        public Denoise(string[] paths)
        {
            processed_paths = paths;

            InitializeComponent();

            updateUI();
        }

        private void output_dir_btn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            using (System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    string selected_path = FBD.SelectedPath;
                    if (Directory.Exists(selected_path))
                    {
                        output_path = selected_path;
                        updateUI();
                    }
                }
            }
        }

        private void denoise_it_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (hrd_checkbox.IsChecked == true) HDR_training = 1;
            else HDR_training = 0;

            if (output_path != "Not set...")
            {
                // Get the location of the denoiser.exe file
                string currentDir = Environment.CurrentDirectory;
                string denoiser_file = System.IO.Path.Combine(currentDir, @"OptiX\Denoiser.exe");

                // Go through each image
                for (int i = 0; i < processed_paths.Length; ++i) {
                    // Declare a process
                    using (Process denoise_one = new Process())
                    {
                        denoise_one.StartInfo.FileName = denoiser_file;
                        denoise_one.StartInfo.CreateNoWindow = true;
                        denoise_one.StartInfo.UseShellExecute = false;

                        string output_file = output_path + @"\" + System.IO.Path.GetFileName(processed_paths[i]);
                        denoise_one.StartInfo.Arguments = String.Format(@"-i ""{0}"" -o ""{1}"" -hdr ""{2}""", processed_paths[i], output_file, HDR_training);
                        denoise_one.Start();

                        denoised_photos++;
                        updateUI();
                    }
                }
            }
        }

        private void updateUI()
        {
            output_dir_label.Content = "Output directory: " + output_path;
            count_label.Content = "Count of photos: " + processed_paths.Length;
            denoise_count_label.Content = "Denoised photos: " + denoised_photos;
        }
    }
}
