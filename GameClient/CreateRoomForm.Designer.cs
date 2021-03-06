﻿/*
 * 由SharpDevelop创建。
 * 用户： Hasee
 * 日期: 2015/9/4
 * 时间: 16:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace GameClient
{
	partial class CreateRoomForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btn_create = new System.Windows.Forms.Button();
            this.cb_mode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_rule = new System.Windows.Forms.ComboBox();
            this.cb_banlist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_timeout = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_sp1 = new System.Windows.Forms.CheckBox();
            this.chk_sp2 = new System.Windows.Forms.CheckBox();
            this.chk_sp3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_lp = new System.Windows.Forms.ComboBox();
            this.lb_lp = new System.Windows.Forms.Label();
            this.cb_hand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_draw = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Location = new System.Drawing.Point(8, 391);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(244, 46);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_createClick);
            // 
            // cb_mode
            // 
            this.cb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_mode.FormattingEnabled = true;
            this.cb_mode.Items.AddRange(new object[] {
            "Single",
            "Tag",
            "Match"});
            this.cb_mode.Location = new System.Drawing.Point(85, 80);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(156, 21);
            this.cb_mode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Duel Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Allowed cards";
            // 
            // cb_rule
            // 
            this.cb_rule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_rule.FormattingEnabled = true;
            this.cb_rule.Items.AddRange(new object[] {
            "OCG",
            "TCG",
            "OCG＆TCG"});
            this.cb_rule.Location = new System.Drawing.Point(83, 46);
            this.cb_rule.Name = "cb_rule";
            this.cb_rule.Size = new System.Drawing.Size(158, 21);
            this.cb_rule.TabIndex = 2;
            // 
            // cb_banlist
            // 
            this.cb_banlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_banlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_banlist.FormattingEnabled = true;
            this.cb_banlist.Items.AddRange(new object[] {
            "OCG",
            "TCG"});
            this.cb_banlist.Location = new System.Drawing.Point(84, 13);
            this.cb_banlist.Name = "cb_banlist";
            this.cb_banlist.Size = new System.Drawing.Size(157, 21);
            this.cb_banlist.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Banlist";
            // 
            // cb_timeout
            // 
            this.cb_timeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_timeout.FormattingEnabled = true;
            this.cb_timeout.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_timeout.Location = new System.Drawing.Point(85, 116);
            this.cb_timeout.Name = "cb_timeout";
            this.cb_timeout.Size = new System.Drawing.Size(89, 21);
            this.cb_timeout.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time Limit";
            // 
            // chk_sp1
            // 
            this.chk_sp1.AutoSize = true;
            this.chk_sp1.Location = new System.Drawing.Point(6, 23);
            this.chk_sp1.Name = "chk_sp1";
            this.chk_sp1.Size = new System.Drawing.Size(98, 17);
            this.chk_sp1.TabIndex = 9;
            this.chk_sp1.Text = "Obsolete Rules";
            this.chk_sp1.UseVisualStyleBackColor = true;
            // 
            // chk_sp2
            // 
            this.chk_sp2.Location = new System.Drawing.Point(6, 43);
            this.chk_sp2.Name = "chk_sp2";
            this.chk_sp2.Size = new System.Drawing.Size(116, 26);
            this.chk_sp2.TabIndex = 9;
            this.chk_sp2.Text = "Don\'t Check Deck";
            this.chk_sp2.UseVisualStyleBackColor = true;
            // 
            // chk_sp3
            // 
            this.chk_sp3.Location = new System.Drawing.Point(6, 72);
            this.chk_sp3.Name = "chk_sp3";
            this.chk_sp3.Size = new System.Drawing.Size(104, 26);
            this.chk_sp3.TabIndex = 9;
            this.chk_sp3.Text = "Do Not Shuffel";
            this.chk_sp3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "StartingLP";
            // 
            // cb_lp
            // 
            this.cb_lp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_lp.FormattingEnabled = true;
            this.cb_lp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_lp.Location = new System.Drawing.Point(85, 255);
            this.cb_lp.Name = "cb_lp";
            this.cb_lp.Size = new System.Drawing.Size(47, 21);
            this.cb_lp.TabIndex = 5;
            this.cb_lp.SelectedIndexChanged += new System.EventHandler(this.Cb_lpSelectedIndexChanged);
            // 
            // lb_lp
            // 
            this.lb_lp.AutoSize = true;
            this.lb_lp.Location = new System.Drawing.Point(139, 260);
            this.lb_lp.Name = "lb_lp";
            this.lb_lp.Size = new System.Drawing.Size(72, 13);
            this.lb_lp.TabIndex = 11;
            this.lb_lp.Text = "x4000 = 8000";
            // 
            // cb_hand
            // 
            this.cb_hand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_hand.FormattingEnabled = true;
            this.cb_hand.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_hand.Location = new System.Drawing.Point(85, 293);
            this.cb_hand.Name = "cb_hand";
            this.cb_hand.Size = new System.Drawing.Size(47, 21);
            this.cb_hand.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Starting Hand";
            // 
            // cb_draw
            // 
            this.cb_draw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_draw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_draw.FormattingEnabled = true;
            this.cb_draw.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cb_draw.Location = new System.Drawing.Point(211, 293);
            this.cb_draw.Name = "cb_draw";
            this.cb_draw.Size = new System.Drawing.Size(47, 21);
            this.cb_draw.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Card per draw";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(85, 325);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(167, 20);
            this.tb_name.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Room Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(83, 362);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(169, 20);
            this.tb_password.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_sp1);
            this.groupBox1.Controls.Add(this.chk_sp2);
            this.groupBox1.Controls.Add(this.chk_sp3);
            this.groupBox1.Location = new System.Drawing.Point(10, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 103);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minutes";
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_lp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_timeout);
            this.Controls.Add(this.cb_banlist);
            this.Controls.Add(this.cb_rule);
            this.Controls.Add(this.cb_draw);
            this.Controls.Add(this.cb_hand);
            this.Controls.Add(this.cb_lp);
            this.Controls.Add(this.cb_mode);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRoomForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Host";
            this.Load += new System.EventHandler(this.CreateRoomForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cb_draw;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cb_hand;
		private System.Windows.Forms.Label lb_lp;
		private System.Windows.Forms.ComboBox cb_lp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chk_sp3;
		private System.Windows.Forms.CheckBox chk_sp2;
		private System.Windows.Forms.CheckBox chk_sp1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_timeout;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb_banlist;
		private System.Windows.Forms.ComboBox cb_rule;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_mode;
		private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label5;
    }
}
