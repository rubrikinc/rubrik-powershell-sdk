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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "AwsVpc";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> List<AwsSecurityGroup>? SecurityGroups
        // GraphQL -> securityGroups: [AwsSecurityGroup!]! (type)
        if (this.SecurityGroups != null) {
            var fspec = this.SecurityGroups.AsFieldSpec(conf.Child("securityGroups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "securityGroups {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsSubnet>? Subnets
        // GraphQL -> subnets: [AwsSubnet!]! (type)
        if (this.Subnets != null) {
            var fspec = this.Subnets.AsFieldSpec(conf.Child("subnets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnets {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<AwsSecurityGroup>? SecurityGroups
        // GraphQL -> securityGroups: [AwsSecurityGroup!]! (type)
        if (ec.Includes("securityGroups",false))
        {
            if(this.SecurityGroups == null) {

                this.SecurityGroups = new List<AwsSecurityGroup>();
                this.SecurityGroups.ApplyExploratoryFieldSpec(ec.NewChild("securityGroups"));

            } else {

                this.SecurityGroups.ApplyExploratoryFieldSpec(ec.NewChild("securityGroups"));

            }
        }
        else if (this.SecurityGroups != null && ec.Excludes("securityGroups",false))
        {
            this.SecurityGroups = null;
        }
        //      C# -> List<AwsSubnet>? Subnets
        // GraphQL -> subnets: [AwsSubnet!]! (type)
        if (ec.Includes("subnets",false))
        {
            if(this.Subnets == null) {

                this.Subnets = new List<AwsSubnet>();
                this.Subnets.ApplyExploratoryFieldSpec(ec.NewChild("subnets"));

            } else {

                this.Subnets.ApplyExploratoryFieldSpec(ec.NewChild("subnets"));

            }
        }
        else if (this.Subnets != null && ec.Excludes("subnets",false))
        {
            this.Subnets = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsVpc> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsVpc());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsVpc> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types