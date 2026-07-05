// SourceWorkloadCloud.cs
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
    public enum SourceWorkloadCloud
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SOURCE_AWS")]
        SOURCE_AWS,

        [EnumMember(Value = "SOURCE_AZURE")]
        SOURCE_AZURE,

        [EnumMember(Value = "SOURCE_GCP")]
        SOURCE_GCP


    } // enum SourceWorkloadCloud

} // namespace RubrikSecurityCloud.Types