using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_IfelseSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ifTest();
            switchTest();
        }

        private void switchTest()
        {
            int iRet = 3;

            string strResult = string.Empty;

            switch(iRet)
            {
                case 2:
                case 3:
                    {
                        strResult = "2 나 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;
                default:
                    {
                        strResult = "Unknown";
                    }
                    break;
            }
        }

        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;

            if (ia > ib)
            {
                strResult = "ia가 크다";
            }
            else if (ia < ib)
            {
                strResult = "ib가 크다";
            }
            else
            {
                strResult = "같다";
            }

            strResult = (ia > ib) ? "ia가 크다" : "같다"; // 3항 연산자


            if(ia > 5 && ib > 5)
            {
                strResult = "둘 다 5보다 크다";
            }

            if(ia > 5 || ib > 5)
            {
                strResult = "적어도 둘 중에 하나는 5보다 크다";
            }
        }

        private void btnIfResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if(iNumber1 > iNumber2)
            {
                lblIfResult.Text = string.Format("- Number1이 Number2보다 {0} 더 큽니다.", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblIfResult.Text = string.Format("- Number2가 Number1보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblIfResult.Text = string.Format("두 숫자는 같습니다. 숫자 : {0}", iNumber1);
            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblSwitchResult.Text = " - 선택 날짜는 월요일입니다.";
                    break;
                case "화":
                    lblSwitchResult.Text = " - 선택 날짜는 화요일입니다.";
                    break;
                case "수":
                    lblSwitchResult.Text = " - 선택 날짜는 수요일입니다.";
                    break;
                case "목":
                case "금":
                    lblSwitchResult.Text = " - 선택 날짜는 목요일 또는 금요일 입니다.";
                    break;
                default:
                    lblSwitchResult.Text = " - 선택 날짜는 주말입니다.(토/일)";
                    break;
            }


        }
    }
}
