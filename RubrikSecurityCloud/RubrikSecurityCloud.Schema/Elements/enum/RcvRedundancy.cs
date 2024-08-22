// RcvRedundancy.cs
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
    public enum RcvRedundancy
    {
        [EnumMember(Value = "AZURE_GRS")]
        AZURE_GRS,

        [EnumMember(Value = "AZURE_LRS")]
        AZURE_LRS,

        [EnumMember(Value = "AZURE_ZRS")]
        AZURE_ZRS,

        [EnumMember(Value = "UNKNOWN_AZURE_REDUNDANCY")]
        UNKNOWN_AZURE_REDUNDANCY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RcvRedundancy

} // namespace RubrikSecurityCloud.Types