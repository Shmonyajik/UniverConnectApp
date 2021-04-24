
namespace WindowsFormsApp1
{
    partial class TypeZanyatiya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeZanyatiya));
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.typeZanyatiyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeZanyatiyaTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.TypeZanyatiyaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.typeZanyatiyaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.typeZanyatiyaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typeZanyatiyaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaBindingNavigator)).BeginInit();
            this.typeZanyatiyaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeZanyatiyaBindingSource
            // 
            this.typeZanyatiyaBindingSource.DataMember = "TypeZanyatiya";
            this.typeZanyatiyaBindingSource.DataSource = this.dataSet1;
            // 
            // typeZanyatiyaTableAdapter
            // 
            this.typeZanyatiyaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._GroupTableAdapter = null;
            this.tableAdapterManager._UserTableAdapter = null;
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafedraTableAdapter = null;
            this.tableAdapterManager.DecanatSotrudnikTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.PoseshyaemostTableAdapter = null;
            this.tableAdapterManager.RaspisanieControlTableAdapter = null;
            this.tableAdapterManager.RaspisanieTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TypeControlTableAdapter = null;
            this.tableAdapterManager.TypeZanyatiyaTableAdapter = this.typeZanyatiyaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeZanyatiyaBindingNavigator
            // 
            this.typeZanyatiyaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.typeZanyatiyaBindingNavigator.BindingSource = this.typeZanyatiyaBindingSource;
            this.typeZanyatiyaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.typeZanyatiyaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.typeZanyatiyaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.typeZanyatiyaBindingNavigatorSaveItem});
            this.typeZanyatiyaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.typeZanyatiyaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.typeZanyatiyaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.typeZanyatiyaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.typeZanyatiyaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.typeZanyatiyaBindingNavigator.Name = "typeZanyatiyaBindingNavigator";
            this.typeZanyatiyaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.typeZanyatiyaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.typeZanyatiyaBindingNavigator.TabIndex = 0;
            this.typeZanyatiyaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // typeZanyatiyaBindingNavigatorSaveItem
            // 
            this.typeZanyatiyaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.typeZanyatiyaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("typeZanyatiyaBindingNavigatorSaveItem.Image")));
            this.typeZanyatiyaBindingNavigatorSaveItem.Name = "typeZanyatiyaBindingNavigatorSaveItem";
            this.typeZanyatiyaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.typeZanyatiyaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.typeZanyatiyaBindingNavigatorSaveItem.Click += new System.EventHandler(this.typeZanyatiyaBindingNavigatorSaveItem_Click);
            // 
            // typeZanyatiyaDataGridView
            // 
            this.typeZanyatiyaDataGridView.AutoGenerateColumns = false;
            this.typeZanyatiyaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeZanyatiyaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.typeZanyatiyaDataGridView.DataSource = this.typeZanyatiyaBindingSource;
            this.typeZanyatiyaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeZanyatiyaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.typeZanyatiyaDataGridView.Name = "typeZanyatiyaDataGridView";
            this.typeZanyatiyaDataGridView.Size = new System.Drawing.Size(800, 425);
            this.typeZanyatiyaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_type_zanyatiya";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_type_zanyatiya";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type_zanyatiya_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "type_zanyatiya_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TypeZanyatiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeZanyatiyaDataGridView);
            this.Controls.Add(this.typeZanyatiyaBindingNavigator);
            this.Name = "TypeZanyatiya";
            this.Text = "TypeZanyatiya";
            this.Load += new System.EventHandler(this.TypeZanyatiya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaBindingNavigator)).EndInit();
            this.typeZanyatiyaBindingNavigator.ResumeLayout(false);
            this.typeZanyatiyaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeZanyatiyaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource typeZanyatiyaBindingSource;
        private DataSet1TableAdapters.TypeZanyatiyaTableAdapter typeZanyatiyaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator typeZanyatiyaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton typeZanyatiyaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView typeZanyatiyaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}