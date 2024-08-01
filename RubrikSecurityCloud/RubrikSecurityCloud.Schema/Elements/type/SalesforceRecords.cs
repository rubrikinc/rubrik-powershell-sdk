// SalesforceRecords.cs
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
    #region SalesforceRecords
    public class SalesforceRecords: BaseType
    {
        #region members

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> List<SalesforceObjectField>? Fields
        // GraphQL -> fields: [SalesforceObjectField!]! (type)
        [JsonProperty("fields")]
        public List<SalesforceObjectField>? Fields { get; set; }

        //      C# -> SalesforceObjectRecordConnection? RecordsConnection
        // GraphQL -> recordsConnection: SalesforceObjectRecordConnection! (type)
        [JsonProperty("recordsConnection")]
        public SalesforceObjectRecordConnection? RecordsConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SalesforceRecords";
    }

    public SalesforceRecords Set(
        System.String? WorkloadId = null,
        List<SalesforceObjectField>? Fields = null,
        SalesforceObjectRecordConnection? RecordsConnection = null
    ) 
    {
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( Fields != null ) {
            this.Fields = Fields;
        }
        if ( RecordsConnection != null ) {
            this.RecordsConnection = RecordsConnection;
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
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
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
        //      C# -> SalesforceObjectRecordConnection? RecordsConnection
        // GraphQL -> recordsConnection: SalesforceObjectRecordConnection! (type)
        if (this.RecordsConnection != null) {
            var fspec = this.RecordsConnection.AsFieldSpec(conf.Child("recordsConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recordsConnection" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
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
        //      C# -> SalesforceObjectRecordConnection? RecordsConnection
        // GraphQL -> recordsConnection: SalesforceObjectRecordConnection! (type)
        if (ec.Includes("recordsConnection",false))
        {
            if(this.RecordsConnection == null) {

                this.RecordsConnection = new SalesforceObjectRecordConnection();
                this.RecordsConnection.ApplyExploratoryFieldSpec(ec.NewChild("recordsConnection"));

            } else {

                this.RecordsConnection.ApplyExploratoryFieldSpec(ec.NewChild("recordsConnection"));

            }
        }
        else if (this.RecordsConnection != null && ec.Excludes("recordsConnection",false))
        {
            this.RecordsConnection = null;
        }
    }


    #endregion

    } // class SalesforceRecords
    
    #endregion

    public static class ListSalesforceRecordsExtensions
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
            this List<SalesforceRecords> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SalesforceRecords> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SalesforceRecords> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SalesforceRecords());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SalesforceRecords> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types