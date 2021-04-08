using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// 取數按鈕確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckNum()) //檢查取數符合規則 
            {
                CalCulateNum();//計算取完後數值
                CheckUI(); //依照新數值更新ui
                JudgeNum(); //判斷獲勝
            }

        }

        /// <summary>
        /// 依照判斷更新ui的狀態
        /// </summary>
        private void CheckUI()
        {

            //初始化取數值
            plget.Visible = false;
            txtgetbox1.Value = 0;
            txtgetbox2.Value = 0;
            txtgetbox3.Value = 0;

            //切換下一個玩家
            btnA.Enabled = !btnA.Enabled;
            btnB.Enabled = !btnB.Enabled;

            if(btnA.Enabled==true)
            {
                txtCurrentUser.Text = "玩家A";
                txtBeforeUser.Text = "玩家B";
            }
            else
            {
                txtCurrentUser.Text = "玩家B";
                txtBeforeUser.Text = "玩家A";
            }

        }

        /// <summary>
        /// 檢查數值正確性
        /// </summary>
        /// <returns>bool 檢查正確為true 可繼續,反之則否</returns>
        private bool CheckNum()
        {
            if (txtgetbox1.Value > txtbox1.Value || txtgetbox2.Value > txtbox2.Value || txtgetbox3.Value > txtbox3.Value)
            {
                MessageBox.Show("取值不得大於剩餘值");
                return false;
            }
            else
            {
                int intrestzero = 0; //儲存為0的取值個數

                //找到三個控件判斷值
                for (int i = 1; i <= 3; i++)
                {
                    if (((NumericUpDown)(this.Controls.Find("txtgetbox"+i.ToString() , true)[0])).Value==0 )
                    {
                        intrestzero++;
                    }
                }


                if (intrestzero < 2)
                {
                    MessageBox.Show("取值不得跨列取值,一次只能取一列");
                    return false;
                }
                else if (intrestzero == 3)
                {
                    MessageBox.Show("必須至少取一列值,不可都不取值");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
        }

        /// <summary>
        /// 計算扣除取值後的數值
        /// </summary>
        private void CalCulateNum()
        {
            txtbox1.Value = txtbox1.Value - txtgetbox1.Value;
            txtbox2.Value = txtbox2.Value - txtgetbox2.Value;
            txtbox3.Value = txtbox3.Value - txtgetbox3.Value;
        }


        /// <summary>
        /// 判斷輸贏,最後剩下三種勝局
        /// 1.只剩下兩堆且各為1個,則當前玩家獲勝
        /// 2.只剩下一堆且超過一個,則當前玩家獲勝(排除玩家故意輸)
        /// 3.只剩下一堆且只有一個,則上一個玩家獲勝
        /// </summary>
        private void JudgeNum()
        {

            int intrestBox = 3; //變數存儲剩餘多少堆

            //找到三個控件判斷值
            for (int i = 1; i <= 3; i++)
            {
                if (((NumericUpDown)(this.Controls.Find("txtbox" + i.ToString(), true)[0])).Value == 0)
                {
                    intrestBox--;
                }
            }

            if (intrestBox == 2) //只剩下兩堆
            {
                //且各只剩下一個,則目前玩家獲勝
                if(txtbox1.Value<=1 && txtbox2.Value <= 1 && txtbox3.Value <= 1)
                {
                    MessageBox.Show(txtCurrentUser.Text + "獲勝");
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                }
            }
            else if (intrestBox == 1) //只剩下一堆
            {
                //且只剩下一個上一個玩家獲勝
                if (txtbox1.Value <= 1 && txtbox2.Value <= 1 && txtbox3.Value <= 1)
                {
                    MessageBox.Show(txtBeforeUser.Text + "獲勝");
                }
                else //否則目前玩家獲勝
                {
                    MessageBox.Show(txtCurrentUser.Text + "獲勝");
                }

                btnA.Enabled = false;
                btnB.Enabled = false;

            }
        }

        //輪到玩家A
        private void btnA_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            plget.Visible = true;
            txtCurrentUser.Text = "玩家A";

        }

        //輪到玩家B
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            plget.Visible = true;
            txtCurrentUser.Text = "玩家B";

        }
    }
}
