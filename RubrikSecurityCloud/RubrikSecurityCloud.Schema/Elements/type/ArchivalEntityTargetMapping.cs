// ArchivalEntityTargetMapping.cs
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
    #region ArchivalEntityTargetMapping
 
    public class ArchivalEntityTargetMapping: BaseType, ArchivalEntity
    {
        #region members

        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        [JsonProperty("useCaseType")]
        public ArchivalEntityUseCaseType? UseCaseType { get; set; }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalEntityTargetMapping";
    }

    public ArchivalEntityTargetMapping Set(
        ArchivalEntityUseCaseType? UseCaseType = null,
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( UseCaseType != null ) {
            this.UseCaseType = UseCaseType;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        if (this.UseCaseType != null) {
            s += ind + "useCaseType\n" ;
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        if (this.UseCaseType == null && Exploration.Includes(parent + ".useCaseType", true))
        {
            this.UseCaseType = new ArchivalEntityUseCaseType();
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        if (this.TargetMapping == null && Exploration.Includes(parent + ".targetMapping"))
        {
            this.TargetMapping = new TargetMapping();
            this.TargetMapping.ApplyExploratoryFieldSpec(parent + ".targetMapping");
        }
    }


    #endregion

    } // class ArchivalEntityTargetMapping
    
    #endregion

    public static class ListArchivalEntityTargetMappingExtensions
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
            this List<ArchivalEntityTargetMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalEntityTargetMapping> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalEntityTargetMapping());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types