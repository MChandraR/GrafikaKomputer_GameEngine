using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Engine
{
    public partial class ProjectLoader : Form
    {
        public List<Project> project { get; set; }
        static String dir = System.IO.Directory.GetCurrentDirectory();
        public ProjectLoader()
        {
            InitializeComponent();
            this.project = new List<Project>();
            if(!Directory.Exists(dir+ "/config"))
            {
                Directory.CreateDirectory(dir+"/config");
            }
            if(Directory.Exists(dir + "/config"))
            {
                using (StreamReader configReader = new StreamReader(dir + "/config/config.json"))
                {
                    project = JsonConvert.DeserializeObject<List<Project>>(configReader.ReadToEnd());
                    foreach (Project proj in project)
                    {
                        projectList.Items.Add(proj.Name + " - \n" + proj.path);
                    }
                }
            }
           
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Show the FolderBrowserDialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                Console.WriteLine("Selected Path: " + selectedPath);
                MessageBox.Show("Selected Path : " + selectedPath);

                project.Add(new Project(selectedPath.Replace(Path.GetDirectoryName(selectedPath),""), selectedPath));
                using (StreamWriter writer = new StreamWriter(dir + "/config/config.json"))
                {
                    writer.Write(JsonConvert.SerializeObject(project));
                }
                new Parent(selectedPath).Show();
                updateProjectList();
               
            }
            else
            {
                Console.WriteLine("No folder selected.");
            }
        }

        public void updateProjectList()
        {
            projectList.Items.Clear();
            foreach (Project proj in project)
            {
                projectList.Items.Add(proj.Name + "\n" + proj.path);
            }
        }

        private void projectList_DoubleClick(object sender, EventArgs e)
        {
            new Parent(project[projectList.SelectedIndex].path).Show();
        }
    }


    public class Project
    {
        public string Name { get; set; }
        public string path { get; set; }

        public Project(string name, string path)
        {
            this.Name = name;
            this.path = path;
        }
    }
}
