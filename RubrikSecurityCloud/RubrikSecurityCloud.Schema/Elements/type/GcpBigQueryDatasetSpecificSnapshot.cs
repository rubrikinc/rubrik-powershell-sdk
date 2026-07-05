// GcpBigQueryDatasetSpecificSnapshot.cs
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
    #region GcpBigQueryDatasetSpecificSnapshot
 
    public class GcpBigQueryDatasetSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<GcpBigQueryTableSpecificSnapshot>? Tables
        // GraphQL -> tables: [GcpBigQueryTableSpecificSnapshot!]! (type)
        [JsonProperty("tables")]
        public List<GcpBigQueryTableSpecificSnapshot>? Tables { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpBigQueryDatasetSpecificSnapshot";
    }

    public GcpBigQueryDatasetSpecificSnapshot Set(
        System.String? SnapshotId = null,
        List<GcpBigQueryTableSpecificSnapshot>? Tables = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Tables != null ) {
            this.Tables = Tables;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> List<GcpBigQueryTableSpecificSnapshot>? Tables
        // GraphQL -> tables: [GcpBigQueryTableSpecificSnapshot!]! (type)
        if (this.Tables != null) {
            var fspec = this.Tables.AsFieldSpec(conf.Child("tables"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tables" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> List<GcpBigQueryTableSpecificSnapshot>? Tables
        // GraphQL -> tables: [GcpBigQueryTableSpecificSnapshot!]! (type)
        if (ec.Includes("tables",false))
        {
            if(this.Tables == null) {

                this.Tables = new List<GcpBigQueryTableSpecificSnapshot>();
                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            } else {

                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            }
        }
        else if (this.Tables != null && ec.Excludes("tables",false))
        {
            this.Tables = null;
        }
    }


    #endregion

    } // class GcpBigQueryDatasetSpecificSnapshot
    
    #endregion

    public static class ListGcpBigQueryDatasetSpecificSnapshotExtensions
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
            this List<GcpBigQueryDatasetSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpBigQueryDatasetSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpBigQueryDatasetSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpBigQueryDatasetSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpBigQueryDatasetSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types