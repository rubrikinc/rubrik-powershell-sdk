// QueryArchivalLocationsEncryptionDetailsSortByField.cs
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
    public enum QueryArchivalLocationsEncryptionDetailsSortByField
    {
        [EnumMember(Value = "LOCATION_NAME")]
        LOCATION_NAME,

        [EnumMember(Value = "REKEY_STATUS")]
        REKEY_STATUS,

        [EnumMember(Value = "ROTATION_STATUS")]
        ROTATION_STATUS,

        [EnumMember(Value = "SORT_BY_FIELD_UNSPECIFIED")]
        SORT_BY_FIELD_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum QueryArchivalLocationsEncryptionDetailsSortByField

} // namespace RubrikSecurityCloud.Types