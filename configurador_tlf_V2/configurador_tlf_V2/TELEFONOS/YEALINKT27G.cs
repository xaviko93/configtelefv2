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

            for (int l = 1; l <= 21; l++)
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



            //CONFIGURANDO EXTENSIONES

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&q=load");
            await cargagrande();
            int h;
            int j;
            int k;
            int numeroextaconfigurar = gridextensiones.Rows.Count - 1;
            columnabuscar = 0;

            if (numeroextaconfigurar >= 7)
            {
                for (j = 0; j < 7; j++)
                {
                    int numfila = j + 1;
                    webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");

                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                for (j = 0; j < 7; j++)
                {
                    int numfila = j + 1;
                    String extensiontelefono = gridextensiones.Rows[j].Cells[0].Value.ToString();
                    String aliastelefono = gridextensiones.Rows[j].Cells[2].Value.ToString();
                    webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    columnabuscar++;
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

            }

            if (numeroextaconfigurar > 7)
            {
                webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                await cargapagina();
            }


            if (numeroextaconfigurar >= 14)
            {
                for (j = 7; j < 14; j++)
                {
                    int numfila = j + 1;
                    webBrowser1.Document.GetElementById("type_" + numfila).SetAttribute("value", "16");

                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                for (j = 7; j < 14; j++)
                {
                    int numfila = j + 1;
                    String extensiontelefono = gridextensiones.Rows[j].Cells[0].Value.ToString();
                    String aliastelefono = gridextensiones.Rows[j].Cells[2].Value.ToString();
                    webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                    columnabuscar++;
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();
            }


            if (numeroextaconfigurar > 14)
            {
                webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                await cargapagina();
            }


            //CONFIGURA LAS EXTENSIONES QUE FALTAN EN LA ULTIMA PAGINA DE EXT POR CONFIGURAR DEL TLF

            int contadortelefonos2;
            for (contadortelefonos2 = columnabuscar; contadortelefonos2 < numeroextaconfigurar; contadortelefonos2++)
            {
                int numlinea = contadortelefonos2 + 1;
                webBrowser1.Document.GetElementById("type_" + numlinea).SetAttribute("value", "16");

            }

            await cargapagina();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();

            for (contadortelefonos2 = columnabuscar; contadortelefonos2 < numeroextaconfigurar; contadortelefonos2++)
            {
                int numfila = contadortelefonos2 + 1;
                String extensiontelefono = gridextensiones.Rows[contadortelefonos2].Cells[0].Value.ToString();
                String aliastelefono = gridextensiones.Rows[contadortelefonos2].Cells[2].Value.ToString();
                webBrowser1.Document.GetElementById("value_" + numfila).SetAttribute("value", extensiontelefono.ToString());
                webBrowser1.Document.GetElementById("label_" + numfila).SetAttribute("value", aliastelefono);
                webBrowser1.Document.GetElementById("line_" + numfila).SetAttribute("value", "0");
                webBrowser1.Document.GetElementById("extern_" + numfila).SetAttribute("value", extensiontelefono.ToString());
            }

            columnabuscar = contadortelefonos2;

            await cargapagina();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargagrande();
        }



        //CONFIGURA LAS EXTENSIONES DE LOS TLF QUE SE ESTAN CONFIGURANDO JUNTO AL ACTUAL
        public async Task configurarextensionestlfaconfigurar(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {
            int numerotlfaconfigurar = gridtelefonos.Rows.Count - 1;
            int numeroextaconfigurar = gridextensiones.Rows.Count - 1;
            int progresoextensiones = gridextensiones.Rows.Count;
            columnabuscar++;
            if (numerotlfaconfigurar > 1)
            {
                if (columnabuscar < 8)
                {
                    limitepaginactual = 8;
                }

                if (columnabuscar > 7 && columnabuscar < 15)
                {
                    limitepaginactual = 15;
                }

                if (columnabuscar > 14)
                {
                    limitepaginactual = 22;
                }

                int columnaseleccionada;
                int recuentotelefonos2 = recuentotelefonos;
                int columnaseleccionadaparte = columnabuscar;
                for (columnaseleccionada = columnabuscar; columnaseleccionada <= limitepaginactual; columnaseleccionada++)
                {

                    String extensiontelefono = gridtelefonos.Rows[recuentotelefonos2].Cells[0].Value.ToString();
                    int extensiontelefononum = Int32.Parse(extensiontelefono);
                    if (extensiontelefononum != extensionaomitir) {
                    webBrowser1.Document.GetElementById("type_" + columnaseleccionadaparte).SetAttribute("value", "16");
                        columnaseleccionadaparte++;
                    }
                    recuentotelefonos2++;
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                int columnaseleccionada2;
                for (columnaseleccionada2 = columnabuscar; columnaseleccionada2 < limitepaginactual; columnaseleccionada2++)
                {
                    String extensiontelefono = gridtelefonos.Rows[recuentotelefonos].Cells[0].Value.ToString();
                    String aliastelefono = gridtelefonos.Rows[recuentotelefonos].Cells[1].Value.ToString();
                    int extensiontelefononumero = Int32.Parse(extensiontelefono);

                    if (extensiontelefononumero != extensionaomitir)
                    {
                        webBrowser1.Document.GetElementById("value_" + columnaseleccionada2).SetAttribute("value", extensiontelefono.ToString());
                        webBrowser1.Document.GetElementById("label_" + columnaseleccionada2).SetAttribute("value", aliastelefono);
                        webBrowser1.Document.GetElementById("line_" + columnaseleccionada2).SetAttribute("value", "0");
                        webBrowser1.Document.GetElementById("extern_" + columnaseleccionada2).SetAttribute("value", extensiontelefono.ToString());
                        columnaseleccionada2++;
                    }

                    columnaseleccionada2--;
                    recuentotelefonos++;
                }

                await cargapagina();
                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargagrande();

                if (recuentotelefonos < numerotlfaconfigurar)
                {
                    if ( limitepaginactual == 8)
                    {
                        limitepaginactual = 15;

                        recuentotelefonos2 = recuentotelefonos;
                        int columnaseleccionadaparte2 = 8;
                        for (columnaseleccionada = 8; columnaseleccionada < limitepaginactual; columnaseleccionada++)
                        {

                            String extensiontelefono = gridtelefonos.Rows[recuentotelefonos2].Cells[0].Value.ToString();
                            int extensiontelefononum = Int32.Parse(extensiontelefono);
                            if (extensiontelefononum != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("type_" + columnaseleccionadaparte2).SetAttribute("value", "16");
                                columnaseleccionadaparte2++;
                            }
                            recuentotelefonos2++;
                        }

                        await cargapagina();
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();

                        int columnaseleccionada4;
                        for (columnaseleccionada4 = 8; columnaseleccionada4 < limitepaginactual; columnaseleccionada4++)
                        {
                            String extensiontelefono = gridtelefonos.Rows[recuentotelefonos].Cells[0].Value.ToString();
                            String aliastelefono = gridtelefonos.Rows[recuentotelefonos].Cells[1].Value.ToString();
                            int extensiontelefononumero = Int32.Parse(extensiontelefono);

                            if (extensiontelefononumero != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("value_" + columnaseleccionada4).SetAttribute("value", extensiontelefono.ToString());
                                webBrowser1.Document.GetElementById("label_" + columnaseleccionada4).SetAttribute("value", aliastelefono);
                                webBrowser1.Document.GetElementById("line_" + columnaseleccionada4).SetAttribute("value", "0");
                                webBrowser1.Document.GetElementById("extern_" + columnaseleccionada4).SetAttribute("value", extensiontelefono.ToString());
                                columnaseleccionada4++;
                            }
                            columnaseleccionada4--;
                            recuentotelefonos++;
                        }

                        await cargapagina();
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();

                    }
                }


                if (recuentotelefonos < numerotlfaconfigurar)
                {
                    if (limitepaginactual == 15)
                    {
                        limitepaginactual = 21;

                        recuentotelefonos2 = recuentotelefonos;
                        int columnaseleccionadaparte2 = 15;
                        for (columnaseleccionada = 15; columnaseleccionada < limitepaginactual; columnaseleccionada++)
                        {

                            String extensiontelefono = gridtelefonos.Rows[recuentotelefonos2].Cells[0].Value.ToString();
                            int extensiontelefononum = Int32.Parse(extensiontelefono);
                            if (extensiontelefononum != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("type_" + columnaseleccionadaparte2).SetAttribute("value", "16");
                                columnaseleccionadaparte2++;
                            }
                            recuentotelefonos2++;
                        }




                        await cargapagina();
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();

                        int columnaseleccionada4;
                        for (columnaseleccionada4 = 15; columnaseleccionada4 < limitepaginactual; columnaseleccionada4++)
                        {
                            String extensiontelefono = gridtelefonos.Rows[recuentotelefonos].Cells[0].Value.ToString();
                            String aliastelefono = gridtelefonos.Rows[recuentotelefonos].Cells[1].Value.ToString();
                            int extensiontelefononumero = Int32.Parse(extensiontelefono);

                            if (extensiontelefononumero != extensionaomitir)
                            {
                                webBrowser1.Document.GetElementById("value_" + columnaseleccionada4).SetAttribute("value", extensiontelefono.ToString());
                                webBrowser1.Document.GetElementById("label_" + columnaseleccionada4).SetAttribute("value", aliastelefono);
                                webBrowser1.Document.GetElementById("line_" + columnaseleccionada4).SetAttribute("value", "0");
                                webBrowser1.Document.GetElementById("extern_" + columnaseleccionada4).SetAttribute("value", extensiontelefono.ToString());
                                columnaseleccionada4++;
                            }
                            columnaseleccionada4--;
                            recuentotelefonos++;
                        }

                        await cargapagina();
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();

                    }
                }


            }
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

