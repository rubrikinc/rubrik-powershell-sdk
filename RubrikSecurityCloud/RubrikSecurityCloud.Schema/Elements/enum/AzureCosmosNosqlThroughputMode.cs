// AzureCosmosNosqlThroughputMode.cs
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
    public enum AzureCosmosNosqlThroughputMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_AUTOSCALE")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_AUTOSCALE,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_MANUAL")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_MANUAL,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_SERVERLESS")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_SERVERLESS,

        [EnumMember(Value = "AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_UNSPECIFIED")]
        AZURE_COSMOS_NOSQL_THROUGHPUT_MODE_UNSPECIFIED


    } // enum AzureCosmosNosqlThroughputMode

} // namespace RubrikSecurityCloud.Types