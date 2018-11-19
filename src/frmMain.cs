namespace EasyNuget
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class frmMain : Form
    {
        private const string PackageSettingsPath = "PackageSettings.json";


        private PackagesSettings settings;
        public static readonly string SettingsFullPath = Path.Combine(ApplicationHelper.GetEntryAssemblyPath(), PackageSettingsPath);

        public frmMain()
        {
            InitializeComponent();
            Initialize();
        }


        #region Methods



        private void Initialize()
        {
            //Load package settings if available
            settings = new PackagesSettings();
            settings.Load(SettingsFullPath);

            RefreshListView();

            //settings.Packages = new System.Collections.Concurrent.ConcurrentDictionary<string, NugetPackageSettings>();
            //settings.Packages.TryAdd("blah", new NugetPackageSettings() { InputProjPath = "C:\\dev", OutputPackagePath = "c:\\program files", PackageVer = "2.1.3" });
            //settings.Save(Path.Combine(ApplicationHelper.GetEntryAssemblyPath(), PackageSettingsPath));
        }

        private void RefreshListView()
        {
            lvPackages.View = View.List;
            lvPackages.SmallImageList = imageList1;
            ListViewItem item;
            lvPackages.BeginUpdate();
            lvPackages.Items.Clear();
            foreach (var kv in settings.Packages)
            {
                item = new ListViewItem($"{kv.Key} {kv.Value.PackageVer}", 1);
                item.ImageKey = "dll.ico";

                if (!kv.Value.Enabled)
                {
                    item.UseItemStyleForSubItems = false;
                    item.SubItems[0].ForeColor = Color.Gray;
                }
                lvPackages.Items.Add(item);
            }

            lvPackages.EndUpdate();
        }

        #endregion

        #region Event handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNugetPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPackage frm = new frmAddPackage();
            frm.Settings = settings;

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                settings.Save(SettingsFullPath);
                RefreshListView();
            }

        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Builder builder = new Builder();
            Parallel.ForEach(settings.Packages, kv =>
            {
                if(kv.Value.Enabled)
                    builder.Build(kv.Value);
            });
        }

        private void enableSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisablePackage(true);

        }

        private void disableSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisablePackage(false);
        }

        private void EnableDisablePackage(bool enable)
        {
            foreach (ListViewItem item in lvPackages.SelectedItems)
            {
                string key = item.Text.Split()[0];
                settings.Packages[key].Enabled = enable;
            }
            settings.Save(SettingsFullPath);
            RefreshListView();
        }

        private void buildSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Builder builder = new Builder();
            foreach (ListViewItem item in lvPackages.SelectedItems)
            {
                string key = item.Text.Split()[0];
                if (settings.Packages[key].Enabled)
                    builder.Build(settings.Packages[key]);
            }
        }

        private void buildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Builder builder = new Builder();
            Parallel.ForEach(settings.Packages, kv =>
            {
                if (kv.Value.Enabled)
                    builder.Build(kv.Value);
            });
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisablePackage(true);
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisablePackage(false);
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }


        #endregion


    }
}
