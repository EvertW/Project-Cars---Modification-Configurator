namespace Project_Cars_Mod_Configurator.ui.Selector
{
    partial class Selector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.optionsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.changeVehicleButton = new System.Windows.Forms.Button();
            this.applyConfigurationButton = new System.Windows.Forms.Button();
            this.currentVehicleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionsLayout
            // 
            this.optionsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsLayout.AutoScroll = true;
            this.optionsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsLayout.Location = new System.Drawing.Point(3, 4);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.Size = new System.Drawing.Size(278, 360);
            this.optionsLayout.TabIndex = 0;
            // 
            // changeVehicleButton
            // 
            this.changeVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeVehicleButton.Location = new System.Drawing.Point(3, 384);
            this.changeVehicleButton.Name = "changeVehicleButton";
            this.changeVehicleButton.Size = new System.Drawing.Size(91, 23);
            this.changeVehicleButton.TabIndex = 6;
            this.changeVehicleButton.Text = "Change Vehicle";
            this.changeVehicleButton.UseVisualStyleBackColor = true;
            this.changeVehicleButton.Click += new System.EventHandler(this.changeVehicleButton_Click);
            // 
            // applyConfigurationButton
            // 
            this.applyConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyConfigurationButton.Location = new System.Drawing.Point(100, 384);
            this.applyConfigurationButton.Name = "applyConfigurationButton";
            this.applyConfigurationButton.Size = new System.Drawing.Size(181, 23);
            this.applyConfigurationButton.TabIndex = 7;
            this.applyConfigurationButton.Text = "Apply Configuration";
            this.applyConfigurationButton.UseVisualStyleBackColor = true;
            this.applyConfigurationButton.Click += new System.EventHandler(this.applyConfigurationButton_Click);
            // 
            // currentVehicleLabel
            // 
            this.currentVehicleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentVehicleLabel.AutoSize = true;
            this.currentVehicleLabel.Location = new System.Drawing.Point(7, 367);
            this.currentVehicleLabel.Name = "currentVehicleLabel";
            this.currentVehicleLabel.Size = new System.Drawing.Size(85, 13);
            this.currentVehicleLabel.TabIndex = 8;
            this.currentVehicleLabel.Text = "Current Vehicle: ";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.currentVehicleLabel);
            this.Controls.Add(this.applyConfigurationButton);
            this.Controls.Add(this.changeVehicleButton);
            this.Controls.Add(this.optionsLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selector";
            this.Text = "Vehicle Configurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel optionsLayout;
        private System.Windows.Forms.Button changeVehicleButton;
        private System.Windows.Forms.Button applyConfigurationButton;
        private System.Windows.Forms.Label currentVehicleLabel;
    }
}