// MssqlLogShippingTargetSortByField.cs
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
    public enum MssqlLogShippingTargetSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LAST_APPLIED_POINT")]
        LAST_APPLIED_POINT,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "PRIMARY_NAME")]
        PRIMARY_NAME,

        [EnumMember(Value = "SECONDARY_NAME")]
        SECONDARY_NAME


    } // enum MssqlLogShippingTargetSortByField

} // namespace RubrikSecurityCloud.Types