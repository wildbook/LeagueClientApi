using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace LeagueClientApi
{
    public class Lockfile
    {
        public static Lockfile FromPath(string lockfilePath)
        {
            using (var fileStream = new FileStream(
                lockfilePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    var contents = streamReader.ReadToEnd().Split(':');
                    return new Lockfile(contents[0], int.Parse(contents[1]), int.Parse(contents[2]), contents[3],
                        contents[4]);
                }
            }
        }

        public static Lockfile FromProcess(Process process)
        {
            var cmd = process.GetCommandLine();
            var port = int.Parse(Regex.Match(cmd, "--app-port=(?<port>[0-9]{1,5})").Groups["port"].Value);
            var token = Regex.Match(cmd, "--remoting-auth-token=(?<token>[^\"]*)").Groups["token"].Value;
            var appname = Regex.Match(cmd, "--app-name=(?<appname>[^\"]*)").Groups["appname"].Value;

            return new Lockfile(appname, process.Id, port, token, "HTTPS");
        }

        public readonly string ProcessName;
        public readonly int ProcessId;
        public readonly int Port;
        public readonly string Password;
        public readonly string ConnectionType;

        public Lockfile(string processName, int processId, int port, string password, string connectionType)
        {
            ProcessName = processName;
            ProcessId = processId;
            Port = port;
            Password = password;
            ConnectionType = connectionType;
        }
    }
}