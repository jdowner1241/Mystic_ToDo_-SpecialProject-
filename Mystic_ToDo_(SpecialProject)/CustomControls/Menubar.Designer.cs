namespace Mystic_ToDo__SpecialProject_.CustomControls
{
    partial class Menubar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            button_Menu1 = new UserControls.Button_Menu();
            button_Menu2 = new UserControls.Button_Menu();
            button_Menu3 = new UserControls.Button_Menu();
            button_Menu4 = new UserControls.Button_Menu();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // button_Menu1
            // 
            button_Menu1.BackColor = Color.Transparent;
            button_Menu1.BackgroundImageLayout = ImageLayout.None;
            button_Menu1.DataContext = button_Menu1;
            button_Menu1.Location = new Point(13, 25);
            button_Menu1.Name = "button_Menu1";
            button_Menu1.Placeholder = "Reminder";
            button_Menu1.Size = new Size(201, 129);
            button_Menu1.TabIndex = 1;
            // 
            // button_Menu2
            // 
            button_Menu2.BackColor = Color.Transparent;
            button_Menu2.BackgroundImageLayout = ImageLayout.None;
            button_Menu2.DataContext = button_Menu2;
            button_Menu2.Location = new Point(210, 27);
            button_Menu2.Name = "button_Menu2";
            button_Menu2.Placeholder = "Calender";
            button_Menu2.Size = new Size(201, 129);
            button_Menu2.TabIndex = 2;
            // 
            // button_Menu3
            // 
            button_Menu3.BackColor = Color.Transparent;
            button_Menu3.BackgroundImageLayout = ImageLayout.None;
            button_Menu3.DataContext = button_Menu3;
            button_Menu3.Location = new Point(399, 27);
            button_Menu3.Name = "button_Menu3";
            button_Menu3.Placeholder = "Time Table";
            button_Menu3.Size = new Size(201, 129);
            button_Menu3.TabIndex = 3;
            // 
            // button_Menu4
            // 
            button_Menu4.BackColor = Color.Transparent;
            button_Menu4.BackgroundImageLayout = ImageLayout.None;
            button_Menu4.DataContext = button_Menu4;
            button_Menu4.Location = new Point(593, 27);
            button_Menu4.Name = "button_Menu4";
            button_Menu4.Placeholder = "Time Tracker";
            button_Menu4.Size = new Size(201, 129);
            button_Menu4.TabIndex = 4;
            // 
            // Menubar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Menu4);
            Controls.Add(button_Menu3);
            Controls.Add(button_Menu2);
            Controls.Add(button_Menu1);
            Controls.Add(menuStrip1);
            Name = "Menubar";
            Size = new Size(815, 154);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private UserControls.Button_Menu button_Menu1;
        private UserControls.Button_Menu button_Menu2;
        private UserControls.Button_Menu button_Menu3;
        private UserControls.Button_Menu button_Menu4;
    }
}
