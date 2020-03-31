using System;
using System.Threading;
using System.Windows.Forms;

namespace configurador_tlf_V2.TELEFONOS
{
    class YEALINKT27G
    {

        bool IsReady;
        public void configuraciongeneral(String ipactual, String extension, String alias, String ipcentralita, WebBrowser webBrowser1)
        {
            webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_listener&p=login&q=loginForm&jumpto=status");

                Thread.Sleep(2500);

            webBrowser1.Document.GetElementById("idUsername").SetAttribute("value", "admin");
            webBrowser1.Document.GetElementById("idPassword").SetAttribute("value", "admin");
            webBrowser1.Document.GetElementById("idConfirm").InvokeMember("Click");

            Thread.Sleep(2500);

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=account-register&q=load");

            Thread.Sleep(2500);

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("AccountEnable")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountLabel")[0].SetAttribute("value", alias);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountRegisterName")[0].SetAttribute("value", extension);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountDisplayName")[0].SetAttribute("value", alias);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountUserName")[0].SetAttribute("value", alias);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("AccountPassword")[0].SetAttribute("value", "p@ssword+" + extension);
            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("server1")[0].SetAttribute("value", ipcentralita);
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            Thread.Sleep(2500);

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=settings-datetime&q=load");

            Thread.Sleep(2500);

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("LocalTimeDhcpTimeSwitch")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("CurrentTimeZoneTime")[0].SetAttribute("value", "+1");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            Thread.Sleep(2500);

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("CurrentTimeZoneZone")[0].SetAttribute("value", "Spain(Madrid)");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            Thread.Sleep(2500);

            webBrowser1.Navigate("http://" + ipactual + "/servlet?m=mod_data&p=features-transfer&q=load");

            Thread.Sleep(2500);

            webBrowser1.Document.GetElementsByTagName("select").GetElementsByName("TransferModeViaDsskey")[0].SetAttribute("value", "1");
            webBrowser1.Document.GetElementById("btn_confirm1").InvokeMember("Click");

            Thread.Sleep(2500);


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Terminado2");
        }


        public void limpiarextensiones()
        {

        }

    }


}
