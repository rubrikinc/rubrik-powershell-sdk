// CdmMssqlDbReplicaAvailabilityInfo.cs
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
    #region CdmMssqlDbReplicaAvailabilityInfo
    public class CdmMssqlDbReplicaAvailabilityInfo: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        [JsonProperty("availabilityMode")]
        public System.String? AvailabilityMode { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMssqlDbReplicaAvailabilityInfo";
    }

    public CdmMssqlDbReplicaAvailabilityInfo Set(
        System.String? AvailabilityMode = null,
        System.String? ReplicaId = null,
        System.String? Role = null
    ) 
    {
        if ( AvailabilityMode != null ) {
            this.AvailabilityMode = AvailabilityMode;
        }
        if ( ReplicaId != null ) {
            this.ReplicaId = ReplicaId;
        }
        if ( Role != null ) {
            this.Role = Role;
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
        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        if (this.AvailabilityMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityMode\n" ;
            } else {
                s += ind + "availabilityMode\n" ;
            }
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (this.ReplicaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaId\n" ;
            } else {
                s += ind + "replicaId\n" ;
            }
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        if (ec.Includes("availabilityMode",true))
        {
            if(this.AvailabilityMode == null) {

                this.AvailabilityMode = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilityMode != null && ec.Excludes("availabilityMode",true))
        {
            this.AvailabilityMode = null;
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (ec.Includes("replicaId",true))
        {
            if(this.ReplicaId == null) {

                this.ReplicaId = "FETCH";

            } else {


            }
        }
        else if (this.ReplicaId != null && ec.Excludes("replicaId",true))
        {
            this.ReplicaId = null;
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = "FETCH";

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
    }


    #endregion

    } // class CdmMssqlDbReplicaAvailabilityInfo
    
    #endregion

    public static class ListCdmMssqlDbReplicaAvailabilityInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CdmMssqlDbReplicaAvailabilityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmMssqlDbReplicaAvailabilityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmMssqlDbReplicaAvailabilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMssqlDbReplicaAvailabilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMssqlDbReplicaAvailabilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types