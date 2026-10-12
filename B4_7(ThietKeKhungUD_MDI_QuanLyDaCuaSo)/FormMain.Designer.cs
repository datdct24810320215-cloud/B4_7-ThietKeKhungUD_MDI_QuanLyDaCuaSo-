namespace B4_7_MDI_QuanLyDaCuaSo
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // ---- MENU ----
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileH;
        private System.Windows.Forms.ToolStripMenuItem mnuTileV;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAll;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;

        // ---- TOOLSTRIP ----
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbStudent;
        private System.Windows.Forms.ToolStripButton tsbProduct;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        private System.Windows.Forms.ToolStripButton tsbCascade;
        private System.Windows.Forms.ToolStripButton tsbTileH;
        private System.Windows.Forms.ToolStripButton tsbTileV;
        private System.Windows.Forms.ToolStripSeparator tsSep2;
        private System.Windows.Forms.ToolStripButton tsbExit;

        // ---- STATUS STRIP ----
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;

        // ---- CONTEXT MENU ----
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem cmsCascade;
        private System.Windows.Forms.ToolStripMenuItem cmsTileH;
        private System.Windows.Forms.ToolStripMenuItem cmsTileV;
        private System.Windows.Forms.ToolStripSeparator cmsSep1;
        private System.Windows.Forms.ToolStripMenuItem cmsCloseAll;

        // ---- TIMER ----
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== INSTANTIATE =====
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbProduct = new System.Windows.Forms.ToolStripButton();
            this.tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCascade = new System.Windows.Forms.ToolStripButton();
            this.tsbTileH = new System.Windows.Forms.ToolStripButton();
            this.tsbTileV = new System.Windows.Forms.ToolStripButton();
            this.tsSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();

            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCloseAll = new System.Windows.Forms.ToolStripMenuItem();

            this.timer1 = new System.Windows.Forms.Timer(this.components);

            // ===== SUSPEND LAYOUT =====
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();

            // ===== MENUSTRIP =====
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSystem, this.mnuCategory, this.mnuWindow, this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.mnuWindow;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip.TabIndex = 0;

            // mnuSystem
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuLogout, this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Text = "Hệ thống";

            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.ShortcutKeys = ((System.Windows.Forms.Keys)(
                (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuLogout.Text = "Đăng xuất";

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";

            // mnuCategory
            this.mnuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuStudent, this.mnuProduct});
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Text = "Danh mục";

            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Text = "Quản lý Sinh viên";

            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Text = "Quản lý Sản phẩm";

            // mnuWindow
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuCascade, this.mnuTileH, this.mnuTileV, this.mnuCloseAll});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Text = "Cửa sổ";

            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Text = "Xếp chồng (Cascade)";

            this.mnuTileH.Name = "mnuTileH";
            this.mnuTileH.Text = "Xếp ngang (Tile Horizontal)";

            this.mnuTileV.Name = "mnuTileV";
            this.mnuTileV.Text = "Xếp dọc (Tile Vertical)";

            this.mnuCloseAll.Name = "mnuCloseAll";
            this.mnuCloseAll.Text = "Đóng tất cả";

            // mnuHelp
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Text = "Trợ giúp";

            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "Giới thiệu";

            // ===== TOOLSTRIP =====
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbStudent, this.tsbProduct, this.tsSep1,
                this.tsbCascade, this.tsbTileH, this.tsbTileV,
                this.tsSep2, this.tsbExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1200, 30);
            this.toolStrip.TabIndex = 1;

            this.tsbStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStudent.Name = "tsbStudent";
            this.tsbStudent.Text = "👥 Sinh viên";

            this.tsbProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbProduct.Name = "tsbProduct";
            this.tsbProduct.Text = "📦 Sản phẩm";

            this.tsSep1.Name = "tsSep1";

            this.tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCascade.Name = "tsbCascade";
            this.tsbCascade.Text = "🪟 Cascade";

            this.tsbTileH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTileH.Name = "tsbTileH";
            this.tsbTileH.Text = "⬌ Tile Ngang";

            this.tsbTileV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTileV.Name = "tsbTileV";
            this.tsbTileV.Text = "⬍ Tile Dọc";

            this.tsSep2.Name = "tsSep2";

            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Text = "❌ Thoát";

            // ===== STATUS STRIP =====
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(230, 240, 250);
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblUser, this.lblMessage, this.lblTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 698);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 2;

            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(120, 17);
            this.lblUser.Text = "👤 Người dùng: --";

            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, 
                System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(880, 17);
            this.lblMessage.Spring = true;
            this.lblMessage.Text = "Sẵn sàng";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 17);
            this.lblTime.Text = "--:--:--";

            // ===== CONTEXT MENU =====
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cmsCascade, this.cmsTileH, this.cmsTileV, this.cmsSep1,
                this.cmsCloseAll});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(200, 98);

            this.cmsCascade.Name = "cmsCascade";
            this.cmsCascade.Text = "Xếp chồng (Cascade)";

            this.cmsTileH.Name = "cmsTileH";
            this.cmsTileH.Text = "Xếp ngang";

            this.cmsTileV.Name = "cmsTileV";
            this.cmsTileV.Text = "Xếp dọc";

            this.cmsSep1.Name = "cmsSep1";

            this.cmsCloseAll.Name = "cmsCloseAll";
            this.cmsCloseAll.Text = "Đóng tất cả";

            // ===== TIMER =====
            this.timer1.Interval = 1000;

            // ===== FORM =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý - MDI Application (Bài 4.7)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // ===== RESUME LAYOUT =====
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
