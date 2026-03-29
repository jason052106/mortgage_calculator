namespace mortgage_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDownPaymentType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblInsideUnit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalHousePrise = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResultFirstPrincipal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLoanYears = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13lblResultFirstPrincipal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblResultTotalPayment = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblResultTotalInterest = new System.Windows.Forms.Label();
            this.lblResultFirstPrincipal = new System.Windows.Forms.Label();
            this.lblResultFirstInterest = new System.Windows.Forms.Label();
            this.lblResultMonthlyPayment = new System.Windows.Forms.Label();
            this.lblResultTotalLoan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "房   屋   總   價：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(164, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "貸   款   利   率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "貸   款   年   限：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(35, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "寬      限      期 ：";
            // 
            // cmbDownPaymentType
            // 
            this.cmbDownPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownPaymentType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbDownPaymentType.FormattingEnabled = true;
            this.cmbDownPaymentType.Items.AddRange(new object[] {
            "自備款比例",
            "自備款金額"});
            this.cmbDownPaymentType.Location = new System.Drawing.Point(35, 95);
            this.cmbDownPaymentType.Name = "cmbDownPaymentType";
            this.cmbDownPaymentType.Size = new System.Drawing.Size(132, 34);
            this.cmbDownPaymentType.TabIndex = 1;
            this.cmbDownPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDownPayment);
            this.panel1.Controls.Add(this.lblInsideUnit);
            this.panel1.Location = new System.Drawing.Point(203, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 29);
            this.panel1.TabIndex = 11;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDownPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(0, 0);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(318, 28);
            this.txtDownPayment.TabIndex = 2;
            this.txtDownPayment.Enter += new System.EventHandler(this.txtDownPayment_Enter);
            // 
            // lblInsideUnit
            // 
            this.lblInsideUnit.AutoSize = true;
            this.lblInsideUnit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInsideUnit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInsideUnit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInsideUnit.Location = new System.Drawing.Point(318, 0);
            this.lblInsideUnit.Name = "lblInsideUnit";
            this.lblInsideUnit.Size = new System.Drawing.Size(31, 26);
            this.lblInsideUnit.TabIndex = 0;
            this.lblInsideUnit.Text = "%";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotalHousePrise);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(203, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 29);
            this.panel2.TabIndex = 1;
            // 
            // txtTotalHousePrise
            // 
            this.txtTotalHousePrise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalHousePrise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalHousePrise.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalHousePrise.Location = new System.Drawing.Point(0, 0);
            this.txtTotalHousePrise.Name = "txtTotalHousePrise";
            this.txtTotalHousePrise.Size = new System.Drawing.Size(257, 28);
            this.txtTotalHousePrise.TabIndex = 0;
            this.txtTotalHousePrise.Enter += new System.EventHandler(this.txtTotalHousePrise_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(257, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "元(NTD)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtResultFirstPrincipal);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(203, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 29);
            this.panel3.TabIndex = 13;
            // 
            // txtResultFirstPrincipal
            // 
            this.txtResultFirstPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultFirstPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResultFirstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.txtResultFirstPrincipal.Name = "txtResultFirstPrincipal";
            this.txtResultFirstPrincipal.Size = new System.Drawing.Size(318, 28);
            this.txtResultFirstPrincipal.TabIndex = 3;
            this.txtResultFirstPrincipal.Enter += new System.EventHandler(this.txtInterestRate_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(318, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "%";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtLoanYears);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(203, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 29);
            this.panel4.TabIndex = 14;
            // 
            // txtLoanYears
            // 
            this.txtLoanYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoanYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoanYears.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanYears.Location = new System.Drawing.Point(0, 0);
            this.txtLoanYears.Name = "txtLoanYears";
            this.txtLoanYears.Size = new System.Drawing.Size(316, 28);
            this.txtLoanYears.TabIndex = 4;
            this.txtLoanYears.Enter += new System.EventHandler(this.txtLoanYears_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(316, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "年";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtGracePeriod);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(203, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 29);
            this.panel5.TabIndex = 15;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGracePeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGracePeriod.Location = new System.Drawing.Point(0, 0);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(316, 28);
            this.txtGracePeriod.TabIndex = 5;
            this.txtGracePeriod.Enter += new System.EventHandler(this.txtGracePeriod_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(316, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "年";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(40, 361);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(514, 38);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "開始試算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(40, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(514, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "重新試算";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 68);
            this.label10.TabIndex = 18;
            this.label10.Text = "貸款總金額：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(4, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 68);
            this.label11.TabIndex = 19;
            this.label11.Text = "每月應繳金額(本+息)：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(4, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 68);
            this.label12.TabIndex = 20;
            this.label12.Text = "首期利息：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13lblResultFirstPrincipal
            // 
            this.label13lblResultFirstPrincipal.AutoSize = true;
            this.label13lblResultFirstPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13lblResultFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13lblResultFirstPrincipal.Location = new System.Drawing.Point(4, 208);
            this.label13lblResultFirstPrincipal.Name = "label13lblResultFirstPrincipal";
            this.label13lblResultFirstPrincipal.Size = new System.Drawing.Size(117, 68);
            this.label13lblResultFirstPrincipal.TabIndex = 21;
            this.label13lblResultFirstPrincipal.Text = "首期本金：";
            this.label13lblResultFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2174F));
            this.tableLayoutPanel1.Controls.Add(this.lblResultTotalPayment, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblResultTotalInterest, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblResultFirstPrincipal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblResultFirstInterest, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblResultMonthlyPayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblResultTotalLoan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13lblResultFirstPrincipal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 519);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 419);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // lblResultTotalPayment
            // 
            this.lblResultTotalPayment.AutoSize = true;
            this.lblResultTotalPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultTotalPayment.Location = new System.Drawing.Point(243, 346);
            this.lblResultTotalPayment.Name = "lblResultTotalPayment";
            this.lblResultTotalPayment.Size = new System.Drawing.Size(266, 72);
            this.lblResultTotalPayment.TabIndex = 31;
            this.lblResultTotalPayment.Text = "0.00";
            this.lblResultTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(4, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 68);
            this.label14.TabIndex = 30;
            this.label14.Text = "總利息支出：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(4, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 72);
            this.label15.TabIndex = 29;
            this.label15.Text = "總還款金額：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultTotalInterest
            // 
            this.lblResultTotalInterest.AutoSize = true;
            this.lblResultTotalInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultTotalInterest.Location = new System.Drawing.Point(243, 277);
            this.lblResultTotalInterest.Name = "lblResultTotalInterest";
            this.lblResultTotalInterest.Size = new System.Drawing.Size(266, 68);
            this.lblResultTotalInterest.TabIndex = 28;
            this.lblResultTotalInterest.Text = "0.00";
            this.lblResultTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultFirstPrincipal
            // 
            this.lblResultFirstPrincipal.AutoSize = true;
            this.lblResultFirstPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultFirstPrincipal.Location = new System.Drawing.Point(243, 208);
            this.lblResultFirstPrincipal.Name = "lblResultFirstPrincipal";
            this.lblResultFirstPrincipal.Size = new System.Drawing.Size(266, 68);
            this.lblResultFirstPrincipal.TabIndex = 27;
            this.lblResultFirstPrincipal.Text = "0.00";
            this.lblResultFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultFirstInterest
            // 
            this.lblResultFirstInterest.AutoSize = true;
            this.lblResultFirstInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultFirstInterest.Location = new System.Drawing.Point(243, 139);
            this.lblResultFirstInterest.Name = "lblResultFirstInterest";
            this.lblResultFirstInterest.Size = new System.Drawing.Size(266, 68);
            this.lblResultFirstInterest.TabIndex = 26;
            this.lblResultFirstInterest.Text = "0.00";
            this.lblResultFirstInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultMonthlyPayment
            // 
            this.lblResultMonthlyPayment.AutoSize = true;
            this.lblResultMonthlyPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultMonthlyPayment.Location = new System.Drawing.Point(243, 70);
            this.lblResultMonthlyPayment.Name = "lblResultMonthlyPayment";
            this.lblResultMonthlyPayment.Size = new System.Drawing.Size(266, 68);
            this.lblResultMonthlyPayment.TabIndex = 25;
            this.lblResultMonthlyPayment.Text = "0.00";
            this.lblResultMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTotalLoan
            // 
            this.lblResultTotalLoan.AutoSize = true;
            this.lblResultTotalLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultTotalLoan.Location = new System.Drawing.Point(243, 1);
            this.lblResultTotalLoan.Name = "lblResultTotalLoan";
            this.lblResultTotalLoan.Size = new System.Drawing.Size(266, 68);
            this.lblResultTotalLoan.TabIndex = 24;
            this.lblResultTotalLoan.Text = "0.00";
            this.lblResultTotalLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(587, 990);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbDownPaymentType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "房貸計算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDownPaymentType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblInsideUnit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalHousePrise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResultFirstPrincipal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLoanYears;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13lblResultFirstPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblResultTotalInterest;
        private System.Windows.Forms.Label lblResultFirstPrincipal;
        private System.Windows.Forms.Label lblResultFirstInterest;
        private System.Windows.Forms.Label lblResultMonthlyPayment;
        private System.Windows.Forms.Label lblResultTotalLoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblResultTotalPayment;
    }
}

