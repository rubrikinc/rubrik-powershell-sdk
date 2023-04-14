// CdmSnapshotGroupBy.cs
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
    #region CdmSnapshotGroupBy
    public class CdmSnapshotGroupBy: IFragment
    {
        #region members
        //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
        // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
        [JsonProperty("cdmSnapshotGroupBy")]
        public List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public CdmSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public CdmSnapshotGroupBy Set(
        List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        CdmSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( CdmSnapshotGroupByField != null ) {
            this.CdmSnapshotGroupByField = CdmSnapshotGroupByField;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
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
            //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
            // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
            if (this.CdmSnapshotGroupByField != null)
            {
                 s += ind + "cdmSnapshotGroupBy\n";

                 s += ind + "{\n" + 
                 this.CdmSnapshotGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
            if (this.SnapshotConnection != null)
            {
                 s += ind + "snapshotConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
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
            //      C# -> List<CdmSnapshotGroupBy>? CdmSnapshotGroupByField
            // GraphQL -> cdmSnapshotGroupBy: [CdmSnapshotGroupBy!]! (type)
            if (this.CdmSnapshotGroupByField == null && Exploration.Includes(parent + ".cdmSnapshotGroupBy"))
            {
                this.CdmSnapshotGroupByField = new List<CdmSnapshotGroupBy>();
                this.CdmSnapshotGroupByField.ApplyExploratoryFragment(parent + ".cdmSnapshotGroupBy");
            }
            //      C# -> CdmSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: CdmSnapshotConnection! (type)
            if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
            {
                this.SnapshotConnection = new CdmSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFragment(parent + ".snapshotConnection");
            }
            //      C# -> CdmSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: CdmSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (CdmSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(CdmSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class CdmSnapshotGroupBy
    #endregion

    public static class ListCdmSnapshotGroupByExtensions
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
            this List<CdmSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmSnapshotGroupBy> list, 
            String parent = "")
        {
            var item = new CdmSnapshotGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types