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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        if (this.VersionState != null) {
            s += ind + "versionState\n" ;
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo != null) {
            s += ind + "dbInfo\n" ;
        }
        //      C# -> System.Int32? ExpirationTime
        // GraphQL -> expirationTime: Int (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.String? GroupPolicyId
        // GraphQL -> groupPolicyId: String (scalar)
        if (this.GroupPolicyId != null) {
            s += ind + "groupPolicyId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int32? IntervalType
        // GraphQL -> intervalType: Int (scalar)
        if (this.IntervalType != null) {
            s += ind + "intervalType\n" ;
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration != null) {
            s += ind + "jobDuration\n" ;
        }
        //      C# -> System.String? NeedSstableLoaderStr
        // GraphQL -> needSstableLoaderStr: String (scalar)
        if (this.NeedSstableLoaderStr != null) {
            s += ind + "needSstableLoaderStr\n" ;
        }
        //      C# -> System.String? RsList
        // GraphQL -> rsList: String (scalar)
        if (this.RsList != null) {
            s += ind + "rsList\n" ;
        }
        //      C# -> System.String? SourceMgmtObj
        // GraphQL -> sourceMgmtObj: String (scalar)
        if (this.SourceMgmtObj != null) {
            s += ind + "sourceMgmtObj\n" ;
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String (scalar)
        if (this.SourceName != null) {
            s += ind + "sourceName\n" ;
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String (scalar)
        if (this.SourceType != null) {
            s += ind + "sourceType\n" ;
        }
        //      C# -> System.String? SystemPolicyId
        // GraphQL -> systemPolicyId: String (scalar)
        if (this.SystemPolicyId != null) {
            s += ind + "systemPolicyId\n" ;
        }
        //      C# -> System.Int32? Timestamp
        // GraphQL -> timestamp: Int (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        if (this.VersionState == null && Exploration.Includes(parent + ".versionState", true))
        {
            this.VersionState = new MosaicVersionObjectVersionState();
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo == null && Exploration.Includes(parent + ".dbInfo", true))
        {
            this.DbInfo = new System.String("FETCH");
        }
        //      C# -> System.Int32? ExpirationTime
        // GraphQL -> expirationTime: Int (scalar)
        if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime", true))
        {
            this.ExpirationTime = new System.Int32();
        }
        //      C# -> System.String? GroupPolicyId
        // GraphQL -> groupPolicyId: String (scalar)
        if (this.GroupPolicyId == null && Exploration.Includes(parent + ".groupPolicyId", true))
        {
            this.GroupPolicyId = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Int32? IntervalType
        // GraphQL -> intervalType: Int (scalar)
        if (this.IntervalType == null && Exploration.Includes(parent + ".intervalType", true))
        {
            this.IntervalType = new System.Int32();
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration == null && Exploration.Includes(parent + ".jobDuration", true))
        {
            this.JobDuration = new System.Int32();
        }
        //      C# -> System.String? NeedSstableLoaderStr
        // GraphQL -> needSstableLoaderStr: String (scalar)
        if (this.NeedSstableLoaderStr == null && Exploration.Includes(parent + ".needSstableLoaderStr", true))
        {
            this.NeedSstableLoaderStr = new System.String("FETCH");
        }
        //      C# -> System.String? RsList
        // GraphQL -> rsList: String (scalar)
        if (this.RsList == null && Exploration.Includes(parent + ".rsList", true))
        {
            this.RsList = new System.String("FETCH");
        }
        //      C# -> System.String? SourceMgmtObj
        // GraphQL -> sourceMgmtObj: String (scalar)
        if (this.SourceMgmtObj == null && Exploration.Includes(parent + ".sourceMgmtObj", true))
        {
            this.SourceMgmtObj = new System.String("FETCH");
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String (scalar)
        if (this.SourceName == null && Exploration.Includes(parent + ".sourceName", true))
        {
            this.SourceName = new System.String("FETCH");
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String (scalar)
        if (this.SourceType == null && Exploration.Includes(parent + ".sourceType", true))
        {
            this.SourceType = new System.String("FETCH");
        }
        //      C# -> System.String? SystemPolicyId
        // GraphQL -> systemPolicyId: String (scalar)
        if (this.SystemPolicyId == null && Exploration.Includes(parent + ".systemPolicyId", true))
        {
            this.SystemPolicyId = new System.String("FETCH");
        }
        //      C# -> System.Int32? Timestamp
        // GraphQL -> timestamp: Int (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = new System.Int32();
        }
    }


    #endregion

    } // class MosaicVersionObject
    
    #endregion

    public static class ListMosaicVersionObjectExtensions
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
            this List<MosaicVersionObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicVersionObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicVersionObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types