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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig != null) {
            s += ind + "datagovAutoEnablePolicyConfig {\n" + this.DatagovAutoEnablePolicyConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ClusterTypeEnum();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig == null && Exploration.Includes(parent + ".datagovAutoEnablePolicyConfig"))
        {
            this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
            this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(parent + ".datagovAutoEnablePolicyConfig");
        }
    }


    #endregion

    } // class UpdateAutoEnablePolicyClusterConfigReply
    
    #endregion

    public static class ListUpdateAutoEnablePolicyClusterConfigReplyExtensions
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
            this List<UpdateAutoEnablePolicyClusterConfigReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateAutoEnablePolicyClusterConfigReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateAutoEnablePolicyClusterConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types