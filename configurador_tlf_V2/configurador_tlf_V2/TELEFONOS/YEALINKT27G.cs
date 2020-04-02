using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT27G
    {
        public async Task configuraciongeneralAsync(String ipactual, String extension, String alias, String ipcentralita, WebBrowser webBrowser1)
        {

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
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountRegisterName")[0].SetAttribute("value", extension);
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


        public async Task limpiarextensiones(String ipactual, WebBrowser webBrowser1)
        {
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
                }
            }
        }

    }
}
