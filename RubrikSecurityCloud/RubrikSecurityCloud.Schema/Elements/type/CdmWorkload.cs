// CdmWorkload.cs
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
    #region CdmWorkload
    public class CdmWorkload: BaseType
    {
        #region members

        //      C# -> SnappableSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SnappableSlaAssignment! (enum)
        [JsonProperty("slaAssignment")]
        public SnappableSlaAssignment? SlaAssignment { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
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

        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String (scalar)
        [JsonProperty("retentionSlaDomainId")]
        public System.String? RetentionSlaDomainId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public CdmWorkload Set(
        SnappableSlaAssignment? SlaAssignment = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.String? RetentionSlaDomainId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
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
        if ( RetentionSlaDomainId != null ) {
            this.RetentionSlaDomainId = RetentionSlaDomainId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> SnappableSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SnappableSlaAssignment! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
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
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String (scalar)
        if (this.RetentionSlaDomainId != null) {
            s += ind + "retentionSlaDomainId\n" ;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            s += ind + "effectiveSlaHolder {\n" + this.EffectiveSlaHolder.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SnappableSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SnappableSlaAssignment! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SnappableSlaAssignment();
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId", true))
        {
            this.EffectiveSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
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
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String (scalar)
        if (this.RetentionSlaDomainId == null && Exploration.Includes(parent + ".retentionSlaDomainId", true))
        {
            this.RetentionSlaDomainId = new System.String("FETCH");
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
        {
            this.EffectiveSlaHolder = new EffectiveSlaHolder();
            this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(parent + ".effectiveSlaHolder");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class CdmWorkload
    
    #endregion

    public static class ListCdmWorkloadExtensions
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
            this List<CdmWorkload> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmWorkload> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmWorkload());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types