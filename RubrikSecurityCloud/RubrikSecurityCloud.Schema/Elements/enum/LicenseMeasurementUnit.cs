// LicenseMeasurementUnit.cs
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
    public enum LicenseMeasurementUnit
    {
        [EnumMember(Value = "CAPACITY_IN_BYTES")]
        CAPACITY_IN_BYTES,

        [EnumMember(Value = "UOM_UNSPECIFIED")]
        UOM_UNSPECIFIED,

        [EnumMember(Value = "USERS")]
        USERS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LicenseMeasurementUnit

} // namespace RubrikSecurityCloud.Types