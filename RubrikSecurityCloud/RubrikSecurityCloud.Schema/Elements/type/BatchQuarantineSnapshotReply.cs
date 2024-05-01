// BatchQuarantineSnapshotReply.cs
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
    #region BatchQuarantineSnapshotReply
    public class BatchQuarantineSnapshotReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsBatchQuarantineSuccessful
        // GraphQL -> isBatchQuarantineSuccessful: Boolean! (scalar)
        [JsonProperty("isBatchQuarantineSuccessful")]
        public System.Boolean? IsBatchQuarantineSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BatchQuarantineSnapshotReply";
    }

    public BatchQuarantineSnapshotReply Set(
        System.Boolean? IsBatchQuarantineSuccessful = null
    ) 
    {
        if ( IsBatchQuarantineSuccessful != null ) {
            this.IsBatchQuarantineSuccessful = IsBatchQuarantineSuccessful;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsBatchQuarantineSuccessful
        // GraphQL -> isBatchQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchQuarantineSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBatchQuarantineSuccessful\n" ;
            } else {
                s += ind + "isBatchQuarantineSuccessful\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsBatchQuarantineSuccessful
        // GraphQL -> isBatchQuarantineSuccessful: Boolean! (scalar)
        if (ec.Includes("isBatchQuarantineSuccessful",true))
        {
            if(this.IsBatchQuarantineSuccessful == null) {

                this.IsBatchQuarantineSuccessful = true;

            } else {


            }
        }
        else if (this.IsBatchQuarantineSuccessful != null && ec.Excludes("isBatchQuarantineSuccessful",true))
        {
            this.IsBatchQuarantineSuccessful = null;
        }
    }


    #endregion

    } // class BatchQuarantineSnapshotReply
    
    #endregion

    public static class ListBatchQuarantineSnapshotReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<BatchQuarantineSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BatchQuarantineSnapshotReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BatchQuarantineSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchQuarantineSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BatchQuarantineSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types