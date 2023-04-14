// EncryptionLevel.cs
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
    public enum EncryptionLevel
    {
        [EnumMember(Value = "HIGH")]
        HIGH,

        [EnumMember(Value = "LOW")]
        LOW,

        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE


    } // enum EncryptionLevel

} // namespace Rubrik.SecurityCloud.Types