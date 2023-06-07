// GlobalSlaSyncStatus.cs
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
    #region GlobalSlaSyncStatus
    public class GlobalSlaSyncStatus: BaseType
    {
        #region members

        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        [JsonProperty("slaSyncStatus")]
        public SlaSyncStatus? SlaSyncStatus { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


        #endregion

    #region methods

    public GlobalSlaSyncStatus Set(
        SlaSyncStatus? SlaSyncStatus = null,
        System.String? ClusterUuid = null
    ) 
    {
        if ( SlaSyncStatus != null ) {
            this.SlaSyncStatus = SlaSyncStatus;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
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
        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        if (this.SlaSyncStatus != null) {
            s += ind + "slaSyncStatus\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        if (this.SlaSyncStatus == null && Exploration.Includes(parent + ".slaSyncStatus", true))
        {
            this.SlaSyncStatus = new SlaSyncStatus();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
    }


    #endregion

    } // class GlobalSlaSyncStatus
    
    #endregion

    public static class ListGlobalSlaSyncStatusExtensions
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
            this List<GlobalSlaSyncStatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSlaSyncStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSlaSyncStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types