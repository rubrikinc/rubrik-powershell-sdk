// Db2InstanceType.cs
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
    public enum Db2InstanceType
    {
        [EnumMember(Value = "INSTANCETYPE_UNSPECIFIED")]
        INSTANCETYPE_UNSPECIFIED,

        [EnumMember(Value = "PARTITIONED")]
        PARTITIONED,

        [EnumMember(Value = "PURESCALE")]
        PURESCALE,

        [EnumMember(Value = "STANDALONE")]
        STANDALONE


    } // enum Db2InstanceType

} // namespace RubrikSecurityCloud.Types