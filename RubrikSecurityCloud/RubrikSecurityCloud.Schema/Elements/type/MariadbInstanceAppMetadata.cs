// MariadbInstanceAppMetadata.cs
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
    #region MariadbInstanceAppMetadata
    public class MariadbInstanceAppMetadata: BaseType
    {
        #region members

        //      C# -> MariadbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MariadbSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public MariadbSnapshotType? SnapshotType { get; set; }

        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!] (scalar)
        [JsonProperty("databaseIds")]
        public List<System.String>? DatabaseIds { get; set; }

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
        return "MariadbInstanceAppMetadata";
    }

    public MariadbInstanceAppMetadata Set(
        MariadbSnapshotType? SnapshotType = null,
        List<System.String>? DatabaseIds = null,
        System.String? MetadataVersion = null,
        KosmosDataSnapshotStats? Stats = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( DatabaseIds != null ) {
            this.DatabaseIds = DatabaseIds;
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
        //      C# -> MariadbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MariadbSnapshotType (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!] (scalar)
        if (this.DatabaseIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseIds\n" ;
            } else {
                s += ind + "databaseIds\n" ;
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
        //      C# -> MariadbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MariadbSnapshotType (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new MariadbSnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [String!] (scalar)
        if (ec.Includes("databaseIds",true))
        {
            if(this.DatabaseIds == null) {

                this.DatabaseIds = new List<System.String>();

            } else {


            }
        }
        else if (this.DatabaseIds != null && ec.Excludes("databaseIds",true))
        {
            this.DatabaseIds = null;
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

    } // class MariadbInstanceAppMetadata
    
    #endregion

    public static class ListMariadbInstanceAppMetadataExtensions
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
            this List<MariadbInstanceAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MariadbInstanceAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MariadbInstanceAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MariadbInstanceAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MariadbInstanceAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types