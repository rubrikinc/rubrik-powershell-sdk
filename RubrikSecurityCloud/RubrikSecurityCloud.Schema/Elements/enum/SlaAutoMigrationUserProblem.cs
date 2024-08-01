// SlaAutoMigrationUserProblem.cs
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
    public enum SlaAutoMigrationUserProblem
    {
        [EnumMember(Value = "NEED_MORE_TIME_TO_PLAN")]
        NEED_MORE_TIME_TO_PLAN,

        [EnumMember(Value = "NEED_RUBRIK_HELP_TO_PLAN")]
        NEED_RUBRIK_HELP_TO_PLAN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaAutoMigrationUserProblem

} // namespace RubrikSecurityCloud.Types