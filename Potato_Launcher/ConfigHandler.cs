using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IniParser;
using IniParser.Model;
using System.IO;

namespace Potato_Launcher
{
    public class ConfigHandler
    {
        // constructor
        public ConfigHandler()
        {
            FileInDataParser Parser = new FileIniDataParser();

            string configDir = String.Format(@"{0}\config", GetLocalDir());
            string configPath = String.Format(@"{0}\config.launcherConfig.ini", GetLocalDir());

            if (!Directory.Exists(configDir))
            {
                Directory.CreateDirectory(configDir);
            }
            if (!File.Exists(configPath))
            {
                // here we create a new empty file
                FileStream configStream = File.Create(configPath);
                configStream.Close();

                // read the file as an INI file
                try
                {
                    IniData data = Parser.ReadFile(configPath);

                    data.Sections.AddSection("Local");
                    data.Sections.AddSection("Remote");

                    data["Local"].AddKey("launcherVersion", "0.0.1");
                    data["Local"].AddKey("gameName", "Example");
                    data["Local"].AddKey("systemTarget", "Win64");

                    data["Remote"].AddKey("FTPUsername", "anonymous");
                    data["Remote"].AddKey("FTPPassword", "anonymous");
                    data["Remote"].AddKey("FTPUrl", "ftp://example.example.com");

                    Parser.WriteFile(configPath, data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
        }

        private string GetConfigPath()
        {
            string configPath = String.Format(@"{0}\config\launcherConfig.ini", GetLocalDir());
            return configPath;
        }

        private string GetConfigDir()
        {
            string configDir = String.Format(@"{0}\config", GetLocalDir());
            return configDir;
        }

        public string GetUpdateCookie()
        {
            string updateCookie = String.Format(@"{0}\.updatecookie", Directory.GetCurrentDirectory());
            return udpateCookie;
        }

        public string GetLocalDir()
        {
            string localDir = String.Format(@"{0}", Directory.GetCurrentDirectory());
            return localDir;
        }

        public string GetTempDir()
        {
            string tempDir = String.Format(@"{0}", Environment.GetEnvironmentVariable("TEMP"));
            return tempDir;
        }

        public string GetManifestPath()
        {
            string manifestPath = String.Format(@"{0}\launcherManifest.txt", Directory.GetCurrentDirectory());
            return manifestPath;
        }

        public string GetGamePath()
        {
            string gamePath = String.Format(@"{0}\game", Directory.GetCurrentDirectory());
            return gamePath;
        }

        public string GetGameExecutable()
        {
            string executablePath = String.Format(@"{0}\{1}\Binaries\{2}\{1}.exe", GetGamePath(), GetGameName(), GetSystemTarget());
            return executablePath;
        }

        public string GetManifestURL()
        {
            string manifestURL = String.Format("{0}/launcher/launcherManifest.txt", GetFTPUrl());
            return manifestURL;
        }

        public string GetManifestChecksumURL()
        {
            string manifestChecksumURL = String.Format("{0}/launcher/launcherManifest.checksum", GetFTPUrl());
            return manifestChecksumURL;
        }

        public string GetLauncherURL()
        {
            string launcherURL = String.Format("{0}/launcher/bin/{1}_Launcher.exe", GetFTPUrl(), GetGameName());
            return launcherURL;
        }

        public string GetChangelogURL()
        {
            string changelogURL = String.Format("{0}/launcher/changelog.html", GetFTPUrl());
            return changelogURL;
        }

        public string GetGameURL()
        {
            string gameURL = String.Format("{0}/game", GetFTPUrl());
            return gameURL;
        }

        public string GetLauncherVersion()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string launcherVersion = data["Local"]["launcherVersion"];

                return launcherVersion;
            }
            catch (Exception ex)
            {
                Console.Write("GetLauncherVersion: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }

        }

        public string GetGameName()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string gameName = data["Local"]["gameName"];

                return gameName;
            }
            catch (Exception ex)
            {
                Console.Write("GetGameName: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }
        }

        public string GetSystemTarget()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string systemTarget = data["Local"]["systemTarget"];

                return systemTarget;
            }
            catch (Exception ex)
            {
                Console.Write("GetSystemTarget: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }
        }

        public string GetFTPUsername()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string FTPUsername = data["Remote"]["FTPUsername"];

                return FTPUsername;
            }
            catch (Exception ex)
            {
                Console.Write("GetFTPUsername: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }
        }

        public string GetFTPPassword()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string FTPPassword = data["Remote"]["FTPPassword"];

                return FTPPassword;
            }
            catch (Exception ex)
            {
                Console.Write("GetFTPPassword: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }
        }

        public string GetFTPUrl()
        {
            try
            {
                FileIniDataParser Parser = new FileIniDataParser();
                IniData data = Parser.ReadFile(GetConfigPath());

                string FTPUrl = data["Remote"]["FTPUrl"];

                return FTPUrl;
            }
            catch (Exception ex)
            {
                Console.Write("GetFTPUrl: ");
                Console.WriteLine(ex.StackTrace);
                return "";
            }
        }
    }
}