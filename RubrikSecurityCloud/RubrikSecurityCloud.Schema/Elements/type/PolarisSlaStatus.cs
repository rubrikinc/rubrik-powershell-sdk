// PolarisSlaStatus.cs
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
    #region PolarisSlaStatus
    public class PolarisSlaStatus: BaseType
    {
        #region members

        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        [JsonProperty("pauseStatus")]
        public PauseStatus? PauseStatus { get; set; }

        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        [JsonProperty("syncStatus")]
        public SlaSyncStatus? SyncStatus { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public PolarisSlaStatus Set(
        PauseStatus? PauseStatus = null,
        SlaSyncStatus? SyncStatus = null,
        Cluster? Cluster = null
    ) 
    {
        if ( PauseStatus != null ) {
            this.PauseStatus = PauseStatus;
        }
        if ( SyncStatus != null ) {
            this.SyncStatus = SyncStatus;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        if (this.PauseStatus != null) {
            s += ind + "pauseStatus\n" ;
        }
        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        if (this.SyncStatus != null) {
            s += ind + "syncStatus\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PauseStatus? PauseStatus
        // GraphQL -> pauseStatus: PauseStatus! (enum)
        if (this.PauseStatus == null && Exploration.Includes(parent + ".pauseStatus", true))
        {
            this.PauseStatus = new PauseStatus();
        }
        //      C# -> SlaSyncStatus? SyncStatus
        // GraphQL -> syncStatus: SlaSyncStatus! (enum)
        if (this.SyncStatus == null && Exploration.Includes(parent + ".syncStatus", true))
        {
            this.SyncStatus = new SlaSyncStatus();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
    }


    #endregion

    } // class PolarisSlaStatus
    
    #endregion

    public static class ListPolarisSlaStatusExtensions
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
            this List<PolarisSlaStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSlaStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSlaStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types