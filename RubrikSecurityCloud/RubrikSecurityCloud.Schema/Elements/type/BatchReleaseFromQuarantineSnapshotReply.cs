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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsBatchReleaseFromQuarantineSuccessful
        // GraphQL -> isBatchReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchReleaseFromQuarantineSuccessful != null) {
            s += ind + "isBatchReleaseFromQuarantineSuccessful\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsBatchReleaseFromQuarantineSuccessful
        // GraphQL -> isBatchReleaseFromQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchReleaseFromQuarantineSuccessful == null && Exploration.Includes(parent + ".isBatchReleaseFromQuarantineSuccessful", true))
        {
            this.IsBatchReleaseFromQuarantineSuccessful = true;
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BatchReleaseFromQuarantineSnapshotReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchReleaseFromQuarantineSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types