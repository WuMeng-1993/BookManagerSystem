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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 静态变量
        public static int id;
        public static string name;

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            FormLogon formLogon = new FormLogon();
            formLogon.ShowDialog();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                this.Close();
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 判断账号和密码是否为空
            if (tbAccount.Text == "" || tbPassword.Text == "") 
            {
                MessageBox.Show("账号或密码不能为空", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 管理员登录
            if (rbAdmin.Checked) 
            {
                AdminLogin();
            }

            // 用户登陆
            if (rbUser.Checked)
            {
                UserLogin();
            }
        }

        /// <summary>
        /// 用户登陆
        /// </summary>
        private void UserLogin()
        {
            int id = int.Parse(tbAccount.Text);
            string password = tbPassword.Text;

            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_User where Uid = {id} and Pwd = {password}";
            SqlDataReader reader = dao.read(sql);
            if (reader.Read())
            {
                Form1.id = id;
                sql = $"select Uname from T_User where Uid = {id}";
                reader = dao.read(sql);
                if (reader.Read())
                {
                    Form1.name = reader["Uname"].ToString();

                    reader.Close();
                    dao.Daoclose();

                    FormUser formUser = new FormUser();
                    formUser.Show();
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        private void AdminLogin()
        {
            int id = int.Parse(tbAccount.Text);
            string password = tbPassword.Text;

            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Admin where AdminID = {id} and Password = {password}";
            SqlDataReader reader = dao.read(sql);
            if (reader.Read())
            {
                Form1.id = id;
                sql = $"select Name from T_Admin where AdminID = {id}";
                reader = dao.read(sql);
                if (reader.Read())
                {
                    Form1.name = reader["Name"].ToString();

                    reader.Close();
                    dao.Daoclose();

                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
