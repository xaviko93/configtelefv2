using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT27G
    {

        public int columnabuscar;
        public int limitepaginactual;
        public int recuentotelefonos = 0;
        public int recuentotelefonos2;
        public int columnaseleccionada;
        public int numfila = 1;
        public int contadorextensiones;
        public int numextensiones;
        public int numextensionesdetlf;
        public int numtotalaconfig;
        public int numlineatlf;

        public async Task configuraciongeneralAsync(String ipactual, int extension, String alias, String ipcentralita, WebBrowser webBrowser1)
        {

            //CONFIGURACION GENERAL

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_listener&p=login&q=loginForm&jumpto=status");

            await cargapagina();

            webBrowser1.Document.GetElementById("idUsername").SetAttribute("value", "admin");
            webBrowser1.Document.GetElementById("idPassword").SetAttribute("value", "admin");
            webBrowser1.Document.GetElementById("idConfirm").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=account-register&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("AccountEnable")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountLabel")[0].SetAttribute("value", alias);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountRegisterName")[0].SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountDisplayName")[0].SetAttribute("value", alias);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountUserName")[0].SetAttribute("value", extension.ToString());
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountPassword")[0].SetAttribute("value", "p@ssword+" + extension);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("server1")[0].SetAttribute("value", ipcentralita);
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=settings-datetime&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("LocalTimeDhcpTimeSwitch")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("CurrentTimeZoneTime")[0].SetAttribute("value", "+1");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("CurrentTimeZoneZone")[0].SetAttribute("value", "Spain(Madrid)");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            await cargapagina();

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=features-transfer&q=load");

            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("TransferModeViaDsskey")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            await cargapagina();


        }

        async Task cargapagina()
        {
            await Task.Delay(2000);
        }

        async Task cargagrande()
        {
            await Task.Delay(5000);
        }


        public async Task limpiaryconfigurarextensiones(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {

            int numextgridextensiones = gridextensiones.Rows.Count - 1;
            int numextgridtelefonos = gridtelefonos.Rows.Count - 2;
            int numtelefaconfigurar = numextgridextensiones + numextgridtelefonos;
            int contadorgridtelefonos = 0;

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&q=load");
            await cargapagina();

            for (int l = 1; l < 22; l++)
            {
                if (l == 8)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                    await cargapagina();
                }

                if (l == 15)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                    await cargapagina();
                }
                if (l <= numtelefaconfigurar)
                {

                    webBrowser1.Document.GetElementById("type_" + l).SetAttribute("value", "16");

                    if ( l <= numextgridextensiones)
                    {
                        contadorextensiones = l - 1;
                        String extensiontelefono = gridextensiones.Rows[contadorextensiones].Cells[0].Value.ToString();
                        String aliastelefono = gridextensiones.Rows[contadorextensiones].Cells[2].Value.ToString();
                        webBrowser1.Document.GetElementById("value_" + l).SetAttribute("value", extensiontelefono.ToString());
                        webBrowser1.Document.GetElementById("label_" + l).SetAttribute("value", aliastelefono);
                        webBrowser1.Document.GetElementById("line_" + l).SetAttribute("value", "0");
                        webBrowser1.Document.GetElementById("extern_" + l).SetAttribute("value", extensiontelefono.ToString());
                    } else
                    {
                        if (extensionaomitir.ToString() == gridtelefonos.Rows[contadorgridtelefonos].Cells[0].Value.ToString())
                        {
                            contadorgridtelefonos++;
                        }
                        String extensiontelefono = gridtelefonos.Rows[contadorgridtelefonos].Cells[0].Value.ToString();
                        String aliastelefono = gridtelefonos.Rows[contadorgridtelefonos].Cells[1].Value.ToString();
                        webBrowser1.Document.GetElementById("value_" + l).SetAttribute("value", extensiontelefono.ToString());
                        webBrowser1.Document.GetElementById("label_" + l).SetAttribute("value", aliastelefono);
                        webBrowser1.Document.GetElementById("line_" + l).SetAttribute("value", "0");
                        webBrowser1.Document.GetElementById("extern_" + l).SetAttribute("value", extensiontelefono.ToString());
                        contadorgridtelefonos++;
                    }
                }
                else
                {
                    webBrowser1.Document.GetElementById("value_" + l).SetAttribute("value", "1");
                    webBrowser1.Document.GetElementById("label_" + l).SetAttribute("value", "1");
                    webBrowser1.Document.GetElementById("line_" + l).SetAttribute("value", "1");
                    webBrowser1.Document.GetElementById("extern_" + l).SetAttribute("value", "1");
                    webBrowser1.Document.GetElementById("type_" + l).SetAttribute("value", "0");
                }

            }
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
        }
            

        public async Task configurarred(String ipactual, WebBrowser webBrowser, String ipaconfigurar2, String mascaraaconfigurar2, String puertaaconfigurar2)
        {
            await cargagrande();
            webBrowser.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=network&q=load");
            await cargapagina();

            webBrowser.Document.GetElementsByTagName("select").GetElementsByName("NetworkIPAddressMode")[0].SetAttribute("value", "0");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanType")[0].SetAttribute("value", "2");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticDNSEnable")[0].SetAttribute("value", "1");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticIp")[0].SetAttribute("value", ipaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticMask")[0].SetAttribute("value", mascaraaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticGateWay")[0].SetAttribute("value", puertaaconfigurar2);
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticPriDns")[0].SetAttribute("value", "8.8.8.8");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticSecDns")[0].SetAttribute("value", "8.8.4.4");

            pulsarintroen5seg();
            webBrowser.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();

        }

        public async Task pulsarintroen5seg()
        {
            await cargapagina();
            SendKeys.Send("{ENTER}");

        }



            


    }

}

