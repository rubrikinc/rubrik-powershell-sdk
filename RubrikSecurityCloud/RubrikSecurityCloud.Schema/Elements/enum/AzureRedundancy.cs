// AzureRedundancy.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AzureRedundancy
    {
        [EnumMember(Value = "GRS")]
        GRS,

        [EnumMember(Value = "GZRS")]
        GZRS,

        [EnumMember(Value = "LRS")]
        LRS,

        [EnumMember(Value = "RA_GRS")]
        RA_GRS,

        [EnumMember(Value = "RA_GZRS")]
        RA_GZRS,

        [EnumMember(Value = "UNKNOWN_AZURE_REDUNDANCY")]
        UNKNOWN_AZURE_REDUNDANCY,

        [EnumMember(Value = "ZRS")]
        ZRS


    } // enum AzureRedundancy

} // namespace Rubrik.SecurityCloud.Types