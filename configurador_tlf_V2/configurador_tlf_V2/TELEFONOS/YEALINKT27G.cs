using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT27G
    {
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

            for (int i = 0; i <= 21; i++)
            {

                int numtelefono = i + 1;
                webBrowser1.Document.GetElementById("value_" + numtelefono).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("label_" + numtelefono).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("line_" + numtelefono).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("extern_" + numtelefono).SetAttribute("value", "1");
                webBrowser1.Document.GetElementById("type_" + numtelefono).SetAttribute("value", "0");

                if (numtelefono == 7)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                    await cargapagina();
                }

                if (numtelefono == 14)
                {
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                    await cargapagina();
                }

                if (numtelefono == 21)
                {
                    await cargapagina();

                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                    await cargagrande();
                    break;
                }
            }

            //CONFIGURANDO EXTENSIONES

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&q=load");
            await cargapagina();
            int h;
            int j;
            int k;
            int numerotlfaconfigurar = gridtelefonos.Rows.Count - 1;
            int numeroextaconfigurar = gridextensiones.Rows.Count - 1;



                webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&q=load");
                await cargapagina();



                for (j = 0; j < numeroextaconfigurar; j++)
                {

                    int progresoblf = j + 1;

                    String extensiontelefono = gridextensiones.Rows[j].Cells[0].Value.ToString();
                    String aliastelefono = gridextensiones.Rows[j].Cells[2].Value.ToString();

                    if (progresoblf == 8)
                        {
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargapagina();
                        webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=2&q=load");
                        await cargapagina();
                    }

                    if (progresoblf == 15)
                    {
                        webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                        await cargapagina();
                        webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=dsskey&model=1&linepage=3&q=load");
                        await cargapagina();
                    }


                    webBrowser1.Document.GetElementById("type_" + progresoblf).SetAttribute("value", "16");
                    webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

                    await cargapagina();

                    webBrowser1.Document.GetElementById("value_" + progresoblf).SetAttribute("value", extensiontelefono.ToString());
                    webBrowser1.Document.GetElementById("label_" + progresoblf).SetAttribute("value", aliastelefono);
                    webBrowser1.Document.GetElementById("line_" + progresoblf).SetAttribute("value", "0");
                    webBrowser1.Document.GetElementById("extern_" + progresoblf).SetAttribute("value", extensiontelefono.ToString());

                }

                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargapagina();


                //CONFIGURA LAS EXTENSIONES DE LOS TELEFONOS QUE ESTÁS CONFIGURANDO JUNTO A ESTE
                int progresoblf2 = j + 1;
                for (k = 0; k < numerotlfaconfigurar; k++)
                {

                    int extensiontelefono = (int)gridtelefonos.Rows[k].Cells[0].Value;
                    String aliastelefono = gridtelefonos.Rows[k].Cells[1].Value.ToString();

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



                }

                webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
                await cargapagina();
                MessageBox.Show("Terminado");

            
            }


        public async Task configurarred(String ipactual)
        {
            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=network&q=load");
            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("NetworkIPAddressMode")[0].SetAttribute("value", "0");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanType")[0].SetAttribute("value", "2");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticDNSEnable")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargapagina();

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticIp")[0].SetAttribute("value", ipaconfigurar2);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticMask")[0].SetAttribute("value", mascaraaconfigurar2);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticGateWay")[0].SetAttribute("value", puertaaconfigurar2);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticPriDns")[0].SetAttribute("value", "8.8.8.8");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("NetworkWanStaticSecDns")[0].SetAttribute("value", "8.8.4.4");

            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");
            await cargapagina();

        }

        }
    }

