// RelationshipConflictResolutionState.cs
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
    public enum RelationshipConflictResolutionState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFLICT_RESOLUTION_STATE_LIVE_RELATIONSHIPS")]
        CONFLICT_RESOLUTION_STATE_LIVE_RELATIONSHIPS,

        [EnumMember(Value = "CONFLICT_RESOLUTION_STATE_SNAPSHOT_RELATIONSHIPS")]
        CONFLICT_RESOLUTION_STATE_SNAPSHOT_RELATIONSHIPS,

        [EnumMember(Value = "RELATIONSHIP_CONFLICT_RESOLUTION_STATE_UNKNOWN")]
        RELATIONSHIP_CONFLICT_RESOLUTION_STATE_UNKNOWN


    } // enum RelationshipConflictResolutionState

} // namespace RubrikSecurityCloud.Types