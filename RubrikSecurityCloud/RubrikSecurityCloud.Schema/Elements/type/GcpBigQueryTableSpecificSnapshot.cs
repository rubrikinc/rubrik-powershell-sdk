// GcpBigQueryTableSpecificSnapshot.cs
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
    #region GcpBigQueryTableSpecificSnapshot
    public class GcpBigQueryTableSpecificSnapshot: BaseType
    {
        #region members

        //      C# -> GcpBigQueryTableType? TableType
        // GraphQL -> tableType: GcpBigQueryTableType! (enum)
        [JsonProperty("tableType")]
        public GcpBigQueryTableType? TableType { get; set; }

        //      C# -> System.Int64? LogicalSizeBytes
        // GraphQL -> logicalSizeBytes: Long! (scalar)
        [JsonProperty("logicalSizeBytes")]
        public System.Int64? LogicalSizeBytes { get; set; }

        //      C# -> System.String? TableId
        // GraphQL -> tableId: String! (scalar)
        [JsonProperty("tableId")]
        public System.String? TableId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpBigQueryTableSpecificSnapshot";
    }

    public GcpBigQueryTableSpecificSnapshot Set(
        GcpBigQueryTableType? TableType = null,
        System.Int64? LogicalSizeBytes = null,
        System.String? TableId = null
    ) 
    {
        if ( TableType != null ) {
            this.TableType = TableType;
        }
        if ( LogicalSizeBytes != null ) {
            this.LogicalSizeBytes = LogicalSizeBytes;
        }
        if ( TableId != null ) {
            this.TableId = TableId;
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
        //      C# -> GcpBigQueryTableType? TableType
        // GraphQL -> tableType: GcpBigQueryTableType! (enum)
        if (this.TableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tableType\n" ;
            } else {
                s += ind + "tableType\n" ;
            }
        }
        //      C# -> System.Int64? LogicalSizeBytes
        // GraphQL -> logicalSizeBytes: Long! (scalar)
        if (this.LogicalSizeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalSizeBytes\n" ;
            } else {
                s += ind + "logicalSizeBytes\n" ;
            }
        }
        //      C# -> System.String? TableId
        // GraphQL -> tableId: String! (scalar)
        if (this.TableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tableId\n" ;
            } else {
                s += ind + "tableId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GcpBigQueryTableType? TableType
        // GraphQL -> tableType: GcpBigQueryTableType! (enum)
        if (ec.Includes("tableType",true))
        {
            if(this.TableType == null) {

                this.TableType = new GcpBigQueryTableType();

            } else {


            }
        }
        else if (this.TableType != null && ec.Excludes("tableType",true))
        {
            this.TableType = null;
        }
        //      C# -> System.Int64? LogicalSizeBytes
        // GraphQL -> logicalSizeBytes: Long! (scalar)
        if (ec.Includes("logicalSizeBytes",true))
        {
            if(this.LogicalSizeBytes == null) {

                this.LogicalSizeBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalSizeBytes != null && ec.Excludes("logicalSizeBytes",true))
        {
            this.LogicalSizeBytes = null;
        }
        //      C# -> System.String? TableId
        // GraphQL -> tableId: String! (scalar)
        if (ec.Includes("tableId",true))
        {
            if(this.TableId == null) {

                this.TableId = "FETCH";

            } else {


            }
        }
        else if (this.TableId != null && ec.Excludes("tableId",true))
        {
            this.TableId = null;
        }
    }


    #endregion

    } // class GcpBigQueryTableSpecificSnapshot
    
    #endregion

    public static class ListGcpBigQueryTableSpecificSnapshotExtensions
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
            this List<GcpBigQueryTableSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpBigQueryTableSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpBigQueryTableSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpBigQueryTableSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpBigQueryTableSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types