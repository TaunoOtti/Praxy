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
using Client.Models;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for AccountDetails.xaml
    /// </summary>
    public partial class AccountDetails : UserControl
    {
        public AccountDetails()
        {
            InitializeComponent();
        }


        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Stream checkStream = null;
            //   OpenFileDialog op1 = new OpenFileDialog();
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "All Image Files | *.*";
            Nullable<bool> result = dlg.ShowDialog();
            // if ((bool)dlg.ShowDialog())
            if (result == true)
            {
                try
                {
                    if ((checkStream = dlg.OpenFile()) != null)
                    {
                        //   MyImage.Source = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                        //listBox1.Items.Add(openFileDialog.FileName);
                        string filename = dlg.FileName;
                        Cv s = new Cv();
                        s.Title = filename;
                        // tb_file.AppendText(dlg.FileName.ToString());
                        MessageBox.Show("Successfully done", filename);
                        myCv.Content = s.Title;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Problem occured, try again later");
            }
        }
    }
}