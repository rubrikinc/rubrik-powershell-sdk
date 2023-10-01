// BatchReleaseFromQuarantineSnapshotReply.cs
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
    #region BatchReleaseFromQuarantineSnapshotReply
    public class BatchReleaseFromQuarantineSnapshotReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsBatchReleaseFromQuarantineSuccessful
        // GraphQL -> isBatchReleaseFromQuarantineSuccessful: Boolean! (scalar)
        [JsonProperty("isBatchReleaseFromQuarantineSuccessful")]
        public System.Boolean? IsBatchReleaseFromQuarantineSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BatchReleaseFromQuarantineSnapshotReply";
    }

    public BatchReleaseFromQuarantineSnapshotReply Set(
        System.Boolean? IsBatchReleaseFromQuarantineSuccessful = null
    ) 
    {
        if ( IsBatchReleaseFromQuarantineSuccessful != null ) {
            this.IsBatchReleaseFromQuarantineSuccessful = IsBatchReleaseFromQuarantineSuccessful;
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
        //      C# -> System.Boolean? IsBatchReleaseFromQuarantineSuccessful
        // GraphQL -> isBatchReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchReleaseFromQuarantineSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBatchReleaseFromQuarantineSuccessful\n" ;
            } else {
                s += ind + "isBatchReleaseFromQuarantineSuccessful\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsBatchReleaseFromQuarantineSuccessful
        // GraphQL -> isBatchReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (ec.Includes("isBatchReleaseFromQuarantineSuccessful",true))
        {
            if(this.IsBatchReleaseFromQuarantineSuccessful == null) {

                this.IsBatchReleaseFromQuarantineSuccessful = true;

            } else {


            }
        }
        else if (this.IsBatchReleaseFromQuarantineSuccessful != null && ec.Excludes("isBatchReleaseFromQuarantineSuccessful",true))
        {
            this.IsBatchReleaseFromQuarantineSuccessful = null;
        }
    }


    #endregion

    } // class BatchReleaseFromQuarantineSnapshotReply
    
    #endregion

    public static class ListBatchReleaseFromQuarantineSnapshotReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<BatchReleaseFromQuarantineSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BatchReleaseFromQuarantineSnapshotReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BatchReleaseFromQuarantineSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchReleaseFromQuarantineSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BatchReleaseFromQuarantineSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types