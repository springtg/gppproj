namespace Pharmacy
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdDn = new DevComponents.DotNetBar.ButtonX();
            this.cmdTHoat = new DevComponents.DotNetBar.ButtonX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cachedrptXuat1 = new Pharmacy.BaoCao.RPT.CachedrptXuat();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.083333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.91666F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 150);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 144);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cmdDn);
            this.panel1.Controls.Add(this.cmdTHoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 37);
            this.panel1.TabIndex = 7;
            // 
            // cmdDn
            // 
            this.cmdDn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdDn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdDn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDn.ForeColor = System.Drawing.Color.White;
            this.cmdDn.Location = new System.Drawing.Point(30, 5);
            this.cmdDn.Margin = new System.Windows.Forms.Padding(0);
            this.cmdDn.Name = "cmdDn";
            this.cmdDn.Size = new System.Drawing.Size(85, 27);
            this.cmdDn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdDn.TabIndex = 2;
            this.cmdDn.Text = "Đăng &nhập";
            this.cmdDn.Click += new System.EventHandler(this.cmdDn_Click);
            // 
            // cmdTHoat
            // 
            this.cmdTHoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdTHoat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cmdTHoat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTHoat.ForeColor = System.Drawing.Color.White;
            this.cmdTHoat.Location = new System.Drawing.Point(142, 5);
            this.cmdTHoat.Margin = new System.Windows.Forms.Padding(0);
            this.cmdTHoat.Name = "cmdTHoat";
            this.cmdTHoat.Size = new System.Drawing.Size(85, 27);
            this.cmdTHoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.cmdTHoat.TabIndex = 3;
            this.cmdTHoat.Text = "&Thoát";
            this.cmdTHoat.Click += new System.EventHandler(this.cmdTHoat_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtUser.FocusHighlightEnabled = true;
            this.txtUser.Location = new System.Drawing.Point(107, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 24);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtPass.FocusHighlightEnabled = true;
            this.txtPass.Location = new System.Drawing.Point(107, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(146, 24);
            this.txtPass.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(4, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Mật khẩu:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(2, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Tên đăng nhập:";
            // 
            // frmLogin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(300, 220);
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::Đăng nhập::..";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.ButtonX cmdTHoat;
        private DevComponents.DotNetBar.ButtonX cmdDn;
        private BaoCao.RPT.CachedrptXuat cachedrptXuat1;
        private System.Windows.Forms.Panel panel1;

    }
}