// CloudDirectCopyScheduleAssignmentItem.cs
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
    #region CloudDirectCopyScheduleAssignmentItem
    public class CloudDirectCopyScheduleAssignmentItem: BaseType
    {
        #region members

        //      C# -> System.String? AssignmentId
        // GraphQL -> assignmentId: UUID! (scalar)
        [JsonProperty("assignmentId")]
        public System.String? AssignmentId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        [JsonProperty("scheduleId")]
        public System.String? ScheduleId { get; set; }

        //      C# -> System.String? ShareId
        // GraphQL -> shareId: UUID! (scalar)
        [JsonProperty("shareId")]
        public System.String? ShareId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectCopyScheduleAssignmentItem";
    }

    public CloudDirectCopyScheduleAssignmentItem Set(
        System.String? AssignmentId = null,
        System.String? ClusterUuid = null,
        System.String? ScheduleId = null,
        System.String? ShareId = null
    ) 
    {
        if ( AssignmentId != null ) {
            this.AssignmentId = AssignmentId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ScheduleId != null ) {
            this.ScheduleId = ScheduleId;
        }
        if ( ShareId != null ) {
            this.ShareId = ShareId;
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
        //      C# -> System.String? AssignmentId
        // GraphQL -> assignmentId: UUID! (scalar)
        if (this.AssignmentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "assignmentId\n" ;
            } else {
                s += ind + "assignmentId\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        if (this.ScheduleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleId\n" ;
            } else {
                s += ind + "scheduleId\n" ;
            }
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: UUID! (scalar)
        if (this.ShareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareId\n" ;
            } else {
                s += ind + "shareId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AssignmentId
        // GraphQL -> assignmentId: UUID! (scalar)
        if (ec.Includes("assignmentId",true))
        {
            if(this.AssignmentId == null) {

                this.AssignmentId = "FETCH";

            } else {


            }
        }
        else if (this.AssignmentId != null && ec.Excludes("assignmentId",true))
        {
            this.AssignmentId = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        if (ec.Includes("scheduleId",true))
        {
            if(this.ScheduleId == null) {

                this.ScheduleId = "FETCH";

            } else {


            }
        }
        else if (this.ScheduleId != null && ec.Excludes("scheduleId",true))
        {
            this.ScheduleId = null;
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: UUID! (scalar)
        if (ec.Includes("shareId",true))
        {
            if(this.ShareId == null) {

                this.ShareId = "FETCH";

            } else {


            }
        }
        else if (this.ShareId != null && ec.Excludes("shareId",true))
        {
            this.ShareId = null;
        }
    }


    #endregion

    } // class CloudDirectCopyScheduleAssignmentItem
    
    #endregion

    public static class ListCloudDirectCopyScheduleAssignmentItemExtensions
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
            this List<CloudDirectCopyScheduleAssignmentItem> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectCopyScheduleAssignmentItem> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectCopyScheduleAssignmentItem> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectCopyScheduleAssignmentItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectCopyScheduleAssignmentItem> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types