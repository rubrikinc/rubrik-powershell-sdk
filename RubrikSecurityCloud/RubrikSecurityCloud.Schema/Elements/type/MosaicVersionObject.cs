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

namespace Rubrik.SecurityCloud.Types
{
    #region MosaicVersionObject
    public class MosaicVersionObject: IFragment
    {
        #region members
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

        //      C# -> MosaicVersionObjectVersionState? VersionState
        // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
        [JsonProperty("versionState")]
        public MosaicVersionObjectVersionState? VersionState { get; set; }

        #endregion

    #region methods

    public MosaicVersionObject Set(
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
        System.Int32? Timestamp = null,
        MosaicVersionObjectVersionState? VersionState = null
    ) 
    {
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
        if ( VersionState != null ) {
            this.VersionState = VersionState;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? DbInfo
            // GraphQL -> dbInfo: String (scalar)
            if (this.DbInfo != null)
            {
                 s += ind + "dbInfo\n";

            }
            //      C# -> System.Int32? ExpirationTime
            // GraphQL -> expirationTime: Int (scalar)
            if (this.ExpirationTime != null)
            {
                 s += ind + "expirationTime\n";

            }
            //      C# -> System.String? GroupPolicyId
            // GraphQL -> groupPolicyId: String (scalar)
            if (this.GroupPolicyId != null)
            {
                 s += ind + "groupPolicyId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int32? IntervalType
            // GraphQL -> intervalType: Int (scalar)
            if (this.IntervalType != null)
            {
                 s += ind + "intervalType\n";

            }
            //      C# -> System.Int32? JobDuration
            // GraphQL -> jobDuration: Int (scalar)
            if (this.JobDuration != null)
            {
                 s += ind + "jobDuration\n";

            }
            //      C# -> System.String? NeedSstableLoaderStr
            // GraphQL -> needSstableLoaderStr: String (scalar)
            if (this.NeedSstableLoaderStr != null)
            {
                 s += ind + "needSstableLoaderStr\n";

            }
            //      C# -> System.String? RsList
            // GraphQL -> rsList: String (scalar)
            if (this.RsList != null)
            {
                 s += ind + "rsList\n";

            }
            //      C# -> System.String? SourceMgmtObj
            // GraphQL -> sourceMgmtObj: String (scalar)
            if (this.SourceMgmtObj != null)
            {
                 s += ind + "sourceMgmtObj\n";

            }
            //      C# -> System.String? SourceName
            // GraphQL -> sourceName: String (scalar)
            if (this.SourceName != null)
            {
                 s += ind + "sourceName\n";

            }
            //      C# -> System.String? SourceType
            // GraphQL -> sourceType: String (scalar)
            if (this.SourceType != null)
            {
                 s += ind + "sourceType\n";

            }
            //      C# -> System.String? SystemPolicyId
            // GraphQL -> systemPolicyId: String (scalar)
            if (this.SystemPolicyId != null)
            {
                 s += ind + "systemPolicyId\n";

            }
            //      C# -> System.Int32? Timestamp
            // GraphQL -> timestamp: Int (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            //      C# -> MosaicVersionObjectVersionState? VersionState
            // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
            if (this.VersionState != null)
            {
                 s += ind + "versionState\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DbInfo
            // GraphQL -> dbInfo: String (scalar)
            if (this.DbInfo == null && Exploration.Includes(parent + ".dbInfo$"))
            {
                this.DbInfo = new System.String("FETCH");
            }
            //      C# -> System.Int32? ExpirationTime
            // GraphQL -> expirationTime: Int (scalar)
            if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime$"))
            {
                this.ExpirationTime = new System.Int32();
            }
            //      C# -> System.String? GroupPolicyId
            // GraphQL -> groupPolicyId: String (scalar)
            if (this.GroupPolicyId == null && Exploration.Includes(parent + ".groupPolicyId$"))
            {
                this.GroupPolicyId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int32? IntervalType
            // GraphQL -> intervalType: Int (scalar)
            if (this.IntervalType == null && Exploration.Includes(parent + ".intervalType$"))
            {
                this.IntervalType = new System.Int32();
            }
            //      C# -> System.Int32? JobDuration
            // GraphQL -> jobDuration: Int (scalar)
            if (this.JobDuration == null && Exploration.Includes(parent + ".jobDuration$"))
            {
                this.JobDuration = new System.Int32();
            }
            //      C# -> System.String? NeedSstableLoaderStr
            // GraphQL -> needSstableLoaderStr: String (scalar)
            if (this.NeedSstableLoaderStr == null && Exploration.Includes(parent + ".needSstableLoaderStr$"))
            {
                this.NeedSstableLoaderStr = new System.String("FETCH");
            }
            //      C# -> System.String? RsList
            // GraphQL -> rsList: String (scalar)
            if (this.RsList == null && Exploration.Includes(parent + ".rsList$"))
            {
                this.RsList = new System.String("FETCH");
            }
            //      C# -> System.String? SourceMgmtObj
            // GraphQL -> sourceMgmtObj: String (scalar)
            if (this.SourceMgmtObj == null && Exploration.Includes(parent + ".sourceMgmtObj$"))
            {
                this.SourceMgmtObj = new System.String("FETCH");
            }
            //      C# -> System.String? SourceName
            // GraphQL -> sourceName: String (scalar)
            if (this.SourceName == null && Exploration.Includes(parent + ".sourceName$"))
            {
                this.SourceName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceType
            // GraphQL -> sourceType: String (scalar)
            if (this.SourceType == null && Exploration.Includes(parent + ".sourceType$"))
            {
                this.SourceType = new System.String("FETCH");
            }
            //      C# -> System.String? SystemPolicyId
            // GraphQL -> systemPolicyId: String (scalar)
            if (this.SystemPolicyId == null && Exploration.Includes(parent + ".systemPolicyId$"))
            {
                this.SystemPolicyId = new System.String("FETCH");
            }
            //      C# -> System.Int32? Timestamp
            // GraphQL -> timestamp: Int (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new System.Int32();
            }
            //      C# -> MosaicVersionObjectVersionState? VersionState
            // GraphQL -> versionState: MosaicVersionObjectVersionState (enum)
            if (this.VersionState == null && Exploration.Includes(parent + ".versionState$"))
            {
                this.VersionState = new MosaicVersionObjectVersionState();
            }
        }


    #endregion

    } // class MosaicVersionObject
    #endregion

    public static class ListMosaicVersionObjectExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<MosaicVersionObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicVersionObject> list, 
            String parent = "")
        {
            var item = new MosaicVersionObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types