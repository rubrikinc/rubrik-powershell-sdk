// JiraSettings.cs
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
    #region JiraSettings
    public class JiraSettings: BaseType
    {
        #region members

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JiraSettings";
    }

    public JiraSettings Set(
        System.String? AppItemTypeToken = null,
        System.String? Name = null,
        System.String? NaturalId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            s += ind + "appItemTypeToken\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken == null && ec.Includes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId == null && ec.Includes("naturalId",true))
        {
            this.NaturalId = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId == null && ec.Includes("workloadId",true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class JiraSettings
    
    #endregion

    public static class ListJiraSettingsExtensions
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
            this List<JiraSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<JiraSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new JiraSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<JiraSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types