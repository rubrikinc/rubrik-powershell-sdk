// MssqlLogShippingTargetSortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    public enum MssqlLogShippingTargetSortByField
    {
        [EnumMember(Value = "LAST_APPLIED_POINT")]
        LAST_APPLIED_POINT,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "PRIMARY_NAME")]
        PRIMARY_NAME,

        [EnumMember(Value = "SECONDARY_NAME")]
        SECONDARY_NAME


    } // enum MssqlLogShippingTargetSortByField

} // namespace Rubrik.SecurityCloud.Types