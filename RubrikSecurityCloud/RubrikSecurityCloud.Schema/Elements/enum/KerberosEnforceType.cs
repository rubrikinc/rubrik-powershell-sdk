// KerberosEnforceType.cs
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
    public enum KerberosEnforceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KERBEROS_ENFORCE_KRB5A")]
        KERBEROS_ENFORCE_KRB5A,

        [EnumMember(Value = "KERBEROS_ENFORCE_KRB5P")]
        KERBEROS_ENFORCE_KRB5P,

        [EnumMember(Value = "KERBEROS_ENFORCE_NONE")]
        KERBEROS_ENFORCE_NONE


    } // enum KerberosEnforceType

} // namespace RubrikSecurityCloud.Types