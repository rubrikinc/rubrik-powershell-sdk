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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsBatchQuarantineSuccessful
        // GraphQL -> isBatchQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchQuarantineSuccessful != null) {
            s += ind + "isBatchQuarantineSuccessful\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsBatchQuarantineSuccessful
        // GraphQL -> isBatchQuarantineSuccessful: Boolean! (scalar)
        if (this.IsBatchQuarantineSuccessful == null && Exploration.Includes(parent + ".isBatchQuarantineSuccessful", true))
        {
            this.IsBatchQuarantineSuccessful = true;
        }
    }


    #endregion

    } // class BatchQuarantineSnapshotReply
    
    #endregion

    public static class ListBatchQuarantineSnapshotReplyExtensions
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
            this List<BatchQuarantineSnapshotReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BatchQuarantineSnapshotReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchQuarantineSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types