using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mortgage_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDownPaymentType.SelectedIndex == 0) //自備款比例
            {
                lblInsideUnit.Text = "%"; 
                txtDownPayment.Text = "請輸入自備款比例";
                txtDownPayment.ForeColor = Color.Gray;
            }
            else // 自備款金額
            {
                lblInsideUnit.Text = "元"; 
                txtDownPayment.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDownPaymentType.SelectedIndex = 0;

            txtDownPayment.Text = "請輸入自備款比例";
            txtDownPayment.ForeColor = Color.LightGray;

            txtTotalHousePrise.Text = "請輸入金額";
            txtTotalHousePrise.ForeColor = Color.LightGray;

            txtResultFirstPrincipal.Text = "請輸入年利率";
            txtResultFirstPrincipal.ForeColor = Color.LightGray;

            txtLoanYears.Text = "請輸入年限";
            txtLoanYears.ForeColor = Color.LightGray;

            txtGracePeriod.Text = "請輸入期限";
            txtGracePeriod.ForeColor = Color.LightGray;

            this.ActiveControl = label12;
        }

        private void txtDownPayment_Enter(object sender, EventArgs e)
        {
            if(txtDownPayment.Text == "請輸入自備款比例")
            {
                txtDownPayment.Text = "";
                txtDownPayment.ForeColor = Color.Black;
            }
        }

        private void txtTotalHousePrise_Enter(object sender, EventArgs e)
        {
            if(txtTotalHousePrise.Text == "請輸入金額")
            {
                txtTotalHousePrise.Text = "";
                txtTotalHousePrise.ForeColor = Color.Black;
            }
        }

        private void txtInterestRate_Enter(object sender, EventArgs e)
        {
            if(txtResultFirstPrincipal.Text == "請輸入年利率")
            {
                txtResultFirstPrincipal.Text = "";
                txtResultFirstPrincipal.ForeColor = Color.Black;
            }
        }

        private void txtLoanYears_Enter(object sender, EventArgs e)
        {
            if(txtLoanYears.Text == "請輸入年限")
            {
                txtLoanYears.Text = "";
                txtLoanYears.ForeColor = Color.Black;
            }
        }

        private void txtGracePeriod_Enter(object sender, EventArgs e)
        {
            if(txtGracePeriod.Text == "請輸入期限")
            {
                txtGracePeriod.Text = "";
                txtGracePeriod.ForeColor = Color.Black;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTotalHousePrise.Text, out double totalHousePrice) || totalHousePrice <= 0)
            {
                MessageBox.Show("請輸入大於 0 的房屋總價！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDownPayment.Text, out double downPaymentInput) || downPaymentInput < 0)
            {
                MessageBox.Show("請輸入正確的自備款數值！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtResultFirstPrincipal.Text, out double annualInterestRate) || annualInterestRate < 0)
            {
                MessageBox.Show("請輸入正確的貸款年利率！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtLoanYears.Text, out int loanTermYears) || loanTermYears <= 0)
            {
                MessageBox.Show("貸款年限必須是大於 0 的整數！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 寬限期為選填，若空白則預設為 0
            int gracePeriodYears = 0;
            if (!string.IsNullOrWhiteSpace(txtGracePeriod.Text))
            {
                if (!int.TryParse(txtGracePeriod.Text, out gracePeriodYears) || gracePeriodYears < 0)
                {
                    MessageBox.Show("寬限期必須是 0 或正整數！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 邏輯防呆：寬限期不能大於或等於貸款總年限
            if (gracePeriodYears >= loanTermYears)
            {
                MessageBox.Show("寬限期不能大於或等於總貸款年限！", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double downPaymentAmount = 0;
            // 判斷下拉選單：0 是比例，1 是金額
            if (cmbDownPaymentType.SelectedIndex == 0)
            {
                downPaymentAmount = totalHousePrice * (downPaymentInput / 100.0);
            }
            else
            {
                downPaymentAmount = downPaymentInput;
            }

            // 貸款總金額
            double totalLoan = totalHousePrice - downPaymentAmount;
            if (totalLoan <= 0)
            {
                MessageBox.Show("自備款大於或等於房屋總價，無需貸款！", "邏輯提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 單位轉換 (年轉月，年利率轉月利率)
            double monthlyRate = (annualInterestRate / 100.0) / 12.0;
            int totalMonths = loanTermYears * 12;
            int graceMonths = gracePeriodYears * 12;
            int amortizedMonths = totalMonths - graceMonths; // 實際攤還本息的期數

            double firstMonthInterest = 0;
            double firstMonthPrincipal = 0;
            double monthlyPaymentAmortized = 0; // 寬限期後的每月本息攤還額
            double totalPayment = 0;
            double totalInterest = 0;

            // 首期利息 = 貸款總額 * 月利率
            firstMonthInterest = totalLoan * monthlyRate;

            // 計算攤還期的每月應繳金額 (處理利率為 0 的極端情況)
            if (monthlyRate == 0)
            {
                monthlyPaymentAmortized = totalLoan / amortizedMonths;
            }
            else
            {
                // 公式：PMT = L * [r * (1+r)^m] / [(1+r)^m - 1]
                double temp = Math.Pow(1 + monthlyRate, amortizedMonths);
                monthlyPaymentAmortized = totalLoan * (monthlyRate * temp) / (temp - 1);
            }

            // 根據是否有寬限期，計算首期本金與總還款額
            if (graceMonths > 0)
            {
                // 有寬限期：首期只繳利息，首期本金為 0
                firstMonthPrincipal = 0;

                // 總還款額 = (寬限期月數 * 每月利息) + (攤還期月數 * 攤還期每月應繳)
                totalPayment = (firstMonthInterest * graceMonths) + (monthlyPaymentAmortized * amortizedMonths);
            }
            else
            {
                // 無寬限期：首期本金 = 每月應繳金額 - 首期利息
                firstMonthPrincipal = monthlyPaymentAmortized - firstMonthInterest;

                // 總還款額 = 總期數 * 每月應繳金額
                totalPayment = monthlyPaymentAmortized * totalMonths;
            }

            // 總利息支出 = 總還款額 - 貸款總額
            totalInterest = totalPayment - totalLoan;

            // 使用 "N2" 加上千分位逗號，並精確到小數點後兩位

            lblResultTotalLoan.Text = $"{totalLoan.ToString("N2")} 元";
            lblResultFirstInterest.Text = $"{firstMonthInterest.ToString("N2")} 元";
            lblResultFirstPrincipal.Text = $"{firstMonthPrincipal.ToString("N2")} 元";
            lblResultTotalInterest.Text = $"{totalInterest.ToString("N2")} 元";
            lblResultTotalPayment.Text = $"{totalPayment.ToString("N2")} 元";

            // 每月應繳金額顯示邏輯 (若有寬限期，需標示兩階段的金額)
            if (graceMonths > 0)
            {
                lblResultMonthlyPayment.Text = $"前 {gracePeriodYears} 年每月: {firstMonthInterest:N2} 元\r\n第 {gracePeriodYears + 1} 年起每月: {monthlyPaymentAmortized:N2} 元";
            }
            else
            {
                lblResultMonthlyPayment.Text = $"{monthlyPaymentAmortized.ToString("N2")} 元";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            // 清空基本的輸入框
            txtTotalHousePrise.Clear();
            txtResultFirstPrincipal.Clear();
            txtLoanYears.Clear();
            txtGracePeriod.Clear();

            // 恢復下拉式選單與自備款的預設值
            cmbDownPaymentType.SelectedIndex = 0; 
            txtDownPayment.Text = "";           
       
            txtDownPayment.Text = "請輸入自備款比例";
            txtDownPayment.ForeColor = Color.LightGray;

            txtTotalHousePrise.Text = "請輸入金額";
            txtTotalHousePrise.ForeColor = Color.LightGray;

            txtResultFirstPrincipal.Text = "請輸入年利率";
            txtResultFirstPrincipal.ForeColor = Color.LightGray;

            txtLoanYears.Text = "請輸入年限";
            txtLoanYears.ForeColor = Color.LightGray;

            txtGracePeriod.Text = "請輸入期限";
            txtGracePeriod.ForeColor = Color.LightGray;

            this.ActiveControl = label12;

            // 將結果標籤恢復為預設的 0.00 或空字串
            lblResultTotalLoan.Text = "0.00";
            lblResultFirstInterest.Text = "0.00";
            lblResultFirstPrincipal.Text = "0.00";
            lblResultTotalInterest.Text = "0.00";
            lblResultTotalPayment.Text = "0.00";
            lblResultMonthlyPayment.Text = "0.00";

            txtTotalHousePrise.Focus();
        }
    }
}
