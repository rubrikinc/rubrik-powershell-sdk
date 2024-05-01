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
        public RscInterface<CloudAccount> CloudAccount { get; set; }

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

    public override string GetGqlTypeName() {
        return "AwsComputeSettings";
    }

    public AwsComputeSettings Set(
        AwsRegion? Region = null,
        RscInterface<CloudAccount> CloudAccount = null,
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        if (this.CloudAccount != null) {
            var fspec = this.CloudAccount.AsFieldSpec(conf.Child("cloudAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccount" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRscManaged\n" ;
            } else {
                s += ind + "isRscManaged\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityGroupId\n" ;
            } else {
                s += ind + "securityGroupId\n" ;
            }
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetId\n" ;
            } else {
                s += ind + "subnetId\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (this.ClusterInterfaceCidrs != null) {
            var fspec = this.ClusterInterfaceCidrs.AsFieldSpec(conf.Child("clusterInterfaceCidrs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterInterfaceCidrs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(conf.Child("proxySettings"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxySettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        if (ec.Includes("cloudAccount",false))
        {
            if(this.CloudAccount == null) {

                this.CloudAccount = new RscInterface<CloudAccount>();
                this.CloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));

            } else {

                this.CloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));

            }
        }
        else if (this.CloudAccount != null && ec.Excludes("cloudAccount",false))
        {
            this.CloudAccount = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (ec.Includes("isRscManaged",true))
        {
            if(this.IsRscManaged == null) {

                this.IsRscManaged = true;

            } else {


            }
        }
        else if (this.IsRscManaged != null && ec.Excludes("isRscManaged",true))
        {
            this.IsRscManaged = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (ec.Includes("securityGroupId",true))
        {
            if(this.SecurityGroupId == null) {

                this.SecurityGroupId = "FETCH";

            } else {


            }
        }
        else if (this.SecurityGroupId != null && ec.Excludes("securityGroupId",true))
        {
            this.SecurityGroupId = null;
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (ec.Includes("subnetId",true))
        {
            if(this.SubnetId == null) {

                this.SubnetId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetId != null && ec.Excludes("subnetId",true))
        {
            this.SubnetId = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (ec.Includes("clusterInterfaceCidrs",false))
        {
            if(this.ClusterInterfaceCidrs == null) {

                this.ClusterInterfaceCidrs = new List<ClusterInfCidrs>();
                this.ClusterInterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("clusterInterfaceCidrs"));

            } else {

                this.ClusterInterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("clusterInterfaceCidrs"));

            }
        }
        else if (this.ClusterInterfaceCidrs != null && ec.Excludes("clusterInterfaceCidrs",false))
        {
            this.ClusterInterfaceCidrs = null;
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (ec.Includes("proxySettings",false))
        {
            if(this.ProxySettings == null) {

                this.ProxySettings = new ProxySettings();
                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            } else {

                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            }
        }
        else if (this.ProxySettings != null && ec.Excludes("proxySettings",false))
        {
            this.ProxySettings = null;
        }
    }


    #endregion

    } // class AwsComputeSettings
    
    #endregion

    public static class ListAwsComputeSettingsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsComputeSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsComputeSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsComputeSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsComputeSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsComputeSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types