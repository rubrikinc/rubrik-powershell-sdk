// FailoverClusterAppConfig.cs
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
    #region FailoverClusterAppConfig
    public class FailoverClusterAppConfig: BaseType
    {
        #region members

        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        [JsonProperty("failoverClusterType")]
        public FailoverClusterType? FailoverClusterType { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        [JsonProperty("failoverClusterId")]
        public System.String? FailoverClusterId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        [JsonProperty("failoverClusterAppSource")]
        public FailoverClusterAppSource? FailoverClusterAppSource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterAppConfig";
    }

    public FailoverClusterAppConfig Set(
        FailoverClusterType? FailoverClusterType = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? FailoverClusterId = null,
        System.String? Name = null,
        FailoverClusterAppSource? FailoverClusterAppSource = null
    ) 
    {
        if ( FailoverClusterType != null ) {
            this.FailoverClusterType = FailoverClusterType;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( FailoverClusterId != null ) {
            this.FailoverClusterId = FailoverClusterId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( FailoverClusterAppSource != null ) {
            this.FailoverClusterAppSource = FailoverClusterAppSource;
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
        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        if (this.FailoverClusterType != null) {
            s += ind + "failoverClusterType\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        if (this.FailoverClusterId != null) {
            s += ind + "failoverClusterId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        if (this.FailoverClusterAppSource != null) {
            var fspec = this.FailoverClusterAppSource.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverClusterAppSource {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        if (this.FailoverClusterType == null && Exploration.Includes(parent + ".failoverClusterType", true))
        {
            this.FailoverClusterType = new FailoverClusterType();
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        if (this.FailoverClusterId == null && Exploration.Includes(parent + ".failoverClusterId", true))
        {
            this.FailoverClusterId = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        if (this.FailoverClusterAppSource == null && Exploration.Includes(parent + ".failoverClusterAppSource"))
        {
            this.FailoverClusterAppSource = new FailoverClusterAppSource();
            this.FailoverClusterAppSource.ApplyExploratoryFieldSpec(parent + ".failoverClusterAppSource");
        }
    }


    #endregion

    } // class FailoverClusterAppConfig
    
    #endregion

    public static class ListFailoverClusterAppConfigExtensions
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
            this List<FailoverClusterAppConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterAppConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterAppConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types