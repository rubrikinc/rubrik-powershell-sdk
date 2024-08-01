// RpoLagInfo.cs
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
    #region RpoLagInfo
    public class RpoLagInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        [JsonProperty("actualInSecs")]
        public System.Int64? ActualInSecs { get; set; }

        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        [JsonProperty("expectedInSecs")]
        public System.Int64? ExpectedInSecs { get; set; }

        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        [JsonProperty("level")]
        public System.String? Level { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RpoLagInfo";
    }

    public RpoLagInfo Set(
        System.Int64? ActualInSecs = null,
        System.Int64? ExpectedInSecs = null,
        System.String? Level = null
    ) 
    {
        if ( ActualInSecs != null ) {
            this.ActualInSecs = ActualInSecs;
        }
        if ( ExpectedInSecs != null ) {
            this.ExpectedInSecs = ExpectedInSecs;
        }
        if ( Level != null ) {
            this.Level = Level;
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
        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        if (this.ActualInSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actualInSecs\n" ;
            } else {
                s += ind + "actualInSecs\n" ;
            }
        }
        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        if (this.ExpectedInSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expectedInSecs\n" ;
            } else {
                s += ind + "expectedInSecs\n" ;
            }
        }
        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        if (this.Level != null) {
            if (conf.Flat) {
                s += conf.Prefix + "level\n" ;
            } else {
                s += ind + "level\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ActualInSecs
        // GraphQL -> actualInSecs: Long! (scalar)
        if (ec.Includes("actualInSecs",true))
        {
            if(this.ActualInSecs == null) {

                this.ActualInSecs = new System.Int64();

            } else {


            }
        }
        else if (this.ActualInSecs != null && ec.Excludes("actualInSecs",true))
        {
            this.ActualInSecs = null;
        }
        //      C# -> System.Int64? ExpectedInSecs
        // GraphQL -> expectedInSecs: Long! (scalar)
        if (ec.Includes("expectedInSecs",true))
        {
            if(this.ExpectedInSecs == null) {

                this.ExpectedInSecs = new System.Int64();

            } else {


            }
        }
        else if (this.ExpectedInSecs != null && ec.Excludes("expectedInSecs",true))
        {
            this.ExpectedInSecs = null;
        }
        //      C# -> System.String? Level
        // GraphQL -> level: String! (scalar)
        if (ec.Includes("level",true))
        {
            if(this.Level == null) {

                this.Level = "FETCH";

            } else {


            }
        }
        else if (this.Level != null && ec.Excludes("level",true))
        {
            this.Level = null;
        }
    }


    #endregion

    } // class RpoLagInfo
    
    #endregion

    public static class ListRpoLagInfoExtensions
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
            this List<RpoLagInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RpoLagInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RpoLagInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RpoLagInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RpoLagInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types