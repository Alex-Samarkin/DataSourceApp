﻿namespace DataSourceApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enumBinder1 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder2 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder3 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.enumBinder4 = new Telerik.WinControls.UI.Data.EnumBinder();
            this.dataSet1 = new DataSourceApp.DataSet1();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.visitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.visitsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).BeginInit();
            this.visitsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enumBinder1
            // 
            this.enumBinder1.Source = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn1.DataSource = this.enumBinder1;
            gridViewComboBoxColumn1.DataType = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn1.DisplayMember = "Description";
            gridViewComboBoxColumn1.FieldName = "SortDirection";
            gridViewComboBoxColumn1.HeaderText = "SortDirection";
            gridViewComboBoxColumn1.IsAutoGenerated = true;
            gridViewComboBoxColumn1.Name = "SortDirection";
            gridViewComboBoxColumn1.ReadOnly = true;
            gridViewComboBoxColumn1.ValueMember = "Value";
            this.enumBinder1.Target = gridViewComboBoxColumn1;
            // 
            // enumBinder2
            // 
            this.enumBinder2.Source = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn2.DataSource = this.enumBinder2;
            gridViewComboBoxColumn2.DataType = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn2.DisplayMember = "Description";
            gridViewComboBoxColumn2.FieldName = "SortDirection";
            gridViewComboBoxColumn2.HeaderText = "SortDirection";
            gridViewComboBoxColumn2.IsAutoGenerated = true;
            gridViewComboBoxColumn2.Name = "SortDirection";
            gridViewComboBoxColumn2.ReadOnly = true;
            gridViewComboBoxColumn2.ValueMember = "Value";
            this.enumBinder2.Target = gridViewComboBoxColumn2;
            // 
            // enumBinder3
            // 
            this.enumBinder3.Source = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn3.DataSource = this.enumBinder3;
            gridViewComboBoxColumn3.DataType = typeof(object);
            gridViewComboBoxColumn3.DisplayMember = "Description";
            gridViewComboBoxColumn3.FieldName = "SortDirection";
            gridViewComboBoxColumn3.HeaderText = "SortDirection";
            gridViewComboBoxColumn3.IsAutoGenerated = true;
            gridViewComboBoxColumn3.Name = "SortDirection";
            gridViewComboBoxColumn3.ReadOnly = true;
            gridViewComboBoxColumn3.ValueMember = "Value";
            this.enumBinder3.Target = gridViewComboBoxColumn3;
            // 
            // enumBinder4
            // 
            this.enumBinder4.Source = typeof(System.ComponentModel.ListSortDirection);
            gridViewComboBoxColumn4.DataSource = this.enumBinder4;
            gridViewComboBoxColumn4.DataType = typeof(object);
            gridViewComboBoxColumn4.DisplayMember = "Description";
            gridViewComboBoxColumn4.FieldName = "SortDirection";
            gridViewComboBoxColumn4.HeaderText = "SortDirection";
            gridViewComboBoxColumn4.IsAutoGenerated = true;
            gridViewComboBoxColumn4.Name = "SortDirection";
            gridViewComboBoxColumn4.ReadOnly = true;
            gridViewComboBoxColumn4.ValueMember = "Value";
            this.enumBinder4.Target = gridViewComboBoxColumn4;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.dataSet1;
            // 
            // visitsBindingNavigator
            // 
            this.visitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitsBindingNavigator.BindingSource = this.visitsBindingSource;
            this.visitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.visitsBindingNavigatorSaveItem});
            this.visitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitsBindingNavigator.Name = "visitsBindingNavigator";
            this.visitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitsBindingNavigator.Size = new System.Drawing.Size(1300, 25);
            this.visitsBindingNavigator.TabIndex = 0;
            this.visitsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // visitsBindingNavigatorSaveItem
            // 
            this.visitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitsBindingNavigatorSaveItem.Enabled = false;
            this.visitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitsBindingNavigatorSaveItem.Image")));
            this.visitsBindingNavigatorSaveItem.Name = "visitsBindingNavigatorSaveItem";
            this.visitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.visitsBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // visitsDataGridView
            // 
            this.visitsDataGridView.AutoGenerateColumns = false;
            this.visitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.visitsDataGridView.DataSource = this.visitsBindingSource;
            this.visitsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.visitsDataGridView.Name = "visitsDataGridView";
            this.visitsDataGridView.Size = new System.Drawing.Size(392, 690);
            this.visitsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOf";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateOf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person_Visits";
            this.personBindingSource.DataSource = this.visitsBindingSource;
            // 
            // personDataGridView
            // 
            this.personDataGridView.AutoGenerateColumns = false;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.personDataGridView.DataSource = this.personBindingSource;
            this.personDataGridView.Location = new System.Drawing.Point(410, 28);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.Size = new System.Drawing.Size(870, 309);
            this.personDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AdressID";
            this.dataGridViewTextBoxColumn8.HeaderText = "AdressID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // adressBindingSource
            // 
            this.adressBindingSource.DataMember = "FK_Person_Adress";
            this.adressBindingSource.DataSource = this.personBindingSource;
            // 
            // adressDataGridView
            // 
            this.adressDataGridView.AutoGenerateColumns = false;
            this.adressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.adressDataGridView.DataSource = this.adressBindingSource;
            this.adressDataGridView.Location = new System.Drawing.Point(417, 352);
            this.adressDataGridView.Name = "adressDataGridView";
            this.adressDataGridView.Size = new System.Drawing.Size(863, 366);
            this.adressDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn10.HeaderText = "City";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn11.HeaderText = "Street";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn12.HeaderText = "House";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Corp";
            this.dataGridViewTextBoxColumn13.HeaderText = "Corp";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn14.HeaderText = "Room";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 738);
            this.Controls.Add(this.adressDataGridView);
            this.Controls.Add(this.personDataGridView);
            this.Controls.Add(this.visitsDataGridView);
            this.Controls.Add(this.visitsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).EndInit();
            this.visitsBindingNavigator.ResumeLayout(false);
            this.visitsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder1;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder2;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder3;
        private Telerik.WinControls.UI.Data.EnumBinder enumBinder4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private System.Windows.Forms.BindingNavigator visitsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton visitsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource adressBindingSource;
        private System.Windows.Forms.DataGridView adressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

