using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace VModManager.Services
{
    public class UpdateService
    {
        private const string RepoApi =
            "https://api.github.com/repos/andreasclaesson/vmmanager/releases/latest";

        public class GitHubRelease
        {
            public string tag_name { get; set; }
            public Asset[] assets { get; set; }
        }

        public class Asset
        {
            public string name { get; set; }
            public string browser_download_url { get; set; }
        }

        public async Task<(bool hasUpdate, string version, string url)> CheckForUpdateAsync(string currentVersion)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "VModManager");

            var json = await client.GetStringAsync(RepoApi);

            var release = JsonSerializer.Deserialize<GitHubRelease>(json);

            if (release == null)
                return (false, currentVersion, null);

            string latestVersion = release.tag_name.TrimStart('v');

            if (latestVersion == currentVersion)
                return (false, latestVersion, null);

            var asset = release.assets[0];

            return (true, latestVersion, asset.browser_download_url);
        }
    }
}