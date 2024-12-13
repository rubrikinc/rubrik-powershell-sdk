// AzureOauthResource.cs
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
    public enum AzureOauthResource
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_RESOURCE_MANAGER")]
        AZURE_RESOURCE_MANAGER,

        [EnumMember(Value = "AZURE_SQL")]
        AZURE_SQL


    } // enum AzureOauthResource

} // namespace RubrikSecurityCloud.Types