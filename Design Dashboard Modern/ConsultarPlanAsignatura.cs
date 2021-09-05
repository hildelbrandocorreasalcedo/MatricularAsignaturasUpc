using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Design_Dashboard_Modern
{
    public partial class ConsultarPlanAsignatura : Form
    {
        private readonly UpcService upcService;
        public ConsultarPlanAsignatura()
        {
            InitializeComponent();
            upcService = new UpcService();
        }

        private void BtLLenarDescripcion_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarJustificacion_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarObjetivoGeneral_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarObjetivosEspecificos_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarComponentesGenericos_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarEstrategiasPedagogicas_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarContenidos_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarMecanismoEvaluacion_Click(object sender, EventArgs e)
        {
        }

        private void BtLLenarReferenciasBibliograficas_Click(object sender, EventArgs e)
        {
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            string materia = CmbAsignatura.Text;
            if (materia != "")
            {
                RespuestaBusqueda respuesta = upcService.BuscarPlanAsignatura(materia);

                if (respuesta.PlanAsignatura != null)
                {
                    PlanAsignaturas planAsignatura = respuesta.PlanAsignatura;
                    TxtDescripcion.Text = planAsignatura.Descripcion;
                    TxtJustificacion.Text = planAsignatura.Justificacion;
                    TxtObjetivoGeneral.Text = planAsignatura.ObjetivoGeneral;
                    TxtObjetivoEspecifico.Text = planAsignatura.ObjetivoEspecifico;
                    TxtComponentesGenericos.Text = planAsignatura.ComponeteGenerico;
                    TxtEstrategias.Text = planAsignatura.Estrategias;
                    TxtContenido.Text = planAsignatura.Contenidos;
                    TxtMecanismoEvaluativo.Text = planAsignatura.MecanismosEvaluacion;
                    TxtReferenciaBibliografica.Text = planAsignatura.ReferenciasBibliograficas;
                    MessageBox.Show(respuesta.Mensaje);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Escoja el Plan Asignatura a buscar", "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            CmbAsignatura.Text = "";
            TxtDescripcion.Text = "";
            TxtJustificacion.Text = "";
            TxtObjetivoGeneral.Text = "";
            TxtObjetivoEspecifico.Text = "";
            TxtComponentesGenericos.Text = "";
            TxtEstrategias.Text = "";
            TxtContenido.Text = "";
            TxtMecanismoEvaluativo.Text = "";
            TxtReferenciaBibliografica.Text = "";
        }

        private void ConsultarPlanAsignatura_Load(object sender, EventArgs e)
        {
            var response = upcService.ConsultarTodosAsignaturasDtg();
            CmbAsignatura.Items.Insert(0, "");
            foreach (var item in response.Asignatura)
            {
                CmbAsignatura.Items.Insert(1, item.Nombre);
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtDescripcion, "");
            
        }

        private void CmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CmbAsignatura, "");
           
        }

        private void TxtJustificacion_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtJustificacion, "");
            
        }

        private void TxtObjetivoGeneral_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtObjetivoGeneral, "");

        }

        private void TxtObjetivoEspecifico_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtObjetivoEspecifico, "");
           
        }

        private void TxtComponentesGenericos_TextChanged(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(TxtComponentesGenericos, "");
            
        }

        private void TxtEstrategias_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtEstrategias, "");
           
        }

        private void TxtContenido_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtContenido, "");
           
        }

        private void TxtMecanismoEvaluativo_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(TxtMecanismoEvaluativo, "");
         
        }

        private void TxtReferenciaBibliografica_TextChanged(object sender, EventArgs e)
        {
    
            errorProvider1.SetError(TxtReferenciaBibliografica, "");
        }
    }
}
