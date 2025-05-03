using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Daemon.Options
{
    public class ScanDaemonSettings : DaemonOptions
    {
        public string ScannedPhotosPath { get; set; }
        public List<string> AllowedExtensions { get; set; } = new() { "jpg" };
    }
}
