using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using ReadZeroTestsFromFile.ConfigurationWizard.Windows;

namespace ReadZeroTestsFromFile.ConfigurationWizard
{
    public class ProjectConfigurationWizard : IWizard
    {
        //private DTE _dte;

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            replacementsDictionary.Add("$inputSource$", "Console");
            //var configurationWindow = new ProjectConfigurationWindow();
            //var dialogResult = configurationWindow.ShowDialog();
        }

        public void ProjectFinishedGenerating(Project project)
        {
               
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            
        }

        public void RunFinished()
        {
            
        }
    }
}
