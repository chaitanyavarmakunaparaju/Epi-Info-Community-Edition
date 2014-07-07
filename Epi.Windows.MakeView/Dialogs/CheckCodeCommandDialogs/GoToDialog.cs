#region Namespaces

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Epi;
using System.Windows.Forms;
using Epi.Windows.Dialogs;
using Epi.Fields;

#endregion  //Namespaces

namespace Epi.Windows.MakeView.Dialogs.CheckCodeCommandDialogs
{
	/// <summary>
	/// ***** This is a wireframe and currently contains no functionality *****
	/// </summary>
    public partial class GoToDialog : CheckCodeDesignDialog
    {
        #region Private Data Members
        View currentView;
        #endregion  //Private Data Members

        #region Constructors

        /// <summary>
		/// Constructor for the class
		/// </summary>
        [Obsolete("Use of default constructor not allowed", true)]
		public GoToDialog()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Constructor of the GoTo dialog
        /// </summary>
        /// <param name="frm">The main form</param>
		public GoToDialog(MainForm frm) : base(frm)
        {
            InitializeComponent();
        }

        #endregion  //Constructors

        #region Private Event Handlers
        
        /// <summary>
		/// Cancel button closes this dialog 
		/// </summary>
		/// <param name="sender">Object that fired the event</param>
		/// <param name="e">.NET supplied event parameters</param>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        /// <summary>
        /// Handles the Click event of the Ok button
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">.NET supplied event parameters</param>
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            bool fieldNameFound = false;
            foreach (Field field in currentView.Fields)
            {
                if (lbxFields.SelectedItem.ToString().Trim().Equals(field.Name.Trim()))
                {         
                    Output = CommandNames.GOTO + StringLiterals.SPACE + lbxFields.SelectedItem.ToString();
                    fieldNameFound = true;
                    break;
                }                
            }

            if (!fieldNameFound)
            {
                string temp = lbxFields.SelectedItem.ToString();
                string pagePosition = temp.Substring(0, temp.IndexOf(' '));
                Output = CommandNames.GOTO + StringLiterals.SPACE + pagePosition;
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        /// <summary>
        /// Handles the Index Change event of the fields list box
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">.NET supplied event parameters</param>
        private void lbxFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = (lbxFields.SelectedItem != null);
        }

        /// <summary>
        /// Opens a process to show the related help topic
        /// </summary>
        /// <param name="sender">Object that fired the event.</param>
        /// <param name="e">.NET supplied event args.</param>
        protected override void btnHelp_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wwwn.cdc.gov/epiinfo/user-guide/command-reference/check-commands-goto.html");
        }

        #endregion  //Private Event Handlers

        #region Public Properties
        
        /// <summary>
        /// Sets the View for the dialog
        /// </summary>
        public override View View
        {
            set
            {
                foreach (Field field in value.Fields)
                {
                    if (field is Fields.RenderableField && !(field is Fields.LabelField))
                    {
                        lbxFields.Items.Add(field.Name);
                    }
                }               

                foreach (Page page in value.Pages)
                {
                    int position = page.Position + 1;
                    lbxFields.Items.Add(position + "    " + page.Name);                    
                }

                currentView = value;
            }          
        }
        #endregion  //Public Properties

    }
}