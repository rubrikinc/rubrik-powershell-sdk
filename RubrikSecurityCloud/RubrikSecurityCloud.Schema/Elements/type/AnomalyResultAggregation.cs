// AnomalyResultAggregation.cs
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
    #region AnomalyResultAggregation
    public class AnomalyResultAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        [JsonProperty("bytesAdded")]
        public System.Int64? BytesAdded { get; set; }

        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        [JsonProperty("bytesDeleted")]
        public System.Int64? BytesDeleted { get; set; }

        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        [JsonProperty("bytesModified")]
        public System.Int64? BytesModified { get; set; }

        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        [JsonProperty("filesAdded")]
        public System.Int64? FilesAdded { get; set; }

        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        [JsonProperty("filesDeleted")]
        public System.Int64? FilesDeleted { get; set; }

        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        [JsonProperty("filesModified")]
        public System.Int64? FilesModified { get; set; }


        #endregion

    #region methods

    public AnomalyResultAggregation Set(
        System.Int64? BytesAdded = null,
        System.Int64? BytesDeleted = null,
        System.Int64? BytesModified = null,
        System.Int64? FilesAdded = null,
        System.Int64? FilesDeleted = null,
        System.Int64? FilesModified = null
    ) 
    {
        if ( BytesAdded != null ) {
            this.BytesAdded = BytesAdded;
        }
        if ( BytesDeleted != null ) {
            this.BytesDeleted = BytesDeleted;
        }
        if ( BytesModified != null ) {
            this.BytesModified = BytesModified;
        }
        if ( FilesAdded != null ) {
            this.FilesAdded = FilesAdded;
        }
        if ( FilesDeleted != null ) {
            this.FilesDeleted = FilesDeleted;
        }
        if ( FilesModified != null ) {
            this.FilesModified = FilesModified;
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
        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        if (this.BytesAdded != null) {
            s += ind + "bytesAdded\n" ;
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted != null) {
            s += ind + "bytesDeleted\n" ;
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified != null) {
            s += ind + "bytesModified\n" ;
        }
        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        if (this.FilesAdded != null) {
            s += ind + "filesAdded\n" ;
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted != null) {
            s += ind + "filesDeleted\n" ;
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified != null) {
            s += ind + "filesModified\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BytesAdded
        // GraphQL -> bytesAdded: Long! (scalar)
        if (this.BytesAdded == null && Exploration.Includes(parent + ".bytesAdded", true))
        {
            this.BytesAdded = new System.Int64();
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted == null && Exploration.Includes(parent + ".bytesDeleted", true))
        {
            this.BytesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified == null && Exploration.Includes(parent + ".bytesModified", true))
        {
            this.BytesModified = new System.Int64();
        }
        //      C# -> System.Int64? FilesAdded
        // GraphQL -> filesAdded: Long! (scalar)
        if (this.FilesAdded == null && Exploration.Includes(parent + ".filesAdded", true))
        {
            this.FilesAdded = new System.Int64();
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted == null && Exploration.Includes(parent + ".filesDeleted", true))
        {
            this.FilesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified == null && Exploration.Includes(parent + ".filesModified", true))
        {
            this.FilesModified = new System.Int64();
        }
    }


    #endregion

    } // class AnomalyResultAggregation
    
    #endregion

    public static class ListAnomalyResultAggregationExtensions
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
            this List<AnomalyResultAggregation> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResultAggregation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResultAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types