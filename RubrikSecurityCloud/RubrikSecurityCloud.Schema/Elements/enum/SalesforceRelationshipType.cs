// SalesforceRelationshipType.cs
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
    public enum SalesforceRelationshipType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LOOKUP")]
        LOOKUP,

        [EnumMember(Value = "MASTER_DETAIL")]
        MASTER_DETAIL


    } // enum SalesforceRelationshipType

} // namespace RubrikSecurityCloud.Types