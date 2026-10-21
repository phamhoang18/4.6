using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4_StudentMdi
{
    public partial class frmMain : Form
    {
        public string CurrentUser { get; } = "admin";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tslUser.Text = "Người dùng: " + CurrentUser;
            UpdateClock();

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    c.ContextMenuStrip = ctxMain;
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            tslTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void OpenChild<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;
                    child.Activate();
                    return;
                }
            }

            T newChild = new T();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void mnuStudent_Click(object sender, EventArgs e)
        {
            OpenChild<frmStudent>();
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý Sản phẩm chưa tồn tại.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CloseAllChildren();
                tslUser.Text = "Người dùng: (đã đăng xuất)";
                SetStatusMessage("Đã đăng xuất");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ctxCloseAll_Click(object sender, EventArgs e)
        {
            CloseAllChildren();
        }

        private void CloseAllChildren()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();
        }

        public void SetStatusMessage(string message)
        {
            tslMessage.Text = DateTime.Now.ToString("HH:mm:ss") + " - " + message;
        }

        public void ReportProgress(int percent, string text)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;

            tslProgress.Visible = true;
            tspbProgress.Visible = true;
            tspbProgress.Value = percent;
            tslProgress.Text = text + ": " + percent + "%";
        }

        public void ResetProgress()
        {
            tspbProgress.Value = 0;
            tspbProgress.Visible = false;
            tslProgress.Text = "";
            tslProgress.Visible = false;
        }
    }
}

