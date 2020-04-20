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
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountUserName")[0].SetAttribute("value", alias);
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

            //LIMPIANDO EXTENSIONES

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&q=load");

            await cargapagina();

            for (int l = 1; l < 22; l++)
            {

                webBrowser1.Document.GetElementById("value_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("label_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("line_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("extern_" + l).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("type_" + l).SetAttribute("value", "0");

                if (l == 7)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                    await cargapagina();
                }

                if (l == 14)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                    await cargapagina();
                }
            }

            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();

            //CONFIGURANDO EXTENSIONES

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=1&q=load");
            await cargapagina();

            numextensiones = gridextensiones.Rows.Count - 1;

            if (numextensiones > 6)
            {

                for (contadorextensiones = 0; contadorextensiones < 7; contadorextensiones++)
                {

                    numfila = contadorextensiones + 1;
                    webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                for (contadorextensiones = 0; contadorextensiones < 7; contadorextensiones++)
                {
                    numfila = contadorextensiones + 1;
                    String extensiontelefono = gridextensiones.Rows[contadorextensiones].Cells[0].Value.ToString();
                    String aliastelefono = gridextensiones.Rows[contadorextensiones].Cells[2].Value.ToString();
                    webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                await cargapagina();

            }

            if (numextensiones > 13)
            {


                for (contadorextensiones = 7; contadorextensiones < 14; contadorextensiones++)
                {

                    int numfila = contadorextensiones + 1;
                    webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                for (contadorextensiones = 7; contadorextensiones < 14; contadorextensiones++)
                {
                    numfila = contadorextensiones + 1;
                    String extensiontelefono = gridextensiones.Rows[contadorextensiones].Cells[0].Value.ToString();
                    String aliastelefono = gridextensiones.Rows[contadorextensiones].Cells[2].Value.ToString();
                    webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                await cargapagina();

            }

            if (numextensiones != 7 && numextensiones != 14)
            {

            

            int contadorextaparte;
            for (contadorextaparte = contadorextensiones; contadorextaparte < numextensiones; contadorextaparte++)
            {
                int numfila = contadorextaparte + 1;
                webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
            }

            await cargapagina();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();

            int contadorextaparte2;
            for (contadorextaparte2 = contadorextensiones; contadorextaparte2 < numextensiones; contadorextaparte2++)
            {
                numfila = contadorextaparte2 + 1;
                String extensiontelefono = gridextensiones.Rows[contadorextensiones].Cells[0].Value.ToString();
                String aliastelefono = gridextensiones.Rows[contadorextensiones].Cells[2].Value.ToString();
                webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
            }

            contadorextensiones = contadorextaparte2;

            await cargapagina();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();
            }
        }



        //CONFIGURA LAS EXTENSIONES DE LOS TLF QUE SE ESTAN CONFIGURANDO JUNTO AL ACTUAL
        public async Task configurarextensionestlfaconfigurar(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {
            numextensionesdetlf = gridtelefonos.Rows.Count - 1;
            numtotalaconfig = numextensionesdetlf + numextensiones;

            if (contadorextensiones < 7)
            {
                int contadorextactual;
                contadorextactual = contadorextensiones;
                numfila = contadorextactual + 1;
                int numlineatemp = numlineatlf;
                    for (contadorextactual = contadorextensiones; contadorextactual < 7; contadorextactual++)
                    {
                        String extensiontelefono = gridtelefonos.Rows[numlineatemp].Cells[0].Value.ToString();
                    numlineatemp++;
                        int extensiontelefononumero = Int32.Parse(extensiontelefono);

                        if (extensiontelefononumero != extensionaomitir)
                        {
                            webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
                            numfila++;
                        }
                        else
                        {
                            contadorextactual--;
                        }
                    }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();
                contadorextactual = contadorextensiones;
                numlineatemp = numlineatlf;
                numfila = contadorextactual + 1;
                    for (contadorextactual = contadorextensiones; contadorextactual < 7; contadorextactual++)
                    {


                        String extensiontelefono = gridtelefonos.Rows[numlineatemp].Cells[0].Value.ToString();
                        String aliastelefono = gridtelefonos.Rows[numlineatemp].Cells[1].Value.ToString();
                    numlineatemp++;
                        int extensiontelefononumero = Int32.Parse(extensiontelefono);

                        if (extensiontelefononumero != extensionaomitir)
                        {
                            webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                            webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                            webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                            webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                            numfila++;
                        }
                        else
                        {
                            contadorextactual--;
                        }
                    }
                    numlineatlf = numlineatemp;
                    contadorextensiones = contadorextactual;

                    await cargapagina();
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();

                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                    await cargapagina();

                }

            

                if (contadorextensiones < 14)
                {
                    int contadorextactual = contadorextensiones;
                    numfila = contadorextactual + 1;
                    int numlineatemp = numlineatlf;
                    for (contadorextactual = contadorextensiones; contadorextactual < 14; contadorextactual++)
                        {
                            String extensiontelefono = gridtelefonos.Rows[numlineatemp].Cells[0].Value.ToString();
                            numlineatemp++;
                            int extensiontelefononumero = Int32.Parse(extensiontelefono);

                            if (extensiontelefononumero != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
                                numfila++;
                            }
                            else
                            {
                                contadorextactual--;
                            }
                        }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();
                contadorextactual = contadorextensiones;
                numlineatemp = numlineatlf;
                        numfila = contadorextactual + 1;
                        for (contadorextactual = contadorextensiones; contadorextactual < 14; contadorextactual++)
                        {


                            String extensiontelefono = gridtelefonos.Rows[numlineatemp].Cells[0].Value.ToString();
                            String aliastelefono = gridtelefonos.Rows[numlineatemp].Cells[1].Value.ToString();
                            numlineatemp++;
                            int extensiontelefononumero = Int32.Parse(extensiontelefono);

                            if (extensiontelefononumero != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                                webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                                webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                                webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                                numfila++;
                            }
                            else
                            {
                                contadorextactual--;
                            }
                        }

                        numlineatlf = numlineatemp;
                        contadorextensiones = contadorextactual;

                        await cargapagina();
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();

                        webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                        await cargapagina();

                    
                }


            numfila = contadorextensiones + 1;
            int contadorextaparte;
            int filaactual = numlineatlf;
            for (contadorextaparte = contadorextensiones; contadorextaparte < numtotalaconfig - 1; contadorextaparte++)
            {

                String extensiontelefono = gridtelefonos.Rows[filaactual].Cells[0].Value.ToString();
                filaactual++;
                int extensiontelefononumero = Int32.Parse(extensiontelefono);

                if (extensiontelefononumero != extensionaomitir)
                {
                    webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");
                    numfila++;
                }
                else
                {
                    contadorextaparte--;
                }
            }
            numfila = contadorextensiones + 1;
            int contadorextaparte2;
            filaactual = numlineatlf;
            for (contadorextaparte2 = contadorextensiones; contadorextaparte2 < numtotalaconfig - 1; contadorextaparte2++)
            {

                String extensiontelefono = gridtelefonos.Rows[filaactual].Cells[0].Value.ToString();
                String aliastelefono = gridtelefonos.Rows[filaactual].Cells[1].Value.ToString();
                filaactual++;
                int extensiontelefononumero = Int32.Parse(extensiontelefono);

                if (extensiontelefononumero != extensionaomitir)
                {
                    webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    numfila++;
                }
                else
                {
                    contadorextaparte2--;
                }
            }

            await cargapagina();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();

        }
            

        public async Task configurarred(String ipactual, WebBrowser webBrowser, String ipaconfigurar2, String mascaraaconfigurar2, String puertaaconfigurar2)
        {
            await cargagrande();
            webBrowser.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=network&q=load");
            await cargapagina();

            webBrowser.Document.GetElementsByTagName("select").GetElementsByName("NetworkIPAddressMode")[0].SetAttribute("value", "0");
            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanType")[0].SetAttribute("value", "2");
            webBrowser.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargapagina();

            webBrowser.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticDNSEnable")[0].SetAttribute("value", "1");
            webBrowser.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargapagina();

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

