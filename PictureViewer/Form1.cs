using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
     
        string currentDir = "";
        public Form1()
        {
            InitializeComponent();
        }
        int count = -1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fb = new FolderBrowserDialog();
                if(fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentDir = fb.SelectedPath;//get selected folder by the user

                    // display cuurent directory in the text box
                    textBoxDirectory.Text = currentDir;

                    //get all large files from the directory
                    //first create directory Info

                    var dirInfo = new DirectoryInfo(currentDir);

                    var files = dirInfo.GetFiles().Where(c => (c.Extension.Equals(".jpg") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".tmp") || c.Extension.Equals(".png")));
                    foreach (var image in files)
                    {   
                        //adds images to the list
                    listBoxImages.Items.Add(image.Name);
                         
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message + " " + ex.Source);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
//get the selected image
                   var selectedImage = listBoxImages.SelectedItems[0].ToString();
               
                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(currentDir))
                {
                    //make the full path to the image
                    var fullpath = Path.Combine(currentDir, selectedImage);

                    //set an image from file to the pictureBox
                    pictureBoxImagePreview.Image = Image.FromFile(fullpath);


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void button_navigation(object sender, EventArgs e)
        {
            //var clickedButton = sender as Button;
            // if(clickedButton.Text.Equals("<"))
            // {
            //     if (SelectedImageIndex > 0)
            //     {
            //         var selectedIndex = listBoxImages.SelectedIndices[0];
            //         Image selectedImg = listBoxImages.ima[selectedIndex];
            //     }

            // }
            // else
            // {

            // }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    var selectedImage = listBoxImages.SelectedItems[0+ 1].ToString();
        //    if (count < 10)
        //    {
        //        count++;
        //    }
        //    button3.Text = (count + 1).ToString();
        //    selectedImage = listBoxImages.SelectedItems[0 + 1].ToString();

        //}
    }
    }

      
  

