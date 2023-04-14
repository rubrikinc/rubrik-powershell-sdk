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

namespace Rubrik.SecurityCloud.Types
{
    #region AwsComputeSettings
    public class AwsComputeSettings: IFragment
    {
        #region members
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

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount (interface)
        [JsonProperty("cloudAccount")]
        public CloudAccount? CloudAccount { get; set; }

        #endregion

    #region methods

    public AwsComputeSettings Set(
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsRscManaged = null,
        System.String? Name = null,
        System.String? SecurityGroupId = null,
        System.String? SubnetId = null,
        System.String? VpcId = null,
        List<ClusterInfCidrs>? ClusterInterfaceCidrs = null,
        ProxySettings? ProxySettings = null,
        AwsRegion? Region = null,
        CloudAccount? CloudAccount = null
    ) 
    {
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
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsRscManaged
            // GraphQL -> isRscManaged: Boolean! (scalar)
            if (this.IsRscManaged != null)
            {
                 s += ind + "isRscManaged\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? SecurityGroupId
            // GraphQL -> securityGroupId: String! (scalar)
            if (this.SecurityGroupId != null)
            {
                 s += ind + "securityGroupId\n";

            }
            //      C# -> System.String? SubnetId
            // GraphQL -> subnetId: String! (scalar)
            if (this.SubnetId != null)
            {
                 s += ind + "subnetId\n";

            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
            // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
            if (this.ClusterInterfaceCidrs != null)
            {
                 s += ind + "clusterInterfaceCidrs\n";

                 s += ind + "{\n" + 
                 this.ClusterInterfaceCidrs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ProxySettings? ProxySettings
            // GraphQL -> proxySettings: ProxySettings (type)
            if (this.ProxySettings != null)
            {
                 s += ind + "proxySettings\n";

                 s += ind + "{\n" + 
                 this.ProxySettings.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsRegion? Region
            // GraphQL -> region: AwsRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
                        //      C# -> CloudAccount? CloudAccount
            // GraphQL -> cloudAccount: CloudAccount (interface)
            if (this.CloudAccount != null)
            {
                s += ind + "cloudAccount\n";
                s += ind + "{\n";

                string typename = this.CloudAccount.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.CloudAccount.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRscManaged
            // GraphQL -> isRscManaged: Boolean! (scalar)
            if (this.IsRscManaged == null && Exploration.Includes(parent + ".isRscManaged$"))
            {
                this.IsRscManaged = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? SecurityGroupId
            // GraphQL -> securityGroupId: String! (scalar)
            if (this.SecurityGroupId == null && Exploration.Includes(parent + ".securityGroupId$"))
            {
                this.SecurityGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? SubnetId
            // GraphQL -> subnetId: String! (scalar)
            if (this.SubnetId == null && Exploration.Includes(parent + ".subnetId$"))
            {
                this.SubnetId = new System.String("FETCH");
            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
            //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
            // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
            if (this.ClusterInterfaceCidrs == null && Exploration.Includes(parent + ".clusterInterfaceCidrs"))
            {
                this.ClusterInterfaceCidrs = new List<ClusterInfCidrs>();
                this.ClusterInterfaceCidrs.ApplyExploratoryFragment(parent + ".clusterInterfaceCidrs");
            }
            //      C# -> ProxySettings? ProxySettings
            // GraphQL -> proxySettings: ProxySettings (type)
            if (this.ProxySettings == null && Exploration.Includes(parent + ".proxySettings"))
            {
                this.ProxySettings = new ProxySettings();
                this.ProxySettings.ApplyExploratoryFragment(parent + ".proxySettings");
            }
            //      C# -> AwsRegion? Region
            // GraphQL -> region: AwsRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AwsRegion();
            }
            //      C# -> CloudAccount? CloudAccount
            // GraphQL -> cloudAccount: CloudAccount (interface)
            if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount"))
            {
                this.CloudAccount = (CloudAccount)InterfaceHelper.CreateInstanceOfFirstType(typeof(CloudAccount));
                this.CloudAccount.ApplyExploratoryFragment(parent + ".cloudAccount");
            }
        }


    #endregion

    } // class AwsComputeSettings
    #endregion

    public static class ListAwsComputeSettingsExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AwsComputeSettings> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsComputeSettings> list, 
            String parent = "")
        {
            var item = new AwsComputeSettings();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types