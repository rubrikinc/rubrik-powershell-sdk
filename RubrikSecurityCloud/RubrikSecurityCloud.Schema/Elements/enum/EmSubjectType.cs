// EmSubjectType.cs
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
    public enum EmSubjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EM_SUBJECT_TYPE_NOT_SPECIFIED")]
        EM_SUBJECT_TYPE_NOT_SPECIFIED,

        [EnumMember(Value = "EM_SUBJECT_TYPE_SERVICE_PRINCIPAL")]
        EM_SUBJECT_TYPE_SERVICE_PRINCIPAL,

        [EnumMember(Value = "EM_SUBJECT_TYPE_UNKNOWN_FUTURE_VALUE")]
        EM_SUBJECT_TYPE_UNKNOWN_FUTURE_VALUE,

        [EnumMember(Value = "EM_SUBJECT_TYPE_UNSPECIFIED")]
        EM_SUBJECT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "EM_SUBJECT_TYPE_USER")]
        EM_SUBJECT_TYPE_USER


    } // enum EmSubjectType

} // namespace RubrikSecurityCloud.Types