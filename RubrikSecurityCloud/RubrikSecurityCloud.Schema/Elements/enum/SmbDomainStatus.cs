// SmbDomainStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
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
    public enum SmbDomainStatus
    {
        [EnumMember(Value = "SMB_DOMAIN_STATUS_CONFIGURED")]
        SMB_DOMAIN_STATUS_CONFIGURED,

        [EnumMember(Value = "SMB_DOMAIN_STATUS_FAILED")]
        SMB_DOMAIN_STATUS_FAILED,

        [EnumMember(Value = "SMB_DOMAIN_STATUS_NOT_CONFIGURED")]
        SMB_DOMAIN_STATUS_NOT_CONFIGURED


    } // enum SmbDomainStatus

} // namespace Rubrik.SecurityCloud.Types