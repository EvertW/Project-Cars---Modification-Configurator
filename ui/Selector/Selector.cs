using Project_Cars_Mod_Configurator.data.models;
using Project_Cars_Mod_Configurator.ui.Selector.SelectorView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Cars_Mod_Configurator.ui.Selector
{
    public partial class Selector : Form
    {
        Modifications modifications;

        List<TypeView> typeViews = new List<TypeView>();

        public Selector(Modifications tuning)
        {
            modifications = tuning;

            InitializeComponent();

            SetupSelectors();
        }

        private void SetupSelectors()
        {
            currentVehicleLabel.Text = "Current vehicle: " + modifications.VehicleName;

            foreach (data.models.Type type in modifications.Types)
            {
                TypeView typeView = new TypeView(type);
                typeViews.Add(typeView);
                optionsLayout.Controls.Add(typeView);
            }
        }

        private void changeVehicleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectVehicle selectVehicle = new SelectVehicle();
            selectVehicle.Show();
        }

        private void applyConfigurationButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TypeView typeView in typeViews)
                {
                    var part = typeView.getSelectedPart();

                    foreach (data.models.Path path in part.Items.Paths)
                    {
                        // Target file
                        var targetDirections = path.Target;
                        var fileDirections = path.Text;

                        // Get files
                        var directions = Directory.GetCurrentDirectory();
                        string parentDir = Directory.GetParent(directions).FullName;

                        // Get paths
                        var targetPath = (parentDir + targetDirections).Replace("/", "\\");
                        var filePath = (parentDir + fileDirections).Replace("/", "\\");

                        // If file exists, remove it first
                        if (File.Exists(targetPath))
                        {
                            File.Delete(targetPath);
                        }

                        // Replace the file
                        File.Copy(filePath, targetPath);
                    }
                }
                MessageBox.Show("Configuration applied successfully.");
            }
            catch
            {
                MessageBox.Show("Something went wrong while applying configuration.");
            }
        }
    }
}
