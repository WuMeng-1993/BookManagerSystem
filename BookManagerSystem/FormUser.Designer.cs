namespace BookManagerSystem
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.租借管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租借图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈到管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息管理ToolStripMenuItem,
            this.租借管理ToolStripMenuItem,
            this.图书评价ToolStripMenuItem,
            this.系统反馈ToolStripMenuItem,
            this.MenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChangePassword,
            this.MenuItemLogOff});
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(207, 43);
            this.个人信息管理ToolStripMenuItem.Text = "个人信息管理";
            // 
            // MenuItemChangePassword
            // 
            this.MenuItemChangePassword.Name = "MenuItemChangePassword";
            this.MenuItemChangePassword.Size = new System.Drawing.Size(270, 48);
            this.MenuItemChangePassword.Text = "修改密码";
            this.MenuItemChangePassword.Click += new System.EventHandler(this.MenuItemChangePassword_Click);
            // 
            // MenuItemLogOff
            // 
            this.MenuItemLogOff.Name = "MenuItemLogOff";
            this.MenuItemLogOff.Size = new System.Drawing.Size(270, 48);
            this.MenuItemLogOff.Text = "注销账号";
            this.MenuItemLogOff.Click += new System.EventHandler(this.MenuItemLogOff_Click);
            // 
            // 租借管理ToolStripMenuItem
            // 
            this.租借管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租借图书ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.租借管理ToolStripMenuItem.Name = "租借管理ToolStripMenuItem";
            this.租借管理ToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.租借管理ToolStripMenuItem.Text = "租借管理";
            // 
            // 租借图书ToolStripMenuItem
            // 
            this.租借图书ToolStripMenuItem.Name = "租借图书ToolStripMenuItem";
            this.租借图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 48);
            this.租借图书ToolStripMenuItem.Text = "租借图书";
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 48);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            // 
            // 图书评价ToolStripMenuItem
            // 
            this.图书评价ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看评价ToolStripMenuItem});
            this.图书评价ToolStripMenuItem.Name = "图书评价ToolStripMenuItem";
            this.图书评价ToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.图书评价ToolStripMenuItem.Text = "图书评价";
            // 
            // 查看评价ToolStripMenuItem
            // 
            this.查看评价ToolStripMenuItem.Name = "查看评价ToolStripMenuItem";
            this.查看评价ToolStripMenuItem.Size = new System.Drawing.Size(270, 48);
            this.查看评价ToolStripMenuItem.Text = "查看评价";
            // 
            // 系统反馈ToolStripMenuItem
            // 
            this.系统反馈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.反馈到管理员ToolStripMenuItem});
            this.系统反馈ToolStripMenuItem.Name = "系统反馈ToolStripMenuItem";
            this.系统反馈ToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.系统反馈ToolStripMenuItem.Text = "系统反馈";
            // 
            // 反馈到管理员ToolStripMenuItem
            // 
            this.反馈到管理员ToolStripMenuItem.Name = "反馈到管理员ToolStripMenuItem";
            this.反馈到管理员ToolStripMenuItem.Size = new System.Drawing.Size(298, 48);
            this.反馈到管理员ToolStripMenuItem.Text = "反馈到管理员";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.ForeColor = System.Drawing.Color.Red;
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(149, 43);
            this.MenuItemLogout.Text = "退出登录";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem 租借管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租借图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书评价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看评价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈到管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.Label label1;
    }
}