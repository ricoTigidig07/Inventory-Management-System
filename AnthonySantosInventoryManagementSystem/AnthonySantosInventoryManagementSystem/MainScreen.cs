using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public partial class InventoryManagementSystemMainScreen : Form
    {
        //saves DataGridViewPart user selection

        public int Index = -1;
        public int IndexProduct = -1;

        public int idxSelectedPart;
        public int idxSelectedProduct;

        //stores user's currently selected part
        public Part selectedPart;
        public Product selectedProduct;

        //**START HERE**
        public InventoryManagementSystemMainScreen()
        {
            InitializeComponent();
            //BuildPartList();
            FormatDGV(DataGridViewPart);
            LoadPartsFromApi();
            Display();
        }

        public void CurrentSelectedPart()
        {
            if (Index >= 0)
            {
                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {
                    if (Inventory.MyPartList[j].PartID == (int)DataGridViewPart.Rows[Index].Cells[0].Value)
                    {
                        selectedPart =  Inventory.MyPartList[j];
                    }
                }
            }
        }

        //formatting for the DGV
        private void FormatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = true;
        }

        //Update display dgv with the current list
        private void Display()
        {
            DataGridViewPart.AutoGenerateColumns = false;

            DataGridViewPart.DataSource = Inventory.MyPartList;

            DataGridViewPart.ClearSelection();

        }

        private async void LoadPartsFromApi()
        {
            try
            {
                var apiParts = await ApiService.GetPartsAsync();
                Inventory.MyPartList.Clear();
                foreach (var p in apiParts)
                {
                    Inventory.MyPartList.Add(new Inhouse(
                        p.part_id,
                        p.part_name,
                        p.cost,
                        p.quantity_on_hand,
                        1,
                        100,
                        0
                    ));
                }
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load parts from RepairOS API.\n" + ex.Message);
            }
        }

        //testing these functions
        private void DataGridViewPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Index = DataGridViewPart.CurrentCell.RowIndex;
            Index = e.RowIndex;
            idxSelectedPart = DataGridViewPart.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPart.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void InventoryManagementMainScreen_Load(object sender, EventArgs e)
        {
            Display();
        }

        //Event handlers
        private void ButtonAddPart_Click(object sender, EventArgs e)
        {
            AddPartScreen addPart = new AddPartScreen();
            addPart.Show();
        }

        private void ButtonModifyPart_Click(object sender, EventArgs e)
        {
            if (Index >= 0)
            {
                CurrentSelectedPart();
                ModifyPartScreen modifyPart = new ModifyPartScreen();
                modifyPart.Show();
                
            }
            else
            {
                MessageBox.Show("Select a part to Modify.");
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductScreen addProduct = new AddProductScreen();
            addProduct.Show();
        }

        private void ButtonExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            //Application.Exit();
        }

        private async void ButtonDeletePart_Click(object sender, EventArgs e)
        {
            if (Index >= 0)
            {
                for (int j = 0; j < Inventory.MyPartList.Count; j++)
                {
                    if (Inventory.MyPartList[j].PartID == (int)DataGridViewPart.Rows[Index].Cells[0].Value)
                    {
                        if (MessageBox.Show("Please Confirm Delete Action", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int partId = Inventory.MyPartList[j].PartID;
                            Inventory.MyPartList.RemoveAt(j);

                            // Call RepairOS API to delete from database
                            try
                            {
                                bool success = await ApiService.DeletePartAsync(partId);
                                if (success)
                                {
                                    MessageBox.Show("Part deleted successfully from RepairOS!", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("Local delete done but API delete failed.", "Warning");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("API Error: " + ex.Message, "Error");
                            }
                        }
                    }
                }
                Display();
                Index = -1;
            }
            else
            {
                MessageBox.Show("Select a part");
            }
        }

        private void ButtonSearchPart_Click(object sender, EventArgs e)
        {
            SearchPart(TextBoxSearchPart.Text);
        }

        private void SearchPart(string keyword)
        {
            if (keyword == "")
            {
                // Show all parts when search box is empty
                DataGridViewPart.DataSource = null;
                DataGridViewPart.DataSource = Inventory.MyPartList;
                DataGridViewPart.ClearSelection();
                return;
            }

            // Filter the list instead of hiding rows
            var filtered = Inventory.MyPartList
                .Where(p => p.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (filtered.Count < 1)
            {
                MessageBox.Show("No parts found matching: " + keyword);
                DataGridViewPart.DataSource = null;
                DataGridViewPart.DataSource = Inventory.MyPartList;
                return;
            }

            DataGridViewPart.DataSource = null;
            DataGridViewPart.DataSource = filtered;
            DataGridViewPart.ClearSelection();
        }

        private void TextBoxSearchPart_TextChanged(object sender, EventArgs e)
        {
            SearchPart(TextBoxSearchPart.Text);
        }

        private void DataGridViewPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            idxSelectedPart = DataGridViewPart.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart((int)DataGridViewPart.Rows[idxSelectedPart].Cells[0].Value);
            DataGridViewPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void InventoryManagementSystemMainScreen_Load(object sender, EventArgs e)
        {

        }

        //private void ButtonTestPartList_Click(object sender, EventArgs e)
        //{
        //    BuildPartList();
        //    DataGridViewPart.ClearSelection();
        //}
    }
}
