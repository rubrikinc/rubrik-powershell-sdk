// CompareSalesforceRecords.cs
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
    #region CompareSalesforceRecords
    public class CompareSalesforceRecords: BaseType
    {
        #region members

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int! (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }

        //      C# -> List<SalesforceObjectField>? Fields
        // GraphQL -> fields: [SalesforceObjectField!]! (type)
        [JsonProperty("fields")]
        public List<SalesforceObjectField>? Fields { get; set; }

        //      C# -> ObjectRecordChangeConnection? RecordChangesConnection
        // GraphQL -> recordChangesConnection: ObjectRecordChangeConnection! (type)
        [JsonProperty("recordChangesConnection")]
        public ObjectRecordChangeConnection? RecordChangesConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CompareSalesforceRecords";
    }

    public CompareSalesforceRecords Set(
        System.Int32? Offset = null,
        System.Int32? Total = null,
        List<SalesforceObjectField>? Fields = null,
        ObjectRecordChangeConnection? RecordChangesConnection = null
    ) 
    {
        if ( Offset != null ) {
            this.Offset = Offset;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Fields != null ) {
            this.Fields = Fields;
        }
        if ( RecordChangesConnection != null ) {
            this.RecordChangesConnection = RecordChangesConnection;
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
        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int! (scalar)
        if (this.Offset != null) {
            if (conf.Flat) {
                s += conf.Prefix + "offset\n" ;
            } else {
                s += ind + "offset\n" ;
            }
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        //      C# -> List<SalesforceObjectField>? Fields
        // GraphQL -> fields: [SalesforceObjectField!]! (type)
        if (this.Fields != null) {
            var fspec = this.Fields.AsFieldSpec(conf.Child("fields"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fields" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectRecordChangeConnection? RecordChangesConnection
        // GraphQL -> recordChangesConnection: ObjectRecordChangeConnection! (type)
        if (this.RecordChangesConnection != null) {
            var fspec = this.RecordChangesConnection.AsFieldSpec(conf.Child("recordChangesConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recordChangesConnection" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int! (scalar)
        if (ec.Includes("offset",true))
        {
            if(this.Offset == null) {

                this.Offset = Int32.MinValue;

            } else {


            }
        }
        else if (this.Offset != null && ec.Excludes("offset",true))
        {
            this.Offset = null;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = Int32.MinValue;

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
        //      C# -> List<SalesforceObjectField>? Fields
        // GraphQL -> fields: [SalesforceObjectField!]! (type)
        if (ec.Includes("fields",false))
        {
            if(this.Fields == null) {

                this.Fields = new List<SalesforceObjectField>();
                this.Fields.ApplyExploratoryFieldSpec(ec.NewChild("fields"));

            } else {

                this.Fields.ApplyExploratoryFieldSpec(ec.NewChild("fields"));

            }
        }
        else if (this.Fields != null && ec.Excludes("fields",false))
        {
            this.Fields = null;
        }
        //      C# -> ObjectRecordChangeConnection? RecordChangesConnection
        // GraphQL -> recordChangesConnection: ObjectRecordChangeConnection! (type)
        if (ec.Includes("recordChangesConnection",false))
        {
            if(this.RecordChangesConnection == null) {

                this.RecordChangesConnection = new ObjectRecordChangeConnection();
                this.RecordChangesConnection.ApplyExploratoryFieldSpec(ec.NewChild("recordChangesConnection"));

            } else {

                this.RecordChangesConnection.ApplyExploratoryFieldSpec(ec.NewChild("recordChangesConnection"));

            }
        }
        else if (this.RecordChangesConnection != null && ec.Excludes("recordChangesConnection",false))
        {
            this.RecordChangesConnection = null;
        }
    }


    #endregion

    } // class CompareSalesforceRecords
    
    #endregion

    public static class ListCompareSalesforceRecordsExtensions
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
            this List<CompareSalesforceRecords> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CompareSalesforceRecords> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CompareSalesforceRecords> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CompareSalesforceRecords());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CompareSalesforceRecords> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types