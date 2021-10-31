namespace AandelenBeheer
{
    partial class FormAandelen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAandelen));
            System.Windows.Forms.Label aandeelIdLabel;
            this.aandeelBeheerDataSet = new AandelenBeheer.AandeelBeheerDataSet();
            this.andelenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.andelenTableAdapter = new AandelenBeheer.AandeelBeheerDataSetTableAdapters.AndelenTableAdapter();
            this.tableAdapterManager = new AandelenBeheer.AandeelBeheerDataSetTableAdapters.TableAdapterManager();
            this.andelenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.andelenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aandeelIdLabel1 = new System.Windows.Forms.Label();
            this.transactiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactiesTableAdapter = new AandelenBeheer.AandeelBeheerDataSetTableAdapters.TransactiesTableAdapter();
            this.transactiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aandeelIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBeheerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andelenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andelenBindingNavigator)).BeginInit();
            this.andelenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aandeelBeheerDataSet
            // 
            this.aandeelBeheerDataSet.DataSetName = "AandeelBeheerDataSet";
            this.aandeelBeheerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // andelenBindingSource
            // 
            this.andelenBindingSource.DataMember = "Andelen";
            this.andelenBindingSource.DataSource = this.aandeelBeheerDataSet;
            // 
            // andelenTableAdapter
            // 
            this.andelenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AndelenTableAdapter = this.andelenTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactiesTableAdapter = this.transactiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AandelenBeheer.AandeelBeheerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // andelenBindingNavigator
            // 
            this.andelenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.andelenBindingNavigator.BindingSource = this.andelenBindingSource;
            this.andelenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.andelenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.andelenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.andelenBindingNavigatorSaveItem});
            this.andelenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.andelenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.andelenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.andelenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.andelenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.andelenBindingNavigator.Name = "andelenBindingNavigator";
            this.andelenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.andelenBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.andelenBindingNavigator.TabIndex = 0;
            this.andelenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // andelenBindingNavigatorSaveItem
            // 
            this.andelenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.andelenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("andelenBindingNavigatorSaveItem.Image")));
            this.andelenBindingNavigatorSaveItem.Name = "andelenBindingNavigatorSaveItem";
            this.andelenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.andelenBindingNavigatorSaveItem.Text = "Save Data";
            this.andelenBindingNavigatorSaveItem.Click += new System.EventHandler(this.andelenBindingNavigatorSaveItem_Click);
            // 
            // aandeelIdLabel
            // 
            aandeelIdLabel.AutoSize = true;
            aandeelIdLabel.Location = new System.Drawing.Point(12, 25);
            aandeelIdLabel.Name = "aandeelIdLabel";
            aandeelIdLabel.Size = new System.Drawing.Size(61, 13);
            aandeelIdLabel.TabIndex = 1;
            aandeelIdLabel.Text = "Aandeel Id:";
            // 
            // aandeelIdLabel1
            // 
            this.aandeelIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.andelenBindingSource, "AandeelId", true));
            this.aandeelIdLabel1.Location = new System.Drawing.Point(79, 25);
            this.aandeelIdLabel1.Name = "aandeelIdLabel1";
            this.aandeelIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.aandeelIdLabel1.TabIndex = 2;
            this.aandeelIdLabel1.Text = "label1";
            // 
            // transactiesBindingSource
            // 
            this.transactiesBindingSource.DataMember = "FK_AandeelId";
            this.transactiesBindingSource.DataSource = this.andelenBindingSource;
            // 
            // transactiesTableAdapter
            // 
            this.transactiesTableAdapter.ClearBeforeFill = true;
            // 
            // transactiesDataGridView
            // 
            this.transactiesDataGridView.AutoGenerateColumns = false;
            this.transactiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.transactiesDataGridView.DataSource = this.transactiesBindingSource;
            this.transactiesDataGridView.Location = new System.Drawing.Point(15, 51);
            this.transactiesDataGridView.Name = "transactiesDataGridView";
            this.transactiesDataGridView.Size = new System.Drawing.Size(644, 220);
            this.transactiesDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactieId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactieId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AandeelId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AandeelId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AantalGekocht";
            this.dataGridViewTextBoxColumn3.HeaderText = "AantalGekocht";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AantalVerkocht";
            this.dataGridViewTextBoxColumn4.HeaderText = "AantalVerkocht";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Koers";
            this.dataGridViewTextBoxColumn5.HeaderText = "Koers";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactieDatum";
            this.dataGridViewTextBoxColumn6.HeaderText = "TransactieDatum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FormAandelen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.transactiesDataGridView);
            this.Controls.Add(aandeelIdLabel);
            this.Controls.Add(this.aandeelIdLabel1);
            this.Controls.Add(this.andelenBindingNavigator);
            this.Name = "FormAandelen";
            this.Text = "Aandelen";
            this.Load += new System.EventHandler(this.FormAandelen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aandeelBeheerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andelenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andelenBindingNavigator)).EndInit();
            this.andelenBindingNavigator.ResumeLayout(false);
            this.andelenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AandeelBeheerDataSet aandeelBeheerDataSet;
        private System.Windows.Forms.BindingSource andelenBindingSource;
        private AandeelBeheerDataSetTableAdapters.AndelenTableAdapter andelenTableAdapter;
        private AandeelBeheerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator andelenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton andelenBindingNavigatorSaveItem;
        private AandeelBeheerDataSetTableAdapters.TransactiesTableAdapter transactiesTableAdapter;
        private System.Windows.Forms.Label aandeelIdLabel1;
        private System.Windows.Forms.BindingSource transactiesBindingSource;
        private System.Windows.Forms.DataGridView transactiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

