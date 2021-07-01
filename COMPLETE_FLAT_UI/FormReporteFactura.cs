using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
     public partial class FormReporteFactura : Form
     {
          public FormReporteFactura()
          {
               InitializeComponent();
          }

          private void crystalReportViewer1_Load(object sender, EventArgs e)
          {

          }

          private void FormReporteFactura_Load(object sender, EventArgs e)
          {
              // rptFactura1 reporte = new rptFactura();
              // reporte.SetParameterValue("@registro", txtFactura.Text);
          }
     }
}
