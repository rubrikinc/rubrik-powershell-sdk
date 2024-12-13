// AzureAdRelationshipRestoreModeEnumType.cs
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
    public enum AzureAdRelationshipRestoreModeEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MERGE")]
        MERGE,

        [EnumMember(Value = "RELATIONSHIP_RESTORE_MODE_UNSPECIFIED")]
        RELATIONSHIP_RESTORE_MODE_UNSPECIFIED,

        [EnumMember(Value = "ROLLBACK")]
        ROLLBACK,

        [EnumMember(Value = "SKIP")]
        SKIP


    } // enum AzureAdRelationshipRestoreModeEnumType

} // namespace RubrikSecurityCloud.Types