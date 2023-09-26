// AzureNativeVmSpecificSnapshot.cs
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
    #region AzureNativeVmSpecificSnapshot
 
    public class AzureNativeVmSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<AzureNativeAttachedDiskSpecificSnapshot>? DataDiskSnapshots
        // GraphQL -> dataDiskSnapshots: [AzureNativeAttachedDiskSpecificSnapshot!]! (type)
        [JsonProperty("dataDiskSnapshots")]
        public List<AzureNativeAttachedDiskSpecificSnapshot>? DataDiskSnapshots { get; set; }

        //      C# -> AzureNativeAttachedDiskSpecificSnapshot? OsDiskSnapshot
        // GraphQL -> osDiskSnapshot: AzureNativeAttachedDiskSpecificSnapshot (type)
        [JsonProperty("osDiskSnapshot")]
        public AzureNativeAttachedDiskSpecificSnapshot? OsDiskSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeVmSpecificSnapshot";
    }

    public AzureNativeVmSpecificSnapshot Set(
        System.String? SnapshotId = null,
        List<AzureNativeAttachedDiskSpecificSnapshot>? DataDiskSnapshots = null,
        AzureNativeAttachedDiskSpecificSnapshot? OsDiskSnapshot = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( DataDiskSnapshots != null ) {
            this.DataDiskSnapshots = DataDiskSnapshots;
        }
        if ( OsDiskSnapshot != null ) {
            this.OsDiskSnapshot = OsDiskSnapshot;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> List<AzureNativeAttachedDiskSpecificSnapshot>? DataDiskSnapshots
        // GraphQL -> dataDiskSnapshots: [AzureNativeAttachedDiskSpecificSnapshot!]! (type)
        if (this.DataDiskSnapshots != null) {
            var fspec = this.DataDiskSnapshots.AsFieldSpec(conf.Child("dataDiskSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataDiskSnapshots {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeAttachedDiskSpecificSnapshot? OsDiskSnapshot
        // GraphQL -> osDiskSnapshot: AzureNativeAttachedDiskSpecificSnapshot (type)
        if (this.OsDiskSnapshot != null) {
            var fspec = this.OsDiskSnapshot.AsFieldSpec(conf.Child("osDiskSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "osDiskSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
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
        //      C# -> List<AzureNativeAttachedDiskSpecificSnapshot>? DataDiskSnapshots
        // GraphQL -> dataDiskSnapshots: [AzureNativeAttachedDiskSpecificSnapshot!]! (type)
        if (ec.Includes("dataDiskSnapshots",false))
        {
            if(this.DataDiskSnapshots == null) {

                this.DataDiskSnapshots = new List<AzureNativeAttachedDiskSpecificSnapshot>();
                this.DataDiskSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("dataDiskSnapshots"));

            } else {

                this.DataDiskSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("dataDiskSnapshots"));

            }
        }
        else if (this.DataDiskSnapshots != null && ec.Excludes("dataDiskSnapshots",false))
        {
            this.DataDiskSnapshots = null;
        }
        //      C# -> AzureNativeAttachedDiskSpecificSnapshot? OsDiskSnapshot
        // GraphQL -> osDiskSnapshot: AzureNativeAttachedDiskSpecificSnapshot (type)
        if (ec.Includes("osDiskSnapshot",false))
        {
            if(this.OsDiskSnapshot == null) {

                this.OsDiskSnapshot = new AzureNativeAttachedDiskSpecificSnapshot();
                this.OsDiskSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("osDiskSnapshot"));

            } else {

                this.OsDiskSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("osDiskSnapshot"));

            }
        }
        else if (this.OsDiskSnapshot != null && ec.Excludes("osDiskSnapshot",false))
        {
            this.OsDiskSnapshot = null;
        }
    }


    #endregion

    } // class AzureNativeVmSpecificSnapshot
    
    #endregion

    public static class ListAzureNativeVmSpecificSnapshotExtensions
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
            this List<AzureNativeVmSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeVmSpecificSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeVmSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeVmSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types