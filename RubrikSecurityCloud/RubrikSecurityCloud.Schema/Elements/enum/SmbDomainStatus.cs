// SmbDomainStatus.cs
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
    public enum SmbDomainStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SMB_DOMAIN_STATUS_CONFIGURED")]
        SMB_DOMAIN_STATUS_CONFIGURED,

        [EnumMember(Value = "SMB_DOMAIN_STATUS_FAILED")]
        SMB_DOMAIN_STATUS_FAILED,

        [EnumMember(Value = "SMB_DOMAIN_STATUS_NOT_CONFIGURED")]
        SMB_DOMAIN_STATUS_NOT_CONFIGURED


    } // enum SmbDomainStatus

} // namespace RubrikSecurityCloud.Types