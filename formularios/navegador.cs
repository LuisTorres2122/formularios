using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace NavegadorVista
{
    public partial class Navegador : UserControl
    {
        
        
        public Navegador()
        {
            InitializeComponent();
        }

        public Form actual = new Form();
        public TextBox[] textbox = { };
        public TextBox[] textboxi = { };
        public DataGridView tabla;
        public static string idApp;

       

        int opcion;

       
        public void cargar(DataGridView dtabla, TextBox[] text, string BD)
        {
            IconButton[] botongc = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
            };
           
          
            


        }
        public void bloqEnd(IconButton[] botongc3)
        {
            for (int i = 0; i < botongc3.Length; i++)
            {
                botongc3[i].Enabled = false;
            }
        }
        public void bloqStart(IconButton[] botongc)// bloque botones al principio
        {
            for (int i = 0; i < botongc.Length; i++)
            {
                botongc[i].Enabled = false;
            }
            
         
           

        }
       


        private void btnExit_Click(object sender, EventArgs e)
        {
            actual.Close();
        }

        private void ComponenteNavegador_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            //Consulta.Vista cv = new Consulta.Vista();
            /*
             * Form 'fcv' = new 'cv.BusquedaAvanzada';
             */
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
          
            //Reportes.Vista cr = new Reportes.Vista();
            /*
             * Form 'fcr' = new 'cr.BusquedaAvanzada';
             */
        }
    }
}
