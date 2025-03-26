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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<FilesetSnapshotVerbose> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetSnapshotVerbose> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotVerbose> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotVerbose());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetSnapshotVerbose> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types