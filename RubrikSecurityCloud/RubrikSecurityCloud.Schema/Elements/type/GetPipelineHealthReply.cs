// GetPipelineHealthReply.cs
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
    #region GetPipelineHealthReply
    public class GetPipelineHealthReply: BaseType
    {
        #region members

        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        [JsonProperty("failedAnalysis")]
        public System.Int64? FailedAnalysis { get; set; }

        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        [JsonProperty("failedBackup")]
        public System.Int64? FailedBackup { get; set; }

        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        [JsonProperty("failedIndexing")]
        public System.Int64? FailedIndexing { get; set; }

        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        [JsonProperty("totalAnalysis")]
        public System.Int64? TotalAnalysis { get; set; }

        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        [JsonProperty("totalBackup")]
        public System.Int64? TotalBackup { get; set; }

        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        [JsonProperty("totalIndexing")]
        public System.Int64? TotalIndexing { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPipelineHealthReply";
    }

    public GetPipelineHealthReply Set(
        System.Int64? FailedAnalysis = null,
        System.Int64? FailedBackup = null,
        System.Int64? FailedIndexing = null,
        System.Int64? TotalAnalysis = null,
        System.Int64? TotalBackup = null,
        System.Int64? TotalIndexing = null
    ) 
    {
        if ( FailedAnalysis != null ) {
            this.FailedAnalysis = FailedAnalysis;
        }
        if ( FailedBackup != null ) {
            this.FailedBackup = FailedBackup;
        }
        if ( FailedIndexing != null ) {
            this.FailedIndexing = FailedIndexing;
        }
        if ( TotalAnalysis != null ) {
            this.TotalAnalysis = TotalAnalysis;
        }
        if ( TotalBackup != null ) {
            this.TotalBackup = TotalBackup;
        }
        if ( TotalIndexing != null ) {
            this.TotalIndexing = TotalIndexing;
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
        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        if (this.FailedAnalysis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedAnalysis\n" ;
            } else {
                s += ind + "failedAnalysis\n" ;
            }
        }
        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        if (this.FailedBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedBackup\n" ;
            } else {
                s += ind + "failedBackup\n" ;
            }
        }
        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        if (this.FailedIndexing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedIndexing\n" ;
            } else {
                s += ind + "failedIndexing\n" ;
            }
        }
        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        if (this.TotalAnalysis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalAnalysis\n" ;
            } else {
                s += ind + "totalAnalysis\n" ;
            }
        }
        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        if (this.TotalBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalBackup\n" ;
            } else {
                s += ind + "totalBackup\n" ;
            }
        }
        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        if (this.TotalIndexing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalIndexing\n" ;
            } else {
                s += ind + "totalIndexing\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        if (ec.Includes("failedAnalysis",true))
        {
            if(this.FailedAnalysis == null) {

                this.FailedAnalysis = new System.Int64();

            } else {


            }
        }
        else if (this.FailedAnalysis != null && ec.Excludes("failedAnalysis",true))
        {
            this.FailedAnalysis = null;
        }
        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        if (ec.Includes("failedBackup",true))
        {
            if(this.FailedBackup == null) {

                this.FailedBackup = new System.Int64();

            } else {


            }
        }
        else if (this.FailedBackup != null && ec.Excludes("failedBackup",true))
        {
            this.FailedBackup = null;
        }
        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        if (ec.Includes("failedIndexing",true))
        {
            if(this.FailedIndexing == null) {

                this.FailedIndexing = new System.Int64();

            } else {


            }
        }
        else if (this.FailedIndexing != null && ec.Excludes("failedIndexing",true))
        {
            this.FailedIndexing = null;
        }
        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        if (ec.Includes("totalAnalysis",true))
        {
            if(this.TotalAnalysis == null) {

                this.TotalAnalysis = new System.Int64();

            } else {


            }
        }
        else if (this.TotalAnalysis != null && ec.Excludes("totalAnalysis",true))
        {
            this.TotalAnalysis = null;
        }
        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        if (ec.Includes("totalBackup",true))
        {
            if(this.TotalBackup == null) {

                this.TotalBackup = new System.Int64();

            } else {


            }
        }
        else if (this.TotalBackup != null && ec.Excludes("totalBackup",true))
        {
            this.TotalBackup = null;
        }
        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        if (ec.Includes("totalIndexing",true))
        {
            if(this.TotalIndexing == null) {

                this.TotalIndexing = new System.Int64();

            } else {


            }
        }
        else if (this.TotalIndexing != null && ec.Excludes("totalIndexing",true))
        {
            this.TotalIndexing = null;
        }
    }


    #endregion

    } // class GetPipelineHealthReply
    
    #endregion

    public static class ListGetPipelineHealthReplyExtensions
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
            this List<GetPipelineHealthReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPipelineHealthReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPipelineHealthReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPipelineHealthReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPipelineHealthReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types