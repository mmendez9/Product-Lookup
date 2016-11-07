namespace Product_Lookup
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label units_On_HandLabel;
            System.Windows.Forms.Label priceLabel;
            this.lblProductNum = new System.Windows.Forms.Label();
            this.productDBDataSet = new Product_Lookup.ProductDBDataSet();
            this.productTableAdapter = new Product_Lookup.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Product_Lookup.ProductDBDataSetTableAdapters.TableAdapterManager();
            this.lbxProductNumber = new System.Windows.Forms.ListBox();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.units_On_HandTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            units_On_HandLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductNum
            // 
            this.lblProductNum.AutoSize = true;
            this.lblProductNum.Location = new System.Drawing.Point(24, 13);
            this.lblProductNum.Name = "lblProductNum";
            this.lblProductNum.Size = new System.Drawing.Size(126, 13);
            this.lblProductNum.TabIndex = 1;
            this.lblProductNum.Text = "Select a Product Number";
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Product_Lookup.ProductDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbxProductNumber
            // 
            this.lbxProductNumber.DataSource = this.productBindingSource2;
            this.lbxProductNumber.DisplayMember = "Product_Number";
            this.lbxProductNumber.FormattingEnabled = true;
            this.lbxProductNumber.Location = new System.Drawing.Point(24, 53);
            this.lbxProductNumber.Name = "lbxProductNumber";
            this.lbxProductNumber.Size = new System.Drawing.Size(126, 95);
            this.lbxProductNumber.TabIndex = 0;
            this.lbxProductNumber.ValueMember = "Product_Number";
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.productDBDataSet;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(180, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(249, 50);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // units_On_HandLabel
            // 
            units_On_HandLabel.AutoSize = true;
            units_On_HandLabel.Location = new System.Drawing.Point(163, 85);
            units_On_HandLabel.Name = "units_On_HandLabel";
            units_On_HandLabel.Size = new System.Drawing.Size(80, 13);
            units_On_HandLabel.TabIndex = 4;
            units_On_HandLabel.Text = "Units On Hand:";
            // 
            // units_On_HandTextBox
            // 
            this.units_On_HandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Units_On_Hand", true));
            this.units_On_HandTextBox.Location = new System.Drawing.Point(249, 82);
            this.units_On_HandTextBox.Name = "units_On_HandTextBox";
            this.units_On_HandTextBox.Size = new System.Drawing.Size(100, 20);
            this.units_On_HandTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(209, 115);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource2, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(249, 112);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 168);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(units_On_HandLabel);
            this.Controls.Add(this.units_On_HandTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.lblProductNum);
            this.Controls.Add(this.lbxProductNumber);
            this.Name = "Form1";
            this.Text = "Product Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.Label lblProductNum;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ProductDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox lbxProductNumber;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox units_On_HandTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

