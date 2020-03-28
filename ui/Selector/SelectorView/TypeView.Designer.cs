namespace Project_Cars_Mod_Configurator.ui.Selector.SelectorView
{
    partial class TypeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeLabel = new System.Windows.Forms.Label();
            this.typeImage = new System.Windows.Forms.PictureBox();
            this.typeOptions = new System.Windows.Forms.ComboBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(13, 34);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Image";
            // 
            // typeImage
            // 
            this.typeImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeImage.Location = new System.Drawing.Point(16, 50);
            this.typeImage.Name = "typeImage";
            this.typeImage.Size = new System.Drawing.Size(220, 220);
            this.typeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typeImage.TabIndex = 1;
            this.typeImage.TabStop = false;
            // 
            // typeOptions
            // 
            this.typeOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOptions.FormattingEnabled = true;
            this.typeOptions.Location = new System.Drawing.Point(16, 291);
            this.typeOptions.Margin = new System.Windows.Forms.Padding(5);
            this.typeOptions.Name = "typeOptions";
            this.typeOptions.Size = new System.Drawing.Size(220, 21);
            this.typeOptions.TabIndex = 2;
            this.typeOptions.SelectedIndexChanged += new System.EventHandler(this.typeOptions_SelectedIndexChanged);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Location = new System.Drawing.Point(13, 273);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(43, 13);
            this.OptionsLabel.TabIndex = 3;
            this.OptionsLabel.Text = "Options";
            // 
            // typeName
            // 
            this.typeName.AutoSize = true;
            this.typeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeName.Location = new System.Drawing.Point(13, 9);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(37, 17);
            this.typeName.TabIndex = 4;
            this.typeName.Text = "Type";
            // 
            // TypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.typeOptions);
            this.Controls.Add(this.typeImage);
            this.Controls.Add(this.TypeLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TypeView";
            this.Size = new System.Drawing.Size(255, 326);
            ((System.ComponentModel.ISupportInitialize)(this.typeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.PictureBox typeImage;
        private System.Windows.Forms.ComboBox typeOptions;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Label typeName;
    }
}
