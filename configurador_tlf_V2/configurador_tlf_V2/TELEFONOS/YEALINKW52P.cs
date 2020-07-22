using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKW52P
    {
        public int numextensiones;
        public int numfila;
        public int contadorextensiones;
        public int numextensionesdetlf;

        public async Task configuraciongeneralAsync(String ipactual, int extension, String alias, String ipcentralita, WebBrowser webBrowser1, DataGridView gridextensiones)
        {

            //CONFIGURACION GENERAL
            

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_listener&p=login&q=loginForm&jumpto=status");

            await cargapagina();
            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("username")[0].SetAttribute("value", "admin");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("pwd")[0].SetAttribute("value", "admin");

            webBrowser1.Document.GetElementById("idConfirm").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=account-register&q=load&acc=0");

            await cargapagina();

            webBrowser1.Document.GetElementById("Enable").SetAttribute("value", "1");
            webBrowser1.Document.GetElementById("Label").SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementById("DisplayName").SetAttribute("value", alias);
            webBrowser1.Document.GetElementById("AuthName").SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementById("UserName").SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementById("editPassword").SetAttribute("value", "p@ssword+" + extension);
            webBrowser1.Document.GetElementById("server1").SetAttribute("value", ipcentralita);

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=settings-datetime&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("LocalTimeDhcpTimeSwitch")[0].SetAttribute("value", "1");

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            webBrowser1.Document.GetElementById("iDTimeZoneName").SetAttribute("value", "+1");

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            webBrowser1.Document.GetElementById("selLocation").SetAttribute("value", "Spain(Madrid)");

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");
        }

        async Task cargapagina()
        {
            await Task.Delay(2000);
        }

        async Task cargapequeña()
        {
            await Task.Delay(100);
        }


        public async Task configurarred(String ipactual, WebBrowser webBrowser, String ipaconfigurar2, String mascaraaconfigurar2, String puertaaconfigurar2)
        {
            await cargapagina();
            webBrowser.Navigate("http://" + ipactual + "/servlet?p=network&q=load");
            await cargapagina();

            webBrowser.Document.GetElementsByTagName("select").GetElementsByName("NetworkIPAddressMode")[0].SetAttribute("value", "0");

            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanType")[1].InvokeMember("Click");


            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");


            await cargapagina();

            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticIp")[0].SetAttribute("value", ipaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticMask")[0].SetAttribute("value", mascaraaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticGateWay")[0].SetAttribute("value", puertaaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticPriDns")[0].SetAttribute("value", "8.8.8.8");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticSecDns")[0].SetAttribute("value", "8.8.4.4");

            await cargapagina();

            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            pulsarintroen5seg();

            await cargapagina();

        }

        public async Task pulsarintroen5seg()
        {
            await cargapagina();
            SendKeys.Send("{ENTER}");

        }



        public async Task ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }



    }
}