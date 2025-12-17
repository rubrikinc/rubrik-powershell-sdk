// BulkGenerateFilesetBackupReportReply.cs
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
    #region BulkGenerateFilesetBackupReportReply
    public class BulkGenerateFilesetBackupReportReply: BaseType
    {
        #region members

        //      C# -> List<AsyncRequestStatus>? SnapshotResults
        // GraphQL -> snapshotResults: [AsyncRequestStatus!]! (type)
        [JsonProperty("snapshotResults")]
        public List<AsyncRequestStatus>? SnapshotResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkGenerateFilesetBackupReportReply";
    }

    public BulkGenerateFilesetBackupReportReply Set(
        List<AsyncRequestStatus>? SnapshotResults = null
    ) 
    {
        if ( SnapshotResults != null ) {
            this.SnapshotResults = SnapshotResults;
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
        //      C# -> List<AsyncRequestStatus>? SnapshotResults
        // GraphQL -> snapshotResults: [AsyncRequestStatus!]! (type)
        if (this.SnapshotResults != null) {
            var fspec = this.SnapshotResults.AsFieldSpec(conf.Child("snapshotResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AsyncRequestStatus>? SnapshotResults
        // GraphQL -> snapshotResults: [AsyncRequestStatus!]! (type)
        if (ec.Includes("snapshotResults",false))
        {
            if(this.SnapshotResults == null) {

                this.SnapshotResults = new List<AsyncRequestStatus>();
                this.SnapshotResults.ApplyExploratoryFieldSpec(ec.NewChild("snapshotResults"));

            } else {

                this.SnapshotResults.ApplyExploratoryFieldSpec(ec.NewChild("snapshotResults"));

            }
        }
        else if (this.SnapshotResults != null && ec.Excludes("snapshotResults",false))
        {
            this.SnapshotResults = null;
        }
    }


    #endregion

    } // class BulkGenerateFilesetBackupReportReply
    
    #endregion

    public static class ListBulkGenerateFilesetBackupReportReplyExtensions
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
            this List<BulkGenerateFilesetBackupReportReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkGenerateFilesetBackupReportReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkGenerateFilesetBackupReportReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkGenerateFilesetBackupReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkGenerateFilesetBackupReportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types