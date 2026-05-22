namespace AnthonySantosInventoryManagementSystem
{
    partial class ModifyPartScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LabelModifyPart = new System.Windows.Forms.Label();
            this.RadioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.RadioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.TextBoxPartID = new System.Windows.Forms.TextBox();
            this.TextBoxPartName = new System.Windows.Forms.TextBox();
            this.TextBoxPartInv = new System.Windows.Forms.TextBox();
            this.TextBoxPartPriceCost = new System.Windows.Forms.TextBox();
            this.TextBoxPartMax = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelInv = new System.Windows.Forms.Label();
            this.LabelPriceCost = new System.Windows.Forms.Label();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.TextBoxPartMin = new System.Windows.Forms.TextBox();
            this.LabelMin = new System.Windows.Forms.Label();
            this.ButtonModifySave = new System.Windows.Forms.Button();
            this.ButtonModifyCancel = new System.Windows.Forms.Button();
            // New fields (same as AddPartScreen)
            this.TextBoxSKU = new System.Windows.Forms.TextBox();
            this.LabelSKU = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxSupplier = new System.Windows.Forms.TextBox();
            this.LabelSupplier = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // LabelModifyPart
            this.LabelModifyPart.AutoSize = true;
            this.LabelModifyPart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelModifyPart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelModifyPart.Location = new System.Drawing.Point(13, 13);
            this.LabelModifyPart.Name = "LabelModifyPart";
            this.LabelModifyPart.Size = new System.Drawing.Size(130, 30);
            this.LabelModifyPart.TabIndex = 0;
            this.LabelModifyPart.Text = "Modify Part";

            // RadioButtonInHouse
            this.RadioButtonInHouse.AutoSize = true;
            this.RadioButtonInHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.RadioButtonInHouse.Location = new System.Drawing.Point(178, 55);
            this.RadioButtonInHouse.Name = "RadioButtonInHouse";
            this.RadioButtonInHouse.Size = new System.Drawing.Size(95, 25);
            this.RadioButtonInHouse.TabIndex = 1;
            this.RadioButtonInHouse.Text = "In-House";
            this.RadioButtonInHouse.UseVisualStyleBackColor = true;
            this.RadioButtonInHouse.CheckedChanged += new System.EventHandler(this.RadioButtonInHouse_CheckedChanged);

            // RadioButtonOutsourced
            this.RadioButtonOutsourced.AutoSize = true;
            this.RadioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.RadioButtonOutsourced.Location = new System.Drawing.Point(302, 55);
            this.RadioButtonOutsourced.Name = "RadioButtonOutsourced";
            this.RadioButtonOutsourced.Size = new System.Drawing.Size(114, 25);
            this.RadioButtonOutsourced.TabIndex = 2;
            this.RadioButtonOutsourced.Text = "Outsourced";
            this.RadioButtonOutsourced.UseVisualStyleBackColor = true;
            this.RadioButtonOutsourced.CheckedChanged += new System.EventHandler(this.RadioButtonOutsourced_CheckedChanged);

            // TextBoxPartID
            this.TextBoxPartID.Enabled = false;
            this.TextBoxPartID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartID.Location = new System.Drawing.Point(178, 95);
            this.TextBoxPartID.Name = "TextBoxPartID";
            this.TextBoxPartID.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartID.TabIndex = 3;
            this.TextBoxPartID.TextChanged += new System.EventHandler(this.TextBoxPartID_TextChanged);

            // LabelID
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelID.Location = new System.Drawing.Point(130, 98);
            this.LabelID.Name = "LabelID";
            this.LabelID.TabIndex = 9;
            this.LabelID.Text = "ID*";

            // TextBoxPartName
            this.TextBoxPartName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartName.Location = new System.Drawing.Point(178, 135);
            this.TextBoxPartName.Name = "TextBoxPartName";
            this.TextBoxPartName.Size = new System.Drawing.Size(200, 29);
            this.TextBoxPartName.TabIndex = 4;
            this.TextBoxPartName.TextChanged += new System.EventHandler(this.TextBoxPartName_TextChanged);

            // LabelName
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelName.Location = new System.Drawing.Point(100, 138);
            this.LabelName.Name = "LabelName";
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name*";

            // TextBoxPartInv
            this.TextBoxPartInv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartInv.Location = new System.Drawing.Point(178, 175);
            this.TextBoxPartInv.Name = "TextBoxPartInv";
            this.TextBoxPartInv.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartInv.TabIndex = 5;
            this.TextBoxPartInv.TextChanged += new System.EventHandler(this.TextBoxPartInv_TextChanged);

            // LabelInv
            this.LabelInv.AutoSize = true;
            this.LabelInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelInv.Location = new System.Drawing.Point(118, 178);
            this.LabelInv.Name = "LabelInv";
            this.LabelInv.TabIndex = 11;
            this.LabelInv.Text = "Inv*";

            // TextBoxPartPriceCost
            this.TextBoxPartPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartPriceCost.Location = new System.Drawing.Point(178, 215);
            this.TextBoxPartPriceCost.Name = "TextBoxPartPriceCost";
            this.TextBoxPartPriceCost.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartPriceCost.TabIndex = 6;
            this.TextBoxPartPriceCost.TextChanged += new System.EventHandler(this.TextBoxPartPriceCost_TextChanged);

            // LabelPriceCost
            this.LabelPriceCost.AutoSize = true;
            this.LabelPriceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPriceCost.Location = new System.Drawing.Point(64, 218);
            this.LabelPriceCost.Name = "LabelPriceCost";
            this.LabelPriceCost.TabIndex = 12;
            this.LabelPriceCost.Text = "Price/Cost*";

            // TextBoxPartMax
            this.TextBoxPartMax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartMax.Location = new System.Drawing.Point(178, 255);
            this.TextBoxPartMax.Name = "TextBoxPartMax";
            this.TextBoxPartMax.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMax.TabIndex = 7;
            this.TextBoxPartMax.TextChanged += new System.EventHandler(this.TextBoxPartMax_TextChanged);

            // LabelMax
            this.LabelMax.AutoSize = true;
            this.LabelMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMax.Location = new System.Drawing.Point(109, 258);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.TabIndex = 13;
            this.LabelMax.Text = "Max*";

            // TextBoxPartMin
            this.TextBoxPartMin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartMin.Location = new System.Drawing.Point(341, 255);
            this.TextBoxPartMin.Name = "TextBoxPartMin";
            this.TextBoxPartMin.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMin.TabIndex = 15;
            this.TextBoxPartMin.TextChanged += new System.EventHandler(this.TextBoxPartMin_TextChanged);

            // LabelMin
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMin.Location = new System.Drawing.Point(292, 258);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.TabIndex = 16;
            this.LabelMin.Text = "Min*";

            // TextBoxX
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxX.Location = new System.Drawing.Point(178, 295);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(150, 29);
            this.TextBoxX.TabIndex = 8;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);

            // LabelX

            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelX.Location = new System.Drawing.Point(44, 298);
            this.LabelX.Name = "LabelX";
            this.LabelX.TabIndex = 14;
            this.LabelX.Text = "Machine ID*";

            // TextBoxSKU
            this.TextBoxSKU.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSKU.Location = new System.Drawing.Point(178, 335);
            this.TextBoxSKU.Name = "TextBoxSKU";
            this.TextBoxSKU.Size = new System.Drawing.Size(150, 29);
            this.TextBoxSKU.TabIndex = 19;

            // LabelSKU
            this.LabelSKU.AutoSize = true;
            this.LabelSKU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSKU.Location = new System.Drawing.Point(118, 338);
            this.LabelSKU.Name = "LabelSKU";
            this.LabelSKU.TabIndex = 20;
            this.LabelSKU.Text = "SKU";

            // TextBoxCategory
            this.TextBoxCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxCategory.Location = new System.Drawing.Point(178, 375);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(150, 29);
            this.TextBoxCategory.TabIndex = 21;

            // LabelCategory
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCategory.Location = new System.Drawing.Point(88, 378);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.TabIndex = 22;
            this.LabelCategory.Text = "Category";

            // TextBoxDescription
            this.TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxDescription.Location = new System.Drawing.Point(178, 415);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(200, 29);
            this.TextBoxDescription.TabIndex = 23;

            // LabelDescription
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDescription.Location = new System.Drawing.Point(72, 418);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.TabIndex = 24;
            this.LabelDescription.Text = "Description";

            // TextBoxSupplier
            this.TextBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSupplier.Location = new System.Drawing.Point(178, 455);
            this.TextBoxSupplier.Name = "TextBoxSupplier";
            this.TextBoxSupplier.Size = new System.Drawing.Size(150, 29);
            this.TextBoxSupplier.TabIndex = 25;

            // LabelSupplier
            this.LabelSupplier.AutoSize = true;
            this.LabelSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSupplier.Location = new System.Drawing.Point(97, 458);
            this.LabelSupplier.Name = "LabelSupplier";
            this.LabelSupplier.TabIndex = 26;
            this.LabelSupplier.Text = "Supplier";

            // ButtonModifySave
            this.ButtonModifySave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonModifySave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifySave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonModifySave.Location = new System.Drawing.Point(178, 505);
            this.ButtonModifySave.Name = "ButtonModifySave";
            this.ButtonModifySave.Size = new System.Drawing.Size(90, 35);
            this.ButtonModifySave.TabIndex = 17;
            this.ButtonModifySave.Text = "Save";
            this.ButtonModifySave.UseVisualStyleBackColor = false;
            this.ButtonModifySave.Click += new System.EventHandler(this.ButtonModifySave_Click);

            // ButtonModifyCancel
            this.ButtonModifyCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonModifyCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifyCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonModifyCancel.Location = new System.Drawing.Point(300, 505);
            this.ButtonModifyCancel.Name = "ButtonModifyCancel";
            this.ButtonModifyCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonModifyCancel.TabIndex = 18;
            this.ButtonModifyCancel.Text = "Cancel";
            this.ButtonModifyCancel.UseVisualStyleBackColor = false;
            this.ButtonModifyCancel.Click += new System.EventHandler(this.ButtonModifyCancel_Click);

            // ModifyPartScreen

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 560);
            this.Controls.Add(this.ButtonModifyCancel);
            this.Controls.Add(this.ButtonModifySave);
            this.Controls.Add(this.LabelSupplier);
            this.Controls.Add(this.TextBoxSupplier);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.LabelSKU);
            this.Controls.Add(this.TextBoxSKU);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.TextBoxPartMin);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelMax);
            this.Controls.Add(this.LabelPriceCost);
            this.Controls.Add(this.LabelInv);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.TextBoxPartMax);
            this.Controls.Add(this.TextBoxPartPriceCost);
            this.Controls.Add(this.TextBoxPartInv);
            this.Controls.Add(this.TextBoxPartName);
            this.Controls.Add(this.TextBoxPartID);
            this.Controls.Add(this.RadioButtonOutsourced);
            this.Controls.Add(this.RadioButtonInHouse);
            this.Controls.Add(this.LabelModifyPart);
            this.Name = "ModifyPartScreen";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelModifyPart;
        private System.Windows.Forms.RadioButton RadioButtonInHouse;
        private System.Windows.Forms.RadioButton RadioButtonOutsourced;
        private System.Windows.Forms.TextBox TextBoxPartID;
        private System.Windows.Forms.TextBox TextBoxPartName;
        private System.Windows.Forms.TextBox TextBoxPartInv;
        private System.Windows.Forms.TextBox TextBoxPartPriceCost;
        private System.Windows.Forms.TextBox TextBoxPartMax;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelInv;
        private System.Windows.Forms.Label LabelPriceCost;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox TextBoxPartMin;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Button ButtonModifySave;
        private System.Windows.Forms.Button ButtonModifyCancel;
        private System.Windows.Forms.TextBox TextBoxSKU;
        private System.Windows.Forms.Label LabelSKU;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxSupplier;
        private System.Windows.Forms.Label LabelSupplier;
    }
}