// StorageAccountContainersSortByField.cs
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
    public enum StorageAccountContainersSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LAST_MODIFIED_TIME")]
        LAST_MODIFIED_TIME,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum StorageAccountContainersSortByField

} // namespace RubrikSecurityCloud.Types