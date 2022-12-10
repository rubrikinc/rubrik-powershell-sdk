// SqlAuthenticationMechanism.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
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
    public enum SqlAuthenticationMechanism
    {
        [EnumMember(Value = "AUTHENTICATION_MECHANISM_UNSPECIFIED")]
        AUTHENTICATION_MECHANISM_UNSPECIFIED,

        [EnumMember(Value = "AZURE_ACTIVE_DIRECTORY_AUTH_CODE")]
        AZURE_ACTIVE_DIRECTORY_AUTH_CODE,

        [EnumMember(Value = "SQL_AUTHENTICATION")]
        SQL_AUTHENTICATION


    } // enum SqlAuthenticationMechanism

} // namespace Rubrik.SecurityCloud.Types