// TaskSummary.cs
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
    #region TaskSummary
    public class TaskSummary: BaseType
    {
        #region members

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        [JsonProperty("numCanceled")]
        public System.Int32? NumCanceled { get; set; }

        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        [JsonProperty("numExpected")]
        public System.Int32? NumExpected { get; set; }

        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        [JsonProperty("numFailed")]
        public System.Int32? NumFailed { get; set; }

        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        [JsonProperty("numSucceeded")]
        public System.Int32? NumSucceeded { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        [JsonProperty("slaDomainName")]
        public System.String? SlaDomainName { get; set; }

        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        [JsonProperty("snappbleId")]
        public System.String? SnappbleId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskSummary";
    }

    public TaskSummary Set(
        ObjectTypeEnum? ObjectType = null,
        System.String? ClusterUuid = null,
        DateTime? Date = null,
        System.String? Location = null,
        System.Int32? NumCanceled = null,
        System.Int32? NumExpected = null,
        System.Int32? NumFailed = null,
        System.Int32? NumSucceeded = null,
        System.String? ObjectName = null,
        System.String? SlaDomainId = null,
        System.String? SlaDomainName = null,
        System.String? SnappbleId = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( NumCanceled != null ) {
            this.NumCanceled = NumCanceled;
        }
        if ( NumExpected != null ) {
            this.NumExpected = NumExpected;
        }
        if ( NumFailed != null ) {
            this.NumFailed = NumFailed;
        }
        if ( NumSucceeded != null ) {
            this.NumSucceeded = NumSucceeded;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SlaDomainName != null ) {
            this.SlaDomainName = SlaDomainName;
        }
        if ( SnappbleId != null ) {
            this.SnappbleId = SnappbleId;
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
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
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
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        if (this.NumCanceled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCanceled\n" ;
            } else {
                s += ind + "numCanceled\n" ;
            }
        }
        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        if (this.NumExpected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numExpected\n" ;
            } else {
                s += ind + "numExpected\n" ;
            }
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (this.NumFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFailed\n" ;
            } else {
                s += ind + "numFailed\n" ;
            }
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (this.NumSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSucceeded\n" ;
            } else {
                s += ind + "numSucceeded\n" ;
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
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainId\n" ;
            } else {
                s += ind + "slaDomainId\n" ;
            }
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainName\n" ;
            } else {
                s += ind + "slaDomainName\n" ;
            }
        }
        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        if (this.SnappbleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappbleId\n" ;
            } else {
                s += ind + "snappbleId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
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
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        if (ec.Includes("numCanceled",true))
        {
            if(this.NumCanceled == null) {

                this.NumCanceled = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCanceled != null && ec.Excludes("numCanceled",true))
        {
            this.NumCanceled = null;
        }
        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        if (ec.Includes("numExpected",true))
        {
            if(this.NumExpected == null) {

                this.NumExpected = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumExpected != null && ec.Excludes("numExpected",true))
        {
            this.NumExpected = null;
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (ec.Includes("numFailed",true))
        {
            if(this.NumFailed == null) {

                this.NumFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFailed != null && ec.Excludes("numFailed",true))
        {
            this.NumFailed = null;
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (ec.Includes("numSucceeded",true))
        {
            if(this.NumSucceeded == null) {

                this.NumSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSucceeded != null && ec.Excludes("numSucceeded",true))
        {
            this.NumSucceeded = null;
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
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (ec.Includes("slaDomainId",true))
        {
            if(this.SlaDomainId == null) {

                this.SlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainId != null && ec.Excludes("slaDomainId",true))
        {
            this.SlaDomainId = null;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (ec.Includes("slaDomainName",true))
        {
            if(this.SlaDomainName == null) {

                this.SlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainName != null && ec.Excludes("slaDomainName",true))
        {
            this.SlaDomainName = null;
        }
        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        if (ec.Includes("snappbleId",true))
        {
            if(this.SnappbleId == null) {

                this.SnappbleId = "FETCH";

            } else {


            }
        }
        else if (this.SnappbleId != null && ec.Excludes("snappbleId",true))
        {
            this.SnappbleId = null;
        }
    }


    #endregion

    } // class TaskSummary
    
    #endregion

    public static class ListTaskSummaryExtensions
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
            this List<TaskSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TaskSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TaskSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types