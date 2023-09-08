// Db2WorkloadDataBackupFile.cs
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
    #region Db2WorkloadDataBackupFile
    public class Db2WorkloadDataBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        [JsonProperty("partitionNum")]
        public System.Int32? PartitionNum { get; set; }

        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        [JsonProperty("sequenceNum")]
        public System.Int32? SequenceNum { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2WorkloadDataBackupFile";
    }

    public Db2WorkloadDataBackupFile Set(
        System.Int32? PartitionNum = null,
        System.Int32? SequenceNum = null
    ) 
    {
        if ( PartitionNum != null ) {
            this.PartitionNum = PartitionNum;
        }
        if ( SequenceNum != null ) {
            this.SequenceNum = SequenceNum;
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
        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        if (this.PartitionNum != null) {
            s += ind + "partitionNum\n" ;
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum != null) {
            s += ind + "sequenceNum\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        if (this.PartitionNum == null && ec.Includes("partitionNum",true))
        {
            this.PartitionNum = Int32.MinValue;
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum == null && ec.Includes("sequenceNum",true))
        {
            this.SequenceNum = Int32.MinValue;
        }
    }


    #endregion

    } // class Db2WorkloadDataBackupFile
    
    #endregion

    public static class ListDb2WorkloadDataBackupFileExtensions
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
            this List<Db2WorkloadDataBackupFile> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2WorkloadDataBackupFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2WorkloadDataBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Db2WorkloadDataBackupFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types