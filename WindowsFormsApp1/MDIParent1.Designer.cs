
namespace WindowsFormsApp1
{
    partial class MDIParent1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аудиторииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиДеканатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещаемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.adminViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminViewTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.AdminViewTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.adminViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.adminViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cтудентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewBindingNavigator)).BeginInit();
            this.adminViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 453);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(844, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel.Text = "Состояние";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(844, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.ролиToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.аудиторииToolStripMenuItem,
            this.кафедрыToolStripMenuItem,
            this.сотрудникиДеканатаToolStripMenuItem,
            this.дисциплиныToolStripMenuItem,
            this.посещаемостьToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.расписаниеКонтроляToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.типыЗанятийToolStripMenuItem,
            this.типыКонтроляToolStripMenuItem,
            this.cтудентыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // аудиторииToolStripMenuItem
            // 
            this.аудиторииToolStripMenuItem.Name = "аудиторииToolStripMenuItem";
            this.аудиторииToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.аудиторииToolStripMenuItem.Text = "Аудитории";
            this.аудиторииToolStripMenuItem.Click += new System.EventHandler(this.аудиторииToolStripMenuItem_Click);
            // 
            // кафедрыToolStripMenuItem
            // 
            this.кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            this.кафедрыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.кафедрыToolStripMenuItem.Text = "Кафедры";
            this.кафедрыToolStripMenuItem.Click += new System.EventHandler(this.кафедрыToolStripMenuItem_Click);
            // 
            // сотрудникиДеканатаToolStripMenuItem
            // 
            this.сотрудникиДеканатаToolStripMenuItem.Name = "сотрудникиДеканатаToolStripMenuItem";
            this.сотрудникиДеканатаToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сотрудникиДеканатаToolStripMenuItem.Text = "Сотрудники деканата";
            this.сотрудникиДеканатаToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиДеканатаToolStripMenuItem_Click);
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // посещаемостьToolStripMenuItem
            // 
            this.посещаемостьToolStripMenuItem.Name = "посещаемостьToolStripMenuItem";
            this.посещаемостьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.посещаемостьToolStripMenuItem.Text = "Посещаемость";
            this.посещаемостьToolStripMenuItem.Click += new System.EventHandler(this.посещаемостьToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // расписаниеКонтроляToolStripMenuItem
            // 
            this.расписаниеКонтроляToolStripMenuItem.Name = "расписаниеКонтроляToolStripMenuItem";
            this.расписаниеКонтроляToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.расписаниеКонтроляToolStripMenuItem.Text = "Расписание контроля";
            this.расписаниеКонтроляToolStripMenuItem.Click += new System.EventHandler(this.расписаниеКонтроляToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // типыЗанятийToolStripMenuItem
            // 
            this.типыЗанятийToolStripMenuItem.Name = "типыЗанятийToolStripMenuItem";
            this.типыЗанятийToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.типыЗанятийToolStripMenuItem.Text = "Типы занятий";
            this.типыЗанятийToolStripMenuItem.Click += new System.EventHandler(this.типыЗанятийToolStripMenuItem_Click);
            // 
            // типыКонтроляToolStripMenuItem
            // 
            this.типыКонтроляToolStripMenuItem.Name = "типыКонтроляToolStripMenuItem";
            this.типыКонтроляToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.типыКонтроляToolStripMenuItem.Text = "Типы контроля";
            this.типыКонтроляToolStripMenuItem.Click += new System.EventHandler(this.типыКонтроляToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminViewBindingSource
            // 
            this.adminViewBindingSource.DataMember = "AdminView";
            this.adminViewBindingSource.DataSource = this.dataSet1;
            // 
            // adminViewTableAdapter
            // 
            this.adminViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._GroupTableAdapter = null;
            this.tableAdapterManager._UserTableAdapter = null;
            this.tableAdapterManager.AuditoriumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafedraTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DecanatSotrudnikTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.PoseshyaemostTableAdapter = null;
            this.tableAdapterManager.RaspisanieControlTableAdapter = null;
            this.tableAdapterManager.RaspisanieTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.TypeControlTableAdapter = null;
            this.tableAdapterManager.TypeZanyatiyaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminViewBindingNavigator
            // 
            this.adminViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adminViewBindingNavigator.BindingSource = this.adminViewBindingSource;
            this.adminViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adminViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adminViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1});
            this.adminViewBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.adminViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adminViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adminViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adminViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adminViewBindingNavigator.Name = "adminViewBindingNavigator";
            this.adminViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adminViewBindingNavigator.Size = new System.Drawing.Size(844, 25);
            this.adminViewBindingNavigator.TabIndex = 6;
            this.adminViewBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.adminViewBindingNavigatorSaveItem_Click);
            // 
            // adminViewDataGridView
            // 
            this.adminViewDataGridView.AutoGenerateColumns = false;
            this.adminViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.adminViewDataGridView.DataSource = this.adminViewBindingSource;
            this.adminViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminViewDataGridView.Location = new System.Drawing.Point(0, 49);
            this.adminViewDataGridView.Name = "adminViewDataGridView";
            this.adminViewDataGridView.Size = new System.Drawing.Size(844, 404);
            this.adminViewDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "role_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "role_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "otchestvo";
            this.dataGridViewTextBoxColumn5.HeaderText = "otchestvo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn6.HeaderText = "login";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn7.HeaderText = "password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn8.HeaderText = "email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // cтудентыToolStripMenuItem
            // 
            this.cтудентыToolStripMenuItem.Name = "cтудентыToolStripMenuItem";
            this.cтудентыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cтудентыToolStripMenuItem.Text = "Cтуденты";
            this.cтудентыToolStripMenuItem.Click += new System.EventHandler(this.cтудентыToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 475);
            this.Controls.Add(this.adminViewDataGridView);
            this.Controls.Add(this.adminViewBindingNavigator);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "UniverConnect-Administrator";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewBindingNavigator)).EndInit();
            this.adminViewBindingNavigator.ResumeLayout(false);
            this.adminViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аудиторииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиДеканатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещаемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеКонтроляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыКонтроляToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource adminViewBindingSource;
        private DataSet1TableAdapters.AdminViewTableAdapter adminViewTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adminViewBindingNavigator;
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
        private System.Windows.Forms.DataGridView adminViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cтудентыToolStripMenuItem;
    }
}



