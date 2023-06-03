// SmtpSecurityTypeEnum.cs
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
    public enum SmtpSecurityTypeEnum
    {
        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "SSL")]
        SSL,

        [EnumMember(Value = "STARTTLS")]
        STARTTLS,

        [EnumMember(Value = "TLS")]
        TLS


    } // enum SmtpSecurityTypeEnum

} // namespace Rubrik.SecurityCloud.Types