// OracleRecoverableRangeMinimal.cs
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
    #region OracleRecoverableRangeMinimal
    public class OracleRecoverableRangeMinimal: BaseType
    {
        #region members

        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> List<BasicOracleSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [BasicOracleSnapshotSummary!]! (type)
        [JsonProperty("dbSnapshotSummaries")]
        public List<BasicOracleSnapshotSummary>? DbSnapshotSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleRecoverableRangeMinimal";
    }

    public OracleRecoverableRangeMinimal Set(
        DateTime? BeginTime = null,
        DateTime? EndTime = null,
        List<BasicOracleSnapshotSummary>? DbSnapshotSummaries = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( DbSnapshotSummaries != null ) {
            this.DbSnapshotSummaries = DbSnapshotSummaries;
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
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        if (this.BeginTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "beginTime\n" ;
            } else {
                s += ind + "beginTime\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> List<BasicOracleSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [BasicOracleSnapshotSummary!]! (type)
        if (this.DbSnapshotSummaries != null) {
            var fspec = this.DbSnapshotSummaries.AsFieldSpec(conf.Child("dbSnapshotSummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dbSnapshotSummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        if (ec.Includes("beginTime",true))
        {
            if(this.BeginTime == null) {

                this.BeginTime = new DateTime();

            } else {


            }
        }
        else if (this.BeginTime != null && ec.Excludes("beginTime",true))
        {
            this.BeginTime = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> List<BasicOracleSnapshotSummary>? DbSnapshotSummaries
        // GraphQL -> dbSnapshotSummaries: [BasicOracleSnapshotSummary!]! (type)
        if (ec.Includes("dbSnapshotSummaries",false))
        {
            if(this.DbSnapshotSummaries == null) {

                this.DbSnapshotSummaries = new List<BasicOracleSnapshotSummary>();
                this.DbSnapshotSummaries.ApplyExploratoryFieldSpec(ec.NewChild("dbSnapshotSummaries"));

            } else {

                this.DbSnapshotSummaries.ApplyExploratoryFieldSpec(ec.NewChild("dbSnapshotSummaries"));

            }
        }
        else if (this.DbSnapshotSummaries != null && ec.Excludes("dbSnapshotSummaries",false))
        {
            this.DbSnapshotSummaries = null;
        }
    }


    #endregion

    } // class OracleRecoverableRangeMinimal
    
    #endregion

    public static class ListOracleRecoverableRangeMinimalExtensions
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
            this List<OracleRecoverableRangeMinimal> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleRecoverableRangeMinimal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleRecoverableRangeMinimal> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRecoverableRangeMinimal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleRecoverableRangeMinimal> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types