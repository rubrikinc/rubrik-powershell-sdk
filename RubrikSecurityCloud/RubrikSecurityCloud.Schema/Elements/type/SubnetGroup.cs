// SubnetGroup.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SubnetGroup
    public class SubnetGroup: BaseType
    {
        #region members

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> List<AwsNativeSubnet>? Subnets
        // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
        [JsonProperty("subnets")]
        public List<AwsNativeSubnet>? Subnets { get; set; }


        #endregion

    #region methods

    public SubnetGroup Set(
        System.String? Arn = null,
        System.String? Name = null,
        System.String? VpcId = null,
        List<AwsNativeSubnet>? Subnets = null
    ) 
    {
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( Subnets != null ) {
            this.Subnets = Subnets;
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
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            s += ind + "arn\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        //      C# -> List<AwsNativeSubnet>? Subnets
        // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
        if (this.Subnets != null) {
            s += ind + "subnets {\n" + this.Subnets.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn == null && Exploration.Includes(parent + ".arn", true))
        {
            this.Arn = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && Exploration.Includes(parent + ".vpcId", true))
        {
            this.VpcId = "FETCH";
        }
        //      C# -> List<AwsNativeSubnet>? Subnets
        // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
        if (this.Subnets == null && Exploration.Includes(parent + ".subnets"))
        {
            this.Subnets = new List<AwsNativeSubnet>();
            this.Subnets.ApplyExploratoryFieldSpec(parent + ".subnets");
        }
    }


    #endregion

    } // class SubnetGroup
    
    #endregion

    public static class ListSubnetGroupExtensions
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
            this List<SubnetGroup> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SubnetGroup> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SubnetGroup());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types