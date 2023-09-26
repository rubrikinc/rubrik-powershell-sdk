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

    public override string GetGqlTypeName() {
        return "ConnectionStatusDetails";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (this.SourceAndRubrik != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceAndRubrik\n" ;
            } else {
                s += ind + "sourceAndRubrik\n" ;
            }
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (this.SourceAndTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceAndTarget\n" ;
            } else {
                s += ind + "sourceAndTarget\n" ;
            }
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (this.TargetAndRubrik != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetAndRubrik\n" ;
            } else {
                s += ind + "targetAndRubrik\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (ec.Includes("sourceAndRubrik",true))
        {
            if(this.SourceAndRubrik == null) {

                this.SourceAndRubrik = new ClusterConnectionStatus();

            } else {


            }
        }
        else if (this.SourceAndRubrik != null && ec.Excludes("sourceAndRubrik",true))
        {
            this.SourceAndRubrik = null;
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (ec.Includes("sourceAndTarget",true))
        {
            if(this.SourceAndTarget == null) {

                this.SourceAndTarget = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.SourceAndTarget != null && ec.Excludes("sourceAndTarget",true))
        {
            this.SourceAndTarget = null;
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (ec.Includes("targetAndRubrik",true))
        {
            if(this.TargetAndRubrik == null) {

                this.TargetAndRubrik = new ClusterConnectionStatus();

            } else {


            }
        }
        else if (this.TargetAndRubrik != null && ec.Excludes("targetAndRubrik",true))
        {
            this.TargetAndRubrik = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConnectionStatusDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConnectionStatusDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConnectionStatusDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types