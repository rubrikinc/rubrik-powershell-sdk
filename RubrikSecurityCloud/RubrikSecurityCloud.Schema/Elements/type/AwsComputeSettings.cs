// AwsComputeSettings.cs
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
    #region AwsComputeSettings
    public class AwsComputeSettings: BaseType
    {
        #region members

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        [JsonProperty("cloudAccount")]
        public CloudAccount? CloudAccount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        [JsonProperty("clusterInterfaceCidrs")]
        public List<ClusterInfCidrs>? ClusterInterfaceCidrs { get; set; }

        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        [JsonProperty("proxySettings")]
        public ProxySettings? ProxySettings { get; set; }


        #endregion

    #region methods

    public AwsComputeSettings Set(
        AwsRegion? Region = null,
        CloudAccount? CloudAccount = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsRscManaged = null,
        System.String? Name = null,
        System.String? SecurityGroupId = null,
        System.String? SubnetId = null,
        System.String? VpcId = null,
        List<ClusterInfCidrs>? ClusterInterfaceCidrs = null,
        ProxySettings? ProxySettings = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsRscManaged != null ) {
            this.IsRscManaged = IsRscManaged;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SecurityGroupId != null ) {
            this.SecurityGroupId = SecurityGroupId;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( ClusterInterfaceCidrs != null ) {
            this.ClusterInterfaceCidrs = ClusterInterfaceCidrs;
        }
        if ( ProxySettings != null ) {
            this.ProxySettings = ProxySettings;
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
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            s += ind + "isRscManaged\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId != null) {
            s += ind + "securityGroupId\n" ;
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            s += ind + "subnetId\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (this.ClusterInterfaceCidrs != null) {
            var fspec = this.ClusterInterfaceCidrs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterInterfaceCidrs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AwsRegion();
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount"))
        {
            var impls = new List<CloudAccount>();
            impls.ApplyExploratoryFieldSpec(parent + ".cloudAccount");
            this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged == null && Exploration.Includes(parent + ".isRscManaged", true))
        {
            this.IsRscManaged = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId == null && Exploration.Includes(parent + ".securityGroupId", true))
        {
            this.SecurityGroupId = "FETCH";
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId == null && Exploration.Includes(parent + ".subnetId", true))
        {
            this.SubnetId = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && Exploration.Includes(parent + ".vpcId", true))
        {
            this.VpcId = "FETCH";
        }
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (this.ClusterInterfaceCidrs == null && Exploration.Includes(parent + ".clusterInterfaceCidrs"))
        {
            this.ClusterInterfaceCidrs = new List<ClusterInfCidrs>();
            this.ClusterInterfaceCidrs.ApplyExploratoryFieldSpec(parent + ".clusterInterfaceCidrs");
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings == null && Exploration.Includes(parent + ".proxySettings"))
        {
            this.ProxySettings = new ProxySettings();
            this.ProxySettings.ApplyExploratoryFieldSpec(parent + ".proxySettings");
        }
    }


    #endregion

    } // class AwsComputeSettings
    
    #endregion

    public static class ListAwsComputeSettingsExtensions
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
            this List<AwsComputeSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsComputeSettings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsComputeSettings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types