using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerSystem
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUser_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"欢迎你：{Form1.name}  {Form1.id}";
        }

        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？","消息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            { 
                this.Close();
            }
        }
    }
}
