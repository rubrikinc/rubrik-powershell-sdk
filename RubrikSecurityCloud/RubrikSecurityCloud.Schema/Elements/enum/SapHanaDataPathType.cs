// SapHanaDataPathType.cs
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
    public enum SapHanaDataPathType
    {
        [EnumMember(Value = "SAP_HANA_DATA_PATH_TYPE_GCP")]
        SAP_HANA_DATA_PATH_TYPE_GCP,

        [EnumMember(Value = "SAP_HANA_DATA_PATH_TYPE_LOCAL")]
        SAP_HANA_DATA_PATH_TYPE_LOCAL,

        [EnumMember(Value = "SAP_HANA_DATA_PATH_TYPE_MANAGED_VOLUME")]
        SAP_HANA_DATA_PATH_TYPE_MANAGED_VOLUME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SapHanaDataPathType

} // namespace RubrikSecurityCloud.Types