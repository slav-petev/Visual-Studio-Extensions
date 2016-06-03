using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ReadZeroTestsFromFile.CommonObjects;

namespace ReadZeroTestsFromFile.ConfigurationWizard.Windows
{
    public partial class ProjectConfigurationWindow : Form
    {
        //private ProjectConfiguration _projectConfiguration =
        //    new ProjectConfiguration();

        public ProjectConfigurationWindow()
        {
            InitializeComponent();
        }

        private void ProjectConfigurationWindow_Load(object sender, EventArgs e)
        {
            cmbInputSource.SelectedIndex = 0;
            panelInputFileConfiguration.Enabled = EnableFileSelection(
                (string) cmbInputSource.SelectedItem);
        }

        private void btnBrowseInputFile_Click(object sender, EventArgs e)
        {
            fdlgInputFile.ShowDialog();
        }

        private void cmbInputSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelInputFileConfiguration.Enabled = EnableFileSelection(
                (string)cmbInputSource.SelectedItem);
        }

        private void ProjectConfigurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_projectConfiguration.SaveToFile();
        }

        #region Helper Methods

        private bool EnableFileSelection(string ioEntity)
        {
            return ioEntity.IndexOf("File", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        #endregion
    }
}
