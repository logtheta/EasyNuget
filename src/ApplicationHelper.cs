using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyNuget
{
    public static class ApplicationHelper
    {
        #region Methods

        /// <summary>
        /// Return the path were is located current executable.
        /// </summary>
        /// <returns></returns>
        public static string GetEntryAssemblyPath()
        {
            var uri = new Uri(Assembly.GetEntryAssembly().CodeBase);
            return Path.GetDirectoryName(uri.LocalPath);
        }

        public static string GetProductVersion(string assemblyName, bool managed = true)
        {
            var path = GetEntryAssemblyPath();
            var assemblyPath = Path.Combine(path, string.Format("{0}.dll", assemblyName));
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assemblyPath);

            return fileVersionInfo.ProductVersion;
        }

        /// <summary>
        /// Return the name of the current application
        /// </summary>
        /// <returns></returns>
        public static string GetAppName()
        {
            //TODO: review
            return Assembly.GetEntryAssembly().FullName;
        }

        /// <summary>
        /// Return the Version of the current executing assembly
        /// </summary>
        /// <returns></returns>
        public static string GetVersion()
        {
            //TODO: review
            return GetVersion(Assembly.GetEntryAssembly());
        }

        /// <summary>
        /// Return the version of an assembly in a formatted way ([Name] [Version])
        /// </summary>
        /// <param name="assembly">An instance of <see cref="System.Reflection.Assembly"/> where to extract the version. /></param>
        /// <returns>
        /// Version in formatted style ([Name] [Version])
        /// </returns>
        public static String GetVersion(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException("assembly");

            string[] applicationInfos = assembly.FullName.Split(new[] { ',' });
            return String.Format("{0} {1}", applicationInfos[0], applicationInfos[1]);
        }

        /// <summary>
        /// Retrieves the calling executable version.
        /// </summary>
        /// <returns></returns>
        public static string RetrieveCallingExecutableVersion()
        {
            //TODO: review
            return Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        // Gets the build date and time(by reading the COFF header)
        // http://msdn.microsoft.com/en-us/library/ms680313

        public static DateTime RetrieveCallingExecutableLinkerTimestamp()
        {
            var assemblyPath = Assembly.GetEntryAssembly().Location;
            if (File.Exists(assemblyPath))
            {
                var buffer = new byte[Math.Max(Marshal.SizeOf(typeof(_IMAGE_FILE_HEADER)), 4)];
                using (var fileStream = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read))
                {
                    fileStream.Position = 0x3C;
                    fileStream.Read(buffer, 0, 4);
                    fileStream.Position = BitConverter.ToUInt32(buffer, 0); // COFF header offset
                    fileStream.Read(buffer, 0, 4); // "PE\0\0"
                    fileStream.Read(buffer, 0, buffer.Length);
                }
                var pinnedBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                try
                {
                    var coffHeader = (_IMAGE_FILE_HEADER)Marshal.PtrToStructure(pinnedBuffer.AddrOfPinnedObject(), typeof(_IMAGE_FILE_HEADER));

                    return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1) + new TimeSpan(coffHeader.TimeDateStamp * TimeSpan.TicksPerSecond));
                }
                finally
                {
                    pinnedBuffer.Free();
                }
            }
            return new DateTime();
        }

        /// <summary>
        /// Gets the executable infos.
        /// </summary>
        /// <returns></returns>
        public static string GetExecutableInfos()
        {
            //TODO: review
            var callingAssembly = Assembly.GetEntryAssembly();
            return string.Format("{0} v.{1} - {2} UTC", callingAssembly.GetName().Name, callingAssembly.GetName().Version, RetrieveCallingExecutableLinkerTimestamp());
        }

        #endregion Methods

        #region Structs

        struct _IMAGE_FILE_HEADER
        {
            public ushort Machine;
            public ushort NumberOfSections;
            public uint TimeDateStamp;
            public uint PointerToSymbolTable;
            public uint NumberOfSymbols;
            public ushort SizeOfOptionalHeader;
            public ushort Characteristics;
        };

        #endregion
    }
}
