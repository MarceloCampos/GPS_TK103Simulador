// minimalistic telnet implementation
// conceived by Tom Janssens on 2007/06/06  for codeproject
//
// http://www.corebvba.be

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
//using System.Web.Script.Serialization;

namespace GPS_TK103Simulador
{
    class IpClient
    {
        /*public*/ TelnetConnection tc;

        public IpClient(string host, int port, string strToSend)
        {
            bool Flag_lblAvisoInvisible = false;
            int tentativas = 0;

            
            tc = new TelnetConnection(host, port);

            while (!tc.IsConnected && tentativas++ < 4)
            {
                Debug.Print("> AVISO: NÃO Conectado IpClient " + host + ":" + port.ToString() + ", tentativa: " + tentativas.ToString());
                System.Threading.Thread.Sleep(1000);
                tc = new TelnetConnection(host, port);

                if (!Flag_lblAvisoInvisible)
                {
                    //   frmAVL.frmAVL_Remoto.Access_Control5_ThreadProcSafe(true, "Gateway IP Desconectado", 1);
                    Flag_lblAvisoInvisible = true;
                }
            }

            tc.WriteLine(strToSend);

            //string lidoSocket = tc.Read();

            //if (!string.IsNullOrEmpty(lidoSocket))
            //{
            //    Debug.Print("> Recebido do Ip Socket: " + lidoSocket);
            //}

            if (tc.IsConnected)
                Debug.Print(":: Enviado: " + strToSend);
            else
                Debug.Print(":: Não foi possível enviar... : " + strToSend);

            // tc?.close();
        }
    }
}
