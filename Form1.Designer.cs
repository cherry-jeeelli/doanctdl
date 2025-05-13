namespace DijkstraTest2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.tbLiter = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.southMap = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.southMap)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.FloralWhite;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold);
            this.lbInfo.Location = new System.Drawing.Point(82, 16);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(855, 32);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Ứng dụng thuật toán Dijkstra tìm kiếm đường đi tối ưu chi phí vận tải";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bảng ước tính chi phí vận chuyển";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(180, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm đi:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(532, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm đến:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Provinces/Cities in South Vietnam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSource
            // 
            this.cbSource.BackColor = System.Drawing.SystemColors.Info;
            this.cbSource.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(299, 60);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(155, 33);
            this.cbSource.TabIndex = 1;
            // 
            // cbDestination
            // 
            this.cbDestination.BackColor = System.Drawing.SystemColors.Info;
            this.cbDestination.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(662, 60);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(155, 33);
            this.cbDestination.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbPath);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbKM);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lable12);
            this.panel3.Controls.Add(this.tbLiter);
            this.panel3.Controls.Add(this.tbCost);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(442, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 290);
            this.panel3.TabIndex = 10;
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.SystemColors.Info;
            this.tbPath.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbPath.Location = new System.Drawing.Point(173, 224);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(383, 29);
            this.tbPath.TabIndex = 8;
            // 
            // tbKM
            // 
            this.tbKM.BackColor = System.Drawing.SystemColors.Info;
            this.tbKM.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tbKM.Location = new System.Drawing.Point(173, 57);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(231, 32);
            this.tbKM.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi phí vận tải:";
            // 
            // lable12
            // 
            this.lable12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lable12.Location = new System.Drawing.Point(17, 60);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(269, 45);
            this.lable12.TabIndex = 10;
            this.lable12.Text = "Quãng đường đi:";
            // 
            // tbLiter
            // 
            this.tbLiter.BackColor = System.Drawing.SystemColors.Info;
            this.tbLiter.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tbLiter.Location = new System.Drawing.Point(173, 114);
            this.tbLiter.Name = "tbLiter";
            this.tbLiter.Size = new System.Drawing.Size(231, 32);
            this.tbLiter.TabIndex = 9;
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.SystemColors.Info;
            this.tbCost.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tbCost.Location = new System.Drawing.Point(173, 168);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(231, 32);
            this.tbCost.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(17, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đường đi:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(17, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tổng nhiên liệu:";
            // 
            // southMap
            // 
            this.southMap.Location = new System.Drawing.Point(3, 3);
            this.southMap.Name = "southMap";
            this.southMap.Size = new System.Drawing.Size(249, 376);
            this.southMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.southMap.TabIndex = 3;
            this.southMap.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FloralWhite;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel4.Controls.Add(this.southMap);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(162, 110);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(255, 384);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.southMap)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            //
            // 
            // btnRun
            // 
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(442, 410); // Vị trí bạn muốn
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(200, 40);
            this.btnRun.Text = "Tính đường đi";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            this.Controls.Add(this.btnRun);

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbLiter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.PictureBox southMap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnRun;

    }
}


