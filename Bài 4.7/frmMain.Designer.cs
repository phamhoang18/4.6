namespace Bai4_StudentMdi
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbProduct = new System.Windows.Forms.ToolStripButton();
            this.tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCascade = new System.Windows.Forms.ToolStripButton();
            this.tsbTileH = new System.Windows.Forms.ToolStripButton();
            this.tsbTileV = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctxMain.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuSystem, this.mnuCatalog, this.mnuWindow });
            this.menuStrip1.MdiWindowListItem = this.mnuWindow;
            this.menuStrip1.Name = "menuStrip1";

            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuLogout, this.mnuExit });
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Text = "Hệ thống";

            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.mnuCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuStudent, this.mnuProduct });
            this.mnuCatalog.Name = "mnuCatalog";
            this.mnuCatalog.Text = "Danh mục";

            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Text = "Quản lý Sinh viên";
            this.mnuStudent.Click += new System.EventHandler(this.mnuStudent_Click);

            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Text = "Quản lý Sản phẩm";
            this.mnuProduct.Click += new System.EventHandler(this.mnuProduct_Click);

            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuCascade, this.mnuTileH, this.mnuTileV });
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Text = "Cửa sổ";

            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);

            this.mnuTileH.Name = "mnuTileH";
            this.mnuTileH.Text = "Tile Horizontal";
            this.mnuTileH.Click += new System.EventHandler(this.mnuTileH_Click);

            this.mnuTileV.Name = "mnuTileV";
            this.mnuTileV.Text = "Tile Vertical";
            this.mnuTileV.Click += new System.EventHandler(this.mnuTileV_Click);

            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbStudent, this.tsbProduct, this.tsSep1, this.tsbCascade, this.tsbTileH, this.tsbTileV });
            this.toolStrip1.Name = "toolStrip1";

            this.tsbStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbStudent.Image = System.Drawing.SystemIcons.Application.ToBitmap();
            this.tsbStudent.Name = "tsbStudent";
            this.tsbStudent.Text = "Sinh viên";
            this.tsbStudent.Click += new System.EventHandler(this.mnuStudent_Click);   // Dùng chung handler với menu

            this.tsbProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbProduct.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            this.tsbProduct.Name = "tsbProduct";
            this.tsbProduct.Text = "Sản phẩm";
            this.tsbProduct.Click += new System.EventHandler(this.mnuProduct_Click);

            this.tsSep1.Name = "tsSep1";

            this.tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbCascade.Image = System.Drawing.SystemIcons.Shield.ToBitmap();
            this.tsbCascade.Name = "tsbCascade";
            this.tsbCascade.Text = "Cascade";
            this.tsbCascade.Click += new System.EventHandler(this.mnuCascade_Click);

            this.tsbTileH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbTileH.Image = System.Drawing.SystemIcons.Question.ToBitmap();
            this.tsbTileH.Name = "tsbTileH";
            this.tsbTileH.Text = "Tile H";
            this.tsbTileH.Click += new System.EventHandler(this.mnuTileH_Click);

            this.tsbTileV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbTileV.Image = System.Drawing.SystemIcons.Warning.ToBitmap();
            this.tsbTileV.Name = "tsbTileV";
            this.tsbTileV.Text = "Tile V";
            this.tsbTileV.Click += new System.EventHandler(this.mnuTileV_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tslUser, this.tslMessage, this.tslProgress, this.tspbProgress, this.tslTime });
            this.statusStrip1.Name = "statusStrip1";

            this.tslUser.Name = "tslUser";
            this.tslUser.Text = "Người dùng: admin";

            this.tslMessage.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslMessage.Name = "tslMessage";
            this.tslMessage.Spring = true;
            this.tslMessage.Text = "Sẵn sàng";
            this.tslMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.tslProgress.Name = "tslProgress";
            this.tslProgress.Text = "";
            this.tslProgress.Visible = false;

            this.tspbProgress.Maximum = 100;
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(120, 16);
            this.tspbProgress.Visible = false;

            this.tslTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslTime.Name = "tslTime";
            this.tslTime.Text = "";

            this.ctxMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ctxCascade, this.ctxTileH, this.ctxTileV, this.ctxCloseAll });
            this.ctxMain.Name = "ctxMain";

            this.ctxCascade.Name = "ctxCascade";
            this.ctxCascade.Text = "Cascade";
            this.ctxCascade.Click += new System.EventHandler(this.mnuCascade_Click);

            this.ctxTileH.Name = "ctxTileH";
            this.ctxTileH.Text = "Tile Horizontal";
            this.ctxTileH.Click += new System.EventHandler(this.mnuTileH_Click);

            this.ctxTileV.Name = "ctxTileV";
            this.ctxTileV.Text = "Tile Vertical";
            this.ctxTileV.Click += new System.EventHandler(this.mnuTileV_Click);

            this.ctxCloseAll.Name = "ctxCloseAll";
            this.ctxCloseAll.Text = "Đóng tất cả cửa sổ";
            this.ctxCloseAll.Click += new System.EventHandler(this.ctxCloseAll_Click);

            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý (MDI)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileH;
        private System.Windows.Forms.ToolStripMenuItem mnuTileV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStudent;
        private System.Windows.Forms.ToolStripButton tsbProduct;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        private System.Windows.Forms.ToolStripButton tsbCascade;
        private System.Windows.Forms.ToolStripButton tsbTileH;
        private System.Windows.Forms.ToolStripButton tsbTileV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslMessage;
        private System.Windows.Forms.ToolStripStatusLabel tslProgress;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripStatusLabel tslTime;
        private System.Windows.Forms.ContextMenuStrip ctxMain;
        private System.Windows.Forms.ToolStripMenuItem ctxCascade;
        private System.Windows.Forms.ToolStripMenuItem ctxTileH;
        private System.Windows.Forms.ToolStripMenuItem ctxTileV;
        private System.Windows.Forms.ToolStripMenuItem ctxCloseAll;
        private System.Windows.Forms.Timer tmrClock;
    }
}
