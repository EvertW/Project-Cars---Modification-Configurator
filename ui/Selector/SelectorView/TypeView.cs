
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Cars_Mod_Configurator.data.models;
using System.IO;

namespace Project_Cars_Mod_Configurator.ui.Selector.SelectorView
{
    public partial class TypeView : UserControl
    {

        Part selectedPart;

        public TypeView(data.models.Type type)
        {
            InitializeComponent();
            SetupType(type);
        }

        private void SetupType(data.models.Type type)
        {
            typeName.Text = type.Name;

            foreach (Part part in type.Parts)
            {
                typeOptions.Items.Add(part);
            }

            typeOptions.SelectedIndex = 0;
        }

        private void typeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var location = Directory.GetCurrentDirectory();
            string parentDir = Directory.GetParent(location).FullName;

            selectedPart = (Part) typeOptions.SelectedItem;

            var imageLocation = (parentDir + selectedPart.ImagePath).Replace("/", "\\");

            typeImage.ImageLocation = imageLocation;
        }

        public Part getSelectedPart()
        {
            return selectedPart;
        }
    }
}
