using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT26P
    {

        public int numextensiones;
        public int numfila;
        public int contadorextensiones;
        public int numextensionesdetlf;

        public async Task configuraciongeneralAsync(String ipactual, int extension, String alias, String ipcentralita, WebBrowser webBrowser1)
        {

            //CONFIGURACION GENERAL

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_listener&p=login&q=loginForm&jumpto=status");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("username")[0].SetAttribute("value", "admin");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("pwd")[0].SetAttribute("value", "admin");

            webBrowser1.Document.GetElementById("idConfirm").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=account-register&q=load&acc=0");

            await cargapagina();

            webBrowser1.Document.GetElementById("Enable").SetAttribute("value", "1");
            webBrowser1.Document.GetElementById("Label").SetAttribute("value", alias);
            webBrowser1.Document.GetElementById("DisplayName").SetAttribute("value", alias);
            webBrowser1.Document.GetElementById("AuthName").SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementById("UserName").SetAttribute("value", alias);
            webBrowser1.Document.GetElementById("editPassword").SetAttribute("value", "p@ssword+" + extension);
            webBrowser1.Document.GetElementById("server1").SetAttribute("value", ipcentralita);

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=settings-datetime&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("LocalTimeDhcpTimeSwitch")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("TimeZoneAndName")[0].SetAttribute("value", "+1 Spain(Madrid)");

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=features-transfer&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("TransferModeViaDsskey")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

        }

        async Task cargapagina()
        {
            await Task.Delay(2000);
        }

        async Task cargapequeña()
        {
            await Task.Delay(100);
        }


        public async Task limpiaryconfigurarextensiones(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {

            //LIMPIANDO EXTENSIONES

            webBrowser1.Navigate("http://" + ipactual + "/servlet?p=dsskey&model=0&q=load");

            await cargapagina();

            for (int l = 1; l < 11; l++)
            {

                webBrowser1.Document.GetElementById("selType_" + l).SetAttribute("value", "0");
                webBrowser1.Document.GetElementById("Value_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("Line_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("Ext_" + l).SetAttribute("value", "1");
            }

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            await cargapagina();

            //CONFIGURANDO EXTENSIONES

            numextensiones = gridextensiones.Rows.Count - 1;

            if (numextensiones > 10)
            {
                numextensiones = 10;
            }

            for (int p = 1; p <= numextensiones; p++)
            {
                webBrowser1.Document.GetElementById("selType_" + p).SetAttribute("value", "16");
                contadorextensiones = p - 1;
                webBrowser1.Document.GetElementById("Value_" + p).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("Line_" + p).SetAttribute("value", "0");
                webBrowser1.Document.GetElementById("Ext_" + p).SetAttribute("value", "1");
                await cargapequeña();
            }

            await cargapagina();
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");
            await cargapagina();
            await cargapagina();

            for (int m = 1; m <= numextensiones; m++)
            {
                contadorextensiones = m - 1;
                String extensiontelefono = gridextensiones.Rows[contadorextensiones].Cells[0].Value.ToString();
                String aliastelefono = gridextensiones.Rows[contadorextensiones].Cells[2].Value.ToString();
                webBrowser1.Document.GetElementById("Value_" + m).SetAttribute("value", aliastelefono);
                webBrowser1.Document.GetElementById("Line_" + m).SetAttribute("value", "0");
                webBrowser1.Document.GetElementById("Ext_" + m).SetAttribute("value", extensiontelefono.ToString());

            }

            await cargapagina();
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");
            await cargapagina();
        }


        //CONFIGURA LAS EXTENSIONES DE LOS TLF QUE SE ESTAN CONFIGURANDO JUNTO AL ACTUAL

        public async Task configurarextensionestlfaconfigurar(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {
            numextensionesdetlf = gridtelefonos.Rows.Count - 1;



                for (int o = 1; o <= numextensionesdetlf; o++) {

                int m = o - 1;
                    String extensiontelefono = gridtelefonos.Rows[m].Cells[0].Value.ToString();
                    String aliastelefono = gridtelefonos.Rows[m].Cells[1].Value.ToString();
                    int numextensiontelefono = Int32.Parse(extensiontelefono);

                if (numextensiones >= 10)
                {
                    break;
                }

                    if (numextensiontelefono != extensionaomitir)
                {
                    numfila++;
                    webBrowser1.Document.GetElementById("Value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("Label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("Line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("Extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());

                }

                }

                await cargapagina();
                webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");
                await cargapagina();

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


            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("btnSubmit")[0].InvokeMember("Click");

            pulsarintroen5seg();
            
            await cargapagina();

        }

        public async Task pulsarintroen5seg()
        {
            await cargapagina();
            SendKeys.Send("{ENTER}");

        }


    }
}
