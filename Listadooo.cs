using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{

    public partial class Form1 : Form
    {
        List<int> Milista = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvalor.Text);
            Milista.Add(n);
            txtvalor.Clear();
            txtvalor.Focus();

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            int n, pos;
            n = int.Parse(txtvalor.Text);
            pos = int.Parse(txtposicion.Text);
            Milista.Insert(n, pos);
            txtvalor.Clear();
            txtvalor.Focus();
            txtposicion.Clear();
            txtposicion.Focus();
        }

        private void btneliminarde_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(txtposicion.Text);
            txtposicion.Clear();
            txtposicion.Focus();
            Milista.RemoveAt(pos);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvalor.Text);
            Milista.Remove(n);
            txtvalor.Clear();
            txtvalor.Focus();

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int i;
            liver.Items.Clear();
            for (i = 0; i <= Milista.Count - 1; i++)
            {
               Liver.Items.Add(Milista.ElementAt(i));
            }

        }

        private Button btnagregar;
        private Button Liver;

        private void InitializeComponent()
        {
            this.btnagregar = new System.Windows.Forms.Button();
            this.Liver = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneliminarde = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.Mostar = new System.Windows.Forms.TextBox();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(26, 194);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // Liver
            // 
            this.Liver.Location = new System.Drawing.Point(26, 124);
            this.Liver.Name = "Liver";
            this.Liver.Size = new System.Drawing.Size(75, 23);
            this.Liver.TabIndex = 1;
            this.Liver.Text = "Mostrar";
            this.Liver.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(26, 263);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneliminarde
            // 
            this.btneliminarde.Location = new System.Drawing.Point(26, 330);
            this.btneliminarde.Name = "btneliminarde";
            this.btneliminarde.Size = new System.Drawing.Size(75, 23);
            this.btneliminarde.TabIndex = 3;
            this.btneliminarde.Text = "Eliminar De";
            this.btneliminarde.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(136, 124);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // Mostar
            // 
            this.Mostar.Location = new System.Drawing.Point(324, 170);
            this.Mostar.Multiline = true;
            this.Mostar.Name = "Mostar";
            this.Mostar.Size = new System.Drawing.Size(185, 208);
            this.Mostar.TabIndex = 5;
            this.Mostar.Text = "Liver";
            // 
            // txtposicion
            // 
            this.txtposicion.Location = new System.Drawing.Point(147, 211);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(100, 23);
            this.txtposicion.TabIndex = 6;
            this.txtposicion.Text = "Posicion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(26, 49);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 23);
            this.txtvalor.TabIndex = 8;
            this.txtvalor.Text = "Colocar datos";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 387);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.Mostar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.btneliminarde);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.Liver);
            this.Controls.Add(this.btnagregar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btneliminar;
        private Button btneliminarde;
        private Button btninsertar;
        private TextBox Mostar;
        private TextBox txtposicion;
        private TextBox textBox3;
        private TextBox txtvalor;

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

        
        
           