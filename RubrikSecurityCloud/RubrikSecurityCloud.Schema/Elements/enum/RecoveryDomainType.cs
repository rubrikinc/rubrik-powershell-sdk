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

namespace Rubrik.SecurityCloud.Types
{
    public enum RecoveryDomainType
    {
        [EnumMember(Value = "O365")]
        O365,

        [EnumMember(Value = "RECOVERY_DOMAIN_UNKNOWN")]
        RECOVERY_DOMAIN_UNKNOWN


    } // enum RecoveryDomainType

} // namespace Rubrik.SecurityCloud.Types