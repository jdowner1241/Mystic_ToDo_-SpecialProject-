namespace Mystic_ToDo__SpecialProject_
{
    partial class MainWindow
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
            menubar1 = new CustomControls.Menubar();
            reminderList1 = new CustomControls.ReminderList();
            SuspendLayout();
            // 
            // menubar1
            // 
            menubar1.Location = new Point(-3, -5);
            menubar1.Name = "menubar1";
            menubar1.Size = new Size(1333, 154);
            menubar1.TabIndex = 0;
            // 
            // reminderList1
            // 
            reminderList1.Location = new Point(-3, 123);
            reminderList1.Name = "reminderList1";
            reminderList1.Size = new Size(910, 405);
            reminderList1.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 614);
            Controls.Add(reminderList1);
            Controls.Add(menubar1);
            Margin = new Padding(2);
            Name = "MainWindow";
            Text = "Mystic ToDo";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Menubar menubar1;
        private CustomControls.ReminderList reminderList1;
    }
}
