// M365DashboardWorkloadType.cs
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
    public enum M365DashboardWorkloadType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DST_EXCHANGE")]
        DST_EXCHANGE,

        [EnumMember(Value = "DST_ONEDRIVE")]
        DST_ONEDRIVE,

        [EnumMember(Value = "DST_SHAREPOINT")]
        DST_SHAREPOINT,

        [EnumMember(Value = "DST_TEAMS")]
        DST_TEAMS


    } // enum M365DashboardWorkloadType

} // namespace RubrikSecurityCloud.Types