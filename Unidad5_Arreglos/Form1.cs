using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad5_Arreglos
{
    public partial class Form1 : Form
    {
        private int[,] notas;
        private int[] promedios;
        private int promedioGeneral;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            notas = new int[4, 3];
            notas[0, 0] = int.Parse(txtNota11.Text);
            notas[0, 1] = int.Parse(txtNota12.Text);
            notas[0, 2] = int.Parse(txtNota13.Text);
            notas[1, 0] = int.Parse(txtNota21.Text);
            notas[1, 1] = int.Parse(txtNota22.Text);
            notas[1, 2] = int.Parse(txtNota23.Text);
            notas[2, 0] = int.Parse(txtNota31.Text);
            notas[2, 1] = int.Parse(txtNota32.Text);
            notas[2, 2] = int.Parse(txtNota33.Text);
            notas[3, 0] = int.Parse(txtNota41.Text);
            notas[3, 1] = int.Parse(txtNota42.Text);
            notas[3, 2] = int.Parse(txtNota43.Text);

            // Calcular promedio de cada estudiante
            promedios = new int[4];
            promedioGeneral = 0;
            for (int i = 0; i < 4; i++)
            {
                int suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }
                promedios[i] = suma / 3;
                promedioGeneral += promedios[i];
            }
            promedioGeneral /= 4;

            // Mostrar tabla con resultados
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Estudiante", "Estudiante");
            dataGridView1.Columns.Add("Materia 1", "Materia 1");
            dataGridView1.Columns.Add("Materia 2", "Materia 2");
            dataGridView1.Columns.Add("Materia 3", "Materia 3");
            dataGridView1.Columns.Add("Promedio", "Promedio");
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Estudiante " + (i + 1);
                dataGridView1.Rows[i].Cells[1].Value = notas[i, 0];
                dataGridView1.Rows[i].Cells[2].Value = notas[i, 1];
                dataGridView1.Rows[i].Cells[3].Value = notas[i, 2];
                dataGridView1.Rows[i].Cells[4].Value = promedios[i];
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "Promedio General";
            dataGridView1.Rows[4].Cells[4].Value = promedioGeneral;
        }
    }
}
