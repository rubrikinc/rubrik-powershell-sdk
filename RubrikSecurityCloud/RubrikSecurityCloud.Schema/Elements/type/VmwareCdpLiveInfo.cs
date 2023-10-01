// VmwareCdpLiveInfo.cs
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
    #region VmwareCdpLiveInfo
    public class VmwareCdpLiveInfo: BaseType
    {
        #region members

        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        [JsonProperty("currentTime")]
        public DateTime? CurrentTime { get; set; }

        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        [JsonProperty("localRecoveryPoint")]
        public DateTime? LocalRecoveryPoint { get; set; }

        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        [JsonProperty("remoteRecoveryPoint")]
        public DateTime? RemoteRecoveryPoint { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareCdpLiveInfo";
    }

    public VmwareCdpLiveInfo Set(
        DateTime? CurrentTime = null,
        DateTime? LocalRecoveryPoint = null,
        DateTime? RemoteRecoveryPoint = null,
        System.String? VmId = null
    ) 
    {
        if ( CurrentTime != null ) {
            this.CurrentTime = CurrentTime;
        }
        if ( LocalRecoveryPoint != null ) {
            this.LocalRecoveryPoint = LocalRecoveryPoint;
        }
        if ( RemoteRecoveryPoint != null ) {
            this.RemoteRecoveryPoint = RemoteRecoveryPoint;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        if (this.CurrentTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTime\n" ;
            } else {
                s += ind + "currentTime\n" ;
            }
        }
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localRecoveryPoint\n" ;
            } else {
                s += ind + "localRecoveryPoint\n" ;
            }
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remoteRecoveryPoint\n" ;
            } else {
                s += ind + "remoteRecoveryPoint\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        if (ec.Includes("currentTime",true))
        {
            if(this.CurrentTime == null) {

                this.CurrentTime = new DateTime();

            } else {


            }
        }
        else if (this.CurrentTime != null && ec.Excludes("currentTime",true))
        {
            this.CurrentTime = null;
        }
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (ec.Includes("localRecoveryPoint",true))
        {
            if(this.LocalRecoveryPoint == null) {

                this.LocalRecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.LocalRecoveryPoint != null && ec.Excludes("localRecoveryPoint",true))
        {
            this.LocalRecoveryPoint = null;
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (ec.Includes("remoteRecoveryPoint",true))
        {
            if(this.RemoteRecoveryPoint == null) {

                this.RemoteRecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.RemoteRecoveryPoint != null && ec.Excludes("remoteRecoveryPoint",true))
        {
            this.RemoteRecoveryPoint = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
    }


    #endregion

    } // class VmwareCdpLiveInfo
    
    #endregion

    public static class ListVmwareCdpLiveInfoExtensions
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
            this List<VmwareCdpLiveInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VmwareCdpLiveInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareCdpLiveInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareCdpLiveInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareCdpLiveInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types