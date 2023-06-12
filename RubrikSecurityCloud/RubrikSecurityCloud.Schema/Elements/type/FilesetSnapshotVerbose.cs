// FilesetSnapshotVerbose.cs
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
    #region FilesetSnapshotVerbose
    public class FilesetSnapshotVerbose: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        [JsonProperty("hasFingerprint")]
        public System.Boolean? HasFingerprint { get; set; }

        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        [JsonProperty("partitionPaths")]
        public List<System.String>? PartitionPaths { get; set; }


        #endregion

    #region methods

    public FilesetSnapshotVerbose Set(
        System.Boolean? HasFingerprint = null,
        List<System.String>? PartitionPaths = null
    ) 
    {
        if ( HasFingerprint != null ) {
            this.HasFingerprint = HasFingerprint;
        }
        if ( PartitionPaths != null ) {
            this.PartitionPaths = PartitionPaths;
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
        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        if (this.HasFingerprint != null) {
            s += ind + "hasFingerprint\n" ;
        }
        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        if (this.PartitionPaths != null) {
            s += ind + "partitionPaths\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        if (this.HasFingerprint == null && Exploration.Includes(parent + ".hasFingerprint", true))
        {
            this.HasFingerprint = true;
        }
        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        if (this.PartitionPaths == null && Exploration.Includes(parent + ".partitionPaths", true))
        {
            this.PartitionPaths = new List<System.String>();
        }
    }


    #endregion

    } // class FilesetSnapshotVerbose
    
    #endregion

    public static class ListFilesetSnapshotVerboseExtensions
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
            this List<FilesetSnapshotVerbose> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotVerbose> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotVerbose());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types