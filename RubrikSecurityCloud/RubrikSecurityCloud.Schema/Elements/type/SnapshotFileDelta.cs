// SnapshotFileDelta.cs
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
    #region SnapshotFileDelta
    public class SnapshotFileDelta: BaseType
    {
        #region members

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        [JsonProperty("childrenDeltas")]
        public List<SnapshotDelta>? ChildrenDeltas { get; set; }

        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        [JsonProperty("file")]
        public SnapshotFile? File { get; set; }

        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        [JsonProperty("previousSnapshotQuarantineInfo")]
        public QuarantineInfo? PreviousSnapshotQuarantineInfo { get; set; }

        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        [JsonProperty("selfDeltas")]
        public List<SnapshotDelta>? SelfDeltas { get; set; }

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotFileDelta";
    }

    public SnapshotFileDelta Set(
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<SnapshotDelta>? ChildrenDeltas = null,
        SnapshotFile? File = null,
        QuarantineInfo? PreviousSnapshotQuarantineInfo = null,
        List<SnapshotDelta>? SelfDeltas = null,
        SensitiveHits? SensitiveHits = null
    ) 
    {
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( ChildrenDeltas != null ) {
            this.ChildrenDeltas = ChildrenDeltas;
        }
        if ( File != null ) {
            this.File = File;
        }
        if ( PreviousSnapshotQuarantineInfo != null ) {
            this.PreviousSnapshotQuarantineInfo = PreviousSnapshotQuarantineInfo;
        }
        if ( SelfDeltas != null ) {
            this.SelfDeltas = SelfDeltas;
        }
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
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
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(conf.Child("analyzerGroupResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerGroupResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (this.ChildrenDeltas != null) {
            var fspec = this.ChildrenDeltas.AsFieldSpec(conf.Child("childrenDeltas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childrenDeltas" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (this.File != null) {
            var fspec = this.File.AsFieldSpec(conf.Child("file"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "file" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (this.PreviousSnapshotQuarantineInfo != null) {
            var fspec = this.PreviousSnapshotQuarantineInfo.AsFieldSpec(conf.Child("previousSnapshotQuarantineInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previousSnapshotQuarantineInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (this.SelfDeltas != null) {
            var fspec = this.SelfDeltas.AsFieldSpec(conf.Child("selfDeltas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selfDeltas" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(conf.Child("sensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (ec.Includes("analyzerGroupResults",false))
        {
            if(this.AnalyzerGroupResults == null) {

                this.AnalyzerGroupResults = new List<AnalyzerGroupResult>();
                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            } else {

                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            }
        }
        else if (this.AnalyzerGroupResults != null && ec.Excludes("analyzerGroupResults",false))
        {
            this.AnalyzerGroupResults = null;
        }
        //      C# -> List<SnapshotDelta>? ChildrenDeltas
        // GraphQL -> childrenDeltas: [SnapshotDelta!]! (type)
        if (ec.Includes("childrenDeltas",false))
        {
            if(this.ChildrenDeltas == null) {

                this.ChildrenDeltas = new List<SnapshotDelta>();
                this.ChildrenDeltas.ApplyExploratoryFieldSpec(ec.NewChild("childrenDeltas"));

            } else {

                this.ChildrenDeltas.ApplyExploratoryFieldSpec(ec.NewChild("childrenDeltas"));

            }
        }
        else if (this.ChildrenDeltas != null && ec.Excludes("childrenDeltas",false))
        {
            this.ChildrenDeltas = null;
        }
        //      C# -> SnapshotFile? File
        // GraphQL -> file: SnapshotFile! (type)
        if (ec.Includes("file",false))
        {
            if(this.File == null) {

                this.File = new SnapshotFile();
                this.File.ApplyExploratoryFieldSpec(ec.NewChild("file"));

            } else {

                this.File.ApplyExploratoryFieldSpec(ec.NewChild("file"));

            }
        }
        else if (this.File != null && ec.Excludes("file",false))
        {
            this.File = null;
        }
        //      C# -> QuarantineInfo? PreviousSnapshotQuarantineInfo
        // GraphQL -> previousSnapshotQuarantineInfo: QuarantineInfo (type)
        if (ec.Includes("previousSnapshotQuarantineInfo",false))
        {
            if(this.PreviousSnapshotQuarantineInfo == null) {

                this.PreviousSnapshotQuarantineInfo = new QuarantineInfo();
                this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshotQuarantineInfo"));

            } else {

                this.PreviousSnapshotQuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshotQuarantineInfo"));

            }
        }
        else if (this.PreviousSnapshotQuarantineInfo != null && ec.Excludes("previousSnapshotQuarantineInfo",false))
        {
            this.PreviousSnapshotQuarantineInfo = null;
        }
        //      C# -> List<SnapshotDelta>? SelfDeltas
        // GraphQL -> selfDeltas: [SnapshotDelta!]! (type)
        if (ec.Includes("selfDeltas",false))
        {
            if(this.SelfDeltas == null) {

                this.SelfDeltas = new List<SnapshotDelta>();
                this.SelfDeltas.ApplyExploratoryFieldSpec(ec.NewChild("selfDeltas"));

            } else {

                this.SelfDeltas.ApplyExploratoryFieldSpec(ec.NewChild("selfDeltas"));

            }
        }
        else if (this.SelfDeltas != null && ec.Excludes("selfDeltas",false))
        {
            this.SelfDeltas = null;
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (ec.Includes("sensitiveHits",false))
        {
            if(this.SensitiveHits == null) {

                this.SensitiveHits = new SensitiveHits();
                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            } else {

                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            }
        }
        else if (this.SensitiveHits != null && ec.Excludes("sensitiveHits",false))
        {
            this.SensitiveHits = null;
        }
    }


    #endregion

    } // class SnapshotFileDelta
    
    #endregion

    public static class ListSnapshotFileDeltaExtensions
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
            this List<SnapshotFileDelta> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotFileDelta> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDelta> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDelta());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotFileDelta> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types