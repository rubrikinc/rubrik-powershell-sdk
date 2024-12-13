// DlpStatusCode.cs
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
    public enum DlpStatusCode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTEGRATION_STATUS_UNSPECIFIED")]
        INTEGRATION_STATUS_UNSPECIFIED,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "SERVICE_ACCOUNT_INSUFFICIENT_PERMISSIONS")]
        SERVICE_ACCOUNT_INSUFFICIENT_PERMISSIONS,

        [EnumMember(Value = "SERVICE_ACCOUNT_MISSING")]
        SERVICE_ACCOUNT_MISSING


    } // enum DlpStatusCode

} // namespace RubrikSecurityCloud.Types