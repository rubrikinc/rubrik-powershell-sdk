// PrincipalTagStats.cs
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
    #region PrincipalTagStats
    public class PrincipalTagStats: BaseType
    {
        #region members

        //      C# -> System.Int64? HumanCount
        // GraphQL -> humanCount: Long! (scalar)
        [JsonProperty("humanCount")]
        public System.Int64? HumanCount { get; set; }

        //      C# -> System.Int64? NonhumanCount
        // GraphQL -> nonhumanCount: Long! (scalar)
        [JsonProperty("nonhumanCount")]
        public System.Int64? NonhumanCount { get; set; }

        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalTagStats";
    }

    public PrincipalTagStats Set(
        System.Int64? HumanCount = null,
        System.Int64? NonhumanCount = null,
        System.Int64? TotalCount = null
    ) 
    {
        if ( HumanCount != null ) {
            this.HumanCount = HumanCount;
        }
        if ( NonhumanCount != null ) {
            this.NonhumanCount = NonhumanCount;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? HumanCount
        // GraphQL -> humanCount: Long! (scalar)
        if (this.HumanCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "humanCount\n" ;
            } else {
                s += ind + "humanCount\n" ;
            }
        }
        //      C# -> System.Int64? NonhumanCount
        // GraphQL -> nonhumanCount: Long! (scalar)
        if (this.NonhumanCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nonhumanCount\n" ;
            } else {
                s += ind + "nonhumanCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? HumanCount
        // GraphQL -> humanCount: Long! (scalar)
        if (ec.Includes("humanCount",true))
        {
            if(this.HumanCount == null) {

                this.HumanCount = new System.Int64();

            } else {


            }
        }
        else if (this.HumanCount != null && ec.Excludes("humanCount",true))
        {
            this.HumanCount = null;
        }
        //      C# -> System.Int64? NonhumanCount
        // GraphQL -> nonhumanCount: Long! (scalar)
        if (ec.Includes("nonhumanCount",true))
        {
            if(this.NonhumanCount == null) {

                this.NonhumanCount = new System.Int64();

            } else {


            }
        }
        else if (this.NonhumanCount != null && ec.Excludes("nonhumanCount",true))
        {
            this.NonhumanCount = null;
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
    }


    #endregion

    } // class PrincipalTagStats
    
    #endregion

    public static class ListPrincipalTagStatsExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PrincipalTagStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalTagStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalTagStats> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalTagStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalTagStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types