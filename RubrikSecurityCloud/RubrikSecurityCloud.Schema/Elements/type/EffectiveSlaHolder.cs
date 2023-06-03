// EffectiveSlaHolder.cs
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
    #region EffectiveSlaHolder
    public class EffectiveSlaHolder: BaseType
    {
        #region members

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectId")]
        public System.String? EffectiveSlaSourceObjectId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectName")]
        public System.String? EffectiveSlaSourceObjectName { get; set; }

        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isEffectiveSlaDomainRetentionLocked")]
        public System.Boolean? IsEffectiveSlaDomainRetentionLocked { get; set; }


        #endregion

    #region methods

    public EffectiveSlaHolder Set(
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.Boolean? IsEffectiveSlaDomainRetentionLocked = null
    ) 
    {
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EffectiveSlaSourceObjectId != null ) {
            this.EffectiveSlaSourceObjectId = EffectiveSlaSourceObjectId;
        }
        if ( EffectiveSlaSourceObjectName != null ) {
            this.EffectiveSlaSourceObjectName = EffectiveSlaSourceObjectName;
        }
        if ( IsEffectiveSlaDomainRetentionLocked != null ) {
            this.IsEffectiveSlaDomainRetentionLocked = IsEffectiveSlaDomainRetentionLocked;
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
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName != null) {
            s += ind + "effectiveSlaDomainName\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId != null) {
            s += ind + "effectiveSlaSourceObjectId\n" ;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName != null) {
            s += ind + "effectiveSlaSourceObjectName\n" ;
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId", true))
        {
            this.EffectiveSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName", true))
        {
            this.EffectiveSlaDomainName = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".effectiveSlaDomainPolarisManagedId", true))
        {
            this.EffectiveSlaDomainPolarisManagedId = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectId", true))
        {
            this.EffectiveSlaSourceObjectId = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectName", true))
        {
            this.EffectiveSlaSourceObjectName = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isEffectiveSlaDomainRetentionLocked", true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = true;
        }
    }


    #endregion

    } // class EffectiveSlaHolder
    
    #endregion

    public static class ListEffectiveSlaHolderExtensions
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
            this List<EffectiveSlaHolder> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EffectiveSlaHolder> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EffectiveSlaHolder());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types