// LineChangeSummary.cs
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
    #region LineChangeSummary
    public class LineChangeSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? Added
        // GraphQL -> added: Long! (scalar)
        [JsonProperty("added")]
        public System.Int64? Added { get; set; }

        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        [JsonProperty("deleted")]
        public System.Int64? Deleted { get; set; }

        //      C# -> System.Int64? Modified
        // GraphQL -> modified: Long! (scalar)
        [JsonProperty("modified")]
        public System.Int64? Modified { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LineChangeSummary";
    }

    public LineChangeSummary Set(
        System.Int64? Added = null,
        System.Int64? Deleted = null,
        System.Int64? Modified = null
    ) 
    {
        if ( Added != null ) {
            this.Added = Added;
        }
        if ( Deleted != null ) {
            this.Deleted = Deleted;
        }
        if ( Modified != null ) {
            this.Modified = Modified;
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
        //      C# -> System.Int64? Added
        // GraphQL -> added: Long! (scalar)
        if (this.Added != null) {
            if (conf.Flat) {
                s += conf.Prefix + "added\n" ;
            } else {
                s += ind + "added\n" ;
            }
        }
        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        if (this.Deleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deleted\n" ;
            } else {
                s += ind + "deleted\n" ;
            }
        }
        //      C# -> System.Int64? Modified
        // GraphQL -> modified: Long! (scalar)
        if (this.Modified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modified\n" ;
            } else {
                s += ind + "modified\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Added
        // GraphQL -> added: Long! (scalar)
        if (ec.Includes("added",true))
        {
            if(this.Added == null) {

                this.Added = new System.Int64();

            } else {


            }
        }
        else if (this.Added != null && ec.Excludes("added",true))
        {
            this.Added = null;
        }
        //      C# -> System.Int64? Deleted
        // GraphQL -> deleted: Long! (scalar)
        if (ec.Includes("deleted",true))
        {
            if(this.Deleted == null) {

                this.Deleted = new System.Int64();

            } else {


            }
        }
        else if (this.Deleted != null && ec.Excludes("deleted",true))
        {
            this.Deleted = null;
        }
        //      C# -> System.Int64? Modified
        // GraphQL -> modified: Long! (scalar)
        if (ec.Includes("modified",true))
        {
            if(this.Modified == null) {

                this.Modified = new System.Int64();

            } else {


            }
        }
        else if (this.Modified != null && ec.Excludes("modified",true))
        {
            this.Modified = null;
        }
    }


    #endregion

    } // class LineChangeSummary
    
    #endregion

    public static class ListLineChangeSummaryExtensions
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
            this List<LineChangeSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LineChangeSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LineChangeSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LineChangeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LineChangeSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types