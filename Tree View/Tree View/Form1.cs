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

namespace Tree_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }
        private void LoadDrives()
        {
            DriveInfo[] drive1 = DriveInfo.GetDrives();
            foreach (var drive in drive1)
            {
                TreeNode tree = new TreeNode(drive.Name);
                tree.Nodes.Add(drive.DriveType.ToString());
                // Store the root directory for later use
                tree.Tag = drive.RootDirectory;
                treeView1.Nodes.Add(tree);
                LoadChilds(tree, drive.RootDirectory);
                ListViewItem item = new ListViewItem(drive.Name);
                item.SubItems.Add(drive.DriveType.ToString());
                item.Tag = drive.RootDirectory;
                listView1.Items.Add(item);
            }
        }

        private void LoadChilds(TreeNode node, DirectoryInfo directory)
        {
            try
            {
                DirectoryInfo[] children = directory.GetDirectories();
                foreach (var direct in children)
                {
                    TreeNode tnode = new TreeNode(direct.Name);
                    tnode.Nodes.Add(directory.LastWriteTime.ToString());
                    tnode.Nodes.Add(""); // Folders don't have a size
                    tnode.Tag = directory; // Store the directory info for later use
                    treeView1.Nodes.Add(tnode);
                    ListViewItem listItem = new ListViewItem(direct.Name);
                    listItem.SubItems.Add(direct.LastWriteTime.ToString());
                    listItem.Tag = directory;
                    listView1.Items.Add(listItem);

                }
            }

            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode tnode = e.Node;

            //Display data of drives on leftside

            if (tnode.Nodes.Count > 0)
            {
                tnode.Nodes.RemoveAt(0);
                DirectoryInfo folder = (DirectoryInfo)tnode.Tag;
                DirectoryInfo[] folders = folder.GetDirectories();
                foreach (DirectoryInfo di in folders)
                {
                    TreeNode nd = new TreeNode();
                    nd.Text = di.Name;
                    nd.Tag = di;
                    tnode.Nodes.Add(nd);

                }
            }
            //Display data of drives on Rightside
            DirectoryInfo diDetails = (DirectoryInfo)tnode.Tag;
            FileInfo[] files = diDetails.GetFiles();
            listView1.Items.Clear();
            foreach (FileInfo file in files)
            {

                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = file.Name;
                listView1.Items.Add(item);
            }
        }

        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            switch (rbtn.Name)
            {
                case "rdoLargeIcon": listView1.View = View.LargeIcon; break;
                case "rdoSmallIcon": listView1.View = View.SmallIcon; break;
                case "rdoDetails": listView1.View = View.Details; break;
                case "rdoTile": listView1.View = View.Tile; break;
                case "rdoList": listView1.View = View.List; break;
            }
        }
    }
}
