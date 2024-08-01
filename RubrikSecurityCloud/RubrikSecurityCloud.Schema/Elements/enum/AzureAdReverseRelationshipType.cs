// AzureAdReverseRelationshipType.cs
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
    public enum AzureAdReverseRelationshipType
    {
        [EnumMember(Value = "MEMBER_OF")]
        MEMBER_OF,

        [EnumMember(Value = "OWNER_OF")]
        OWNER_OF,

        [EnumMember(Value = "REVERSE_RELATIONSHIP_TYPE_UNKNOWN")]
        REVERSE_RELATIONSHIP_TYPE_UNKNOWN,

        [EnumMember(Value = "ROLE_ASSIGNMENT_OF")]
        ROLE_ASSIGNMENT_OF,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureAdReverseRelationshipType

} // namespace RubrikSecurityCloud.Types