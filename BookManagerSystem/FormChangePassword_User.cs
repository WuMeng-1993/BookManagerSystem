using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerSystem
{
    public partial class FormChangePassword_User : Form
    {
        public FormChangePassword_User()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 判断输入是否为空
            if (tbOldPassword.Text == "" || tbNewPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("输入不能为空","提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 判断新密码和确认密码是否一致
            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("两次输入的密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dao dao = new Dao();
            dao.connect();
            string sql = $"select Pwd from T_User where Uid = '{Form1.id}'";
            SqlDataReader reader = dao.read(sql);
            reader.Read();

            // 判断原密码是否正确
            if (reader[0].ToString() != tbOldPassword.Text)
            {
                MessageBox.Show("原密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                sql = $"update T_User set Pwd = '{tbNewPassword.Text}' where Uid = '{Form1.id}'";
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();
                    dao.Daoclose();
                    this.Close();
                }
            }
            catch
            { 
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
