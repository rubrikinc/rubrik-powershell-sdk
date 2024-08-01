// DataLocationType.cs
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
    public enum DataLocationType
    {
        [EnumMember(Value = "CDM_ARCHIVAL_LOCATION")]
        CDM_ARCHIVAL_LOCATION,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "DATA_LOCATION_TYPE_UNSPECIFIED")]
        DATA_LOCATION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataLocationType

} // namespace RubrikSecurityCloud.Types