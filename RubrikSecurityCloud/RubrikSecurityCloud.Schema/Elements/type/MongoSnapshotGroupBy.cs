// MongoSnapshotGroupBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:43.
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
    #region MongoSnapshotGroupBy
    public class MongoSnapshotGroupBy: IFragment
    {
        #region members
        //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
        // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
        [JsonProperty("mongoSnapshotConnection")]
        public CdmSnapshotConnection? MongoSnapshotConnection { get; set; }

        //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
        // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
        [JsonProperty("mongoSnapshotGroupBy")]
        public List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField { get; set; }

        //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MongoSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public MongoSnapshotGroupBy Set(
        CdmSnapshotConnection? MongoSnapshotConnection = null,
        List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField = null,
        MongoSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( MongoSnapshotConnection != null ) {
            this.MongoSnapshotConnection = MongoSnapshotConnection;
        }
        if ( MongoSnapshotGroupByField != null ) {
            this.MongoSnapshotGroupByField = MongoSnapshotGroupByField;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
            //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
            // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
            if (this.MongoSnapshotConnection != null)
            {
                 s += ind + "mongoSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.MongoSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
            // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
            if (this.MongoSnapshotGroupByField != null)
            {
                 s += ind + "mongoSnapshotGroupBy\n";

                 s += ind + "{\n" + 
                 this.MongoSnapshotGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
            if (this.GroupByInfo != null)
            {
                 s += ind + "groupByInfo\n";

                 s += ind + "{\n" + 
                 this.GroupByInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> CdmSnapshotConnection? MongoSnapshotConnection
            // GraphQL -> mongoSnapshotConnection: CdmSnapshotConnection! (type)
            if (this.MongoSnapshotConnection == null && Exploration.Includes(parent + ".mongoSnapshotConnection"))
            {
                this.MongoSnapshotConnection = new CdmSnapshotConnection();
                this.MongoSnapshotConnection.ApplyExploratoryFragment(parent + ".mongoSnapshotConnection");
            }
            //      C# -> List<MongoSnapshotGroupBy>? MongoSnapshotGroupByField
            // GraphQL -> mongoSnapshotGroupBy: [MongoSnapshotGroupBy!]! (type)
            if (this.MongoSnapshotGroupByField == null && Exploration.Includes(parent + ".mongoSnapshotGroupBy"))
            {
                this.MongoSnapshotGroupByField = new List<MongoSnapshotGroupBy>();
                this.MongoSnapshotGroupByField.ApplyExploratoryFragment(parent + ".mongoSnapshotGroupBy");
            }
            //      C# -> MongoSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MongoSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (MongoSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(MongoSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class MongoSnapshotGroupBy
    #endregion

    public static class ListMongoSnapshotGroupByExtensions
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
            this List<MongoSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MongoSnapshotGroupBy> list, 
            String parent = "")
        {
            var item = new MongoSnapshotGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types