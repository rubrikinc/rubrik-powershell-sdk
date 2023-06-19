// MssqlLogShippingTargetFilterField.cs
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
    public enum MssqlLogShippingTargetFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "PRIMARY_DB_ID")]
        PRIMARY_DB_ID,

        [EnumMember(Value = "PRIMARY_NAME")]
        PRIMARY_NAME,

        [EnumMember(Value = "SECONDARY_NAME")]
        SECONDARY_NAME,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum MssqlLogShippingTargetFilterField

} // namespace RubrikSecurityCloud.Types