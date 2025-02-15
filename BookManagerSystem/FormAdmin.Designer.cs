﻿namespace BookManagerSystem
{
    partial class FormAdmin
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
            this.MenuItemUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看用户租借情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下架图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书评价管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息管理ToolStripMenuItem,
            this.业务管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.用户反馈ToolStripMenuItem,
            this.MenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(717, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUpdatePwd,
            this.MenuItemLogOff});
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.个人信息管理ToolStripMenuItem.Text = "个人信息管理";
            // 
            // MenuItemUpdatePwd
            // 
            this.MenuItemUpdatePwd.Name = "MenuItemUpdatePwd";
            this.MenuItemUpdatePwd.Size = new System.Drawing.Size(160, 30);
            this.MenuItemUpdatePwd.Text = "修改密码";
            this.MenuItemUpdatePwd.Click += new System.EventHandler(this.MenuItemUpdatePwd_Click);
            // 
            // MenuItemLogOff
            // 
            this.MenuItemLogOff.Name = "MenuItemLogOff";
            this.MenuItemLogOff.Size = new System.Drawing.Size(160, 30);
            this.MenuItemLogOff.Text = "注销账号";
            this.MenuItemLogOff.Click += new System.EventHandler(this.MenuItemLogOff_Click);
            // 
            // 业务管理ToolStripMenuItem
            // 
            this.业务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看用户租借情况ToolStripMenuItem,
            this.用户信息管理ToolStripMenuItem});
            this.业务管理ToolStripMenuItem.Name = "业务管理ToolStripMenuItem";
            this.业务管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.业务管理ToolStripMenuItem.Text = "业务管理";
            // 
            // 查看用户租借情况ToolStripMenuItem
            // 
            this.查看用户租借情况ToolStripMenuItem.Name = "查看用户租借情况ToolStripMenuItem";
            this.查看用户租借情况ToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.查看用户租借情况ToolStripMenuItem.Text = "查看用户租借情况";
            // 
            // 用户信息管理ToolStripMenuItem
            // 
            this.用户信息管理ToolStripMenuItem.Name = "用户信息管理ToolStripMenuItem";
            this.用户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.用户信息管理ToolStripMenuItem.Text = "用户信息管理";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddBook,
            this.修改图书ToolStripMenuItem,
            this.下架图书ToolStripMenuItem,
            this.搜索图书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // MenuItemAddBook
            // 
            this.MenuItemAddBook.Name = "MenuItemAddBook";
            this.MenuItemAddBook.Size = new System.Drawing.Size(160, 30);
            this.MenuItemAddBook.Text = "添加图书";
            this.MenuItemAddBook.Click += new System.EventHandler(this.MenuItemAddBook_Click);
            // 
            // 修改图书ToolStripMenuItem
            // 
            this.修改图书ToolStripMenuItem.Name = "修改图书ToolStripMenuItem";
            this.修改图书ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.修改图书ToolStripMenuItem.Text = "修改图书";
            // 
            // 下架图书ToolStripMenuItem
            // 
            this.下架图书ToolStripMenuItem.Name = "下架图书ToolStripMenuItem";
            this.下架图书ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.下架图书ToolStripMenuItem.Text = "下架图书";
            // 
            // 搜索图书ToolStripMenuItem
            // 
            this.搜索图书ToolStripMenuItem.Name = "搜索图书ToolStripMenuItem";
            this.搜索图书ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.搜索图书ToolStripMenuItem.Text = "搜索图书";
            // 
            // 用户反馈ToolStripMenuItem
            // 
            this.用户反馈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书评价管理ToolStripMenuItem,
            this.消息管理ToolStripMenuItem});
            this.用户反馈ToolStripMenuItem.Name = "用户反馈ToolStripMenuItem";
            this.用户反馈ToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.用户反馈ToolStripMenuItem.Text = "用户反馈";
            // 
            // 图书评价管理ToolStripMenuItem
            // 
            this.图书评价管理ToolStripMenuItem.Name = "图书评价管理ToolStripMenuItem";
            this.图书评价管理ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.图书评价管理ToolStripMenuItem.Text = "图书评价管理";
            // 
            // 消息管理ToolStripMenuItem
            // 
            this.消息管理ToolStripMenuItem.Name = "消息管理ToolStripMenuItem";
            this.消息管理ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.消息管理ToolStripMenuItem.Text = "消息管理";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.ForeColor = System.Drawing.Color.Red;
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(100, 30);
            this.MenuItemLogout.Text = "退出登录";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "管理员";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUpdatePwd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem 业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看用户租借情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddBook;
        private System.Windows.Forms.ToolStripMenuItem 修改图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下架图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书评价管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.Label label1;
    }
}