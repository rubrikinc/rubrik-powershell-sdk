// WorkloadIdToSnapshotIds.cs
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
    #region WorkloadIdToSnapshotIds
    public class WorkloadIdToSnapshotIds: BaseType
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        [JsonProperty("snapshotIds")]
        public List<System.String>? SnapshotIds { get; set; }

        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        [JsonProperty("snapshotTimestamps")]
        public List<DateTime>? SnapshotTimestamps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadIdToSnapshotIds";
    }

    public WorkloadIdToSnapshotIds Set(
        System.String? ObjectId = null,
        List<System.String>? SnapshotIds = null,
        List<DateTime>? SnapshotTimestamps = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotIds != null ) {
            this.SnapshotIds = SnapshotIds;
        }
        if ( SnapshotTimestamps != null ) {
            this.SnapshotTimestamps = SnapshotTimestamps;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotIds\n" ;
            } else {
                s += ind + "snapshotIds\n" ;
            }
        }
        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        if (this.SnapshotTimestamps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTimestamps\n" ;
            } else {
                s += ind + "snapshotTimestamps\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (ec.Includes("snapshotIds",true))
        {
            if(this.SnapshotIds == null) {

                this.SnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotIds != null && ec.Excludes("snapshotIds",true))
        {
            this.SnapshotIds = null;
        }
        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        if (ec.Includes("snapshotTimestamps",true))
        {
            if(this.SnapshotTimestamps == null) {

                this.SnapshotTimestamps = new List<DateTime>();

            } else {


            }
        }
        else if (this.SnapshotTimestamps != null && ec.Excludes("snapshotTimestamps",true))
        {
            this.SnapshotTimestamps = null;
        }
    }


    #endregion

    } // class WorkloadIdToSnapshotIds
    
    #endregion

    public static class ListWorkloadIdToSnapshotIdsExtensions
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
            this List<WorkloadIdToSnapshotIds> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadIdToSnapshotIds> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadIdToSnapshotIds> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadIdToSnapshotIds());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadIdToSnapshotIds> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types