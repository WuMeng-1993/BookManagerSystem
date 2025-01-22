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
    public partial class FormAddBook : Form
    {
        public FormAddBook()
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
        /// 添加图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == "" || tbName.Text.Trim() == "" || tbAuthor.Text.Trim() == ""
                || tbPublisher.Text.Trim() == "" || tbType.Text.Trim() == "" || tbPrice.Text.Trim() == ""
                || tbNum.Text.Trim() == "" || tbIntorduce.Text.Trim() == "" || TimePicker.Text.Trim() == "")
            {
                MessageBox.Show("输入框不能为空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dao dao = new Dao();
            dao.connect();
            string sql = $"insert into Table_Book values('{int.Parse(tbID.Text)}','{tbName.Text}','{tbAuthor.Text}','{tbPublisher.Text}','{TimePicker.Value}','{tbType.Text}','{float.Parse(tbPrice.Text)}','{int.Parse(tbNum.Text)}','{tbIntorduce.Text}','0')";
            int n = dao.Execute(sql);
            try
            {
                if (n > 0)
                {
                    dao.Daoclose();
                    MessageBox.Show("添加成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("ERROR", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
