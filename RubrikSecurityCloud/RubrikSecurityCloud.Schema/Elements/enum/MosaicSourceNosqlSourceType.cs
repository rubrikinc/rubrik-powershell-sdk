// MosaicSourceNosqlSourceType.cs
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
    public enum MosaicSourceNosqlSourceType
    {
        [EnumMember(Value = "CASSANDRA")]
        CASSANDRA,

        [EnumMember(Value = "MONGODB")]
        MONGODB,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED


    } // enum MosaicSourceNosqlSourceType

} // namespace RubrikSecurityCloud.Types