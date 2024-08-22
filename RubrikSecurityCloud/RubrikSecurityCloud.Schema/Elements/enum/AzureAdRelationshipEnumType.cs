// AzureAdRelationshipEnumType.cs
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
    public enum AzureAdRelationshipEnumType
    {
        [EnumMember(Value = "MEMBER")]
        MEMBER,

        [EnumMember(Value = "OWNER")]
        OWNER,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureAdRelationshipEnumType

} // namespace RubrikSecurityCloud.Types