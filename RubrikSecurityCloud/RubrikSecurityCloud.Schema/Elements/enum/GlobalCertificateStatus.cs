// GlobalCertificateStatus.cs
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
    public enum GlobalCertificateStatus
    {
        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "EXPIRING_SOON")]
        EXPIRING_SOON,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED,

        [EnumMember(Value = "VALID")]
        VALID


    } // enum GlobalCertificateStatus

} // namespace Rubrik.SecurityCloud.Types