// UnmanagedObjectsSortType.cs
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
    public enum UnmanagedObjectsSortType
    {
        [EnumMember(Value = "ARCHIVAL_STORAGE")]
        ARCHIVAL_STORAGE,

        [EnumMember(Value = "LOCAL_STORAGE")]
        LOCAL_STORAGE,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "RETENTION_SLA_DOMAIN_NAME")]
        RETENTION_SLA_DOMAIN_NAME,

        [EnumMember(Value = "SNAPSHOTS_COUNT")]
        SNAPSHOTS_COUNT,

        [EnumMember(Value = "UNMANAGED_STATUS")]
        UNMANAGED_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UnmanagedObjectsSortType

} // namespace RubrikSecurityCloud.Types