using LeagueClientApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class ProcessControl
    {
        public static class V1
        {
            public static class Process
            {
                /// <summary>
                /// Returns information about the process-control.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<ProcessControlProcess> Get(LeagueClientSession session)
                    => session.SendRequestAsync<ProcessControlProcess>("GET", "/process-control/v1/process");

                public static class ExitAndRun
                {
                    /// <summary>
                    /// Exits the application and runs a given executable just before it shuts down.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="args"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string executablePath, string workingDir,
                        string[] args)
                        => session.SendRequestAsync("POST", "/process-control/v1/process/exit-and-run",
                            new Dictionary<string, string>
                            {
                                {"executablePath", executablePath},
                                {"workingDir", workingDir}
                            }, body: args);
                }

                public static class Quit
                {
                    /// <summary>
                    /// Quits the application.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session)
                        => session.SendRequestAsync("POST", "/process-control/v1/process/quit");
                }

                public static class Endpoint
                {
                    /// <summary>
                    /// Restarts the application. Does nothing if there is already a waiting delayed restart. Optionally accepts specific version to restart.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, int delaySeconds,
                        int? restartVersion = null)
                    {
                        var query = new Dictionary<string, string> {{"delaySeconds", delaySeconds.ToString()}};
                        if (restartVersion.HasValue) query.Add("restartVersion", restartVersion.ToString());
                        return session.SendRequestAsync("POST", "/plugin-name/endpoint", query);
                    }
                }

                public static class RestartToRepair
                {
                    /// <summary>
                    /// Restarts the application in order to perform a full repair (including self repair).
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string productId)
                        => session.SendRequestAsync("POST", "/process-control/v1/process/restart-to-repair",
                            new Dictionary<string, string> {{"productId", productId}});
                }
            }
        }
    }
}