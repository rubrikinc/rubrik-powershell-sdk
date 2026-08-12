// TagConditionKeyPrefix.cs
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
    public enum TagConditionKeyPrefix
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "TAG_CONDITION_KEY_PREFIX_REQUEST_TAG")]
        TAG_CONDITION_KEY_PREFIX_REQUEST_TAG,

        [EnumMember(Value = "TAG_CONDITION_KEY_PREFIX_RESOURCE_TAG")]
        TAG_CONDITION_KEY_PREFIX_RESOURCE_TAG,

        [EnumMember(Value = "TAG_CONDITION_KEY_PREFIX_UNSPECIFIED")]
        TAG_CONDITION_KEY_PREFIX_UNSPECIFIED


    } // enum TagConditionKeyPrefix

} // namespace RubrikSecurityCloud.Types