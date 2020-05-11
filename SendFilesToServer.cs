using Renci.SshNet;
using System;
using System.IO;

namespace Sherlock
{
    class SendFilesToServer
    {
        public static void Send(string host, string username, string password, string fileName) 
        {
            using (ScpClient client = new ScpClient(host, username, password)) 
            {
                String Path = @".";
                client.Connect();
                client.Upload(new FileInfo(fileName), Path); 
                client.Disconnect();                
            }
        }
    }
}
