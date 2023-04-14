// AnomalyResultGroupedData.cs
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
    #region AnomalyResultGroupedData
    public class AnomalyResultGroupedData: IFragment
    {
        #region members
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        [JsonProperty("anomalyResultGroupedData")]
        public List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField { get; set; }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        [JsonProperty("anomalyResults")]
        public AnomalyResultConnection? AnomalyResults { get; set; }

        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public AnomalyResultGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public AnomalyResultGroupedData Set(
        List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField = null,
        AnomalyResultConnection? AnomalyResults = null,
        AnomalyResultGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AnomalyResultGroupedDataField != null ) {
            this.AnomalyResultGroupedDataField = AnomalyResultGroupedDataField;
        }
        if ( AnomalyResults != null ) {
            this.AnomalyResults = AnomalyResults;
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
            //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
            // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
            if (this.AnomalyResultGroupedDataField != null)
            {
                 s += ind + "anomalyResultGroupedData\n";

                 s += ind + "{\n" + 
                 this.AnomalyResultGroupedDataField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnomalyResultConnection? AnomalyResults
            // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
            if (this.AnomalyResults != null)
            {
                 s += ind + "anomalyResults\n";

                 s += ind + "{\n" + 
                 this.AnomalyResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnomalyResultGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
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
            //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
            // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
            if (this.AnomalyResultGroupedDataField == null && Exploration.Includes(parent + ".anomalyResultGroupedData"))
            {
                this.AnomalyResultGroupedDataField = new List<AnomalyResultGroupedData>();
                this.AnomalyResultGroupedDataField.ApplyExploratoryFragment(parent + ".anomalyResultGroupedData");
            }
            //      C# -> AnomalyResultConnection? AnomalyResults
            // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
            if (this.AnomalyResults == null && Exploration.Includes(parent + ".anomalyResults"))
            {
                this.AnomalyResults = new AnomalyResultConnection();
                this.AnomalyResults.ApplyExploratoryFragment(parent + ".anomalyResults");
            }
            //      C# -> AnomalyResultGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (AnomalyResultGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(AnomalyResultGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class AnomalyResultGroupedData
    #endregion

    public static class ListAnomalyResultGroupedDataExtensions
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
            this List<AnomalyResultGroupedData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnomalyResultGroupedData> list, 
            String parent = "")
        {
            var item = new AnomalyResultGroupedData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types