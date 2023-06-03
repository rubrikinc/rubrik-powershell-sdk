// AwsVpc.cs
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
    #region AwsVpc
    public class AwsVpc: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<AwsSecurityGroup>? SecurityGroups
        // GraphQL -> securityGroups: [AwsSecurityGroup!]! (type)
        [JsonProperty("securityGroups")]
        public List<AwsSecurityGroup>? SecurityGroups { get; set; }

        //      C# -> List<AwsSubnet>? Subnets
        // GraphQL -> subnets: [AwsSubnet!]! (type)
        [JsonProperty("subnets")]
        public List<AwsSubnet>? Subnets { get; set; }


        #endregion

    #region methods

    public AwsVpc Set(
        System.String? Id = null,
        System.String? Name = null,
        List<AwsSecurityGroup>? SecurityGroups = null,
        List<AwsSubnet>? Subnets = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SecurityGroups != null ) {
            this.SecurityGroups = SecurityGroups;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<AwsSecurityGroup>? SecurityGroups
        // GraphQL -> securityGroups: [AwsSecurityGroup!]! (type)
        if (this.SecurityGroups != null) {
            s += ind + "securityGroups {\n" + this.SecurityGroups.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AwsSubnet>? Subnets
        // GraphQL -> subnets: [AwsSubnet!]! (type)
        if (this.Subnets != null) {
            s += ind + "subnets {\n" + this.Subnets.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> List<AwsSecurityGroup>? SecurityGroups
        // GraphQL -> securityGroups: [AwsSecurityGroup!]! (type)
        if (this.SecurityGroups == null && Exploration.Includes(parent + ".securityGroups"))
        {
            this.SecurityGroups = new List<AwsSecurityGroup>();
            this.SecurityGroups.ApplyExploratoryFieldSpec(parent + ".securityGroups");
        }
        //      C# -> List<AwsSubnet>? Subnets
        // GraphQL -> subnets: [AwsSubnet!]! (type)
        if (this.Subnets == null && Exploration.Includes(parent + ".subnets"))
        {
            this.Subnets = new List<AwsSubnet>();
            this.Subnets.ApplyExploratoryFieldSpec(parent + ".subnets");
        }
    }


    #endregion

    } // class AwsVpc
    
    #endregion

    public static class ListAwsVpcExtensions
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
            this List<AwsVpc> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsVpc> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsVpc());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types