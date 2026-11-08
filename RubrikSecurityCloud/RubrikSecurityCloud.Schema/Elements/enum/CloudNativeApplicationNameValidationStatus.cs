// CloudNativeApplicationNameValidationStatus.cs
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
    public enum CloudNativeApplicationNameValidationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_NAME_INVALID_FORMAT")]
        APP_NAME_INVALID_FORMAT,

        [EnumMember(Value = "APP_NAME_NON_UNIQUE")]
        APP_NAME_NON_UNIQUE,

        [EnumMember(Value = "APP_NAME_VALID")]
        APP_NAME_VALID,

        [EnumMember(Value = "APP_NAME_VALIDATION_UNSPECIFIED")]
        APP_NAME_VALIDATION_UNSPECIFIED


    } // enum CloudNativeApplicationNameValidationStatus

} // namespace RubrikSecurityCloud.Types