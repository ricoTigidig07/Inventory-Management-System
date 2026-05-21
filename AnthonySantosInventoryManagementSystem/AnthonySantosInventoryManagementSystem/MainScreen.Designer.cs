namespace AnthonySantosInventoryManagementSystem
{
    partial class InventoryManagementSystemMainScreen
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
            this.MainScreenLabel = new System.Windows.Forms.Label();
            this.DataGridViewPart = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.ButtonDeletePart = new System.Windows.Forms.Button();
            this.ButtonModifyPart = new System.Windows.Forms.Button();
            this.ButtonAddPart = new System.Windows.Forms.Button();
            this.TextBoxSearchPart = new System.Windows.Forms.TextBox();
            this.ButtonSearchPart = new System.Windows.Forms.Button();
            this.LabelPart = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).BeginInit();
            this.groupBoxParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScreenLabel
            // 
            this.MainScreenLabel.AutoSize = true;
            this.MainScreenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MainScreenLabel.Location = new System.Drawing.Point(26, 24);
            this.MainScreenLabel.Name = "MainScreenLabel";
            this.MainScreenLabel.Size = new System.Drawing.Size(358, 21);
            this.MainScreenLabel.TabIndex = 0;
            this.MainScreenLabel.Text = "Inventory Management System - Main Screen";
            // 
            // DataGridViewPart
            // 
            this.DataGridViewPart.AllowUserToAddRows = false;
            this.DataGridViewPart.AllowUserToDeleteRows = false;
            this.DataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.inStock,
            this.pricePerUnitPart});
            this.DataGridViewPart.Location = new System.Drawing.Point(24, 92);
            this.DataGridViewPart.Name = "DataGridViewPart";
            this.DataGridViewPart.ReadOnly = true;
            this.DataGridViewPart.Size = new System.Drawing.Size(443, 222);
            this.DataGridViewPart.TabIndex = 1;
            this.DataGridViewPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPart_CellClick);
            this.DataGridViewPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPart_CellContentClick);
            // 
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Part Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.DataPropertyName = "inStock";
            this.inStock.HeaderText = "Inventory Level";
            this.inStock.MinimumWidth = 50;
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // pricePerUnitPart
            // 
            this.pricePerUnitPart.DataPropertyName = "price";
            this.pricePerUnitPart.HeaderText = "Price/Cost per Unit";
            this.pricePerUnitPart.Name = "pricePerUnitPart";
            this.pricePerUnitPart.ReadOnly = true;
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxParts.Controls.Add(this.ButtonDeletePart);
            this.groupBoxParts.Controls.Add(this.ButtonModifyPart);
            this.groupBoxParts.Controls.Add(this.ButtonAddPart);
            this.groupBoxParts.Controls.Add(this.TextBoxSearchPart);
            this.groupBoxParts.Controls.Add(this.ButtonSearchPart);
            this.groupBoxParts.Controls.Add(this.LabelPart);
            this.groupBoxParts.Controls.Add(this.DataGridViewPart);
            this.groupBoxParts.Location = new System.Drawing.Point(42, 81);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(497, 408);
            this.groupBoxParts.TabIndex = 2;
            this.groupBoxParts.TabStop = false;
            // 
            // ButtonDeletePart
            // 
            this.ButtonDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDeletePart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePart.Location = new System.Drawing.Point(367, 340);
            this.ButtonDeletePart.Name = "ButtonDeletePart";
            this.ButtonDeletePart.Size = new System.Drawing.Size(100, 38);
            this.ButtonDeletePart.TabIndex = 7;
            this.ButtonDeletePart.Text = "Delete";
            this.ButtonDeletePart.UseVisualStyleBackColor = true;
            this.ButtonDeletePart.Click += new System.EventHandler(this.ButtonDeletePart_Click);
            // 
            // ButtonModifyPart
            // 
            this.ButtonModifyPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonModifyPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifyPart.Location = new System.Drawing.Point(199, 340);
            this.ButtonModifyPart.Name = "ButtonModifyPart";
            this.ButtonModifyPart.Size = new System.Drawing.Size(100, 38);
            this.ButtonModifyPart.TabIndex = 6;
            this.ButtonModifyPart.Text = "Modify";
            this.ButtonModifyPart.UseVisualStyleBackColor = true;
            this.ButtonModifyPart.Click += new System.EventHandler(this.ButtonModifyPart_Click);
            // 
            // ButtonAddPart
            // 
            this.ButtonAddPart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAddPart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPart.Location = new System.Drawing.Point(24, 340);
            this.ButtonAddPart.Name = "ButtonAddPart";
            this.ButtonAddPart.Size = new System.Drawing.Size(100, 38);
            this.ButtonAddPart.TabIndex = 5;
            this.ButtonAddPart.Text = "Add";
            this.ButtonAddPart.UseVisualStyleBackColor = true;
            this.ButtonAddPart.Click += new System.EventHandler(this.ButtonAddPart_Click);
            // 
            // TextBoxSearchPart
            // 
            this.TextBoxSearchPart.Location = new System.Drawing.Point(280, 35);
            this.TextBoxSearchPart.Name = "TextBoxSearchPart";
            this.TextBoxSearchPart.Size = new System.Drawing.Size(162, 20);
            this.TextBoxSearchPart.TabIndex = 4;
            this.TextBoxSearchPart.TextChanged += new System.EventHandler(this.TextBoxSearchPart_TextChanged);
            // 
            // ButtonSearchPart
            // 
            this.ButtonSearchPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearchPart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchPart.Location = new System.Drawing.Point(165, 33);
            this.ButtonSearchPart.Name = "ButtonSearchPart";
            this.ButtonSearchPart.Size = new System.Drawing.Size(109, 23);
            this.ButtonSearchPart.TabIndex = 3;
            this.ButtonSearchPart.Text = "Search Part Name";
            this.ButtonSearchPart.UseVisualStyleBackColor = true;
            this.ButtonSearchPart.Click += new System.EventHandler(this.ButtonSearchPart_Click);
            // 
            // LabelPart
            // 
            this.LabelPart.AutoSize = true;
            this.LabelPart.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPart.Location = new System.Drawing.Point(24, 32);
            this.LabelPart.Name = "LabelPart";
            this.LabelPart.Size = new System.Drawing.Size(72, 32);
            this.LabelPart.TabIndex = 2;
            this.LabelPart.Text = "Parts";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(929, 521);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(109, 44);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click_1);
            // 
            // InventoryManagementSystemMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 598);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBoxParts);
            this.Controls.Add(this.MainScreenLabel);
            this.Name = "InventoryManagementSystemMainScreen";
            this.Text = "Inventory Management System Main Screen";
            this.Load += new System.EventHandler(this.InventoryManagementSystemMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainScreenLabel;
        private System.Windows.Forms.DataGridView DataGridViewPart;
        private System.Windows.Forms.GroupBox groupBoxParts;
        private System.Windows.Forms.Button ButtonDeletePart;
        private System.Windows.Forms.Button ButtonModifyPart;
        private System.Windows.Forms.Button ButtonAddPart;
        private System.Windows.Forms.TextBox TextBoxSearchPart;
        private System.Windows.Forms.Button ButtonSearchPart;
        private System.Windows.Forms.Label LabelPart;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitPart;
    }
}

