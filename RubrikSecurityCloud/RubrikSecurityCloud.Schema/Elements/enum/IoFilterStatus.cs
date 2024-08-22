// IoFilterStatus.cs
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
    public enum IoFilterStatus
    {
        [EnumMember(Value = "IO_FILTER_STATUS_INCONSISTENT")]
        IO_FILTER_STATUS_INCONSISTENT,

        [EnumMember(Value = "IO_FILTER_STATUS_INSTALLED")]
        IO_FILTER_STATUS_INSTALLED,

        [EnumMember(Value = "IO_FILTER_STATUS_INSTALL_ERROR")]
        IO_FILTER_STATUS_INSTALL_ERROR,

        [EnumMember(Value = "IO_FILTER_STATUS_INSTALL_IN_PROGRESS")]
        IO_FILTER_STATUS_INSTALL_IN_PROGRESS,

        [EnumMember(Value = "IO_FILTER_STATUS_OUT_OF_DATE")]
        IO_FILTER_STATUS_OUT_OF_DATE,

        [EnumMember(Value = "IO_FILTER_STATUS_UNAVAILABLE")]
        IO_FILTER_STATUS_UNAVAILABLE,

        [EnumMember(Value = "IO_FILTER_STATUS_UNINSTALLED")]
        IO_FILTER_STATUS_UNINSTALLED,

        [EnumMember(Value = "IO_FILTER_STATUS_UNINSTALL_ERROR")]
        IO_FILTER_STATUS_UNINSTALL_ERROR,

        [EnumMember(Value = "IO_FILTER_STATUS_UNINSTALL_IN_PROGRESS")]
        IO_FILTER_STATUS_UNINSTALL_IN_PROGRESS,

        [EnumMember(Value = "IO_FILTER_STATUS_UNKNOWN")]
        IO_FILTER_STATUS_UNKNOWN,

        [EnumMember(Value = "IO_FILTER_STATUS_UNSUPPORTED")]
        IO_FILTER_STATUS_UNSUPPORTED,

        [EnumMember(Value = "IO_FILTER_STATUS_UNSUPPORTED_BY_RUBRIK")]
        IO_FILTER_STATUS_UNSUPPORTED_BY_RUBRIK,

        [EnumMember(Value = "IO_FILTER_STATUS_UNSUPPORTED_BY_VMWARE")]
        IO_FILTER_STATUS_UNSUPPORTED_BY_VMWARE,

        [EnumMember(Value = "IO_FILTER_STATUS_UPGRADE_ERROR")]
        IO_FILTER_STATUS_UPGRADE_ERROR,

        [EnumMember(Value = "IO_FILTER_STATUS_UPGRADE_IN_PROGRESS")]
        IO_FILTER_STATUS_UPGRADE_IN_PROGRESS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum IoFilterStatus

} // namespace RubrikSecurityCloud.Types