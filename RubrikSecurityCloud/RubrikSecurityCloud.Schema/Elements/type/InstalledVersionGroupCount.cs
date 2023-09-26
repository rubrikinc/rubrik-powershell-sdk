// InstalledVersionGroupCount.cs
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
    #region InstalledVersionGroupCount
    public class InstalledVersionGroupCount: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [JsonProperty("group")]
        public System.String? Group { get; set; }

        //      C# -> System.Boolean? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
        [JsonProperty("isUpgradeRecommended")]
        public System.Boolean? IsUpgradeRecommended { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InstalledVersionGroupCount";
    }

    public InstalledVersionGroupCount Set(
        System.Int32? Count = null,
        System.String? Group = null,
        System.Boolean? IsUpgradeRecommended = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( IsUpgradeRecommended != null ) {
            this.IsUpgradeRecommended = IsUpgradeRecommended;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (this.Group != null) {
            if (conf.Flat) {
                s += conf.Prefix + "group\n" ;
            } else {
                s += ind + "group\n" ;
            }
        }
        //      C# -> System.Boolean? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
        if (this.IsUpgradeRecommended != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUpgradeRecommended\n" ;
            } else {
                s += ind + "isUpgradeRecommended\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (ec.Includes("group",true))
        {
            if(this.Group == null) {

                this.Group = "FETCH";

            } else {


            }
        }
        else if (this.Group != null && ec.Excludes("group",true))
        {
            this.Group = null;
        }
        //      C# -> System.Boolean? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
        if (ec.Includes("isUpgradeRecommended",true))
        {
            if(this.IsUpgradeRecommended == null) {

                this.IsUpgradeRecommended = true;

            } else {


            }
        }
        else if (this.IsUpgradeRecommended != null && ec.Excludes("isUpgradeRecommended",true))
        {
            this.IsUpgradeRecommended = null;
        }
    }


    #endregion

    } // class InstalledVersionGroupCount
    
    #endregion

    public static class ListInstalledVersionGroupCountExtensions
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
            this List<InstalledVersionGroupCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<InstalledVersionGroupCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InstalledVersionGroupCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InstalledVersionGroupCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types