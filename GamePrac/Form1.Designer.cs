namespace GamePrac
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbox1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.lblgetbox1 = new System.Windows.Forms.Label();
            this.lblgetbox2 = new System.Windows.Forms.Label();
            this.lblgetbox3 = new System.Windows.Forms.Label();
            this.plget = new System.Windows.Forms.Panel();
            this.txtgetbox3 = new System.Windows.Forms.NumericUpDown();
            this.txtgetbox2 = new System.Windows.Forms.NumericUpDown();
            this.txtgetbox1 = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.plpaly = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBeforeUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.NumericUpDown();
            this.txtbox2 = new System.Windows.Forms.NumericUpDown();
            this.txtbox3 = new System.Windows.Forms.NumericUpDown();
            this.plget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox1)).BeginInit();
            this.plpaly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbox1
            // 
            this.lblbox1.AutoSize = true;
            this.lblbox1.Location = new System.Drawing.Point(3, 22);
            this.lblbox1.Name = "lblbox1";
            this.lblbox1.Size = new System.Drawing.Size(62, 18);
            this.lblbox1.TabIndex = 3;
            this.lblbox1.Text = "第一堆";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "第二堆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "第三堆";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(215, 362);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(134, 74);
            this.btnA.TabIndex = 8;
            this.btnA.Text = "玩家A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblgetbox1
            // 
            this.lblgetbox1.AutoSize = true;
            this.lblgetbox1.Location = new System.Drawing.Point(13, 17);
            this.lblgetbox1.Name = "lblgetbox1";
            this.lblgetbox1.Size = new System.Drawing.Size(49, 18);
            this.lblgetbox1.TabIndex = 10;
            this.lblgetbox1.Text = "取數:";
            // 
            // lblgetbox2
            // 
            this.lblgetbox2.AutoSize = true;
            this.lblgetbox2.Location = new System.Drawing.Point(13, 59);
            this.lblgetbox2.Name = "lblgetbox2";
            this.lblgetbox2.Size = new System.Drawing.Size(49, 18);
            this.lblgetbox2.TabIndex = 11;
            this.lblgetbox2.Text = "取數:";
            // 
            // lblgetbox3
            // 
            this.lblgetbox3.AutoSize = true;
            this.lblgetbox3.Location = new System.Drawing.Point(13, 106);
            this.lblgetbox3.Name = "lblgetbox3";
            this.lblgetbox3.Size = new System.Drawing.Size(49, 18);
            this.lblgetbox3.TabIndex = 12;
            this.lblgetbox3.Text = "取數:";
            // 
            // plget
            // 
            this.plget.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plget.Controls.Add(this.txtgetbox3);
            this.plget.Controls.Add(this.txtgetbox2);
            this.plget.Controls.Add(this.txtgetbox1);
            this.plget.Controls.Add(this.btnConfirm);
            this.plget.Controls.Add(this.lblgetbox2);
            this.plget.Controls.Add(this.lblgetbox1);
            this.plget.Controls.Add(this.lblgetbox3);
            this.plget.Location = new System.Drawing.Point(404, 32);
            this.plget.Name = "plget";
            this.plget.Size = new System.Drawing.Size(403, 158);
            this.plget.TabIndex = 15;
            this.plget.Visible = false;
            // 
            // txtgetbox3
            // 
            this.txtgetbox3.Location = new System.Drawing.Point(68, 104);
            this.txtgetbox3.Name = "txtgetbox3";
            this.txtgetbox3.Size = new System.Drawing.Size(120, 29);
            this.txtgetbox3.TabIndex = 20;
            // 
            // txtgetbox2
            // 
            this.txtgetbox2.Location = new System.Drawing.Point(68, 57);
            this.txtgetbox2.Name = "txtgetbox2";
            this.txtgetbox2.Size = new System.Drawing.Size(120, 29);
            this.txtgetbox2.TabIndex = 19;
            // 
            // txtgetbox1
            // 
            this.txtgetbox1.Location = new System.Drawing.Point(68, 17);
            this.txtgetbox1.Name = "txtgetbox1";
            this.txtgetbox1.Size = new System.Drawing.Size(120, 29);
            this.txtgetbox1.TabIndex = 18;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(217, 39);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 74);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(496, 362);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(134, 74);
            this.btnB.TabIndex = 16;
            this.btnB.Text = "玩家B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // plpaly
            // 
            this.plpaly.Controls.Add(this.txtbox3);
            this.plpaly.Controls.Add(this.txtbox2);
            this.plpaly.Controls.Add(this.txtbox1);
            this.plpaly.Controls.Add(this.label1);
            this.plpaly.Controls.Add(this.label2);
            this.plpaly.Controls.Add(this.lblbox1);
            this.plpaly.Location = new System.Drawing.Point(131, 32);
            this.plpaly.Name = "plpaly";
            this.plpaly.Size = new System.Drawing.Size(256, 158);
            this.plpaly.TabIndex = 17;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(846, 49);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(85, 18);
            this.lblCurrentUser.TabIndex = 19;
            this.lblCurrentUser.Text = "目前玩家:";
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(849, 71);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(170, 29);
            this.txtCurrentUser.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "上個玩家:";
            // 
            // txtBeforeUser
            // 
            this.txtBeforeUser.Enabled = false;
            this.txtBeforeUser.Location = new System.Drawing.Point(849, 127);
            this.txtBeforeUser.Name = "txtBeforeUser";
            this.txtBeforeUser.Size = new System.Drawing.Size(170, 29);
            this.txtBeforeUser.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(212, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(607, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "玩法:兩人猜拳誰先開始,則按哪個按鈕先手";
            // 
            // txtbox1
            // 
            this.txtbox1.Enabled = false;
            this.txtbox1.Location = new System.Drawing.Point(77, 22);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(170, 29);
            this.txtbox1.TabIndex = 24;
            this.txtbox1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtbox2
            // 
            this.txtbox2.Enabled = false;
            this.txtbox2.Location = new System.Drawing.Point(77, 65);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(170, 29);
            this.txtbox2.TabIndex = 25;
            this.txtbox2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtbox3
            // 
            this.txtbox3.Enabled = false;
            this.txtbox3.Location = new System.Drawing.Point(77, 115);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(170, 29);
            this.txtbox3.TabIndex = 26;
            this.txtbox3.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBeforeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentUser);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.plpaly);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.plget);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "FrmGamePrac";
            this.plget.ResumeLayout(false);
            this.plget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgetbox1)).EndInit();
            this.plpaly.ResumeLayout(false);
            this.plpaly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblgetbox1;
        private System.Windows.Forms.Label lblgetbox2;
        private System.Windows.Forms.Label lblgetbox3;
        private System.Windows.Forms.Panel plget;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Panel plpaly;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown txtgetbox3;
        private System.Windows.Forms.NumericUpDown txtgetbox2;
        private System.Windows.Forms.NumericUpDown txtgetbox1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBeforeUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtbox3;
        private System.Windows.Forms.NumericUpDown txtbox2;
        private System.Windows.Forms.NumericUpDown txtbox1;
    }
}

