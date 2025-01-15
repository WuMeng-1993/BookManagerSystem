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

        /// <summary>
        /// 注销账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemLogOff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要注销账号吗?", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                int id = Form1.id;

                Dao dao = new Dao();
                dao.connect();

                string sql = $"delete T_User where Uid = {id}";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("注销成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dao.Daoclose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注销失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dao.Daoclose();
                }
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemChangePassword_Click(object sender, EventArgs e)
        {
            // 打开修改密码窗体
            FormChangePassword_User formChangePassword_User = new FormChangePassword_User();
            formChangePassword_User.Show();


        }
    }
}
