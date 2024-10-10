namespace Mystic_ToDo__SpecialProject_.CustomControls
{
    partial class ReminderList
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
            editor1 = new Editor();
            SuspendLayout();
            // 
            // editor1
            // 
            editor1.Location = new Point(161, 3);
            editor1.Name = "editor1";
            editor1.Size = new Size(580, 243);
            editor1.TabIndex = 0;
            // 
            // ReminderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editor1);
            Name = "ReminderList";
            Size = new Size(910, 405);
            ResumeLayout(false);
        }

        #endregion

        private Editor editor1;
    }
}
