// WorkloadType.cs
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
    public enum WorkloadType
    {
        [EnumMember(Value = "O365_EXCHANGE")]
        O365_EXCHANGE,

        [EnumMember(Value = "O365_ONEDRIVE")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365_SHAREPOINT")]
        O365_SHAREPOINT,

        [EnumMember(Value = "SNAPPABLE_TYPE_UNKNOWN")]
        SNAPPABLE_TYPE_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum WorkloadType

} // namespace RubrikSecurityCloud.Types