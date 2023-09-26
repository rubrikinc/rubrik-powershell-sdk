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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "GlobalSlaSyncStatus";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        if (this.SlaSyncStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaSyncStatus\n" ;
            } else {
                s += ind + "slaSyncStatus\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaSyncStatus? SlaSyncStatus
        // GraphQL -> slaSyncStatus: SlaSyncStatus! (enum)
        if (ec.Includes("slaSyncStatus",true))
        {
            if(this.SlaSyncStatus == null) {

                this.SlaSyncStatus = new SlaSyncStatus();

            } else {


            }
        }
        else if (this.SlaSyncStatus != null && ec.Excludes("slaSyncStatus",true))
        {
            this.SlaSyncStatus = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSlaSyncStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSlaSyncStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalSlaSyncStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types