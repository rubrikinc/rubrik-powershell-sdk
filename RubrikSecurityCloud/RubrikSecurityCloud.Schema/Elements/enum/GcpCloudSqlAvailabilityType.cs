// GcpCloudSqlAvailabilityType.cs
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
    public enum GcpCloudSqlAvailabilityType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AVAILABILITY_TYPE_UNSPECIFIED")]
        AVAILABILITY_TYPE_UNSPECIFIED,

        [EnumMember(Value = "REGIONAL")]
        REGIONAL,

        [EnumMember(Value = "ZONAL")]
        ZONAL


    } // enum GcpCloudSqlAvailabilityType

} // namespace RubrikSecurityCloud.Types