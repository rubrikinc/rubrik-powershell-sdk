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

namespace Rubrik.SecurityCloud.Types
{
    #region ExchangeLiveMount
    public class ExchangeLiveMount: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: UUID! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady != null)
            {
                 s += ind + "isReady\n";

            }
            //      C# -> System.String? NodeCompositeId
            // GraphQL -> nodeCompositeId: String! (scalar)
            if (this.NodeCompositeId != null)
            {
                 s += ind + "nodeCompositeId\n";

            }
            //      C# -> System.String? NodeIp
            // GraphQL -> nodeIp: String! (scalar)
            if (this.NodeIp != null)
            {
                 s += ind + "nodeIp\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ExchangeDatabase? SourceDatabase
            // GraphQL -> sourceDatabase: ExchangeDatabase (type)
            if (this.SourceDatabase != null)
            {
                 s += ind + "sourceDatabase\n";

                 s += ind + "{\n" + 
                 this.SourceDatabase.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: UUID! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady == null && Exploration.Includes(parent + ".isReady$"))
            {
                this.IsReady = new System.Boolean();
            }
            //      C# -> System.String? NodeCompositeId
            // GraphQL -> nodeCompositeId: String! (scalar)
            if (this.NodeCompositeId == null && Exploration.Includes(parent + ".nodeCompositeId$"))
            {
                this.NodeCompositeId = new System.String("FETCH");
            }
            //      C# -> System.String? NodeIp
            // GraphQL -> nodeIp: String! (scalar)
            if (this.NodeIp == null && Exploration.Includes(parent + ".nodeIp$"))
            {
                this.NodeIp = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> ExchangeDatabase? SourceDatabase
            // GraphQL -> sourceDatabase: ExchangeDatabase (type)
            if (this.SourceDatabase == null && Exploration.Includes(parent + ".sourceDatabase"))
            {
                this.SourceDatabase = new ExchangeDatabase();
                this.SourceDatabase.ApplyExploratoryFragment(parent + ".sourceDatabase");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
        }


    #endregion

    } // class ExchangeLiveMount
    #endregion

    public static class ListExchangeLiveMountExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ExchangeLiveMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ExchangeLiveMount> list, 
            String parent = "")
        {
            var item = new ExchangeLiveMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types