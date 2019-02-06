using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace LeagueClientApi
{
    public class LeagueClient
    {
        public event EventHandler<Lockfile> LeagueClientSessionStarted;

        private string _lcBasePath;

        private string LockfilePath =>
            string.IsNullOrWhiteSpace(_lcBasePath) ? null : Path.Combine(_lcBasePath, "lockfile");

        /// <summary>
        /// Try to auto-detect league instead of using a hardcoded path
        /// </summary>
        public LeagueClient()
        {
            var leagueProc = Process.GetProcessesByName("LeagueClient");

            if (leagueProc.Length > 0)
            {
                CheckForLeague();
            }
            else
            {
                var time = new Timer
                {
                    AutoReset = true,
                    Enabled = true,
                    Interval = 1000
                };

                time.Elapsed += (sender, e) =>
                {
                    if (CheckForLeague())
                        time.Stop();
                };
            }
        }

        public bool CheckForLeague()
        {

            var lc = Process.GetProcessesByName("LeagueClient");
            foreach (var p in lc)
            {
                var path = p.MainModule.FileName;

                if (path.Contains("RADS")) path = Regex.Split(path, @"RADS")[0];

                if (!IsValidLeagueClientPath(path)) continue;
                _lcBasePath = path;
                CheckForExistingLockfile();
                return true;
            }

            var lcUx = Process.GetProcessesByName("LeagueClientUx");
            if (lcUx.Length > 0)
            {
                LeagueClientSessionStarted?.Invoke(this, Lockfile.FromProcess(lcUx[0]));
                return true;
            }

            return false;
        }

        public LeagueClient(string lcBasePath)
        {
            if (!IsValidLeagueClientPath(lcBasePath))
                throw new ArgumentException("Supplied lcBasePath is not valid.");
            _lcBasePath = lcBasePath;

            var watcher = new FileSystemWatcher
            {
                Path = lcBasePath,
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName |
                               NotifyFilters.DirectoryName,
                Filter = "lockfile"
            };

            watcher.Created += (s, e) =>
            {
                CheckForExistingLockfile();
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            };
            watcher.EnableRaisingEvents = true;
        }

        public async Task<LeagueClientSession> WaitUntilConnectedAsync()
        {
            var tcs = new TaskCompletionSource<LeagueClientSession>();

            void SetResult(object sender, Lockfile e)
            {
                LeagueClientSessionStarted -= SetResult;
                tcs.SetResult(new LeagueClientSession(e));
            }

            LeagueClientSessionStarted += SetResult;
            CheckForLeague();
            return await tcs.Task;
        }

        public LeagueClientSession WaitUntilConnected(int millisecondtimeout = -1)
        {
            var task = WaitUntilConnectedAsync();
            task.Wait(millisecondtimeout);
            return task.Result;
        }

        public void CheckForExistingLockfile()
        {
            if (File.Exists(LockfilePath))
                LeagueClientSessionStarted?.Invoke(this, Lockfile.FromPath(LockfilePath));
        }

        private static bool IsValidLeagueClientPath(string lcBasePath) =>
            Directory.Exists(Path.Combine(lcBasePath, "RADS")) &&
            (File.Exists(Path.Combine(lcBasePath, "LeagueClient.exe")) || Directory.Exists(Path.Combine(lcBasePath, "LeagueClient.app")));
    }
}