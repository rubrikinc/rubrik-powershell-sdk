// GetPausedObjectRes.cs
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
    #region GetPausedObjectRes
    public class GetPausedObjectRes: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> PendingObjectPauseAssignmentStatus? PendingPauseStatus
        // GraphQL -> pendingPauseStatus: PendingObjectPauseAssignmentStatus! (enum)
        [JsonProperty("pendingPauseStatus")]
        public PendingObjectPauseAssignmentStatus? PendingPauseStatus { get; set; }

        //      C# -> ManagedObjectType? SnappableHierarchyType
        // GraphQL -> snappableHierarchyType: ManagedObjectType! (enum)
        [JsonProperty("snappableHierarchyType")]
        public ManagedObjectType? SnappableHierarchyType { get; set; }

        //      C# -> System.String? Note
        // GraphQL -> note: String! (scalar)
        [JsonProperty("note")]
        public System.String? Note { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> DateTime? PauseStartDate
        // GraphQL -> pauseStartDate: DateTime (scalar)
        [JsonProperty("pauseStartDate")]
        public DateTime? PauseStartDate { get; set; }

        //      C# -> System.String? PausedBy
        // GraphQL -> pausedBy: String! (scalar)
        [JsonProperty("pausedBy")]
        public System.String? PausedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPausedObjectRes";
    }

    public GetPausedObjectRes Set(
        ManagedObjectType? ObjectType = null,
        PendingObjectPauseAssignmentStatus? PendingPauseStatus = null,
        ManagedObjectType? SnappableHierarchyType = null,
        System.String? Note = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        DateTime? PauseStartDate = null,
        System.String? PausedBy = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( PendingPauseStatus != null ) {
            this.PendingPauseStatus = PendingPauseStatus;
        }
        if ( SnappableHierarchyType != null ) {
            this.SnappableHierarchyType = SnappableHierarchyType;
        }
        if ( Note != null ) {
            this.Note = Note;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( PauseStartDate != null ) {
            this.PauseStartDate = PauseStartDate;
        }
        if ( PausedBy != null ) {
            this.PausedBy = PausedBy;
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
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> PendingObjectPauseAssignmentStatus? PendingPauseStatus
        // GraphQL -> pendingPauseStatus: PendingObjectPauseAssignmentStatus! (enum)
        if (this.PendingPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingPauseStatus\n" ;
            } else {
                s += ind + "pendingPauseStatus\n" ;
            }
        }
        //      C# -> ManagedObjectType? SnappableHierarchyType
        // GraphQL -> snappableHierarchyType: ManagedObjectType! (enum)
        if (this.SnappableHierarchyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableHierarchyType\n" ;
            } else {
                s += ind + "snappableHierarchyType\n" ;
            }
        }
        //      C# -> System.String? Note
        // GraphQL -> note: String! (scalar)
        if (this.Note != null) {
            if (conf.Flat) {
                s += conf.Prefix + "note\n" ;
            } else {
                s += ind + "note\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> DateTime? PauseStartDate
        // GraphQL -> pauseStartDate: DateTime (scalar)
        if (this.PauseStartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseStartDate\n" ;
            } else {
                s += ind + "pauseStartDate\n" ;
            }
        }
        //      C# -> System.String? PausedBy
        // GraphQL -> pausedBy: String! (scalar)
        if (this.PausedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedBy\n" ;
            } else {
                s += ind + "pausedBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> PendingObjectPauseAssignmentStatus? PendingPauseStatus
        // GraphQL -> pendingPauseStatus: PendingObjectPauseAssignmentStatus! (enum)
        if (ec.Includes("pendingPauseStatus",true))
        {
            if(this.PendingPauseStatus == null) {

                this.PendingPauseStatus = new PendingObjectPauseAssignmentStatus();

            } else {


            }
        }
        else if (this.PendingPauseStatus != null && ec.Excludes("pendingPauseStatus",true))
        {
            this.PendingPauseStatus = null;
        }
        //      C# -> ManagedObjectType? SnappableHierarchyType
        // GraphQL -> snappableHierarchyType: ManagedObjectType! (enum)
        if (ec.Includes("snappableHierarchyType",true))
        {
            if(this.SnappableHierarchyType == null) {

                this.SnappableHierarchyType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.SnappableHierarchyType != null && ec.Excludes("snappableHierarchyType",true))
        {
            this.SnappableHierarchyType = null;
        }
        //      C# -> System.String? Note
        // GraphQL -> note: String! (scalar)
        if (ec.Includes("note",true))
        {
            if(this.Note == null) {

                this.Note = "FETCH";

            } else {


            }
        }
        else if (this.Note != null && ec.Excludes("note",true))
        {
            this.Note = null;
        }
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
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> DateTime? PauseStartDate
        // GraphQL -> pauseStartDate: DateTime (scalar)
        if (ec.Includes("pauseStartDate",true))
        {
            if(this.PauseStartDate == null) {

                this.PauseStartDate = new DateTime();

            } else {


            }
        }
        else if (this.PauseStartDate != null && ec.Excludes("pauseStartDate",true))
        {
            this.PauseStartDate = null;
        }
        //      C# -> System.String? PausedBy
        // GraphQL -> pausedBy: String! (scalar)
        if (ec.Includes("pausedBy",true))
        {
            if(this.PausedBy == null) {

                this.PausedBy = "FETCH";

            } else {


            }
        }
        else if (this.PausedBy != null && ec.Excludes("pausedBy",true))
        {
            this.PausedBy = null;
        }
    }


    #endregion

    } // class GetPausedObjectRes
    
    #endregion

    public static class ListGetPausedObjectResExtensions
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
            this List<GetPausedObjectRes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPausedObjectRes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPausedObjectRes> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPausedObjectRes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPausedObjectRes> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types