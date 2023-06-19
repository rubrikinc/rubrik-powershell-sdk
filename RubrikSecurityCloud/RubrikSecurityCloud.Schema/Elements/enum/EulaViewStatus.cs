// EulaViewStatus.cs
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
    public enum EulaViewStatus
    {
        [EnumMember(Value = "ALREADY_VIEWED")]
        ALREADY_VIEWED,

        [EnumMember(Value = "FIRST_VIEWED")]
        FIRST_VIEWED,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED


    } // enum EulaViewStatus

} // namespace RubrikSecurityCloud.Types