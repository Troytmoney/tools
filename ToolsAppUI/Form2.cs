using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsAppUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Initialize the PictureBox control
            // Initialize the PictureBox control
            pictureBox1 = new PictureBox();
            pictureBox1.Dock = DockStyle.Fill;  // Fill the form with the PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;  // Stretch the image
            this.Controls.Add(pictureBox1);  // Add the PictureBox to the form's controls

            string exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            // Path to the getwallpaper.exe in the same directory as the executable
            string getWallpaperPath = Path.Combine(exeDirectory, "getwallpaper.exe");

            // Check if the getwallpaper.exe exists
            if (File.Exists(getWallpaperPath))
            {
                try
                {
                    // Start getwallpaper.exe
                    Process process = new Process();
                    process.StartInfo.FileName = getWallpaperPath;
                    process.StartInfo.Arguments = "";  // You can pass arguments here if necessary
                    process.Start();

                    // Wait for the process to complete. You may need to adjust the wait time depending on how long it takes to generate the image.
                    process.WaitForExit();

                    // Give it 2 seconds before displaying the image
                    Thread.Sleep(2000);  // Sleep for 2 seconds

                    // Now check if the image exists in the temp folder
                    string tempPath = Path.Combine(Path.GetTempPath(), "TranscodedWallpaper.png");

                    if (File.Exists(tempPath))
                    {
                        // Load the image into pictureBox1 (NOT the form's background)
                        pictureBox1.Image = Image.FromFile(tempPath);

                        // Optional: Show a confirmation message
                        MessageBox.Show("The wallpaper image has been loaded and displayed in PictureBox1!");
                    }
                    else
                    {
                        MessageBox.Show("Error: The image file was not found in the temp folder.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while running getwallpaper.exe: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Error: getwallpaper.exe not found in the application directory.");
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}