using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TWAP
{
    public partial class WaterQuality : Form
    {
        public WaterQuality()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbBackhome_Click(object sender, EventArgs e)
        {
            Main home = new Main();
            home.Show();
            this.Close();
        }
        /// <summary>
        /// 点源管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbPointSourceManage_Click(object sender, EventArgs e)
        {
            PointSouceManage pointSourceManage = new PointSouceManage();
            pointSourceManage.Show();
        }
        /// <summary>
        /// 面源管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbMgtManage_Click(object sender, EventArgs e)
        {
            SelectMgtSubbasin selectSubbasin = new SelectMgtSubbasin();
            selectSubbasin.Show();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbRefresh_Click(object sender, EventArgs e)
        {
            InitInputTree();
            InitOutputTree();
        }

        /// <summary>
        /// 运行模拟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbRunSWAT_Click(object sender, EventArgs e)
        {
            RunSwatModel rsm = new RunSwatModel();
            rsm.WindowState = FormWindowState.Normal;
            rsm.Show();
        }
        /// <summary>
        /// 输出结果管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wqtsbOutputManage_Click(object sender, EventArgs e)
        {
            //OutputDataManag output = new OutputDataManag();
            //output.WindowState = FormWindowState.Maximized;
            //output.Show();
            ReadSWATOutput output = new ReadSWATOutput();
            output.Show();
        }
        /// <summary>
        /// 加载窗体时将有关文件加载到下拉框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterQuality_Load(object sender, EventArgs e)
        {
            InitInputTree();
            InitOutputTree();

        }
        /// <summary>
        /// 加载模型输入数据
        /// </summary>
        private void InitInputTree()
        {
            treeViewInput.Nodes.Clear();
            treeViewInput.LabelEdit = true;
            TreeNode node_input = new TreeNode();
            node_input.Text = "模型输入数据";
            treeViewInput.Nodes.Add(node_input);

            TreeNode node_point = new TreeNode();
            node_point.Text = "点源";
            node_input.Nodes.Add(node_point);
            List<string> list_point = findFile(Application.StartupPath + "\\TxtInOut", "*p.dat");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_point.Nodes.Add(node);
            }

            TreeNode node_mgt = new TreeNode();
            node_mgt.Text = "面源";
            node_input.Nodes.Add(node_mgt);
            List<string> list_mgt = findFile(Application.StartupPath + "\\TxtInOut", "*.mgt");
            foreach (string file in list_mgt)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_mgt.Nodes.Add(node);
            }

            node_input.Expand();
            node_point.Expand();
            node_mgt.Expand();
        }
        /// <summary>
        /// 加载模型输出数据
        /// </summary>
        private void InitOutputTree()
        {
            treeViewOutput.Nodes.Clear();
            treeViewOutput.LabelEdit = true;
            TreeNode node_output = new TreeNode();
            node_output.Text = "模型输出结果";
            treeViewOutput.Nodes.Add(node_output);
            List<string> list_output = findFile(Application.StartupPath + "\\TxtInOut", "output*.*");
            foreach (string file in list_output)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_output.Nodes.Add(node);
            }
            node_output.Expand();
        }
        /// <summary>
        /// 查找某个文件夹下的指定文件
        /// </summary>
        /// <param name="sourcePath">文件夹</param>
        /// <param name="extension">指定文件</param>
        /// <returns></returns>
        public List<string> findFile(string sourcePath,string extension)
        {
            List<string> list = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(sourcePath);
            FileInfo[] theFileInfo = theFolder.GetFiles(extension, SearchOption.TopDirectoryOnly);
            foreach (FileInfo NextFile in theFileInfo)
                list.Add(NextFile.FullName);
            return list;
        }

        private void treeViewOutput_DoubleClick(object sender, EventArgs e)
        {
            string File = treeViewOutput.SelectedNode.Text.ToString();
            if (File != null)
            {
                System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath + "\\TxtInOut\\" + File);    //调用操作系统的记事本程序来打开文件
            }
            else
            {
                MessageBox.Show("请选择！");
            }
        }

        private void treeViewInput_DoubleClick(object sender, EventArgs e)
        {
            string File = treeViewInput.SelectedNode.Text.ToString();
            if (File != null)
            {
                System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath + "\\TxtInOut\\" + File);    //调用操作系统的记事本程序来打开文件
            }
            else
            {
                MessageBox.Show("请选择！");
            }
        }

    }
}
