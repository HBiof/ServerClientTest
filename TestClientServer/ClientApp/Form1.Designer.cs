namespace ClientApp
{
    partial class Form1
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
            this.txbUserName = new VDC.FrameWork.XtraEditors.TextEdit();
            this.labelControl1 = new VDC.FrameWork.XtraEditors.LabelControl();
            this.labelControl2 = new VDC.FrameWork.XtraEditors.LabelControl();
            this.txbItems = new VDC.FrameWork.XtraEditors.TextEdit();
            this.labelControl3 = new VDC.FrameWork.XtraEditors.LabelControl();
            this.txbIpAddress = new VDC.FrameWork.XtraEditors.TextEdit();
            this.labelControl4 = new VDC.FrameWork.XtraEditors.LabelControl();
            this.txbPort = new VDC.FrameWork.XtraEditors.TextEdit();
            this.btnConnect = new VDC.FrameWork.XtraEditors.SimpleButton();
            this.btnStartSend = new VDC.FrameWork.XtraEditors.SimpleButton();
            this.labelControl5 = new VDC.FrameWork.XtraEditors.LabelControl();
            this.lbltrangthai = new VDC.FrameWork.XtraEditors.LabelControl();
            this.lblResponse = new VDC.FrameWork.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbIpAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPort.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(67, 10);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(205, 20);
            this.txbUserName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShadownColor = System.Drawing.Color.Empty;
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "UserName:";
            // 
            // 
            // 
            this.labelControl1.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShadownColor = System.Drawing.Color.Empty;
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Số Items:";
            // 
            // 
            // 
            this.labelControl2.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // txbItems
            // 
            this.txbItems.Location = new System.Drawing.Point(67, 36);
            this.txbItems.Name = "txbItems";
            this.txbItems.Size = new System.Drawing.Size(205, 20);
            this.txbItems.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.ShadownColor = System.Drawing.Color.Empty;
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ip Address:";
            // 
            // 
            // 
            this.labelControl3.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // txbIpAddress
            // 
            this.txbIpAddress.Location = new System.Drawing.Point(70, 136);
            this.txbIpAddress.Name = "txbIpAddress";
            this.txbIpAddress.Size = new System.Drawing.Size(202, 20);
            this.txbIpAddress.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.ShadownColor = System.Drawing.Color.Empty;
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Port:";
            // 
            // 
            // 
            this.labelControl4.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(70, 162);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(55, 20);
            this.txbPort.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(116, 226);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStartSend
            // 
            this.btnStartSend.Location = new System.Drawing.Point(197, 226);
            this.btnStartSend.Name = "btnStartSend";
            this.btnStartSend.Size = new System.Drawing.Size(75, 23);
            this.btnStartSend.TabIndex = 9;
            this.btnStartSend.Text = "Gửi";
            this.btnStartSend.Click += new System.EventHandler(this.btnStartSend_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.ShadownColor = System.Drawing.Color.Empty;
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Trạng thái:";
            // 
            // 
            // 
            this.labelControl5.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.Location = new System.Drawing.Point(72, 188);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.ShadownColor = System.Drawing.Color.Empty;
            this.lbltrangthai.Size = new System.Drawing.Size(57, 13);
            this.lbltrangthai.TabIndex = 11;
            this.lbltrangthai.Text = "not connect";
            // 
            // 
            // 
            this.lbltrangthai.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // lblResponse
            // 
            this.lblResponse.Location = new System.Drawing.Point(72, 91);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.ShadownColor = System.Drawing.Color.Empty;
            this.lblResponse.Size = new System.Drawing.Size(0, 13);
            this.lblResponse.TabIndex = 12;
            // 
            // 
            // 
            this.lblResponse.Warning.WarningColor = System.Drawing.Color.Red;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lbltrangthai);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnStartSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txbIpAddress);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txbItems);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txbUserName);
            this.Name = "Form1";
            this.Text = "ClientApp";
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbIpAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPort.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VDC.FrameWork.XtraEditors.TextEdit txbUserName;
        private VDC.FrameWork.XtraEditors.LabelControl labelControl1;
        private VDC.FrameWork.XtraEditors.LabelControl labelControl2;
        private VDC.FrameWork.XtraEditors.TextEdit txbItems;
        private VDC.FrameWork.XtraEditors.LabelControl labelControl3;
        private VDC.FrameWork.XtraEditors.TextEdit txbIpAddress;
        private VDC.FrameWork.XtraEditors.LabelControl labelControl4;
        private VDC.FrameWork.XtraEditors.TextEdit txbPort;
        private VDC.FrameWork.XtraEditors.SimpleButton btnConnect;
        private VDC.FrameWork.XtraEditors.SimpleButton btnStartSend;
        private VDC.FrameWork.XtraEditors.LabelControl labelControl5;
        private VDC.FrameWork.XtraEditors.LabelControl lbltrangthai;
        private VDC.FrameWork.XtraEditors.LabelControl lblResponse;
    }
}

