// AzureExocomputeGetConfigResponse.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureExocomputeGetConfigResponse
    public class AzureExocomputeGetConfigResponse: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        [JsonProperty("configUuid")]
        public System.String? ConfigUuid { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        [JsonProperty("podSubnetNativeId")]
        public System.String? PodSubnetNativeId { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        public ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeGetConfigResponse";
    }

    public AzureExocomputeGetConfigResponse Set(
        AzureCloudAccountRegion? Region = null,
        System.String? ConfigUuid = null,
        System.Boolean? IsRscManaged = null,
        System.String? Message = null,
        System.String? PodSubnetNativeId = null,
        System.String? SubnetNativeId = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ConfigUuid != null ) {
            this.ConfigUuid = ConfigUuid;
        }
        if ( IsRscManaged != null ) {
            this.IsRscManaged = IsRscManaged;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( PodSubnetNativeId != null ) {
            this.PodSubnetNativeId = PodSubnetNativeId;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
        }
        if ( HealthCheckStatus != null ) {
            this.HealthCheckStatus = HealthCheckStatus;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (this.ConfigUuid != null) {
            s += ind + "configUuid\n" ;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            s += ind + "isRscManaged\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId != null) {
            s += ind + "podSubnetNativeId\n" ;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            s += ind + "subnetNativeId\n" ;
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (this.HealthCheckStatus != null) {
            var fspec = this.HealthCheckStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "healthCheckStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AzureCloudAccountRegion();
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (this.ConfigUuid == null && ec.Includes("configUuid",true))
        {
            this.ConfigUuid = "FETCH";
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged == null && ec.Includes("isRscManaged",true))
        {
            this.IsRscManaged = true;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId == null && ec.Includes("podSubnetNativeId",true))
        {
            this.PodSubnetNativeId = "FETCH";
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId == null && ec.Includes("subnetNativeId",true))
        {
            this.SubnetNativeId = "FETCH";
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (this.HealthCheckStatus == null && ec.Includes("healthCheckStatus",false))
        {
            this.HealthCheckStatus = new ExocomputeHealthCheckStatus();
            this.HealthCheckStatus.ApplyExploratoryFieldSpec(ec.NewChild("healthCheckStatus"));
        }
    }


    #endregion

    } // class AzureExocomputeGetConfigResponse
    
    #endregion

    public static class ListAzureExocomputeGetConfigResponseExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureExocomputeGetConfigResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeGetConfigResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeGetConfigResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureExocomputeGetConfigResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types