using Project_Cars_Mod_Configurator.data.models;
using Project_Cars_Mod_Configurator.ui.Selector;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project_Cars_Mod_Configurator
{
    public partial class SelectVehicle : Form
    {
        public SelectVehicle()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            try
            {
                var location = Directory.GetCurrentDirectory();
                DirectoryInfo directory = new DirectoryInfo(location);
                DirectoryInfo[] Folders = directory.GetDirectories();

                foreach (DirectoryInfo folder in Folders)
                {
                    var fileNames = folder.GetFiles().Select(i => i.Name);
                    if (fileNames.Contains("modifications.xml"))
                    {
                        vehicleSelector.Items.Add(folder.Name);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not find 'Modifications' folder.");
            }
        }

        private void CarSelected(object sender, EventArgs e)
        {
            if (vehicleSelector.SelectedItem != null)
            {
                var selectedItem = vehicleSelector.SelectedItem.ToString();
                var location = Directory.GetCurrentDirectory() + "\\" + selectedItem + "\\modifications.xml";

                try
                {
                    // Read the XML file
                    XmlSerializer serializer = new XmlSerializer(typeof(Modifications));
                    using (FileStream fileStream = new FileStream(location, FileMode.Open))
                    {
                        Modifications result = (Modifications)serializer.Deserialize(fileStream);

                        this.Hide();

                        Selector selector = new Selector(result);
                        selector.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Could not parse modifications XML file.");
                }
            }
        }
    }
}
