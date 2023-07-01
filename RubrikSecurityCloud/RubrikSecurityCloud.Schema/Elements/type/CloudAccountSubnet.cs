// CloudAccountSubnet.cs
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
    #region CloudAccountSubnet
    public class CloudAccountSubnet: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        [JsonProperty("cidrBlock")]
        public CloudAccountAddressBlockV4? CidrBlock { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountSubnet";
    }

    public CloudAccountSubnet Set(
        System.String? AvailabilityZone = null,
        System.String? Name = null,
        System.String? SubnetId = null,
        System.String? VpcId = null,
        CloudAccountAddressBlockV4? CidrBlock = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( CidrBlock != null ) {
            this.CidrBlock = CidrBlock;
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
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            s += ind + "availabilityZone\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
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
        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        if (this.CidrBlock != null) {
            var fspec = this.CidrBlock.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cidrBlock {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone", true))
        {
            this.AvailabilityZone = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
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
        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        if (this.CidrBlock == null && Exploration.Includes(parent + ".cidrBlock"))
        {
            this.CidrBlock = new CloudAccountAddressBlockV4();
            this.CidrBlock.ApplyExploratoryFieldSpec(parent + ".cidrBlock");
        }
    }


    #endregion

    } // class CloudAccountSubnet
    
    #endregion

    public static class ListCloudAccountSubnetExtensions
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
            this List<CloudAccountSubnet> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountSubnet> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountSubnet());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types