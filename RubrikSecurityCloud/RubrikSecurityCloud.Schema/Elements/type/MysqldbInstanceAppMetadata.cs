// MysqldbInstanceAppMetadata.cs
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
    #region MysqldbInstanceAppMetadata
    public class MysqldbInstanceAppMetadata: BaseType
    {
        #region members

        //      C# -> List<System.String>? DatabaseCdmIds
        // GraphQL -> databaseCdmIds: [String!] (scalar)
        [JsonProperty("databaseCdmIds")]
        public List<System.String>? DatabaseCdmIds { get; set; }

        //      C# -> System.String? MetadataVersion
        // GraphQL -> metadataVersion: String (scalar)
        [JsonProperty("metadataVersion")]
        public System.String? MetadataVersion { get; set; }

        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        [JsonProperty("stats")]
        public KosmosDataSnapshotStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqldbInstanceAppMetadata";
    }

    public MysqldbInstanceAppMetadata Set(
        List<System.String>? DatabaseCdmIds = null,
        System.String? MetadataVersion = null,
        KosmosDataSnapshotStats? Stats = null
    ) 
    {
        if ( DatabaseCdmIds != null ) {
            this.DatabaseCdmIds = DatabaseCdmIds;
        }
        if ( MetadataVersion != null ) {
            this.MetadataVersion = MetadataVersion;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
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
        //      C# -> List<System.String>? DatabaseCdmIds
        // GraphQL -> databaseCdmIds: [String!] (scalar)
        if (this.DatabaseCdmIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseCdmIds\n" ;
            } else {
                s += ind + "databaseCdmIds\n" ;
            }
        }
        //      C# -> System.String? MetadataVersion
        // GraphQL -> metadataVersion: String (scalar)
        if (this.MetadataVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metadataVersion\n" ;
            } else {
                s += ind + "metadataVersion\n" ;
            }
        }
        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(conf.Child("stats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "stats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? DatabaseCdmIds
        // GraphQL -> databaseCdmIds: [String!] (scalar)
        if (ec.Includes("databaseCdmIds",true))
        {
            if(this.DatabaseCdmIds == null) {

                this.DatabaseCdmIds = new List<System.String>();

            } else {


            }
        }
        else if (this.DatabaseCdmIds != null && ec.Excludes("databaseCdmIds",true))
        {
            this.DatabaseCdmIds = null;
        }
        //      C# -> System.String? MetadataVersion
        // GraphQL -> metadataVersion: String (scalar)
        if (ec.Includes("metadataVersion",true))
        {
            if(this.MetadataVersion == null) {

                this.MetadataVersion = "FETCH";

            } else {


            }
        }
        else if (this.MetadataVersion != null && ec.Excludes("metadataVersion",true))
        {
            this.MetadataVersion = null;
        }
        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        if (ec.Includes("stats",false))
        {
            if(this.Stats == null) {

                this.Stats = new KosmosDataSnapshotStats();
                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            } else {

                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            }
        }
        else if (this.Stats != null && ec.Excludes("stats",false))
        {
            this.Stats = null;
        }
    }


    #endregion

    } // class MysqldbInstanceAppMetadata
    
    #endregion

    public static class ListMysqldbInstanceAppMetadataExtensions
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
            this List<MysqldbInstanceAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqldbInstanceAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqldbInstanceAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqldbInstanceAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqldbInstanceAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types