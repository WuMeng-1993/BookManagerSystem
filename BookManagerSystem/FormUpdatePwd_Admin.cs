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
    public partial class FormUpdatePwd_Admin : Form
    {
        public FormUpdatePwd_Admin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 判断输入是否为空
            if (this.tbOldPwd.Text == "" || this.tbNewPwd.Text == "" || this.tbConfirmPwd.Text == "")
            {
                MessageBox.Show("输入不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 判断新密码和确认密码是否一致
            if (this.tbNewPwd.Text != this.tbConfirmPwd.Text)
            {
                MessageBox.Show("两次输入的密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 判断原密码是否正确
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select Password from T_Admin where AdminID = '{Form1.id}'";
            SqlDataReader reader = dao.read(sql);
            reader.Read();
            if (reader[0].ToString() != tbOldPwd.Text) 
            {
                MessageBox.Show("原密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                sql = $"update T_Admin set Password = '{tbNewPwd.Text}' where AdminID = '{Form1.id}'";
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

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
