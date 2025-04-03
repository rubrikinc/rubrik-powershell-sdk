// IssuerType.cs
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
    public enum IssuerType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXTERNAL")]
        EXTERNAL,

        [EnumMember(Value = "ISSUER_TYPE_UNKNOWN")]
        ISSUER_TYPE_UNKNOWN,

        [EnumMember(Value = "RUBRIK")]
        RUBRIK,

        [EnumMember(Value = "SELF")]
        SELF


    } // enum IssuerType

} // namespace RubrikSecurityCloud.Types