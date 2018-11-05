namespace Ejercicio_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tareaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Ejercicio_3.agendaDataSet();
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
            this.tareaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tareaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByAñoToolStrip = new System.Windows.Forms.ToolStrip();
            this.añoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.añoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByAñoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tareaTableAdapter = new Ejercicio_3.agendaDataSetTableAdapters.tareaTableAdapter();
            this.tableAdapterManager = new Ejercicio_3.agendaDataSetTableAdapters.TableAdapterManager();
            this.agendaTableAdapter = new Ejercicio_3.agendaDataSetTableAdapters.agendaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tareaListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingNavigator)).BeginInit();
            this.tareaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataGridView)).BeginInit();
            this.fillByAñoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tareaBindingNavigator
            // 
            this.tareaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tareaBindingNavigator.BindingSource = this.tareaBindingSource;
            this.tareaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tareaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tareaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tareaBindingNavigatorSaveItem});
            this.tareaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tareaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tareaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tareaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tareaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tareaBindingNavigator.Name = "tareaBindingNavigator";
            this.tareaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tareaBindingNavigator.Size = new System.Drawing.Size(1082, 25);
            this.tareaBindingNavigator.TabIndex = 0;
            this.tareaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataMember = "tarea";
            this.tareaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tareaBindingNavigatorSaveItem
            // 
            this.tareaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tareaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tareaBindingNavigatorSaveItem.Image")));
            this.tareaBindingNavigatorSaveItem.Name = "tareaBindingNavigatorSaveItem";
            this.tareaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tareaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tareaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tareaBindingNavigatorSaveItem_Click);
            // 
            // tareaDataGridView
            // 
            this.tareaDataGridView.AutoGenerateColumns = false;
            this.tareaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tareaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tareaDataGridView.DataSource = this.tareaBindingSource;
            this.tareaDataGridView.Location = new System.Drawing.Point(0, 53);
            this.tareaDataGridView.Name = "tareaDataGridView";
            this.tareaDataGridView.Size = new System.Drawing.Size(763, 196);
            this.tareaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn1.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lugar";
            this.dataGridViewTextBoxColumn4.HeaderText = "lugar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_agenda";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_agenda";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // fillByAñoToolStrip
            // 
            this.fillByAñoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añoToolStripLabel,
            this.añoToolStripTextBox,
            this.fillByAñoToolStripButton});
            this.fillByAñoToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByAñoToolStrip.Name = "fillByAñoToolStrip";
            this.fillByAñoToolStrip.Size = new System.Drawing.Size(1082, 25);
            this.fillByAñoToolStrip.TabIndex = 2;
            this.fillByAñoToolStrip.Text = "fillByAñoToolStrip";
            // 
            // añoToolStripLabel
            // 
            this.añoToolStripLabel.Name = "añoToolStripLabel";
            this.añoToolStripLabel.Size = new System.Drawing.Size(30, 22);
            this.añoToolStripLabel.Text = "año:";
            // 
            // añoToolStripTextBox
            // 
            this.añoToolStripTextBox.Name = "añoToolStripTextBox";
            this.añoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByAñoToolStripButton
            // 
            this.fillByAñoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAñoToolStripButton.Name = "fillByAñoToolStripButton";
            this.fillByAñoToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByAñoToolStripButton.Text = "FillByAño";
            this.fillByAñoToolStripButton.Click += new System.EventHandler(this.fillByAñoToolStripButton_Click);
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tareaTableAdapter = this.tareaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ejercicio_3.agendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(330, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(436, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.agendaDataSet;
            // 
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataMember = "tarea";
            this.tareaBindingSource1.DataSource = this.agendaDataSet;
            // 
            // tareaListBox
            // 
            this.tareaListBox.DataSource = this.tareaBindingSource1;
            this.tareaListBox.DisplayMember = "descripcion";
            this.tareaListBox.FormattingEnabled = true;
            this.tareaListBox.Location = new System.Drawing.Point(669, 270);
            this.tareaListBox.Name = "tareaListBox";
            this.tareaListBox.Size = new System.Drawing.Size(300, 212);
            this.tareaListBox.TabIndex = 9;
            this.tareaListBox.ValueMember = "fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.tareaListBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByAñoToolStrip);
            this.Controls.Add(this.tareaDataGridView);
            this.Controls.Add(this.tareaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingNavigator)).EndInit();
            this.tareaBindingNavigator.ResumeLayout(false);
            this.tareaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataGridView)).EndInit();
            this.fillByAñoToolStrip.ResumeLayout(false);
            this.fillByAñoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private agendaDataSetTableAdapters.tareaTableAdapter tareaTableAdapter;
        private agendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tareaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tareaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tareaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private agendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByAñoToolStrip;
        private System.Windows.Forms.ToolStripLabel añoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox añoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByAñoToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private System.Windows.Forms.ListBox tareaListBox;
    }
}

