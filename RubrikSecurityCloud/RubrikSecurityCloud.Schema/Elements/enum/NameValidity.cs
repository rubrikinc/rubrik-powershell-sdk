// NameValidity.cs
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
    public enum NameValidity
    {
        [EnumMember(Value = "ALREADY_EXISTS")]
        ALREADY_EXISTS,

        [EnumMember(Value = "ILLEGAL")]
        ILLEGAL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VALID")]
        VALID


    } // enum NameValidity

} // namespace Rubrik.SecurityCloud.Types