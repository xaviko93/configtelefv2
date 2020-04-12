﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT27G
    {

        public int columnabuscar;
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


        public async Task configurarextensionestlfaconfigurar(String ipactual, WebBrowser webBrowser1, DataGridView gridextensiones, DataGridView gridtelefonos, int extensionaomitir)
        {
            int numerotlfaconfigurar = gridtelefonos.Rows.Count - 1;
            int numeroextaconfigurar = gridextensiones.Rows.Count - 1;
            int progresoextensiones = gridextensiones.Rows.Count;
            columnabuscar++;
            if (numerotlfaconfigurar > 1)
            {
                int j;
                for(j = 1; j < numeroextaconfigurar; j++)
                {
                    if (columnabuscar != 8, 16)
                    {
                        for (j = 0; j < 7; j++)
                        {
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


                    progresoextensiones++;
                }
            }

        }
            /*
            //CONFIGURA LAS EXTENSIONES DE LOS TELEFONOS QUE ESTÁS CONFIGURANDO JUNTO A ESTE
                columnabuscar = 0;
                int progresoblf2 = j + 1;
                for (k = 1; k <= numerotlfaconfigurar; k++)
                {

                    int extensiontelefono = (int)gridtelefonos.Rows[columnabuscar].Cells[0].Value;
                    String aliastelefono = gridtelefonos.Rows[columnabuscar].Cells[1].Value.ToString();

                    await cargapagina();

                    if (progresoblf2 == 8)
                    {
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();
                        webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                        await cargapagina();
                    }

                    if (progresoblf2 == 15)
                    {
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargagrande();
                        webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                        await cargapagina();
                    }

                    if (extensionaomitir != extensiontelefono)
                    {

                        webBrowser1.Document.GetElementById("type_" + progresoblf2).SetAttribute("value", "16");
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

                        await cargagrande();

                        webBrowser1.Document.GetElementById("value_" + progresoblf2).SetAttribute("value", extensiontelefono.ToString());
                        webBrowser1.Document.GetElementById("label_" + progresoblf2).SetAttribute("value", aliastelefono);
                        webBrowser1.Document.GetElementById("line_" + progresoblf2).SetAttribute("value", "0");
                        webBrowser1.Document.GetElementById("extern_" + progresoblf2).SetAttribute("value", extensiontelefono.ToString());
                        progresoblf2++;
                    }

                columnabuscar++;

                }

            await cargagrande();
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

    */





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

