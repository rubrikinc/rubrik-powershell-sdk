// NasMigrationShareDetail.cs
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
    #region NasMigrationShareDetail
    public class NasMigrationShareDetail: BaseType
    {
        #region members

        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        [JsonProperty("exportPoint")]
        public System.String? ExportPoint { get; set; }

        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        [JsonProperty("hostShareCdmId")]
        public System.String? HostShareCdmId { get; set; }

        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        [JsonProperty("hostShareFid")]
        public System.String? HostShareFid { get; set; }

        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        [JsonProperty("mappedNasShareExportPoint")]
        public System.String? MappedNasShareExportPoint { get; set; }

        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        [JsonProperty("mappedNasShareFid")]
        public System.String? MappedNasShareFid { get; set; }

        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        [JsonProperty("shareType")]
        public System.String? ShareType { get; set; }

        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        [JsonProperty("filesets")]
        public List<NasMigrationFilesetDetail>? Filesets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationShareDetail";
    }

    public NasMigrationShareDetail Set(
        System.String? ExportPoint = null,
        System.String? HostShareCdmId = null,
        System.String? HostShareFid = null,
        System.String? MappedNasShareExportPoint = null,
        System.String? MappedNasShareFid = null,
        System.String? ShareType = null,
        List<NasMigrationFilesetDetail>? Filesets = null
    ) 
    {
        if ( ExportPoint != null ) {
            this.ExportPoint = ExportPoint;
        }
        if ( HostShareCdmId != null ) {
            this.HostShareCdmId = HostShareCdmId;
        }
        if ( HostShareFid != null ) {
            this.HostShareFid = HostShareFid;
        }
        if ( MappedNasShareExportPoint != null ) {
            this.MappedNasShareExportPoint = MappedNasShareExportPoint;
        }
        if ( MappedNasShareFid != null ) {
            this.MappedNasShareFid = MappedNasShareFid;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( Filesets != null ) {
            this.Filesets = Filesets;
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
        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        if (this.ExportPoint != null) {
            s += ind + "exportPoint\n" ;
        }
        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        if (this.HostShareCdmId != null) {
            s += ind + "hostShareCdmId\n" ;
        }
        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        if (this.HostShareFid != null) {
            s += ind + "hostShareFid\n" ;
        }
        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        if (this.MappedNasShareExportPoint != null) {
            s += ind + "mappedNasShareExportPoint\n" ;
        }
        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        if (this.MappedNasShareFid != null) {
            s += ind + "mappedNasShareFid\n" ;
        }
        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        if (this.ShareType != null) {
            s += ind + "shareType\n" ;
        }
        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        if (this.Filesets != null) {
            var fspec = this.Filesets.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filesets {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        if (this.ExportPoint == null && Exploration.Includes(parent + ".exportPoint", true))
        {
            this.ExportPoint = "FETCH";
        }
        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        if (this.HostShareCdmId == null && Exploration.Includes(parent + ".hostShareCdmId", true))
        {
            this.HostShareCdmId = "FETCH";
        }
        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        if (this.HostShareFid == null && Exploration.Includes(parent + ".hostShareFid", true))
        {
            this.HostShareFid = "FETCH";
        }
        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        if (this.MappedNasShareExportPoint == null && Exploration.Includes(parent + ".mappedNasShareExportPoint", true))
        {
            this.MappedNasShareExportPoint = "FETCH";
        }
        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        if (this.MappedNasShareFid == null && Exploration.Includes(parent + ".mappedNasShareFid", true))
        {
            this.MappedNasShareFid = "FETCH";
        }
        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        if (this.ShareType == null && Exploration.Includes(parent + ".shareType", true))
        {
            this.ShareType = "FETCH";
        }
        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        if (this.Filesets == null && Exploration.Includes(parent + ".filesets"))
        {
            this.Filesets = new List<NasMigrationFilesetDetail>();
            this.Filesets.ApplyExploratoryFieldSpec(parent + ".filesets");
        }
    }


    #endregion

    } // class NasMigrationShareDetail
    
    #endregion

    public static class ListNasMigrationShareDetailExtensions
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
            this List<NasMigrationShareDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationShareDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationShareDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types