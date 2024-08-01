// SlaAutoMigrationFsmState.cs
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
    public enum SlaAutoMigrationFsmState
    {
        [EnumMember(Value = "AUTO_MIGRATION")]
        AUTO_MIGRATION,

        [EnumMember(Value = "END")]
        END,

        [EnumMember(Value = "GRACE_PERIOD")]
        GRACE_PERIOD,

        [EnumMember(Value = "MANDATORY_PERIOD")]
        MANDATORY_PERIOD,

        [EnumMember(Value = "OPTED_OUT")]
        OPTED_OUT,

        [EnumMember(Value = "START")]
        START,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaAutoMigrationFsmState

} // namespace RubrikSecurityCloud.Types