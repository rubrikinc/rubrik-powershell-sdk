### HostVfdInstallResponse
Supported in v5.0+

- errorInfo: System.String
  - Supported in v5.0+
- hostId: System.String
  - Required. Supported in v5.0+
- hostVfdDriverState: HostVfdState
  - Required. Supported in v5.0+
v5.0-v6.0: Specifies the installation status of the VFD driver on a Windows host. The value is 'NotInstalled' when the driver is absent. The value is 'Installed' when the driver is present. The value is 'RestartRequred' when the driver is present but requires a restart of the Windows host in order to function.
v7.0+: Specifies the installation status of the VFD driver on a Windows host. The value is - 'NotInstalled' when the driver is absent. - 'Installed' when the driver is present. - 'InstalledButRestartRequred' when the driver is present but requires a restart of the Windows host. - 'InstalledButTwoRestartsRequred' when the driver is updated but requires two restarts of the Window host. - 'UninstalledButRestartRequired' when the driver is uninstalled but requires a restart of the Windows host to remove the driver.
