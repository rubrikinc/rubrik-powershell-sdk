// PrecheckIdentifier.cs
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
    public enum PrecheckIdentifier
    {
        [EnumMember(Value = "PRECHECK_MIGRATION")]
        PRECHECK_MIGRATION,

        [EnumMember(Value = "PRECHECK_OTHER")]
        PRECHECK_OTHER,

        [EnumMember(Value = "PRECHECK_UNSPECIFIED")]
        PRECHECK_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PrecheckIdentifier

} // namespace RubrikSecurityCloud.Types