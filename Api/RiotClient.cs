using LeagueClientApi.Model;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class RiotClient
    {
        public static class Affinity
        {
            /// <summary>
            /// Deletes the current runtime affinity of the application.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Delete(LeagueClientSession session) =>
                session.SendRequestAsync("DELETE", "/riotclient/affinity");

            /// <summary>
            /// Gets the current runtime affinity of the application.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Get(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("GET", "/riotclient/affinity");

            /// <summary>
            /// Sets the current runtime affinity of the application.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="newAffinity"></param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, string newAffinity) =>
                session.SendRequestAsync("POST", "/riotclient/affinity",
                    new Dictionary<string, string> {{"newAffinity", newAffinity}});
        }

        public static class AppName
        {
            /// <summary>
            /// Application name without file extension
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<string> Get(LeagueClientSession session) =>
                session.SendRequestAsync<string>("GET", "/riotclient/app-name");
        }

        public static class AppPort
        {
            /// <summary>
            /// Get the TCP port number that the remoting server is listening on.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<int> Get(LeagueClientSession session) =>
                session.SendRequestAsync<int>("GET", "/riotclient/app-port");
        }

        public static class AuthToken
        {
            /// <summary>
            /// Return the auth token used by the remoting server
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<string> Get(LeagueClientSession session) =>
                session.SendRequestAsync<string>("GET", "/riotclient/auth-token");
        }

        public static class CommandLineArgs
        {
            /// <summary>
            /// Get the command line parameters for the application
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<string[]> Get(LeagueClientSession session) =>
                session.SendRequestAsync<string[]>("GET", "/riotclient/command-line-args");
        }

        public static class GetRegionLocale
        {
            /// <summary>
            /// Get the current region and locale.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<Model.RegionLocale> Get(LeagueClientSession session) =>
                session.SendRequestAsync<Model.RegionLocale>("GET", "/riotclient/get_region_locale");
        }

        public static class KillAndRestartUx
        {
            /// <summary>
            /// Kills the ux process and restarts it. Used only when the ux process crashes.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/kill-and-restart-ux");
        }

        public static class KillUx
        {
            /// <summary>
            /// Kills the ux process.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/kill-ux");
        }

        public static class LaunchUx
        {
            /// <summary>
            /// Launches the ux process.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/launch-ux");
        }

        public static class MachineId
        {
            /// <summary>
            /// Base64 encoded uuid identifying the user's machine
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<string> Get(LeagueClientSession session) =>
                session.SendRequestAsync<string>("GET", "/riotclient/machine-id");
        }

        public static class NewArgs
        {
            //TODO: Fix all formData endpoints, including this one. (In this case, add "args=" in front of serialized body)
            /// <summary>
            /// Endpoint for passing in new data.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="args">Vector of new command line arguments</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, string[] args) =>
                session.SendRequestAsync("POST", "/riotclient/new-args", body: args);
        }

        public static class RegionLocale
        {
            /// <summary>
            /// Get the current region and locale.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<Model.RegionLocale> Get(LeagueClientSession session) =>
                session.SendRequestAsync<Model.RegionLocale>("GET", "/riotclient/region-locale");

            /// <summary>
            /// Update the region and locale.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="data">Region and locale resource.</param>
            /// <returns></returns>
            public static Task Put(LeagueClientSession session, Model.RegionLocale data) =>
                session.SendRequestAsync("PUT", "/riotclient/region-locale", body: data);

            public static class Ack
            {
                /// <summary>
                /// Ux acknowledges the update to the region and locale.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="requestId">The region and locale change requestId that is being acknowledged.</param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, int requestId) =>
                    session.SendRequestAsync("PUT", "/riotclient/region-locale/ack", body: requestId);
            }
        }

        public static class SetRegionLocale
        {
            /// <summary>
            /// Update the region and locale.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="region">Name of the region.</param>
            /// <param name="locale">Name of the locale.</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, string region, string locale) =>
                session.SendRequestAsync("POST", "/riotclient/set_region_locale",
                    new Dictionary<string, string> {{"region", region}, {"locale", locale}});
        }

        public static class ShowSwagger
        {
            /// <summary>
            /// Open swagger in the default browser.
            /// 
            /// Note: If you get this to work, please contact me :)
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/show-swagger");
        }

        public static class Splash
        {
            /// <summary>
            /// Hide the splash screen.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Delete(LeagueClientSession session) =>
                session.SendRequestAsync("DELETE", "/riotclient/splash");

            /// <summary>
            /// Show the splash screen.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Put(LeagueClientSession session) =>
                session.SendRequestAsync("PUT", "/riotclient/splash");
        }

        public static class SystemInfo
        {
            public static class V1
            {
                public static class BasicInfo
                {
                    /// <summary>
                    /// Get basic system information: OS, memory, processor speed, and number of physical cores
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<BasicSystemInfo> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<BasicSystemInfo>("GET", "/riotclient/system-info/v1/basic-info");
                }
            }
        }

        public static class Trace
        {
            /// <summary>
            /// Retrieves a completed scheduler trace.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Get(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("GET", "/riotclient/trace");
        }

        public static class Unload
        {
            /// <summary>
            /// Unloads the UX process
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/unload");
        }

        public static class UxCrashCount
        {
            /// <summary>
            /// Returns whether the ux has crashed or not
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<int> Get(LeagueClientSession session) =>
                session.SendRequestAsync<int>("GET", "/riotclient/ux-crash-count");
        }

        public static class UxFlash
        {
            /// <summary>
            /// Flash the ux process' main window and the taskbar/dock icon, if they exist.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/riotclient/ux-flash");
        }

        public static class UxLoadComplete
        {
            /// <summary>
            /// Ux notification that it has completed loading the main window.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Put(LeagueClientSession session) =>
                session.SendRequestAsync("PUT", "/riotclient/ux-load-complete");
        }

        public static class UxMimimize
        {
            /// <summary>
            /// Minimize the ux process and all its windows if it exists. This does not kill the ux.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("PUT", "/riotclient/ux-minimize");
        }

        public static class UxShow
        {
            /// <summary>
            /// Shows the ux process if it exists; create and show if it does not.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("PUT", "/riotclient/ux-show");
        }

        public static class UxState
        {
            /// <summary>
            /// Get the current Ux state.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Get(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("GET", "/riotclient/ux-state");

            public static class Ack
            {
                /// <summary>
                /// Ux acknowledges the update to the Ux state.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="requestId">The ux change requestId that is being acknowledged.</param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, int requestId) =>
                    session.SendRequestAsync("PUT", "/riotclient/ux-state/ack", body: requestId);
            }
        }

        public static class V1
        {
            public static class Bugsplat
            {
                public static class Logs
                {
                    /// <summary>
                    /// Adds the enclosed log to the app's bugsplat report.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="logFilePath">Full path to the log file.</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string logFilePath) =>
                        session.SendRequestAsync("POST", "/riotclient/v1/bugsplat/logs", body: logFilePath);
                }

                public static class PlatformId
                {
                    /// <summary>
                    /// Get the bugsplat platform id.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<string>("GET", "/riotclient/v1/bugsplat/platform-id");

                    /// <summary>
                    /// Tags the bugsplat with a platform id so it can be filtered more easily.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="platformId">The platform id that should be reported to bugsplat.</param>
                    /// <returns></returns>
                    public static Task Put(LeagueClientSession session, string platformId) =>
                        session.SendRequestAsync("PUT", "/riotclient/v1/bugsplat/platform-id", body: platformId);
                }
            }
        }

        public static class ZoomScale
        {
            /// <summary>
            /// Gets the last known posted zoom-scale value.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<int> Get(LeagueClientSession session) =>
                session.SendRequestAsync<int>("GET", "/riotclient/zoom-scale");

            /// <summary>
            /// Handles changing the zoom scale value.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="newZoomScale"></param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, double newZoomScale) => session.SendRequestAsync(
                "POST", "/riotclient/zoom-scale",
                new Dictionary<string, string> {{"newZoomScale", newZoomScale.ToString(CultureInfo.InvariantCulture)}});
        }
    }
}