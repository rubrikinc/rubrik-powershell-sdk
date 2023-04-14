// HostFilterStatus.cs
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
    public enum HostFilterStatus
    {
        [EnumMember(Value = "HOST_FILTER_STATUS_INSTALLED")]
        HOST_FILTER_STATUS_INSTALLED,

        [EnumMember(Value = "HOST_FILTER_STATUS_OUT_OF_DATE")]
        HOST_FILTER_STATUS_OUT_OF_DATE,

        [EnumMember(Value = "HOST_FILTER_STATUS_PAST_EXPECTED_DATE")]
        HOST_FILTER_STATUS_PAST_EXPECTED_DATE,

        [EnumMember(Value = "HOST_FILTER_STATUS_UNINSTALLED")]
        HOST_FILTER_STATUS_UNINSTALLED,

        [EnumMember(Value = "HOST_FILTER_STATUS_UNKNOWN")]
        HOST_FILTER_STATUS_UNKNOWN,

        [EnumMember(Value = "HOST_FILTER_STATUS_UNSUPPORTED_BY_VMWARE")]
        HOST_FILTER_STATUS_UNSUPPORTED_BY_VMWARE


    } // enum HostFilterStatus

} // namespace Rubrik.SecurityCloud.Types