// SailPointStatusCode.cs
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
    public enum SailPointStatusCode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREDENTIAL_ERROR")]
        CREDENTIAL_ERROR,

        [EnumMember(Value = "INTEGRATION_STATUS_UNSPECIFIED")]
        INTEGRATION_STATUS_UNSPECIFIED,

        [EnumMember(Value = "OK")]
        OK


    } // enum SailPointStatusCode

} // namespace RubrikSecurityCloud.Types