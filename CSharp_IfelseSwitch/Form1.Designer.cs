﻿namespace CSharp_IfelseSwitch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnIfResult = new System.Windows.Forms.Button();
            this.lblIfResult = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnswitchResult = new System.Windows.Forms.Button();
            this.lblSwitchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2)";
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(12, 24);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(82, 21);
            this.nNumber1.TabIndex = 2;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(133, 24);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(82, 21);
            this.nNumber2.TabIndex = 3;
            // 
            // btnIfResult
            // 
            this.btnIfResult.Location = new System.Drawing.Point(242, 24);
            this.btnIfResult.Name = "btnIfResult";
            this.btnIfResult.Size = new System.Drawing.Size(137, 23);
            this.btnIfResult.TabIndex = 4;
            this.btnIfResult.Text = "Number 비교";
            this.btnIfResult.UseVisualStyleBackColor = true;
            this.btnIfResult.Click += new System.EventHandler(this.btnIfResult_Click);
            // 
            // lblIfResult
            // 
            this.lblIfResult.AutoSize = true;
            this.lblIfResult.Location = new System.Drawing.Point(12, 89);
            this.lblIfResult.Name = "lblIfResult";
            this.lblIfResult.Size = new System.Drawing.Size(11, 12);
            this.lblIfResult.TabIndex = 5;
            this.lblIfResult.Text = "-";
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(14, 160);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(80, 20);
            this.cboxDay.TabIndex = 6;
            this.cboxDay.Text = "월";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "요일선택)";
            // 
            // btnswitchResult
            // 
            this.btnswitchResult.Location = new System.Drawing.Point(242, 157);
            this.btnswitchResult.Name = "btnswitchResult";
            this.btnswitchResult.Size = new System.Drawing.Size(137, 23);
            this.btnswitchResult.TabIndex = 8;
            this.btnswitchResult.Text = "선택 요일 확인";
            this.btnswitchResult.UseVisualStyleBackColor = true;
            this.btnswitchResult.Click += new System.EventHandler(this.btnswitchResult_Click);
            // 
            // lblSwitchResult
            // 
            this.lblSwitchResult.AutoSize = true;
            this.lblSwitchResult.Location = new System.Drawing.Point(12, 226);
            this.lblSwitchResult.Name = "lblSwitchResult";
            this.lblSwitchResult.Size = new System.Drawing.Size(11, 12);
            this.lblSwitchResult.TabIndex = 9;
            this.lblSwitchResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 295);
            this.Controls.Add(this.lblSwitchResult);
            this.Controls.Add(this.btnswitchResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblIfResult);
            this.Controls.Add(this.btnIfResult);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.Button btnIfResult;
        private System.Windows.Forms.Label lblIfResult;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnswitchResult;
        private System.Windows.Forms.Label lblSwitchResult;
    }
}

