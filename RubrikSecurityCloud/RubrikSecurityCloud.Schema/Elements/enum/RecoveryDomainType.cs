// RecoveryDomainType.cs
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
    public enum RecoveryDomainType
    {
        [EnumMember(Value = "O365")]
        O365,

        [EnumMember(Value = "RECOVERY_DOMAIN_UNKNOWN")]
        RECOVERY_DOMAIN_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryDomainType

} // namespace RubrikSecurityCloud.Types