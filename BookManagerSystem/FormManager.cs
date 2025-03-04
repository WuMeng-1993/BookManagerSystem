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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载图书信息
        /// </summary>
        private void LoadBooks() 
        {
            Dao dao = new Dao();
            dao.connect();
            string sql = "select * from Table_Book";
            SqlDataReader reader = dao.read(sql);

            while (reader.Read())
            {
                dataGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                );

                reader.Close();
                dao.Daoclose();
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManager_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        /// <summary>
        /// 单击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView.CurrentRow.Cells[1].Value.ToString();

            labelId.Text = id;
            labelName.Text = name;
        }
    }
}
