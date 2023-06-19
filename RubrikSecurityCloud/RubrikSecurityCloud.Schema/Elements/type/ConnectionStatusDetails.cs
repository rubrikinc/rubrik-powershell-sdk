// ConnectionStatusDetails.cs
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
    #region ConnectionStatusDetails
    public class ConnectionStatusDetails: BaseType
    {
        #region members

        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("sourceAndRubrik")]
        public ClusterConnectionStatus? SourceAndRubrik { get; set; }

        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        [JsonProperty("sourceAndTarget")]
        public ConnectionStatusType? SourceAndTarget { get; set; }

        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("targetAndRubrik")]
        public ClusterConnectionStatus? TargetAndRubrik { get; set; }


        #endregion

    #region methods

    public ConnectionStatusDetails Set(
        ClusterConnectionStatus? SourceAndRubrik = null,
        ConnectionStatusType? SourceAndTarget = null,
        ClusterConnectionStatus? TargetAndRubrik = null
    ) 
    {
        if ( SourceAndRubrik != null ) {
            this.SourceAndRubrik = SourceAndRubrik;
        }
        if ( SourceAndTarget != null ) {
            this.SourceAndTarget = SourceAndTarget;
        }
        if ( TargetAndRubrik != null ) {
            this.TargetAndRubrik = TargetAndRubrik;
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
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (this.SourceAndRubrik != null) {
            s += ind + "sourceAndRubrik\n" ;
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (this.SourceAndTarget != null) {
            s += ind + "sourceAndTarget\n" ;
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (this.TargetAndRubrik != null) {
            s += ind + "targetAndRubrik\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (this.SourceAndRubrik == null && Exploration.Includes(parent + ".sourceAndRubrik", true))
        {
            this.SourceAndRubrik = new ClusterConnectionStatus();
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (this.SourceAndTarget == null && Exploration.Includes(parent + ".sourceAndTarget", true))
        {
            this.SourceAndTarget = new ConnectionStatusType();
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (this.TargetAndRubrik == null && Exploration.Includes(parent + ".targetAndRubrik", true))
        {
            this.TargetAndRubrik = new ClusterConnectionStatus();
        }
    }


    #endregion

    } // class ConnectionStatusDetails
    
    #endregion

    public static class ListConnectionStatusDetailsExtensions
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
            this List<ConnectionStatusDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConnectionStatusDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ConnectionStatusDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types