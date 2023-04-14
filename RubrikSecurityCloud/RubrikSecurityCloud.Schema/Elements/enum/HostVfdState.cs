// HostVfdState.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum HostVfdState
    {
        [EnumMember(Value = "HOST_VFD_STATE_INSTALLED")]
        HOST_VFD_STATE_INSTALLED,

        [EnumMember(Value = "HOST_VFD_STATE_INSTALLED_BUT_RESTART_REQUIRED")]
        HOST_VFD_STATE_INSTALLED_BUT_RESTART_REQUIRED,

        [EnumMember(Value = "HOST_VFD_STATE_INSTALLED_BUT_TWO_RESTARTS_REQUIRED")]
        HOST_VFD_STATE_INSTALLED_BUT_TWO_RESTARTS_REQUIRED,

        [EnumMember(Value = "HOST_VFD_STATE_NOT_INSTALLED")]
        HOST_VFD_STATE_NOT_INSTALLED,

        [EnumMember(Value = "HOST_VFD_STATE_UNINSTALLED_BUT_RESTART_REQUIRED")]
        HOST_VFD_STATE_UNINSTALLED_BUT_RESTART_REQUIRED


    } // enum HostVfdState

} // namespace Rubrik.SecurityCloud.Types