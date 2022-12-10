// AwsExocomputeGetConfigResponse.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:26.
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
    #region AwsExocomputeGetConfigResponse
    public class AwsExocomputeGetConfigResponse: IFragment
    {
        #region members
        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        [JsonProperty("areSecurityGroupsRscManaged")]
        public System.Boolean? AreSecurityGroupsRscManaged { get; set; }

        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        [JsonProperty("clusterSecurityGroupId")]
        public System.String? ClusterSecurityGroupId { get; set; }

        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        [JsonProperty("configUuid")]
        public System.String? ConfigUuid { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        [JsonProperty("nodeSecurityGroupId")]
        public System.String? NodeSecurityGroupId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        public ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }

        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        [JsonProperty("subnet1")]
        public AwsExocomputeSubnetType? Subnet1 { get; set; }

        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        [JsonProperty("subnet2")]
        public AwsExocomputeSubnetType? Subnet2 { get; set; }

        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AwsCloudAccountRegion? Region { get; set; }

        #endregion

    #region methods

    public AwsExocomputeGetConfigResponse Set(
        System.Boolean? AreSecurityGroupsRscManaged = null,
        System.String? ClusterSecurityGroupId = null,
        System.String? ConfigUuid = null,
        System.String? Message = null,
        System.String? NodeSecurityGroupId = null,
        System.String? VpcId = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null,
        AwsExocomputeSubnetType? Subnet1 = null,
        AwsExocomputeSubnetType? Subnet2 = null,
        AwsCloudAccountRegion? Region = null
    ) 
    {
        if ( AreSecurityGroupsRscManaged != null ) {
            this.AreSecurityGroupsRscManaged = AreSecurityGroupsRscManaged;
        }
        if ( ClusterSecurityGroupId != null ) {
            this.ClusterSecurityGroupId = ClusterSecurityGroupId;
        }
        if ( ConfigUuid != null ) {
            this.ConfigUuid = ConfigUuid;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( NodeSecurityGroupId != null ) {
            this.NodeSecurityGroupId = NodeSecurityGroupId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( HealthCheckStatus != null ) {
            this.HealthCheckStatus = HealthCheckStatus;
        }
        if ( Subnet1 != null ) {
            this.Subnet1 = Subnet1;
        }
        if ( Subnet2 != null ) {
            this.Subnet2 = Subnet2;
        }
        if ( Region != null ) {
            this.Region = Region;
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
            //      C# -> System.Boolean? AreSecurityGroupsRscManaged
            // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
            if (this.AreSecurityGroupsRscManaged != null)
            {
                 s += ind + "areSecurityGroupsRscManaged\n";

            }
            //      C# -> System.String? ClusterSecurityGroupId
            // GraphQL -> clusterSecurityGroupId: String! (scalar)
            if (this.ClusterSecurityGroupId != null)
            {
                 s += ind + "clusterSecurityGroupId\n";

            }
            //      C# -> System.String? ConfigUuid
            // GraphQL -> configUuid: String! (scalar)
            if (this.ConfigUuid != null)
            {
                 s += ind + "configUuid\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.String? NodeSecurityGroupId
            // GraphQL -> nodeSecurityGroupId: String! (scalar)
            if (this.NodeSecurityGroupId != null)
            {
                 s += ind + "nodeSecurityGroupId\n";

            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
            // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
            if (this.HealthCheckStatus != null)
            {
                 s += ind + "healthCheckStatus\n";

                 s += ind + "{\n" + 
                 this.HealthCheckStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsExocomputeSubnetType? Subnet1
            // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
            if (this.Subnet1 != null)
            {
                 s += ind + "subnet1\n";

                 s += ind + "{\n" + 
                 this.Subnet1.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsExocomputeSubnetType? Subnet2
            // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
            if (this.Subnet2 != null)
            {
                 s += ind + "subnet2\n";

                 s += ind + "{\n" + 
                 this.Subnet2.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsCloudAccountRegion? Region
            // GraphQL -> region: AwsCloudAccountRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? AreSecurityGroupsRscManaged
            // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
            if (this.AreSecurityGroupsRscManaged == null && Exploration.Includes(parent + ".areSecurityGroupsRscManaged$"))
            {
                this.AreSecurityGroupsRscManaged = new System.Boolean();
            }
            //      C# -> System.String? ClusterSecurityGroupId
            // GraphQL -> clusterSecurityGroupId: String! (scalar)
            if (this.ClusterSecurityGroupId == null && Exploration.Includes(parent + ".clusterSecurityGroupId$"))
            {
                this.ClusterSecurityGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? ConfigUuid
            // GraphQL -> configUuid: String! (scalar)
            if (this.ConfigUuid == null && Exploration.Includes(parent + ".configUuid$"))
            {
                this.ConfigUuid = new System.String("FETCH");
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.String? NodeSecurityGroupId
            // GraphQL -> nodeSecurityGroupId: String! (scalar)
            if (this.NodeSecurityGroupId == null && Exploration.Includes(parent + ".nodeSecurityGroupId$"))
            {
                this.NodeSecurityGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
            //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
            // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
            if (this.HealthCheckStatus == null && Exploration.Includes(parent + ".healthCheckStatus"))
            {
                this.HealthCheckStatus = new ExocomputeHealthCheckStatus();
                this.HealthCheckStatus.ApplyExploratoryFragment(parent + ".healthCheckStatus");
            }
            //      C# -> AwsExocomputeSubnetType? Subnet1
            // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
            if (this.Subnet1 == null && Exploration.Includes(parent + ".subnet1"))
            {
                this.Subnet1 = new AwsExocomputeSubnetType();
                this.Subnet1.ApplyExploratoryFragment(parent + ".subnet1");
            }
            //      C# -> AwsExocomputeSubnetType? Subnet2
            // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
            if (this.Subnet2 == null && Exploration.Includes(parent + ".subnet2"))
            {
                this.Subnet2 = new AwsExocomputeSubnetType();
                this.Subnet2.ApplyExploratoryFragment(parent + ".subnet2");
            }
            //      C# -> AwsCloudAccountRegion? Region
            // GraphQL -> region: AwsCloudAccountRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AwsCloudAccountRegion();
            }
        }


    #endregion

    } // class AwsExocomputeGetConfigResponse
    #endregion

    public static class ListAwsExocomputeGetConfigResponseExtensions
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
            this List<AwsExocomputeGetConfigResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsExocomputeGetConfigResponse> list, 
            String parent = "")
        {
            var item = new AwsExocomputeGetConfigResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types