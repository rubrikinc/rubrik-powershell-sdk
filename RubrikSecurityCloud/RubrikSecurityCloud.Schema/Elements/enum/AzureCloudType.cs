// AzureCloudType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    public enum AzureCloudType
    {
        [EnumMember(Value = "AZURECHINACLOUD")]
        AZURECHINACLOUD,

        [EnumMember(Value = "AZUREPUBLICCLOUD")]
        AZUREPUBLICCLOUD,

        [EnumMember(Value = "AZUREUSGOVERNMENTCLOUD")]
        AZUREUSGOVERNMENTCLOUD


    } // enum AzureCloudType

} // namespace Rubrik.SecurityCloud.Types