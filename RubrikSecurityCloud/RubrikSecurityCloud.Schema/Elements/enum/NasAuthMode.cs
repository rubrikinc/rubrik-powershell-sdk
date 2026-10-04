// NasAuthMode.cs
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
    public enum NasAuthMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KERBEROS_ONLY")]
        KERBEROS_ONLY,

        [EnumMember(Value = "KERBEROS_PREFERRED")]
        KERBEROS_PREFERRED,

        [EnumMember(Value = "NAS_AUTH_MODE_UNSPECIFIED")]
        NAS_AUTH_MODE_UNSPECIFIED,

        [EnumMember(Value = "STANDARD")]
        STANDARD


    } // enum NasAuthMode

} // namespace RubrikSecurityCloud.Types