using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWAP
{
    class FileAttr
    {
        private string filedir = "";    //文件路径
        private string filename = "";   //文件名
        private string fileformat = ""; //文件格式
        /// <summary>
        /// 设置文件路径
        /// </summary>
        /// <param name="filedir"></param>
        public void setFileDir(string filedir)
        {
            this.filedir = filedir;
        }
        /// <summary>
        /// 获取文件路径
        /// </summary>
        /// <returns></returns>
        public string getFileDir()
        {
            return filedir;
        }

    }
}
