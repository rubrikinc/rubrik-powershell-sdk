// SapHanaHostHostType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
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

} // namespace Rubrik.SecurityCloud.Types