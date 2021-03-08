using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasheetGenerator
{
    /// <summary>
    /// The form internally used by <see cref="CustomMessageBox"/> class.
    /// </summary>
    internal partial class CustomMessageForm : Form
    {
        /// <summary>
        /// This constructor is required for designer support.
        /// </summary>
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        public CustomMessageForm(string description)
        {
            InitializeComponent();

            this.lab_Details.Text = description;
        }
    }
    /// <summary>
    /// Your custom message box helper.
    /// </summary>
    public static class CustomMessageBox
    {
        public static void Show(string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new CustomMessageForm(description))
            {
                form.ShowDialog();
            }
        }
    }
}
