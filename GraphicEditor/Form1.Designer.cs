namespace GraphicEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolMenu = new ToolStrip();
            DrawRectangleBtn = new ToolStripButton();
            SelectShapeBtn = new ToolStripButton();
            mainMenu.SuspendLayout();
            toolMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, imageToolStripMenuItem, helpToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(52, 20);
            imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolMenu
            // 
            toolMenu.ImageScalingSize = new Size(20, 20);
            toolMenu.Items.AddRange(new ToolStripItem[] { DrawRectangleBtn, SelectShapeBtn });
            toolMenu.Location = new Point(0, 24);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(800, 27);
            toolMenu.TabIndex = 1;
            toolMenu.Text = "tool";
            // 
            // DrawRectangleBtn
            // 
            DrawRectangleBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DrawRectangleBtn.Image = (Image)resources.GetObject("DrawRectangleBtn.Image");
            DrawRectangleBtn.ImageTransparentColor = Color.Magenta;
            DrawRectangleBtn.Name = "DrawRectangleBtn";
            DrawRectangleBtn.Size = new Size(24, 24);
            DrawRectangleBtn.Text = "Draw Rectangle";
            DrawRectangleBtn.ToolTipText = "Draw Rectangle";
            DrawRectangleBtn.Click += DrawRectangleBtn_Click;
            // 
            // SelectShapeBtn
            // 
            SelectShapeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SelectShapeBtn.Image = (Image)resources.GetObject("SelectShapeBtn.Image");
            SelectShapeBtn.ImageTransparentColor = Color.Magenta;
            SelectShapeBtn.Name = "SelectShapeBtn";
            SelectShapeBtn.Size = new Size(24, 24);
            SelectShapeBtn.Text = "Select a Shape";
            SelectShapeBtn.Click += SelectShapeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolMenu);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += ReDraw;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            toolMenu.ResumeLayout(false);
            toolMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolMenu;
        private ToolStripButton DrawRectangleBtn;
        private ToolStripButton SelectShapeBtn;
    }
}