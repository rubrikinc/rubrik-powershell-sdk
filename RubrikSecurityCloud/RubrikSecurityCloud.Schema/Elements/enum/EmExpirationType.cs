// EmExpirationType.cs
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
    public enum EmExpirationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EM_EXPIRATION_TYPE_AFTER_DATE_TIME")]
        EM_EXPIRATION_TYPE_AFTER_DATE_TIME,

        [EnumMember(Value = "EM_EXPIRATION_TYPE_AFTER_DURATION")]
        EM_EXPIRATION_TYPE_AFTER_DURATION,

        [EnumMember(Value = "EM_EXPIRATION_TYPE_NO_EXPIRATION")]
        EM_EXPIRATION_TYPE_NO_EXPIRATION,

        [EnumMember(Value = "EM_EXPIRATION_TYPE_UNSPECIFIED")]
        EM_EXPIRATION_TYPE_UNSPECIFIED


    } // enum EmExpirationType

} // namespace RubrikSecurityCloud.Types