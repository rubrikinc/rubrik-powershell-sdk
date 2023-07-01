// Ec2InstanceNic.cs
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
    #region Ec2InstanceNic
    public class Ec2InstanceNic: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        [JsonProperty("secGroup")]
        public SnappableSecurityGroup? SecGroup { get; set; }

        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        [JsonProperty("subnet")]
        public SnappableSubnet? Subnet { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ec2InstanceNic";
    }

    public Ec2InstanceNic Set(
        System.String? Key = null,
        SnappableSecurityGroup? SecGroup = null,
        SnappableSubnet? Subnet = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( SecGroup != null ) {
            this.SecGroup = SecGroup;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        if (this.SecGroup != null) {
            var fspec = this.SecGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        if (this.Subnet != null) {
            var fspec = this.Subnet.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subnet {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = "FETCH";
        }
        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        if (this.SecGroup == null && Exploration.Includes(parent + ".secGroup"))
        {
            this.SecGroup = new SnappableSecurityGroup();
            this.SecGroup.ApplyExploratoryFieldSpec(parent + ".secGroup");
        }
        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        if (this.Subnet == null && Exploration.Includes(parent + ".subnet"))
        {
            this.Subnet = new SnappableSubnet();
            this.Subnet.ApplyExploratoryFieldSpec(parent + ".subnet");
        }
    }


    #endregion

    } // class Ec2InstanceNic
    
    #endregion

    public static class ListEc2InstanceNicExtensions
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
            this List<Ec2InstanceNic> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Ec2InstanceNic> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Ec2InstanceNic());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types