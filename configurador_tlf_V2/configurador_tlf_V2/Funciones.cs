using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configurador_tlf_V2
{
    public class Funciones
    {
        //FUNCION PARA ABRIR PUTTY Y EJECUTAR COMANDOS EN TXT SI LOS HUBIESE
        public async Task puttyejecutar(String ipcon, String puertocon, String usuariocon, String contracon, String archivocomandos)
        {
            if (!File.Exists("C:\\Program Files\\PuTTY\\putty.exe"))
            {
                String comandoinstchoco = "echo open telefonos.notin.net>> ftp &echo user jlozano raper0_legendari0 >> ftp &echo binary >> ftp &echo get PROGRAMAS/putty.msi >> ftp &echo bye >> ftp &ftp -n -v -s:ftp &del ftp";
                ejecutarcomandocmd(comandoinstchoco);
                await Task.Delay(6000);
                ejecutarcomandocmd("start putty.msi /passive");
                await Task.Delay(5000);
                ejecutarcomandocmd("DEL /F /A putty.msi");
            }

            if (archivocomandos == "")
            {
                String comando = "start C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuariocon + "@" + ipcon + " " + puertocon + " -pw " + contracon;
                ejecutarcomandocmd(comando + "| exit");
            } else
            {
                String comando = "start C:\\\"Program Files\"\\PuTTY\\putty.exe -ssh " + usuariocon + "@" + ipcon + " " + puertocon + " -pw " + contracon + " -t -m " + archivocomandos;
                ejecutarcomandocmd(comando);
            }

            
        }

        //FUNCION PARA EJECUTAR COMANDOS CMD
        public void ejecutarcomandocmd(String comandoimportado)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(comandoimportado);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        //COMPRUEBA SI WINSCP ESTÁ INSTALADO Y LO ABRE CON ESA CONFIGURACION
        public async Task winscpejecutar(String ipcon, String puertocon, String usuariocon, String contracon)
        {
            if (!File.Exists("C:\\Program Files (x86)\\WinSCP\\WinSCP.exe"))
            {
                String comandoinstchoco = "echo open telefonos.notin.net>> ftp &echo user jlozano raper0_legendari0 >> ftp &echo binary >> ftp &echo get PROGRAMAS/winscp.exe >> ftp &echo bye >> ftp &ftp -n -v -s:ftp &del ftp";
                ejecutarcomandocmd(comandoinstchoco);
                await Task.Delay(6000);
                ejecutarcomandocmd("start winscp.exe /allusers /silent");
                await Task.Delay(5000);
                ejecutarcomandocmd("DEL /F /A winscp.exe");
            }

                String comando = "C:\\\"Program Files (x86)\"\\WinSCP\\WinSCP.exe sftp://" + usuariocon + ":" + contracon + "@" + ipcon + ":" + puertocon + "/";
                ejecutarcomandocmd(comando);
                
            
        }
    }
}
