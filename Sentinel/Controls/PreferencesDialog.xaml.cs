namespace Sentinel.Controls
{
    using System;

    using Sentinel.Interfaces;
    using Sentinel.Services;

    public partial class PreferencesDialog
    {
        public PreferencesDialog()
            : this(0)
        {
        }

        public PreferencesDialog(int selectedTabIndex)
        {
            InitializeComponent();
            Preferences = ServiceLocator.Instance.Get<IUserPreferences>();
            SelectedTabIndex = selectedTabIndex;
            DataContext = this;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public int SelectedTabIndex { get; set; }

        // ReSharper disable once MemberCanBePrivate.Global
        public IUserPreferences Preferences { get; private set; }

        private void WindowClosed(object sender, EventArgs e)
        {
            Preferences.Show = false;
        }
    }
}