// MosaicVersionObject.cs
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
    #region MosaicVersionObject
    public class MosaicVersionObject: BaseType
    {
        #region members

        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        [JsonProperty("versionState")]
        public MosaicVersionObjectVersionState? VersionState { get; set; }

        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        [JsonProperty("dbInfo")]
        public System.String? DbInfo { get; set; }

        //      C# -> System.Int32? ExpirationTime
        // GraphQL -> expirationTime: Int (scalar)
        [JsonProperty("expirationTime")]
        public System.Int32? ExpirationTime { get; set; }

        //      C# -> System.String? GroupPolicyId
        // GraphQL -> groupPolicyId: String (scalar)
        [JsonProperty("groupPolicyId")]
        public System.String? GroupPolicyId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? IntervalType
        // GraphQL -> intervalType: Int (scalar)
        [JsonProperty("intervalType")]
        public System.Int32? IntervalType { get; set; }

        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        [JsonProperty("jobDuration")]
        public System.Int32? JobDuration { get; set; }

        //      C# -> System.String? NeedSstableLoaderStr
        // GraphQL -> needSstableLoaderStr: String (scalar)
        [JsonProperty("needSstableLoaderStr")]
        public System.String? NeedSstableLoaderStr { get; set; }

        //      C# -> System.String? RsList
        // GraphQL -> rsList: String (scalar)
        [JsonProperty("rsList")]
        public System.String? RsList { get; set; }

        //      C# -> System.String? SourceMgmtObj
        // GraphQL -> sourceMgmtObj: String (scalar)
        [JsonProperty("sourceMgmtObj")]
        public System.String? SourceMgmtObj { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String (scalar)
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }

        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String (scalar)
        [JsonProperty("sourceType")]
        public System.String? SourceType { get; set; }

        //      C# -> System.String? SystemPolicyId
        // GraphQL -> systemPolicyId: String (scalar)
        [JsonProperty("systemPolicyId")]
        public System.String? SystemPolicyId { get; set; }

        //      C# -> System.Int32? Timestamp
        // GraphQL -> timestamp: Int (scalar)
        [JsonProperty("timestamp")]
        public System.Int32? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicVersionObject";
    }

    public MosaicVersionObject Set(
        MosaicVersionObjectVersionState? VersionState = null,
        System.String? DbInfo = null,
        System.Int32? ExpirationTime = null,
        System.String? GroupPolicyId = null,
        System.String? Id = null,
        System.Int32? IntervalType = null,
        System.Int32? JobDuration = null,
        System.String? NeedSstableLoaderStr = null,
        System.String? RsList = null,
        System.String? SourceMgmtObj = null,
        System.String? SourceName = null,
        System.String? SourceType = null,
        System.String? SystemPolicyId = null,
        System.Int32? Timestamp = null
    ) 
    {
        if ( VersionState != null ) {
            this.VersionState = VersionState;
        }
        if ( DbInfo != null ) {
            this.DbInfo = DbInfo;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( GroupPolicyId != null ) {
            this.GroupPolicyId = GroupPolicyId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IntervalType != null ) {
            this.IntervalType = IntervalType;
        }
        if ( JobDuration != null ) {
            this.JobDuration = JobDuration;
        }
        if ( NeedSstableLoaderStr != null ) {
            this.NeedSstableLoaderStr = NeedSstableLoaderStr;
        }
        if ( RsList != null ) {
            this.RsList = RsList;
        }
        if ( SourceMgmtObj != null ) {
            this.SourceMgmtObj = SourceMgmtObj;
        }
        if ( SourceName != null ) {
            this.SourceName = SourceName;
        }
        if ( SourceType != null ) {
            this.SourceType = SourceType;
        }
        if ( SystemPolicyId != null ) {
            this.SystemPolicyId = SystemPolicyId;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        if (this.VersionState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionState\n" ;
            } else {
                s += ind + "versionState\n" ;
            }
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbInfo\n" ;
            } else {
                s += ind + "dbInfo\n" ;
            }
        }
        //      C# -> System.Int32? ExpirationTime
        // GraphQL -> expirationTime: Int (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
            }
        }
        //      C# -> System.String? GroupPolicyId
        // GraphQL -> groupPolicyId: String (scalar)
        if (this.GroupPolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupPolicyId\n" ;
            } else {
                s += ind + "groupPolicyId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int32? IntervalType
        // GraphQL -> intervalType: Int (scalar)
        if (this.IntervalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "intervalType\n" ;
            } else {
                s += ind + "intervalType\n" ;
            }
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobDuration\n" ;
            } else {
                s += ind + "jobDuration\n" ;
            }
        }
        //      C# -> System.String? NeedSstableLoaderStr
        // GraphQL -> needSstableLoaderStr: String (scalar)
        if (this.NeedSstableLoaderStr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "needSstableLoaderStr\n" ;
            } else {
                s += ind + "needSstableLoaderStr\n" ;
            }
        }
        //      C# -> System.String? RsList
        // GraphQL -> rsList: String (scalar)
        if (this.RsList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rsList\n" ;
            } else {
                s += ind + "rsList\n" ;
            }
        }
        //      C# -> System.String? SourceMgmtObj
        // GraphQL -> sourceMgmtObj: String (scalar)
        if (this.SourceMgmtObj != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceMgmtObj\n" ;
            } else {
                s += ind + "sourceMgmtObj\n" ;
            }
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String (scalar)
        if (this.SourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceName\n" ;
            } else {
                s += ind + "sourceName\n" ;
            }
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String (scalar)
        if (this.SourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceType\n" ;
            } else {
                s += ind + "sourceType\n" ;
            }
        }
        //      C# -> System.String? SystemPolicyId
        // GraphQL -> systemPolicyId: String (scalar)
        if (this.SystemPolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemPolicyId\n" ;
            } else {
                s += ind + "systemPolicyId\n" ;
            }
        }
        //      C# -> System.Int32? Timestamp
        // GraphQL -> timestamp: Int (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        if (ec.Includes("versionState",true))
        {
            if(this.VersionState == null) {

                this.VersionState = new MosaicVersionObjectVersionState();

            } else {


            }
        }
        else if (this.VersionState != null && ec.Excludes("versionState",true))
        {
            this.VersionState = null;
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (ec.Includes("dbInfo",true))
        {
            if(this.DbInfo == null) {

                this.DbInfo = "FETCH";

            } else {


            }
        }
        else if (this.DbInfo != null && ec.Excludes("dbInfo",true))
        {
            this.DbInfo = null;
        }
        //      C# -> System.Int32? ExpirationTime
        // GraphQL -> expirationTime: Int (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = Int32.MinValue;

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
        }
        //      C# -> System.String? GroupPolicyId
        // GraphQL -> groupPolicyId: String (scalar)
        if (ec.Includes("groupPolicyId",true))
        {
            if(this.GroupPolicyId == null) {

                this.GroupPolicyId = "FETCH";

            } else {


            }
        }
        else if (this.GroupPolicyId != null && ec.Excludes("groupPolicyId",true))
        {
            this.GroupPolicyId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int32? IntervalType
        // GraphQL -> intervalType: Int (scalar)
        if (ec.Includes("intervalType",true))
        {
            if(this.IntervalType == null) {

                this.IntervalType = Int32.MinValue;

            } else {


            }
        }
        else if (this.IntervalType != null && ec.Excludes("intervalType",true))
        {
            this.IntervalType = null;
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (ec.Includes("jobDuration",true))
        {
            if(this.JobDuration == null) {

                this.JobDuration = Int32.MinValue;

            } else {


            }
        }
        else if (this.JobDuration != null && ec.Excludes("jobDuration",true))
        {
            this.JobDuration = null;
        }
        //      C# -> System.String? NeedSstableLoaderStr
        // GraphQL -> needSstableLoaderStr: String (scalar)
        if (ec.Includes("needSstableLoaderStr",true))
        {
            if(this.NeedSstableLoaderStr == null) {

                this.NeedSstableLoaderStr = "FETCH";

            } else {


            }
        }
        else if (this.NeedSstableLoaderStr != null && ec.Excludes("needSstableLoaderStr",true))
        {
            this.NeedSstableLoaderStr = null;
        }
        //      C# -> System.String? RsList
        // GraphQL -> rsList: String (scalar)
        if (ec.Includes("rsList",true))
        {
            if(this.RsList == null) {

                this.RsList = "FETCH";

            } else {


            }
        }
        else if (this.RsList != null && ec.Excludes("rsList",true))
        {
            this.RsList = null;
        }
        //      C# -> System.String? SourceMgmtObj
        // GraphQL -> sourceMgmtObj: String (scalar)
        if (ec.Includes("sourceMgmtObj",true))
        {
            if(this.SourceMgmtObj == null) {

                this.SourceMgmtObj = "FETCH";

            } else {


            }
        }
        else if (this.SourceMgmtObj != null && ec.Excludes("sourceMgmtObj",true))
        {
            this.SourceMgmtObj = null;
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String (scalar)
        if (ec.Includes("sourceName",true))
        {
            if(this.SourceName == null) {

                this.SourceName = "FETCH";

            } else {


            }
        }
        else if (this.SourceName != null && ec.Excludes("sourceName",true))
        {
            this.SourceName = null;
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String (scalar)
        if (ec.Includes("sourceType",true))
        {
            if(this.SourceType == null) {

                this.SourceType = "FETCH";

            } else {


            }
        }
        else if (this.SourceType != null && ec.Excludes("sourceType",true))
        {
            this.SourceType = null;
        }
        //      C# -> System.String? SystemPolicyId
        // GraphQL -> systemPolicyId: String (scalar)
        if (ec.Includes("systemPolicyId",true))
        {
            if(this.SystemPolicyId == null) {

                this.SystemPolicyId = "FETCH";

            } else {


            }
        }
        else if (this.SystemPolicyId != null && ec.Excludes("systemPolicyId",true))
        {
            this.SystemPolicyId = null;
        }
        //      C# -> System.Int32? Timestamp
        // GraphQL -> timestamp: Int (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = Int32.MinValue;

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
    }


    #endregion

    } // class MosaicVersionObject
    
    #endregion

    public static class ListMosaicVersionObjectExtensions
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
            this List<MosaicVersionObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MosaicVersionObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicVersionObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicVersionObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicVersionObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types