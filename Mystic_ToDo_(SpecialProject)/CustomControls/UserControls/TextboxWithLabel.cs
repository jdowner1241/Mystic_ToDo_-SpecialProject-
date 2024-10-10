using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mystic_ToDo__SpecialProject_.CustomControls.UserControls
{
    public partial class TextboxWithLabel : UserControl
    {
        public TextboxWithLabel()
        {
            DataContext = this;
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private string placeholder;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Placeholder
        {
            get { return placeholder;  }
            set
            {
                placeholder = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName == nameof(Placeholder))
            {
                label1.Text = placeholder;
            }       
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do not call the base class OnPaintBackground to prevent background painting
        }
    }
}
