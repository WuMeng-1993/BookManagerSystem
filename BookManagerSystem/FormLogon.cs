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
    public partial class FormLogon : Form
    {
        public FormLogon()
        {
            InitializeComponent();
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

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbIDCard.Text == "") 
            {
                MessageBox.Show("身份证不能为空","消息",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbName.Text == "") 
            {
                MessageBox.Show("姓名不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSex.Text == "")
            {
                MessageBox.Show("性别不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbTel.Text == "")
            {
                MessageBox.Show("电话号码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbPwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbAgainPwd.Text == "")
            {
                MessageBox.Show("确认密码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 读取数据库中账号的最大值，然后+1
            Dao dao = new Dao();
            dao.connect();
            string sql = "select MAX(Uid) from T_User";
            SqlDataReader reader = dao.read(sql);
            reader.Read();
            int id = int.Parse(reader[0].ToString());

            // 获取输入框的值
            string idCard = tbIDCard.Text;
            string name = tbName.Text;
            string sex = cbSex.Text;
            string tel = tbTel.Text;
            string pwd = tbPwd.Text;
            string againPwd = tbAgainPwd.Text;

            // 判断密码前后是否一致
            if (!pwd.Equals(againPwd)) 
            {
                MessageBox.Show("密码不一致", "信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = $"insert into T_User values('{++id}','{name}','{pwd}','{sex}','{idCard}','{tel}','1')";
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show($"注册成功, 账号是{id}", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("注册失败", "信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 关闭数据库
            reader.Close();
            dao.Daoclose();
        }
    }
}
