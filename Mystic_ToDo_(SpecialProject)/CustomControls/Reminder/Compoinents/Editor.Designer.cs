namespace Mystic_ToDo__SpecialProject_.CustomControls
{
    partial class Editor
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
            textboxWithLabel1 = new UserControls.TextboxWithLabel();
            textboxWithLabel2 = new UserControls.TextboxWithLabel();
            SuspendLayout();
            // 
            // textboxWithLabel1
            // 
            textboxWithLabel1.BackColor = Color.Transparent;
            textboxWithLabel1.DataContext = textboxWithLabel1;
            textboxWithLabel1.Location = new Point(12, 14);
            textboxWithLabel1.Name = "textboxWithLabel1";
            textboxWithLabel1.Placeholder = "Name";
            textboxWithLabel1.Size = new Size(245, 91);
            textboxWithLabel1.TabIndex = 0;
            // 
            // textboxWithLabel2
            // 
            textboxWithLabel2.BackColor = Color.Transparent;
            textboxWithLabel2.DataContext = textboxWithLabel2;
            textboxWithLabel2.Location = new Point(12, 111);
            textboxWithLabel2.Name = "textboxWithLabel2";
            textboxWithLabel2.Placeholder = "Description";
            textboxWithLabel2.Size = new Size(245, 91);
            textboxWithLabel2.TabIndex = 1;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textboxWithLabel2);
            Controls.Add(textboxWithLabel1);
            Name = "Editor";
            Size = new Size(890, 218);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.TextboxWithLabel textboxWithLabel1;
        private UserControls.TextboxWithLabel textboxWithLabel2;
    }
}
