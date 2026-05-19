namespace AnthonySantosInventoryManagementSystem
{
    partial class AddPartScreen
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.RadioButton RadioButtonOutsourced;
            this.LabelAddPart = new System.Windows.Forms.Label();
            this.RadioButtonInHouse = new System.Windows.Forms.RadioButton();
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
            this.ButtonPartSave = new System.Windows.Forms.Button();
            this.ButtonPartCancel = new System.Windows.Forms.Button();
            // New fields
            this.TextBoxSKU = new System.Windows.Forms.TextBox();
            this.LabelSKU = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxSupplier = new System.Windows.Forms.TextBox();
            this.LabelSupplier = new System.Windows.Forms.Label();
            RadioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

            // RadioButtonOutsourced
            RadioButtonOutsourced.AutoSize = true;
            RadioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            RadioButtonOutsourced.Location = new System.Drawing.Point(302, 25);
            RadioButtonOutsourced.Name = "RadioButtonOutsourced";
            RadioButtonOutsourced.Size = new System.Drawing.Size(114, 25);
            RadioButtonOutsourced.TabIndex = 2;
            RadioButtonOutsourced.Text = "Outsourced";
            RadioButtonOutsourced.UseVisualStyleBackColor = true;
            RadioButtonOutsourced.CheckedChanged += new System.EventHandler(this.RadioButtonOutsourced_CheckedChanged);

            // LabelAddPart
            this.LabelAddPart.AutoSize = true;
            this.LabelAddPart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.LabelAddPart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelAddPart.Location = new System.Drawing.Point(13, 13);
            this.LabelAddPart.Name = "LabelAddPart";
            this.LabelAddPart.TabIndex = 0;
            this.LabelAddPart.Text = "Add Part";

            // RadioButtonInHouse
            this.RadioButtonInHouse.AutoSize = true;
            this.RadioButtonInHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.RadioButtonInHouse.Location = new System.Drawing.Point(178, 25);
            this.RadioButtonInHouse.Name = "RadioButtonInHouse";
            this.RadioButtonInHouse.Size = new System.Drawing.Size(95, 25);
            this.RadioButtonInHouse.TabIndex = 1;
            this.RadioButtonInHouse.Text = "In-House";
            this.RadioButtonInHouse.UseVisualStyleBackColor = true;
            this.RadioButtonInHouse.CheckedChanged += new System.EventHandler(this.RadioButtonInHouse_CheckedChanged);

            // TextBoxPartID
            this.TextBoxPartID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartID.Location = new System.Drawing.Point(178, 65);
            this.TextBoxPartID.Name = "TextBoxPartID";
            this.TextBoxPartID.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartID.TabIndex = 3;
            this.TextBoxPartID.TextChanged += new System.EventHandler(this.TextBoxPartID_TextChanged);

            // LabelID
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelID.Location = new System.Drawing.Point(130, 65);
            this.LabelID.Name = "LabelID";
            this.LabelID.TabIndex = 9;
            this.LabelID.Text = "ID*";

            // TextBoxPartName
            this.TextBoxPartName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartName.Location = new System.Drawing.Point(178, 105);
            this.TextBoxPartName.Name = "TextBoxPartName";
            this.TextBoxPartName.Size = new System.Drawing.Size(200, 29);
            this.TextBoxPartName.TabIndex = 4;
            this.TextBoxPartName.TextChanged += new System.EventHandler(this.TextBoxPartName_TextChanged);

            // LabelName
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelName.Location = new System.Drawing.Point(100, 105);
            this.LabelName.Name = "LabelName";
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name*";

            // TextBoxPartInv
            this.TextBoxPartInv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartInv.Location = new System.Drawing.Point(178, 145);
            this.TextBoxPartInv.Name = "TextBoxPartInv";
            this.TextBoxPartInv.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartInv.TabIndex = 5;
            this.TextBoxPartInv.TextChanged += new System.EventHandler(this.TextBoxPartInv_TextChanged);

            // LabelInv
            this.LabelInv.AutoSize = true;
            this.LabelInv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelInv.Location = new System.Drawing.Point(118, 145);
            this.LabelInv.Name = "LabelInv";
            this.LabelInv.TabIndex = 11;
            this.LabelInv.Text = "Inv*";

            // TextBoxPartPriceCost
            this.TextBoxPartPriceCost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartPriceCost.Location = new System.Drawing.Point(178, 185);
            this.TextBoxPartPriceCost.Name = "TextBoxPartPriceCost";
            this.TextBoxPartPriceCost.Size = new System.Drawing.Size(150, 29);
            this.TextBoxPartPriceCost.TabIndex = 6;
            this.TextBoxPartPriceCost.TextChanged += new System.EventHandler(this.TextBoxPartPriceCost_TextChanged);

            // LabelPriceCost
            this.LabelPriceCost.AutoSize = true;
            this.LabelPriceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPriceCost.Location = new System.Drawing.Point(64, 185);
            this.LabelPriceCost.Name = "LabelPriceCost";
            this.LabelPriceCost.TabIndex = 12;
            this.LabelPriceCost.Text = "Price/Cost*";

            // TextBoxPartMax
            this.TextBoxPartMax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartMax.Location = new System.Drawing.Point(178, 225);
            this.TextBoxPartMax.Name = "TextBoxPartMax";
            this.TextBoxPartMax.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMax.TabIndex = 7;
            this.TextBoxPartMax.TextChanged += new System.EventHandler(this.TextBoxPartMax_TextChanged);

            // LabelMax
            this.LabelMax.AutoSize = true;
            this.LabelMax.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMax.Location = new System.Drawing.Point(109, 225);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.TabIndex = 13;
            this.LabelMax.Text = "Max*";

            // TextBoxPartMin
            this.TextBoxPartMin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPartMin.Location = new System.Drawing.Point(341, 225);
            this.TextBoxPartMin.Name = "TextBoxPartMin";
            this.TextBoxPartMin.Size = new System.Drawing.Size(75, 29);
            this.TextBoxPartMin.TabIndex = 15;
            this.TextBoxPartMin.TextChanged += new System.EventHandler(this.TextBoxPartMin_TextChanged);

            // LabelMin
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMin.Location = new System.Drawing.Point(292, 225);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.TabIndex = 16;
            this.LabelMin.Text = "Min*";

            // TextBoxX
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxX.Location = new System.Drawing.Point(178, 265);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(150, 29);
            this.TextBoxX.TabIndex = 8;
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);

            // LabelX
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelX.Location = new System.Drawing.Point(44, 265);
            this.LabelX.Name = "LabelX";
            this.LabelX.TabIndex = 14;
            this.LabelX.Text = "Machine ID*";

            // TextBoxSKU
            this.TextBoxSKU.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSKU.Location = new System.Drawing.Point(178, 305);
            this.TextBoxSKU.Name = "TextBoxSKU";
            this.TextBoxSKU.Size = new System.Drawing.Size(150, 29);
            this.TextBoxSKU.TabIndex = 19;

            // LabelSKU
            this.LabelSKU.AutoSize = true;
            this.LabelSKU.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSKU.Location = new System.Drawing.Point(118, 305);
            this.LabelSKU.Name = "LabelSKU";
            this.LabelSKU.TabIndex = 20;
            this.LabelSKU.Text = "SKU";

            // TextBoxCategory
            this.TextBoxCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxCategory.Location = new System.Drawing.Point(178, 345);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(150, 29);
            this.TextBoxCategory.TabIndex = 21;

            // LabelCategory
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCategory.Location = new System.Drawing.Point(88, 345);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.TabIndex = 22;
            this.LabelCategory.Text = "Category";

            // TextBoxDescription
            this.TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxDescription.Location = new System.Drawing.Point(178, 385);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(200, 29);
            this.TextBoxDescription.TabIndex = 23;

            // LabelDescription
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDescription.Location = new System.Drawing.Point(72, 385);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.TabIndex = 24;
            this.LabelDescription.Text = "Description";

            // TextBoxSupplier
            this.TextBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSupplier.Location = new System.Drawing.Point(178, 425);
            this.TextBoxSupplier.Name = "TextBoxSupplier";
            this.TextBoxSupplier.Size = new System.Drawing.Size(150, 29);
            this.TextBoxSupplier.TabIndex = 25;

            // LabelSupplier
            this.LabelSupplier.AutoSize = true;
            this.LabelSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSupplier.Location = new System.Drawing.Point(97, 425);
            this.LabelSupplier.Name = "LabelSupplier";
            this.LabelSupplier.TabIndex = 26;
            this.LabelSupplier.Text = "Supplier";

            // ButtonPartSave
            this.ButtonPartSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPartSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPartSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonPartSave.Location = new System.Drawing.Point(178, 475);
            this.ButtonPartSave.Name = "ButtonPartSave";
            this.ButtonPartSave.Size = new System.Drawing.Size(90, 35);
            this.ButtonPartSave.TabIndex = 17;
            this.ButtonPartSave.Text = "Save";
            this.ButtonPartSave.UseVisualStyleBackColor = false;
            this.ButtonPartSave.Click += new System.EventHandler(this.ButtonPartSave_Click);

            // ButtonPartCancel
            this.ButtonPartCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPartCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPartCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonPartCancel.Location = new System.Drawing.Point(300, 475);
            this.ButtonPartCancel.Name = "ButtonPartCancel";
            this.ButtonPartCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonPartCancel.TabIndex = 18;
            this.ButtonPartCancel.Text = "Cancel";
            this.ButtonPartCancel.UseVisualStyleBackColor = false;
            this.ButtonPartCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            // AddPartScreen
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 530);
            this.Controls.Add(this.ButtonPartCancel);
            this.Controls.Add(this.ButtonPartSave);
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
            this.Controls.Add(RadioButtonOutsourced);
            this.Controls.Add(this.RadioButtonInHouse);
            this.Controls.Add(this.LabelAddPart);
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LabelAddPart;
        private System.Windows.Forms.RadioButton RadioButtonInHouse;
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
        private System.Windows.Forms.Button ButtonPartSave;
        private System.Windows.Forms.Button ButtonPartCancel;
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