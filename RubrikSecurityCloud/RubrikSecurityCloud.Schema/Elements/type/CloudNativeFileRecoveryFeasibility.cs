// CloudNativeFileRecoveryFeasibility.cs
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
    #region CloudNativeFileRecoveryFeasibility
    public class CloudNativeFileRecoveryFeasibility: BaseType
    {
        #region members

        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        [JsonProperty("fileRecoveryFeasibility")]
        public FileRecoveryFeasibility? FileRecoveryFeasibility { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeFileRecoveryFeasibility";
    }

    public CloudNativeFileRecoveryFeasibility Set(
        FileRecoveryFeasibility? FileRecoveryFeasibility = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( FileRecoveryFeasibility != null ) {
            this.FileRecoveryFeasibility = FileRecoveryFeasibility;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileRecoveryFeasibility\n" ;
            } else {
                s += ind + "fileRecoveryFeasibility\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (ec.Includes("fileRecoveryFeasibility",true))
        {
            if(this.FileRecoveryFeasibility == null) {

                this.FileRecoveryFeasibility = new FileRecoveryFeasibility();

            } else {


            }
        }
        else if (this.FileRecoveryFeasibility != null && ec.Excludes("fileRecoveryFeasibility",true))
        {
            this.FileRecoveryFeasibility = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
    }


    #endregion

    } // class CloudNativeFileRecoveryFeasibility
    
    #endregion

    public static class ListCloudNativeFileRecoveryFeasibilityExtensions
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
            this List<CloudNativeFileRecoveryFeasibility> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeFileRecoveryFeasibility> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeFileRecoveryFeasibility> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeFileRecoveryFeasibility());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeFileRecoveryFeasibility> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types