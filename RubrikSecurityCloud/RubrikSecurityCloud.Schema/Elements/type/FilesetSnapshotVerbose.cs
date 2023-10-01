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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "FilesetSnapshotVerbose";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        if (this.HasFingerprint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasFingerprint\n" ;
            } else {
                s += ind + "hasFingerprint\n" ;
            }
        }
        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        if (this.PartitionPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partitionPaths\n" ;
            } else {
                s += ind + "partitionPaths\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        if (ec.Includes("hasFingerprint",true))
        {
            if(this.HasFingerprint == null) {

                this.HasFingerprint = true;

            } else {


            }
        }
        else if (this.HasFingerprint != null && ec.Excludes("hasFingerprint",true))
        {
            this.HasFingerprint = null;
        }
        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        if (ec.Includes("partitionPaths",true))
        {
            if(this.PartitionPaths == null) {

                this.PartitionPaths = new List<System.String>();

            } else {


            }
        }
        else if (this.PartitionPaths != null && ec.Excludes("partitionPaths",true))
        {
            this.PartitionPaths = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FilesetSnapshotVerbose> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotVerbose> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotVerbose());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetSnapshotVerbose> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types