// TprPolicySortByField.cs
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
    public enum TprPolicySortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NUMBER_OF_ACTIONS")]
        NUMBER_OF_ACTIONS,

        [EnumMember(Value = "NUMBER_OF_OBJECT_TYPES")]
        NUMBER_OF_OBJECT_TYPES,

        [EnumMember(Value = "NUMBER_OF_PROTECTABLE_OBJECTS")]
        NUMBER_OF_PROTECTABLE_OBJECTS,

        [EnumMember(Value = "POLICY_NAME")]
        POLICY_NAME


    } // enum TprPolicySortByField

} // namespace RubrikSecurityCloud.Types