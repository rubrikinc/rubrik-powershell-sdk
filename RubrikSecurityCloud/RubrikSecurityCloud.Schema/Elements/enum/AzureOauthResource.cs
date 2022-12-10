// AzureOauthResource.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:21.
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
    public enum AzureOauthResource
    {
        [EnumMember(Value = "AZURE_RESOURCE_MANAGER")]
        AZURE_RESOURCE_MANAGER,

        [EnumMember(Value = "AZURE_SQL")]
        AZURE_SQL


    } // enum AzureOauthResource

} // namespace Rubrik.SecurityCloud.Types