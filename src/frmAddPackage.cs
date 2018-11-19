namespace EasyNuget
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class frmAddPackage : Form
    {
        Builder builder;

        public PackagesSettings Settings { get; set; }

        public frmAddPackage()
        {
            InitializeComponent();
            //TxtOutputPackagePath.Text = @"c:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + @"\.nuget\packages";
            builder = new Builder();
        }

        private void BtnBrowseInput_Click(object sender, EventArgs e)
        {
            if (ofInput.ShowDialog() == DialogResult.OK)
            {
                TxtInputProjPath.Text = ofInput.FileName;
            }
        }

        private void BtnBrowseOutput_Click(object sender, EventArgs e)
        {
            fbOut.RootFolder = Environment.SpecialFolder.Desktop;
            fbOut.SelectedPath = @"c:\Users\" + Environment.UserName + @"\.nuget\packages";
            if (fbOut.ShowDialog() == DialogResult.OK)
            {
                TxtOutputPackagePath.Text = fbOut.SelectedPath;
            }
        }

        private void BtnTestPackage_Click(object sender, EventArgs e)
        {
            if (TxtInputProjPath.Text == String.Empty || TxtOutputPackagePath.Text == String.Empty || TxtPackageVer.Text == String.Empty)
            {
                MessageBox.Show(this, "Please fill up all the fields", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NugetPackageSettings settings = new NugetPackageSettings()
                {
                    InputProjPath = TxtInputProjPath.Text,
                    OutputPackagePath = TxtOutputPackagePath.Text,
                    PackageVer = TxtPackageVer.Text
                };

                builder.Build(settings);
                MessageBox.Show(this, "The package has been tested and compiled", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred building the package due to:\r\n{ex.Message}", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddPackage_Click(object sender, EventArgs e)
        {
            if (TxtInputProjPath.Text == String.Empty || TxtOutputPackagePath.Text == String.Empty || TxtPackageVer.Text == String.Empty)
            {
                MessageBox.Show(this, "Please fill up all the fields", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NugetPackageSettings settings = new NugetPackageSettings()
                {
                    InputProjPath = TxtInputProjPath.Text,
                    OutputPackagePath = TxtOutputPackagePath.Text,
                    PackageVer = TxtPackageVer.Text
                };

                string k = Path.GetFileNameWithoutExtension(TxtInputProjPath.Text);


                Settings.Packages.TryAdd(k, settings);
                Settings.Save(frmMain.SettingsFullPath);

                MessageBox.Show(this, "The package has been added to the list", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred adding the package due to:\r\n{ex.Message}", "Add Package", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
