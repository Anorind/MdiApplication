namespace MdiApplication
{
    partial class ParentForm
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
            MdiMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            WindowMenuItem = new ToolStripMenuItem();
            WindowCascadeMenuItem = new ToolStripMenuItem();
            WindowTileMenuItem = new ToolStripMenuItem();
            IconToolMenuItem = new ToolStripMenuItem();
            MdiMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MdiMenu
            // 
            MdiMenu.ImageScalingSize = new Size(24, 24);
            MdiMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, WindowMenuItem });
            MdiMenu.Location = new Point(0, 0);
            MdiMenu.MdiWindowListItem = WindowMenuItem;
            MdiMenu.Name = "MdiMenu";
            MdiMenu.Size = new Size(800, 33);
            MdiMenu.TabIndex = 0;
            MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(54, 29);
            FileMenuItem.Text = "File";
            // 
            // NewMenuItem
            // 
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(270, 34);
            NewMenuItem.Text = "&New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(270, 34);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // WindowMenuItem
            // 
            WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WindowCascadeMenuItem, WindowTileMenuItem, IconToolMenuItem });
            WindowMenuItem.Name = "WindowMenuItem";
            WindowMenuItem.Size = new Size(94, 29);
            WindowMenuItem.Text = "Window";
            // 
            // WindowCascadeMenuItem
            // 
            WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            WindowCascadeMenuItem.Size = new Size(179, 34);
            WindowCascadeMenuItem.Text = "&Cascade";
            WindowCascadeMenuItem.Click += WindowCascadeMenuItem_Click;
            // 
            // WindowTileMenuItem
            // 
            WindowTileMenuItem.Name = "WindowTileMenuItem";
            WindowTileMenuItem.Size = new Size(179, 34);
            WindowTileMenuItem.Text = "&Тilе";
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            // 
            // IconToolMenuItem
            // 
            IconToolMenuItem.Name = "IconToolMenuItem";
            IconToolMenuItem.Size = new Size(179, 34);
            IconToolMenuItem.Text = "Icon";
            IconToolMenuItem.Click += IconToolMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MdiMenu);
            IsMdiContainer = true;
            MainMenuStrip = MdiMenu;
            Name = "ParentForm";
            Text = "Form1";
            MdiMenu.ResumeLayout(false);
            MdiMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MdiMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem WindowCascadeMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
        private ToolStripMenuItem IconToolMenuItem;
    }
}