
namespace SchoolListApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНазвоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заСпеціальністюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заКонкурсомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваВУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регіонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.повнаАдресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціальностіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataBaseDataSet = new SchoolListApp.SchoolDataBaseDataSet();
            this.table_1TableAdapter = new SchoolListApp.SchoolDataBaseDataSetTableAdapters.Table_1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1076, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableEditingToolStripMenuItem,
            this.addFormToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // enableEditingToolStripMenuItem
            // 
            this.enableEditingToolStripMenuItem.Name = "enableEditingToolStripMenuItem";
            this.enableEditingToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.enableEditingToolStripMenuItem.Text = "Enable Editing";
            // 
            // addFormToolStripMenuItem
            // 
            this.addFormToolStripMenuItem.Name = "addFormToolStripMenuItem";
            this.addFormToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addFormToolStripMenuItem.Text = "Add Form";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заНазвоюToolStripMenuItem,
            this.заСпеціальністюToolStripMenuItem,
            this.заКонкурсомToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // заНазвоюToolStripMenuItem
            // 
            this.заНазвоюToolStripMenuItem.Name = "заНазвоюToolStripMenuItem";
            this.заНазвоюToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.заНазвоюToolStripMenuItem.Text = "За назвою";
            // 
            // заСпеціальністюToolStripMenuItem
            // 
            this.заСпеціальністюToolStripMenuItem.Name = "заСпеціальністюToolStripMenuItem";
            this.заСпеціальністюToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.заСпеціальністюToolStripMenuItem.Text = "За спеціальністю";
            // 
            // заКонкурсомToolStripMenuItem
            // 
            this.заКонкурсомToolStripMenuItem.Name = "заКонкурсомToolStripMenuItem";
            this.заКонкурсомToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.заКонкурсомToolStripMenuItem.Text = "За конкурсом";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddDataGridViewTextBoxColumn,
            this.назваВУЗDataGridViewTextBoxColumn,
            this.регіонDataGridViewTextBoxColumn,
            this.повнаАдресаDataGridViewTextBoxColumn,
            this.спеціальностіDataGridViewTextBoxColumn,
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 432);
            this.dataGridView1.TabIndex = 4;
            // 
            // ddDataGridViewTextBoxColumn
            // 
            this.ddDataGridViewTextBoxColumn.DataPropertyName = "dd";
            this.ddDataGridViewTextBoxColumn.HeaderText = "dd";
            this.ddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ddDataGridViewTextBoxColumn.Name = "ddDataGridViewTextBoxColumn";
            this.ddDataGridViewTextBoxColumn.Width = 70;
            // 
            // назваВУЗDataGridViewTextBoxColumn
            // 
            this.назваВУЗDataGridViewTextBoxColumn.DataPropertyName = "Назва ВУЗ";
            this.назваВУЗDataGridViewTextBoxColumn.HeaderText = "Назва ВУЗ";
            this.назваВУЗDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваВУЗDataGridViewTextBoxColumn.Name = "назваВУЗDataGridViewTextBoxColumn";
            this.назваВУЗDataGridViewTextBoxColumn.Width = 250;
            // 
            // регіонDataGridViewTextBoxColumn
            // 
            this.регіонDataGridViewTextBoxColumn.DataPropertyName = "Регіон";
            this.регіонDataGridViewTextBoxColumn.HeaderText = "Регіон";
            this.регіонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регіонDataGridViewTextBoxColumn.Name = "регіонDataGridViewTextBoxColumn";
            this.регіонDataGridViewTextBoxColumn.Width = 125;
            // 
            // повнаАдресаDataGridViewTextBoxColumn
            // 
            this.повнаАдресаDataGridViewTextBoxColumn.DataPropertyName = "Повна адреса";
            this.повнаАдресаDataGridViewTextBoxColumn.HeaderText = "Повна адреса";
            this.повнаАдресаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.повнаАдресаDataGridViewTextBoxColumn.Name = "повнаАдресаDataGridViewTextBoxColumn";
            this.повнаАдресаDataGridViewTextBoxColumn.Width = 125;
            // 
            // спеціальностіDataGridViewTextBoxColumn
            // 
            this.спеціальностіDataGridViewTextBoxColumn.DataPropertyName = "Спеціальності";
            this.спеціальностіDataGridViewTextBoxColumn.HeaderText = "Спеціальності";
            this.спеціальностіDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.спеціальностіDataGridViewTextBoxColumn.Name = "спеціальностіDataGridViewTextBoxColumn";
            this.спеціальностіDataGridViewTextBoxColumn.Width = 150;
            // 
            // вартість1РокуНавчанняDataGridViewTextBoxColumn
            // 
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn.DataPropertyName = "Вартість 1 року навчання";
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn.HeaderText = "Вартість 1 року навчання";
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn.Name = "вартість1РокуНавчанняDataGridViewTextBoxColumn";
            this.вартість1РокуНавчанняDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.schoolDataBaseDataSetBindingSource;
            // 
            // schoolDataBaseDataSetBindingSource
            // 
            this.schoolDataBaseDataSetBindingSource.DataSource = this.schoolDataBaseDataSet;
            this.schoolDataBaseDataSetBindingSource.Position = 0;
            // 
            // schoolDataBaseDataSet
            // 
            this.schoolDataBaseDataSet.DataSetName = "SchoolDataBaseDataSet";
            this.schoolDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Додати форму";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(930, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 82);
            this.button2.TabIndex = 6;
            this.button2.Text = "Перезавантажити базу даних";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(930, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 82);
            this.button3.TabIndex = 7;
            this.button3.Text = "Зберегти базу даних";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Шукати за назвою";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(609, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Шукати за регіоном";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(841, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "По коду спеціальності";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 499);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolList App 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFormToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource schoolDataBaseDataSetBindingSource;
        private SchoolDataBaseDataSet schoolDataBaseDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private SchoolDataBaseDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНазвоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заСпеціальністюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заКонкурсомToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваВУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регіонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn повнаАдресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціальностіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вартість1РокуНавчанняDataGridViewTextBoxColumn;
    }
}

