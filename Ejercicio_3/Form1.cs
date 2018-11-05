using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.agendaDataSet.tarea);

        }

        /*private void fillByAñoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.agendaTableAdapter.FillByAño(this.agendaDataSet.agenda, ((int)(System.Convert.ChangeType(añoToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(this.tareaTableAdapter.Count(textBox3.Text).ToString()) == 0) { 
                this.tareaTableAdapter.InsertTarea(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text));
                this.tareaTableAdapter.Fill(this.agendaDataSet.tarea);
            }
            else
            {
                MessageBox.Show("Ya hay un registro con esa clave principal");
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tareaTableAdapter.FillBy(this.agendaDataSet.tarea, lugarToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.Fill(this.agendaDataSet.tarea);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.DeleteQuery(tareaListBox.SelectedValue.ToString());
            this.tareaTableAdapter.Fill(this.agendaDataSet.tarea);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), tareaListBox.SelectedValue.ToString());
            this.tareaTableAdapter.Fill(this.agendaDataSet.tarea);
        }

        private void tareaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tareaListBox.SelectedValue != null) { 
                textBox1.Text = this.tareaTableAdapter.SelectFecha(tareaListBox.SelectedValue.ToString());
                textBox2.Text = this.tareaTableAdapter.SelectHora(tareaListBox.SelectedValue.ToString());
                textBox3.Text = this.tareaTableAdapter.SelectDescripcion(tareaListBox.SelectedValue.ToString());
                textBox4.Text = this.tareaTableAdapter.SelectLugar(tareaListBox.SelectedValue.ToString());
                textBox5.Text = this.tareaTableAdapter.SelectID(tareaListBox.SelectedValue.ToString()).ToString();
            }
        }
    }
}
