// SourceSourceType.cs
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
    public enum SourceSourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SOURCE_SOURCE_TYPE_CASSANDRA")]
        SOURCE_SOURCE_TYPE_CASSANDRA,

        [EnumMember(Value = "SOURCE_SOURCE_TYPE_MONGO")]
        SOURCE_SOURCE_TYPE_MONGO


    } // enum SourceSourceType

} // namespace RubrikSecurityCloud.Types