namespace EasyNuget
{
    public class Builder
    {


        public void Build(NugetPackageSettings settings)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C build.cmd {settings.InputProjPath} {settings.OutputPackagePath} {settings.PackageVer}";
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
