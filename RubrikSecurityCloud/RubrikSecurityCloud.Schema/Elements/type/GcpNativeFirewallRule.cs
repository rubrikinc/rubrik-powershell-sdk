// GcpNativeFirewallRule.cs
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
    #region GcpNativeFirewallRule
    public class GcpNativeFirewallRule: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? TargetTags
        // GraphQL -> targetTags: [String!]! (scalar)
        [JsonProperty("targetTags")]
        public List<System.String>? TargetTags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeFirewallRule";
    }

    public GcpNativeFirewallRule Set(
        System.String? Name = null,
        List<System.String>? TargetTags = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TargetTags != null ) {
            this.TargetTags = TargetTags;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<System.String>? TargetTags
        // GraphQL -> targetTags: [String!]! (scalar)
        if (this.TargetTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetTags\n" ;
            } else {
                s += ind + "targetTags\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<System.String>? TargetTags
        // GraphQL -> targetTags: [String!]! (scalar)
        if (ec.Includes("targetTags",true))
        {
            if(this.TargetTags == null) {

                this.TargetTags = new List<System.String>();

            } else {


            }
        }
        else if (this.TargetTags != null && ec.Excludes("targetTags",true))
        {
            this.TargetTags = null;
        }
    }


    #endregion

    } // class GcpNativeFirewallRule
    
    #endregion

    public static class ListGcpNativeFirewallRuleExtensions
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
            this List<GcpNativeFirewallRule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeFirewallRule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeFirewallRule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeFirewallRule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types