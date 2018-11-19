using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.IO;

namespace EasyNuget
{
    public class NugetPackageSettings
    {

        public string InputProjPath { get; set; }
        public string OutputPackagePath { get; set; }
        public string PackageVer { get; set; }
        public bool Enabled { get; set; } = true;
    }

    
    public class PackagesSettings
    {
        public ConcurrentDictionary<string, NugetPackageSettings> Packages { get; set; }

        public void Load(string path)
        {
            if (path == null)
                throw new InvalidOperationException("Please provide path for Packages Settings");

            if (!File.Exists(path))
                return;

            var json = File.ReadAllText(path);
            Packages = JsonConvert.DeserializeObject<ConcurrentDictionary<string, NugetPackageSettings>>(json);
        }


        public void Save(string path)
        {
            var json =JsonConvert.SerializeObject(this.Packages, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public PackagesSettings()
        {
            Packages = new ConcurrentDictionary<string, NugetPackageSettings>();
        }

    }




}
