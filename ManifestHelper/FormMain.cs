using System;
using System.IO;
using System.Windows.Forms;

namespace ManifestHelper
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLangCode_TextChanged(sender, e);
        }

        private void btnExePath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExePath.Text))
            {
                dgFilePath.InitialDirectory = Path.GetDirectoryName(txtExePath.Text);
            }
            var result = dgFilePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = dgFilePath.FileName;
                txtExePath.Text = filePath;
                txtExePath.Select(filePath.Length, 0);
                string dirName = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                filePath = Path.Combine(dirName, $"{fileName}.manifest");
                txtManifestPath.Text = filePath;
                txtManifestPath.Select(filePath.Length, 0);
            }
        }

        private void btnManifestPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtManifestPath.Text))
            {
                dgFilePath.InitialDirectory = Path.GetDirectoryName(txtManifestPath.Text);
            }
            var result = dgFilePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = dgFilePath.FileName;
                txtManifestPath.Text = filePath;
                txtManifestPath.Select(filePath.Length, 0);
            }
        }

        private void cbLangCode_TextChanged(object sender, EventArgs e)
        {
            string codePage = cbLangCode.Text;
            if (string.IsNullOrEmpty(codePage))
            {
                codePage = "请设置语言代码";
            }
            string manifest = Properties.Resources.ManifestTemplate.Replace("$$$$$", codePage);
            txtPreview.Text = manifest;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string filePath = txtManifestPath.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show(this, "请指定文件路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManifestPath.Focus();
                return;
            }

            string dirName = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dirName))
            {
                try
                {
                    Directory.CreateDirectory(dirName);
                }
                catch
                {
                    MessageBox.Show(this, "创建文件夹失败, 可能权限不足, 可以试试使用管理员权限运行本程序", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            StreamWriter sw = new StreamWriter(filePath, append: false);
            try
            {
                sw.Write(txtPreview.Text);
            }
            catch
            {
                MessageBox.Show(this, "文件写入失败, 可能权限不足, 可以试试使用管理员权限运行本程序", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sw.Close();
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            string extension = Path.GetExtension(filePath);
            if (string.Compare(extension, ".exe", true) == 0)
            {
                e.Effect = DragDropEffects.Move;
            }
            txtExePath.Text = filePath;
            txtExePath.Select(filePath.Length, 0);
            string dirName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            filePath = Path.Combine(dirName, $"{fileName}.manifest");
            txtManifestPath.Text = filePath;
            txtManifestPath.Select(filePath.Length, 0);
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            string localFilePath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string extension = Path.GetExtension(localFilePath);
            if (string.Compare(extension, ".exe", true) == 0)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
