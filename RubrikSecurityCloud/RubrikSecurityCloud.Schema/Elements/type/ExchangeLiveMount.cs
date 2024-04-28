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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String! (scalar)
        if (this.NodeCompositeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeCompositeId\n" ;
            } else {
                s += ind + "nodeCompositeId\n" ;
            }
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String! (scalar)
        if (this.NodeIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeIp\n" ;
            } else {
                s += ind + "nodeIp\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ExchangeDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: ExchangeDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(conf.Child("sourceDatabase"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceDatabase" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? NodeCompositeId
        // GraphQL -> nodeCompositeId: String! (scalar)
        if (ec.Includes("nodeCompositeId",true))
        {
            if(this.NodeCompositeId == null) {

                this.NodeCompositeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeCompositeId != null && ec.Excludes("nodeCompositeId",true))
        {
            this.NodeCompositeId = null;
        }
        //      C# -> System.String? NodeIp
        // GraphQL -> nodeIp: String! (scalar)
        if (ec.Includes("nodeIp",true))
        {
            if(this.NodeIp == null) {

                this.NodeIp = "FETCH";

            } else {


            }
        }
        else if (this.NodeIp != null && ec.Excludes("nodeIp",true))
        {
            this.NodeIp = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> ExchangeDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: ExchangeDatabase (type)
        if (ec.Includes("sourceDatabase",false))
        {
            if(this.SourceDatabase == null) {

                this.SourceDatabase = new ExchangeDatabase();
                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            } else {

                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            }
        }
        else if (this.SourceDatabase != null && ec.Excludes("sourceDatabase",false))
        {
            this.SourceDatabase = null;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (ec.Includes("sourceSnapshot",false))
        {
            if(this.SourceSnapshot == null) {

                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            } else {

                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            }
        }
        else if (this.SourceSnapshot != null && ec.Excludes("sourceSnapshot",false))
        {
            this.SourceSnapshot = null;
        }
    }


    #endregion

    } // class ExchangeLiveMount
    
    #endregion

    public static class ListExchangeLiveMountExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ExchangeLiveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExchangeLiveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ExchangeLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types