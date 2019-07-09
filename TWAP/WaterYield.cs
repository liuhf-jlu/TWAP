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
    public partial class WaterYield : Form
    {
        public WaterYield()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddWeatherData_Click(object sender, EventArgs e)
        {
            WeatherInputData weatherInputData = new WeatherInputData();
            weatherInputData.WindowState = FormWindowState.Normal;
            weatherInputData.Show();
        }
        /// <summary>
        /// 运行SWAT模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRunSWATModel_Click(object sender, EventArgs e)
        {
            RunSwatModel rsm = new RunSwatModel();
            rsm.WindowState = FormWindowState.Normal;
            rsm.Show();
        }
        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBackHome_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main();
            mainPage.Show();
            this.Dispose();
            this.Close();
        }
        /// <summary>
        /// 输出数据管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOutputDataManag_Click(object sender, EventArgs e)
        {
            //OutputDataManag output = new OutputDataManag();
            //output.WindowState = FormWindowState.Normal;
            //output.Show();
            ReadSWATOutput output = new ReadSWATOutput();
            output.Show();
        }
        /// <summary>
        /// 重置数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbResetData_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 刷新，将文件名加载到combox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            InitTreeViewInput();
            InitTreeViewOutput();
        }
        /// <summary>
        /// 水库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbReservoirManage_Click(object sender, EventArgs e)
        {
            SelectResevoir selectReservoir = new SelectResevoir();
            selectReservoir.Show();
        }

        private void WaterYield_Load(object sender, EventArgs e)
        {
            InitTreeViewInput();
            InitTreeViewOutput();
        }
        public void InitTreeViewOutput()
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
        /// 初始化TreeViewInput，加载气象原始数据、fork文件、水库原始数据、res文件、mon文件等模型输入文件
        /// </summary>
        public void InitTreeViewInput()
        {
            treeViewInput.Nodes.Clear();    //清空数据
            treeViewInput.LabelEdit = true;  //可编辑状态
            TreeNode node_input = new TreeNode();
            node_input.Text = "模型输入数据";
            treeViewInput.Nodes.Add(node_input);
            TreeNode node_InputWeatherData = new TreeNode();
            node_InputWeatherData.Text = "气象输入数据";
            node_input.Nodes.Add(node_InputWeatherData);
            //pcp
            List<string> list_point = findFile(Application.StartupPath + "\\TxtInOut", "*.pcp");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputWeatherData.Nodes.Add(node);
            }
            //wnd
            list_point = findFile(Application.StartupPath + "\\TxtInOut", "*.wnd");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputWeatherData.Nodes.Add(node);
            }
            //tmp
            list_point = findFile(Application.StartupPath + "\\TxtInOut", "*.tmp");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputWeatherData.Nodes.Add(node);
            }
            //slr
            list_point = findFile(Application.StartupPath + "\\TxtInOut", "*.slr");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputWeatherData.Nodes.Add(node);
            }
            //hmd
            list_point = findFile(Application.StartupPath + "\\TxtInOut", "*.hmd");
            foreach (string file in list_point)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputWeatherData.Nodes.Add(node);
            }

            //加载水库res文件
            TreeNode node_InputRes = new TreeNode();
            node_InputRes.Text = "*.RES";
            node_input.Nodes.Add(node_InputRes);
            List<string> list_res = findFile(Application.StartupPath + "\\TxtInOut", "*.res");
            foreach (string file in list_res)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputRes.Nodes.Add(node);
            }
            //加载水库mon文件
            TreeNode node_InputMon = new TreeNode();
            node_InputMon.Text = "*.MON";
            node_input.Nodes.Add(node_InputMon);
            List<string> list_mon = findFile(Application.StartupPath + "\\TxtInOut", "*.mon");
            foreach (string file in list_mon)
            {
                TreeNode node = new TreeNode();
                node.Text = System.IO.Path.GetFileName(file);
                node_InputMon.Nodes.Add(node);
            }

            node_input.Expand();
            node_InputWeatherData.Expand();
            node_InputRes.Expand();
            node_InputMon.Expand();

        }
        /// <summary>
        /// 查找某个文件夹下的指定文件
        /// </summary>
        /// <param name="sourcePath">文件夹</param>
        /// <param name="extension">指定文件</param>
        /// <returns></returns>
        public List<string> findFile(string sourcePath, string extension)
        {
            List<string> list = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(sourcePath);
            FileInfo[] theFileInfo = theFolder.GetFiles(extension, SearchOption.TopDirectoryOnly);
            foreach (FileInfo NextFile in theFileInfo)
                list.Add(NextFile.FullName);
            return list;
        }
        private void toolStripWaterYield_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// 双击TreeView中的选项时，打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewOfWaterYield_DoubleClick(object sender, EventArgs e)
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


    }
}
