// MigrationCustomerType.cs
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
    public enum MigrationCustomerType
    {
        [EnumMember(Value = "COMPLEX")]
        COMPLEX,

        [EnumMember(Value = "CUSTOMER_TYPE_UNSPECIFIED")]
        CUSTOMER_TYPE_UNSPECIFIED,

        [EnumMember(Value = "MEDIUM")]
        MEDIUM,

        [EnumMember(Value = "SIMPLE")]
        SIMPLE,

        [EnumMember(Value = "TPR")]
        TPR,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MigrationCustomerType

} // namespace RubrikSecurityCloud.Types