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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出登陆吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"欢迎你：{Form1.name} {Form1.id}";
        }

        /// <summary>
        /// 管理员的注销账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemLogOff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要注销账号吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = Form1.id;

                Dao dao = new Dao();
                dao.connect();

                string sql = $"delete T_Admin where AdminID = {id}";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("注销成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dao.Daoclose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注销失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dao.Daoclose();
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemUpdatePwd_Click(object sender, EventArgs e)
        {
            FormUpdatePwd_Admin formUpdatePwd_Admin = new FormUpdatePwd_Admin();
            formUpdatePwd_Admin.ShowDialog();
        }
    }
}
