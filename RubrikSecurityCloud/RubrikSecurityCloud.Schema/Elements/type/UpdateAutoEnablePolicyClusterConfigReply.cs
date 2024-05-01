// UpdateAutoEnablePolicyClusterConfigReply.cs
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
    #region UpdateAutoEnablePolicyClusterConfigReply
    public class UpdateAutoEnablePolicyClusterConfigReply: BaseType
    {
        #region members

        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        [JsonProperty("type")]
        public ClusterTypeEnum? Type { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        [JsonProperty("datagovAutoEnablePolicyConfig")]
        public AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateAutoEnablePolicyClusterConfigReply";
    }

    public UpdateAutoEnablePolicyClusterConfigReply Set(
        ClusterTypeEnum? Type = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Version = null,
        AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( DatagovAutoEnablePolicyConfig != null ) {
            this.DatagovAutoEnablePolicyConfig = DatagovAutoEnablePolicyConfig;
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
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig != null) {
            var fspec = this.DatagovAutoEnablePolicyConfig.AsFieldSpec(conf.Child("datagovAutoEnablePolicyConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datagovAutoEnablePolicyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ClusterTypeEnum();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (ec.Includes("datagovAutoEnablePolicyConfig",false))
        {
            if(this.DatagovAutoEnablePolicyConfig == null) {

                this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
                this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovAutoEnablePolicyConfig"));

            } else {

                this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovAutoEnablePolicyConfig"));

            }
        }
        else if (this.DatagovAutoEnablePolicyConfig != null && ec.Excludes("datagovAutoEnablePolicyConfig",false))
        {
            this.DatagovAutoEnablePolicyConfig = null;
        }
    }


    #endregion

    } // class UpdateAutoEnablePolicyClusterConfigReply
    
    #endregion

    public static class ListUpdateAutoEnablePolicyClusterConfigReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UpdateAutoEnablePolicyClusterConfigReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateAutoEnablePolicyClusterConfigReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateAutoEnablePolicyClusterConfigReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateAutoEnablePolicyClusterConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateAutoEnablePolicyClusterConfigReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types