// GetObjectPauseListSortByField.cs
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
    public enum GetObjectPauseListSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GET_OBJECT_LIST_SORT_BY_PARAMS_UNSPECIFIED")]
        GET_OBJECT_LIST_SORT_BY_PARAMS_UNSPECIFIED,

        [EnumMember(Value = "PAUSE_SINCE")]
        PAUSE_SINCE


    } // enum GetObjectPauseListSortByField

} // namespace RubrikSecurityCloud.Types