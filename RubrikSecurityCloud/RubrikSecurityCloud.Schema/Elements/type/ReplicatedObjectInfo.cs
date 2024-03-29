// ReplicatedObjectInfo.cs
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
    #region ReplicatedObjectInfo
    public class ReplicatedObjectInfo: BaseType
    {
        #region members

        //      C# -> System.String? CdmObjectId
        // GraphQL -> cdmObjectId: UUID! (scalar)
        [JsonProperty("cdmObjectId")]
        public System.String? CdmObjectId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicatedObjectInfo";
    }

    public ReplicatedObjectInfo Set(
        System.String? CdmObjectId = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.String? Fid = null
    ) 
    {
        if ( CdmObjectId != null ) {
            this.CdmObjectId = CdmObjectId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
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
        //      C# -> System.String? CdmObjectId
        // GraphQL -> cdmObjectId: UUID! (scalar)
        if (this.CdmObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmObjectId\n" ;
            } else {
                s += ind + "cdmObjectId\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmObjectId
        // GraphQL -> cdmObjectId: UUID! (scalar)
        if (ec.Includes("cdmObjectId",true))
        {
            if(this.CdmObjectId == null) {

                this.CdmObjectId = "FETCH";

            } else {


            }
        }
        else if (this.CdmObjectId != null && ec.Excludes("cdmObjectId",true))
        {
            this.CdmObjectId = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
    }


    #endregion

    } // class ReplicatedObjectInfo
    
    #endregion

    public static class ListReplicatedObjectInfoExtensions
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
            this List<ReplicatedObjectInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ReplicatedObjectInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicatedObjectInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicatedObjectInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicatedObjectInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types