// QuarantineSpec.cs
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
    #region QuarantineSpec
    public class QuarantineSpec: BaseType
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<FileDetails>? FilesDetails
        // GraphQL -> filesDetails: [FileDetails!]! (type)
        [JsonProperty("filesDetails")]
        public List<FileDetails>? FilesDetails { get; set; }


        #endregion

    #region methods

    public QuarantineSpec Set(
        System.String? SnapshotId = null,
        List<FileDetails>? FilesDetails = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( FilesDetails != null ) {
            this.FilesDetails = FilesDetails;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> List<FileDetails>? FilesDetails
        // GraphQL -> filesDetails: [FileDetails!]! (type)
        if (this.FilesDetails != null) {
            s += ind + "filesDetails {\n" + this.FilesDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = new System.String("FETCH");
        }
        //      C# -> List<FileDetails>? FilesDetails
        // GraphQL -> filesDetails: [FileDetails!]! (type)
        if (this.FilesDetails == null && Exploration.Includes(parent + ".filesDetails"))
        {
            this.FilesDetails = new List<FileDetails>();
            this.FilesDetails.ApplyExploratoryFieldSpec(parent + ".filesDetails");
        }
    }


    #endregion

    } // class QuarantineSpec
    
    #endregion

    public static class ListQuarantineSpecExtensions
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
            this List<QuarantineSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<QuarantineSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new QuarantineSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types