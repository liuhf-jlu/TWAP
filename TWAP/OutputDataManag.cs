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
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;

namespace TWAP
{
    public partial class OutputDataManag : Form
    {
        private static string Rpath = "TestObject.accdb";
        //连接字符串
        private static string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\" + Rpath;
        //文件读取的路径
        private string filename;
        //从文件中读取数据放到集合中去
        private List<string> list = new List<string>();
        //记录数据的行数
        private long number = 0;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public OutputDataManag()
        {
            InitializeComponent();
        }

        private void btnSelectOutputData_Click(object sender, EventArgs e)
        {
            openFileDialog1.Reset();
            openFileDialog1.FileName = "选择输出文件";
            Text = openFileDialog1.Title;
            openFileDialog1.Filter = "output*.*;|*.*;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //将路径显示出来
                textBox1.Text = openFileDialog1.FileName;
                filename = textBox1.Text;
                FileStream hr = new FileStream(filename, FileMode.Open);
                //按行文件读
                StreamReader sh = new StreamReader(hr);
                //每行存放的数据
                string data;
                while ((data = sh.ReadLine()) != null)
                {
                    list.Add(data);
                    number++;
                }
                hr.Close();
                sh.Close();
                //richTextBox1.Text = list[8];
            }
        }

        private void btnImportToAccess_Click(object sender, EventArgs e)
        {
            try
            {

                using (OleDbConnection Oled = new OleDbConnection(conn))
                {
                    try
                    {
                        Oled.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //遍历所有文件中的数据
                    for (int i = 9; i < number; i++)
                    {
                        //将一行数据分割成单个数据
                        string[] Data = Regex.Split(list[i], "\\s+", RegexOptions.IgnoreCase);//将所有连续的空格替换掉
                        string sql = "INSERT INTO output_sub VALUES('" + Data[0] + "','" + Data[1] + "','" + Data[2] + "','" + Data[3] + "','" + Data[4] + "','" + Data[5] + "','" + Data[6] + "','" + Data[7] + "','" + Data[8] + "','" + Data[9] + "','" + Data[10] + "','" + Data[11] + "','" + Data[12] + "','" + Data[13] + "','" + Data[14] + "','" + Data[15] + "','" + Data[16] + "','" + Data[17] + "','" + Data[18] + "')";
                        OleDbCommand comm = new OleDbCommand(sql, Oled);
                        comm.ExecuteNonQuery();
                    }
                    //数据库断开连接
                    Oled.Close();
                    if (this.textBox1.Text == "")
                    {
                        MessageBox.Show("文件路径不能为空", "提示");
                    }
                    else
                    {
                        MessageBox.Show("数据添加成功", "提示");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectAccess_Click(object sender, EventArgs e)
        {
            openFileDialog1.Reset();
            openFileDialog1.FileName = "";
            Text = openFileDialog1.Title;
            openFileDialog1.Filter = "*.accdb|*.accdb";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //将路径显示出来
                textBox2.Text = openFileDialog1.FileName;
                filename = textBox2.Text;
                FileStream hr = new FileStream(filename, FileMode.Open);
                //按行文件读
                StreamReader sh = new StreamReader(hr);
                //每行存放的数据
                string data;
                while ((data = sh.ReadLine()) != null)
                {
                    list.Add(data);
                    number++;
                }
                hr.Close();
                sh.Close();
            }
            try
            {
                string path = Path.GetFileName(filename);//只获取文件名output.sub
                //将选中的文件复制到debug目录下
                string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(filename));
                //bool isrewrite = true;
                File.Copy(textBox2.Text, targetPath);
                Rpath = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAccess_Click(object sender, EventArgs e)
        {
            using (OleDbConnection Oled = new OleDbConnection(conn))
            {
                Oled.Open();
                string sql = "select * from output_sub";
                OleDbDataAdapter comm = new OleDbDataAdapter(sql, Oled);
                DataSet ds = new DataSet();
                comm.Fill(ds, "output_sub");
                dataGridAccess.DataSource = ds.Tables["output_sub"];
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            WaterYield wy = new WaterYield();
            wy.WindowState = FormWindowState.Maximized;     //窗体最大化
            wy.Show();
            this.Close();
        }

        private void tsbShowTxt_Click(object sender, EventArgs e)
        {

        }

        private void tsbImportToAccess_Click(object sender, EventArgs e)
        {

        }

        private void tsbShowAccess_Click(object sender, EventArgs e)
        {

        }
    }
}
