// AzureCosmosNosqlThroughputScope.cs
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
    public enum AzureCosmosNosqlThroughputScope
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_ACCOUNT")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_ACCOUNT,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_CONTAINER")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_CONTAINER,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_DATABASE")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_DATABASE,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_UNSPECIFIED")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_SCOPE_UNSPECIFIED


    } // enum AzureCosmosNosqlThroughputScope

} // namespace RubrikSecurityCloud.Types