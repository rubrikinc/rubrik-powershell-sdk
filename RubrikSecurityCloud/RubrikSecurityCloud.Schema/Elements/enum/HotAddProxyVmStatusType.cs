// HotAddProxyVmStatusType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:09.
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
    public enum HotAddProxyVmStatusType
    {
        [EnumMember(Value = "HOT_ADD_PROXY_VM_STATUS_TYPE_EXPIRED")]
        HOT_ADD_PROXY_VM_STATUS_TYPE_EXPIRED,

        [EnumMember(Value = "HOT_ADD_PROXY_VM_STATUS_TYPE_FAILED")]
        HOT_ADD_PROXY_VM_STATUS_TYPE_FAILED,

        [EnumMember(Value = "HOT_ADD_PROXY_VM_STATUS_TYPE_MAINTAINING")]
        HOT_ADD_PROXY_VM_STATUS_TYPE_MAINTAINING,

        [EnumMember(Value = "HOT_ADD_PROXY_VM_STATUS_TYPE_RUNNING")]
        HOT_ADD_PROXY_VM_STATUS_TYPE_RUNNING


    } // enum HotAddProxyVmStatusType

} // namespace Rubrik.SecurityCloud.Types