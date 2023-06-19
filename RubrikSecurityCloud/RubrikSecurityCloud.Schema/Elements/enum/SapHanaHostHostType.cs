// SapHanaHostHostType.cs
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
    public enum SapHanaHostHostType
    {
        [EnumMember(Value = "SAP_HANA_HOST_HOST_TYPE_MASTER")]
        SAP_HANA_HOST_HOST_TYPE_MASTER,

        [EnumMember(Value = "SAP_HANA_HOST_HOST_TYPE_SECONDARY_MASTER")]
        SAP_HANA_HOST_HOST_TYPE_SECONDARY_MASTER,

        [EnumMember(Value = "SAP_HANA_HOST_HOST_TYPE_SECONDARY_SLAVE")]
        SAP_HANA_HOST_HOST_TYPE_SECONDARY_SLAVE,

        [EnumMember(Value = "SAP_HANA_HOST_HOST_TYPE_SLAVE")]
        SAP_HANA_HOST_HOST_TYPE_SLAVE


    } // enum SapHanaHostHostType

} // namespace RubrikSecurityCloud.Types