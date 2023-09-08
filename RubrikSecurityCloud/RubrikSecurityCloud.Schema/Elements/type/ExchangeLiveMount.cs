// ExchangeLiveMount.cs
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
    #region ExchangeLiveMount
    public class ExchangeLiveMount: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String! (scalar)
        [JsonProperty("nodeCompositeId")]
        public System.String? NodeCompositeId { get; set; }

        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String! (scalar)
        [JsonProperty("nodeIp")]
        public System.String? NodeIp { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ExchangeDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: ExchangeDatabase (type)
        [JsonProperty("sourceDatabase")]
        public ExchangeDatabase? SourceDatabase { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExchangeLiveMount";
    }

    public ExchangeLiveMount Set(
        System.String? CdmId = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? NodeCompositeId = null,
        System.String? NodeIp = null,
        Cluster? Cluster = null,
        ExchangeDatabase? SourceDatabase = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( NodeCompositeId != null ) {
            this.NodeCompositeId = NodeCompositeId;
        }
        if ( NodeIp != null ) {
            this.NodeIp = NodeIp;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SourceDatabase != null ) {
            this.SourceDatabase = SourceDatabase;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String! (scalar)
        if (this.NodeCompositeId != null) {
            s += ind + "nodeCompositeId\n" ;
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String! (scalar)
        if (this.NodeIp != null) {
            s += ind + "nodeIp\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ExchangeDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: ExchangeDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && ec.Includes("isReady",true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String! (scalar)
        if (this.NodeCompositeId == null && ec.Includes("nodeCompositeId",true))
        {
            this.NodeCompositeId = "FETCH";
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String! (scalar)
        if (this.NodeIp == null && ec.Includes("nodeIp",true))
        {
            this.NodeIp = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> ExchangeDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: ExchangeDatabase (type)
        if (this.SourceDatabase == null && ec.Includes("sourceDatabase",false))
        {
            this.SourceDatabase = new ExchangeDatabase();
            this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot == null && ec.Includes("sourceSnapshot",false))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));
        }
    }


    #endregion

    } // class ExchangeLiveMount
    
    #endregion

    public static class ListExchangeLiveMountExtensions
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
            this List<ExchangeLiveMount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExchangeLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExchangeLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ExchangeLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types