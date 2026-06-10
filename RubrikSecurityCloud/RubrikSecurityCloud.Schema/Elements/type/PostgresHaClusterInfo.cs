// PostgresHaClusterInfo.cs
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
    #region PostgresHaClusterInfo
    public class PostgresHaClusterInfo: BaseType
    {
        #region members

        //      C# -> System.String? ActiveReplicaId
        // GraphQL -> activeReplicaId: UUID (scalar)
        [JsonProperty("activeReplicaId")]
        public System.String? ActiveReplicaId { get; set; }

        //      C# -> System.String? HaGroupName
        // GraphQL -> haGroupName: String! (scalar)
        [JsonProperty("haGroupName")]
        public System.String? HaGroupName { get; set; }

        //      C# -> List<KosmosTopologyReplicaInfo>? Replicas
        // GraphQL -> replicas: [KosmosTopologyReplicaInfo!]! (type)
        [JsonProperty("replicas")]
        public List<KosmosTopologyReplicaInfo>? Replicas { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PostgresHaClusterInfo";
    }

    public PostgresHaClusterInfo Set(
        System.String? ActiveReplicaId = null,
        System.String? HaGroupName = null,
        List<KosmosTopologyReplicaInfo>? Replicas = null
    ) 
    {
        if ( ActiveReplicaId != null ) {
            this.ActiveReplicaId = ActiveReplicaId;
        }
        if ( HaGroupName != null ) {
            this.HaGroupName = HaGroupName;
        }
        if ( Replicas != null ) {
            this.Replicas = Replicas;
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
        //      C# -> System.String? ActiveReplicaId
        // GraphQL -> activeReplicaId: UUID (scalar)
        if (this.ActiveReplicaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeReplicaId\n" ;
            } else {
                s += ind + "activeReplicaId\n" ;
            }
        }
        //      C# -> System.String? HaGroupName
        // GraphQL -> haGroupName: String! (scalar)
        if (this.HaGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "haGroupName\n" ;
            } else {
                s += ind + "haGroupName\n" ;
            }
        }
        //      C# -> List<KosmosTopologyReplicaInfo>? Replicas
        // GraphQL -> replicas: [KosmosTopologyReplicaInfo!]! (type)
        if (this.Replicas != null) {
            var fspec = this.Replicas.AsFieldSpec(conf.Child("replicas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicas" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ActiveReplicaId
        // GraphQL -> activeReplicaId: UUID (scalar)
        if (ec.Includes("activeReplicaId",true))
        {
            if(this.ActiveReplicaId == null) {

                this.ActiveReplicaId = "FETCH";

            } else {


            }
        }
        else if (this.ActiveReplicaId != null && ec.Excludes("activeReplicaId",true))
        {
            this.ActiveReplicaId = null;
        }
        //      C# -> System.String? HaGroupName
        // GraphQL -> haGroupName: String! (scalar)
        if (ec.Includes("haGroupName",true))
        {
            if(this.HaGroupName == null) {

                this.HaGroupName = "FETCH";

            } else {


            }
        }
        else if (this.HaGroupName != null && ec.Excludes("haGroupName",true))
        {
            this.HaGroupName = null;
        }
        //      C# -> List<KosmosTopologyReplicaInfo>? Replicas
        // GraphQL -> replicas: [KosmosTopologyReplicaInfo!]! (type)
        if (ec.Includes("replicas",false))
        {
            if(this.Replicas == null) {

                this.Replicas = new List<KosmosTopologyReplicaInfo>();
                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            } else {

                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            }
        }
        else if (this.Replicas != null && ec.Excludes("replicas",false))
        {
            this.Replicas = null;
        }
    }


    #endregion

    } // class PostgresHaClusterInfo
    
    #endregion

    public static class ListPostgresHaClusterInfoExtensions
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
            this List<PostgresHaClusterInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PostgresHaClusterInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PostgresHaClusterInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PostgresHaClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PostgresHaClusterInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types