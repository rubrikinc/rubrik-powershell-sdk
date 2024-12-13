// HostUiFilterStatus.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum HostUiFilterStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_CHECK_VCENTER")]
        HOST_UI_FILTER_STATUS_CHECK_VCENTER,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_ERROR_CONTACT_SUPPORT")]
        HOST_UI_FILTER_STATUS_ERROR_CONTACT_SUPPORT,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_ERROR_MAINTENANCE_MODE")]
        HOST_UI_FILTER_STATUS_ERROR_MAINTENANCE_MODE,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_INSTALL_IN_PROGRESS")]
        HOST_UI_FILTER_STATUS_INSTALL_IN_PROGRESS,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_NO_FILTER")]
        HOST_UI_FILTER_STATUS_NO_FILTER,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_OK")]
        HOST_UI_FILTER_STATUS_OK,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_RETRY_INSTALL")]
        HOST_UI_FILTER_STATUS_RETRY_INSTALL,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_UNINSTALL_IN_PROGRESS")]
        HOST_UI_FILTER_STATUS_UNINSTALL_IN_PROGRESS,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_UNKNOWN")]
        HOST_UI_FILTER_STATUS_UNKNOWN,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_UNSUPPORTED_BY_VMWARE")]
        HOST_UI_FILTER_STATUS_UNSUPPORTED_BY_VMWARE,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_UPGRADE_IN_PROGRESS")]
        HOST_UI_FILTER_STATUS_UPGRADE_IN_PROGRESS,

        [EnumMember(Value = "HOST_UI_FILTER_STATUS_UPGRADE_NEEDED")]
        HOST_UI_FILTER_STATUS_UPGRADE_NEEDED


    } // enum HostUiFilterStatus

} // namespace RubrikSecurityCloud.Types