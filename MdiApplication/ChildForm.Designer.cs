namespace MdiApplication
{
    partial class ChildForm
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
            components = new System.ComponentModel.Container();
            ChildTextBox = new RichTextBox();
            ChildWindowMenu = new MenuStrip();
            FormatMenuItem = new ToolStripMenuItem();
            ТoggleMenuItem = new ToolStripMenuItem();
            EditToolMenuItem = new ToolStripMenuItem();
            копіюванняToolStripMenuItem = new ToolStripMenuItem();
            вирізатиToolStripMenuItem = new ToolStripMenuItem();
            вставитиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            виділитиToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            копіюватиToolStripMenuItem = new ToolStripMenuItem();
            вирізатиToolStripMenuItem1 = new ToolStripMenuItem();
            вставитиToolStripMenuItem1 = new ToolStripMenuItem();
            видалитиToolStripMenuItem1 = new ToolStripMenuItem();
            виділитиToolStripMenuItem1 = new ToolStripMenuItem();
            ChildWindowMenu.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ChildTextBox
            // 
            ChildTextBox.Dock = DockStyle.Fill;
            ChildTextBox.Location = new Point(0, 33);
            ChildTextBox.Name = "ChildTextBox";
            ChildTextBox.Size = new Size(800, 417);
            ChildTextBox.TabIndex = 0;
            ChildTextBox.Text = "";
            // 
            // ChildWindowMenu
            // 
            ChildWindowMenu.ImageScalingSize = new Size(24, 24);
            ChildWindowMenu.Items.AddRange(new ToolStripItem[] { FormatMenuItem, EditToolMenuItem });
            ChildWindowMenu.Location = new Point(0, 0);
            ChildWindowMenu.Name = "ChildWindowMenu";
            ChildWindowMenu.Size = new Size(800, 33);
            ChildWindowMenu.TabIndex = 1;
            ChildWindowMenu.Text = "menuStrip1";
            // 
            // FormatMenuItem
            // 
            FormatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ТoggleMenuItem });
            FormatMenuItem.MergeAction = MergeAction.Insert;
            FormatMenuItem.MergeIndex = 1;
            FormatMenuItem.Name = "FormatMenuItem";
            FormatMenuItem.Size = new Size(85, 29);
            FormatMenuItem.Text = "F&ormat";
            // 
            // ТoggleMenuItem
            // 
            ТoggleMenuItem.Name = "ТoggleMenuItem";
            ТoggleMenuItem.Size = new Size(266, 34);
            ТoggleMenuItem.Text = "&Toggle Foreground";
            ТoggleMenuItem.Click += ТoggleMenuItem_Click;
            // 
            // EditToolMenuItem
            // 
            EditToolMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копіюванняToolStripMenuItem, вирізатиToolStripMenuItem, вставитиToolStripMenuItem, видалитиToolStripMenuItem, виділитиToolStripMenuItem });
            EditToolMenuItem.Name = "EditToolMenuItem";
            EditToolMenuItem.Size = new Size(58, 29);
            EditToolMenuItem.Text = "Edit";
            // 
            // копіюванняToolStripMenuItem
            // 
            копіюванняToolStripMenuItem.Name = "копіюванняToolStripMenuItem";
            копіюванняToolStripMenuItem.Size = new Size(200, 34);
            копіюванняToolStripMenuItem.Text = "Копіювати";
            копіюванняToolStripMenuItem.Click += копіюванняToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem
            // 
            вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            вирізатиToolStripMenuItem.Size = new Size(200, 34);
            вирізатиToolStripMenuItem.Text = "Вирізати";
            вирізатиToolStripMenuItem.Click += вирізатиToolStripMenuItem_Click;
            // 
            // вставитиToolStripMenuItem
            // 
            вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            вставитиToolStripMenuItem.Size = new Size(200, 34);
            вставитиToolStripMenuItem.Text = "Вставити";
            вставитиToolStripMenuItem.Click += вставитиToolStripMenuItem_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(200, 34);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // виділитиToolStripMenuItem
            // 
            виділитиToolStripMenuItem.Name = "виділитиToolStripMenuItem";
            виділитиToolStripMenuItem.Size = new Size(200, 34);
            виділитиToolStripMenuItem.Text = "Виділити";
            виділитиToolStripMenuItem.Click += виділитиToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { копіюватиToolStripMenuItem, вирізатиToolStripMenuItem1, вставитиToolStripMenuItem1, видалитиToolStripMenuItem1, виділитиToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(171, 164);
            // 
            // копіюватиToolStripMenuItem
            // 
            копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            копіюватиToolStripMenuItem.Size = new Size(170, 32);
            копіюватиToolStripMenuItem.Text = "Копіювати";
            копіюватиToolStripMenuItem.Click += копіюватиToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem1
            // 
            вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            вирізатиToolStripMenuItem1.Size = new Size(170, 32);
            вирізатиToolStripMenuItem1.Text = "Вирізати";
            вирізатиToolStripMenuItem1.Click += вирізатиToolStripMenuItem1_Click;
            // 
            // вставитиToolStripMenuItem1
            // 
            вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            вставитиToolStripMenuItem1.Size = new Size(170, 32);
            вставитиToolStripMenuItem1.Text = "Вставити";
            вставитиToolStripMenuItem1.Click += вставитиToolStripMenuItem1_Click;
            // 
            // видалитиToolStripMenuItem1
            // 
            видалитиToolStripMenuItem1.Name = "видалитиToolStripMenuItem1";
            видалитиToolStripMenuItem1.Size = new Size(170, 32);
            видалитиToolStripMenuItem1.Text = "Видалити";
            видалитиToolStripMenuItem1.Click += видалитиToolStripMenuItem1_Click;
            // 
            // виділитиToolStripMenuItem1
            // 
            виділитиToolStripMenuItem1.Name = "виділитиToolStripMenuItem1";
            виділитиToolStripMenuItem1.Size = new Size(170, 32);
            виділитиToolStripMenuItem1.Text = "Виділити";
            виділитиToolStripMenuItem1.Click += виділитиToolStripMenuItem1_Click;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChildTextBox);
            Controls.Add(ChildWindowMenu);
            MainMenuStrip = ChildWindowMenu;
            Name = "ChildForm";
            Text = "ChildForm";
            ChildWindowMenu.ResumeLayout(false);
            ChildWindowMenu.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ChildTextBox;
        private MenuStrip ChildWindowMenu;
        private ToolStripMenuItem FormatMenuItem;
        private ToolStripMenuItem ТoggleMenuItem;
        private ToolStripMenuItem EditToolMenuItem;
        private ToolStripMenuItem копіюванняToolStripMenuItem;
        private ToolStripMenuItem вирізатиToolStripMenuItem;
        private ToolStripMenuItem вставитиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem виділитиToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem копіюватиToolStripMenuItem;
        private ToolStripMenuItem вирізатиToolStripMenuItem1;
        private ToolStripMenuItem вставитиToolStripMenuItem1;
        private ToolStripMenuItem видалитиToolStripMenuItem1;
        private ToolStripMenuItem виділитиToolStripMenuItem1;
    }
}