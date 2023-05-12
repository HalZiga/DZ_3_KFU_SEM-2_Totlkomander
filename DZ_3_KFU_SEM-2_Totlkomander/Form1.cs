using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DZ_3_KFU_SEM_2_Totlkomander
{
    public partial class Form1 : Form
    {
        private List<File_> Files = new List<File_>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (dialog.SelectedPath != null)
            {
                LoadFilesAndDirectories(dialog.SelectedPath);
            }
        }

        public void LoadFilesAndDirectories(string filepath)
        {
            Files.Clear();
            listView1.Items.Clear();

            Files = Parser.GetFiles(filepath);
            if (Files.Count == 0)
            {
                return;
            }

            var imList = new ImageList();

            listView1.LargeImageList = imList;
            listView1.SmallImageList = imList;

            for (int i = 0; i < Files.Count; i++)
            {
                imList.Images.Add(Files[i].Image);

                ListViewItem item = new ListViewItem(new string[] { "", Files[i].Name, Files[i].WriteTime, Files[i].Ext, Files[i].Size })
                {
                    ImageIndex = i
                };

                listView1.Items.Add(item);
            }

            textBox_search_bar.Text = filepath;
        }
    }
}
