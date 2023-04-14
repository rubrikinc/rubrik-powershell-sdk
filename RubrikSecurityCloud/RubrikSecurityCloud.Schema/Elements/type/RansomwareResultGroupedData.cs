// RansomwareResultGroupedData.cs
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
    #region RansomwareResultGroupedData
    public class RansomwareResultGroupedData: IFragment
    {
        #region members
        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        [JsonProperty("ransomwareResultGroupedData")]
        public List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField { get; set; }

        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        [JsonProperty("ransomwareResults")]
        public RansomwareResultConnection? RansomwareResults { get; set; }

        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public RansomwareResultGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public RansomwareResultGroupedData Set(
        List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField = null,
        RansomwareResultConnection? RansomwareResults = null,
        RansomwareResultGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( RansomwareResultGroupedDataField != null ) {
            this.RansomwareResultGroupedDataField = RansomwareResultGroupedDataField;
        }
        if ( RansomwareResults != null ) {
            this.RansomwareResults = RansomwareResults;
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
            //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
            // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
            if (this.RansomwareResultGroupedDataField != null)
            {
                 s += ind + "ransomwareResultGroupedData\n";

                 s += ind + "{\n" + 
                 this.RansomwareResultGroupedDataField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RansomwareResultConnection? RansomwareResults
            // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
            if (this.RansomwareResults != null)
            {
                 s += ind + "ransomwareResults\n";

                 s += ind + "{\n" + 
                 this.RansomwareResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RansomwareResultGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
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
            //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
            // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
            if (this.RansomwareResultGroupedDataField == null && Exploration.Includes(parent + ".ransomwareResultGroupedData"))
            {
                this.RansomwareResultGroupedDataField = new List<RansomwareResultGroupedData>();
                this.RansomwareResultGroupedDataField.ApplyExploratoryFragment(parent + ".ransomwareResultGroupedData");
            }
            //      C# -> RansomwareResultConnection? RansomwareResults
            // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
            if (this.RansomwareResults == null && Exploration.Includes(parent + ".ransomwareResults"))
            {
                this.RansomwareResults = new RansomwareResultConnection();
                this.RansomwareResults.ApplyExploratoryFragment(parent + ".ransomwareResults");
            }
            //      C# -> RansomwareResultGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (RansomwareResultGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(RansomwareResultGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class RansomwareResultGroupedData
    #endregion

    public static class ListRansomwareResultGroupedDataExtensions
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
            this List<RansomwareResultGroupedData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RansomwareResultGroupedData> list, 
            String parent = "")
        {
            var item = new RansomwareResultGroupedData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types