// O365SetupOperationMode.cs
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
    public enum O365SetupOperationMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "O365_SETUP_OPERATION_MODE_ONBOARDING_MODE")]
        O365_SETUP_OPERATION_MODE_ONBOARDING_MODE,

        [EnumMember(Value = "O365_SETUP_OPERATION_MODE_PRIORITIZED_ONBOARDING")]
        O365_SETUP_OPERATION_MODE_PRIORITIZED_ONBOARDING,

        [EnumMember(Value = "O365_SETUP_OPERATION_MODE_UNSPECIFIED")]
        O365_SETUP_OPERATION_MODE_UNSPECIFIED


    } // enum O365SetupOperationMode

} // namespace RubrikSecurityCloud.Types