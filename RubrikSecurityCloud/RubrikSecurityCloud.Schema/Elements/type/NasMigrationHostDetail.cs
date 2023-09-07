// NasMigrationHostDetail.cs
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
    #region NasMigrationHostDetail
    public class NasMigrationHostDetail: BaseType
    {
        #region members

        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        [JsonProperty("hostCdmId")]
        public System.String? HostCdmId { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        [JsonProperty("mappedDataSourceCdmId")]
        public System.String? MappedDataSourceCdmId { get; set; }

        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        [JsonProperty("mappedDataSourceFid")]
        public System.String? MappedDataSourceFid { get; set; }

        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        [JsonProperty("mappedDataSourceName")]
        public System.String? MappedDataSourceName { get; set; }

        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        [JsonProperty("mappedDataSourceType")]
        public System.String? MappedDataSourceType { get; set; }

        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        [JsonProperty("shares")]
        public List<NasMigrationShareDetail>? Shares { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationHostDetail";
    }

    public NasMigrationHostDetail Set(
        System.String? HostCdmId = null,
        System.String? HostFid = null,
        System.String? Hostname = null,
        System.String? MappedDataSourceCdmId = null,
        System.String? MappedDataSourceFid = null,
        System.String? MappedDataSourceName = null,
        System.String? MappedDataSourceType = null,
        List<NasMigrationShareDetail>? Shares = null
    ) 
    {
        if ( HostCdmId != null ) {
            this.HostCdmId = HostCdmId;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( MappedDataSourceCdmId != null ) {
            this.MappedDataSourceCdmId = MappedDataSourceCdmId;
        }
        if ( MappedDataSourceFid != null ) {
            this.MappedDataSourceFid = MappedDataSourceFid;
        }
        if ( MappedDataSourceName != null ) {
            this.MappedDataSourceName = MappedDataSourceName;
        }
        if ( MappedDataSourceType != null ) {
            this.MappedDataSourceType = MappedDataSourceType;
        }
        if ( Shares != null ) {
            this.Shares = Shares;
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
        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        if (this.HostCdmId != null) {
            s += ind + "hostCdmId\n" ;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        if (this.HostFid != null) {
            s += ind + "hostFid\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        if (this.MappedDataSourceCdmId != null) {
            s += ind + "mappedDataSourceCdmId\n" ;
        }
        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        if (this.MappedDataSourceFid != null) {
            s += ind + "mappedDataSourceFid\n" ;
        }
        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        if (this.MappedDataSourceName != null) {
            s += ind + "mappedDataSourceName\n" ;
        }
        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        if (this.MappedDataSourceType != null) {
            s += ind + "mappedDataSourceType\n" ;
        }
        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        if (this.Shares != null) {
            var fspec = this.Shares.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "shares {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        if (this.HostCdmId == null && ec.Includes("hostCdmId",true))
        {
            this.HostCdmId = "FETCH";
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        if (this.HostFid == null && ec.Includes("hostFid",true))
        {
            this.HostFid = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && ec.Includes("hostname",true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        if (this.MappedDataSourceCdmId == null && ec.Includes("mappedDataSourceCdmId",true))
        {
            this.MappedDataSourceCdmId = "FETCH";
        }
        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        if (this.MappedDataSourceFid == null && ec.Includes("mappedDataSourceFid",true))
        {
            this.MappedDataSourceFid = "FETCH";
        }
        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        if (this.MappedDataSourceName == null && ec.Includes("mappedDataSourceName",true))
        {
            this.MappedDataSourceName = "FETCH";
        }
        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        if (this.MappedDataSourceType == null && ec.Includes("mappedDataSourceType",true))
        {
            this.MappedDataSourceType = "FETCH";
        }
        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        if (this.Shares == null && ec.Includes("shares",false))
        {
            this.Shares = new List<NasMigrationShareDetail>();
            this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));
        }
    }


    #endregion

    } // class NasMigrationHostDetail
    
    #endregion

    public static class ListNasMigrationHostDetailExtensions
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
            this List<NasMigrationHostDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationHostDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NasMigrationHostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types