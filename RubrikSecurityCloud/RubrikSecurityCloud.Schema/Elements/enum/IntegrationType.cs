// IntegrationType.cs
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
    public enum IntegrationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CROWD_STRIKE")]
        CROWD_STRIKE,

        [EnumMember(Value = "DATA_LOSS_PREVENTION")]
        DATA_LOSS_PREVENTION,

        [EnumMember(Value = "INTEGRATION_TYPE_UNSPECIFIED")]
        INTEGRATION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "MICROSOFT_PURVIEW")]
        MICROSOFT_PURVIEW,

        [EnumMember(Value = "OKTA")]
        OKTA,

        [EnumMember(Value = "PRIVILEGED_ACCESS_MANAGEMENT")]
        PRIVILEGED_ACCESS_MANAGEMENT,

        [EnumMember(Value = "SERVICENOW_ITSM")]
        SERVICENOW_ITSM


    } // enum IntegrationType

} // namespace RubrikSecurityCloud.Types