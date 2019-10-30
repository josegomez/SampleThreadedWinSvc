namespace ThreadedServiceSample
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.svcProcInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.svcSampleInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // svcProcInstaller
            // 
            this.svcProcInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.svcProcInstaller.Password = null;
            this.svcProcInstaller.Username = null;
            // 
            // svcSampleInstaller
            // 
            this.svcSampleInstaller.Description = "Sample Service";
            this.svcSampleInstaller.DisplayName = "Sample Service";
            this.svcSampleInstaller.ServiceName = "svcSample";
            this.svcSampleInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.svcProcInstaller,
            this.svcSampleInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller svcProcInstaller;
        private System.ServiceProcess.ServiceInstaller svcSampleInstaller;
    }
}