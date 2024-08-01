// RecoveryPermission.cs
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
    #region RecoveryPermission
    public class RecoveryPermission: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        [JsonProperty("isCleanable")]
        public System.Boolean? IsCleanable { get; set; }

        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        [JsonProperty("isResumable")]
        public System.Boolean? IsResumable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        [JsonProperty("recoveryFid")]
        public System.String? RecoveryFid { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPermission";
    }

    public RecoveryPermission Set(
        System.Boolean? IsCleanable = null,
        System.Boolean? IsResumable = null,
        System.Boolean? IsViewable = null,
        System.String? RecoveryFid = null,
        System.String? RecoveryName = null
    ) 
    {
        if ( IsCleanable != null ) {
            this.IsCleanable = IsCleanable;
        }
        if ( IsResumable != null ) {
            this.IsResumable = IsResumable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( RecoveryFid != null ) {
            this.RecoveryFid = RecoveryFid;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
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
        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        if (this.IsCleanable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCleanable\n" ;
            } else {
                s += ind + "isCleanable\n" ;
            }
        }
        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        if (this.IsResumable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isResumable\n" ;
            } else {
                s += ind + "isResumable\n" ;
            }
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isViewable\n" ;
            } else {
                s += ind + "isViewable\n" ;
            }
        }
        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        if (this.RecoveryFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryFid\n" ;
            } else {
                s += ind + "recoveryFid\n" ;
            }
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryName\n" ;
            } else {
                s += ind + "recoveryName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        if (ec.Includes("isCleanable",true))
        {
            if(this.IsCleanable == null) {

                this.IsCleanable = true;

            } else {


            }
        }
        else if (this.IsCleanable != null && ec.Excludes("isCleanable",true))
        {
            this.IsCleanable = null;
        }
        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        if (ec.Includes("isResumable",true))
        {
            if(this.IsResumable == null) {

                this.IsResumable = true;

            } else {


            }
        }
        else if (this.IsResumable != null && ec.Excludes("isResumable",true))
        {
            this.IsResumable = null;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (ec.Includes("isViewable",true))
        {
            if(this.IsViewable == null) {

                this.IsViewable = true;

            } else {


            }
        }
        else if (this.IsViewable != null && ec.Excludes("isViewable",true))
        {
            this.IsViewable = null;
        }
        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        if (ec.Includes("recoveryFid",true))
        {
            if(this.RecoveryFid == null) {

                this.RecoveryFid = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryFid != null && ec.Excludes("recoveryFid",true))
        {
            this.RecoveryFid = null;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (ec.Includes("recoveryName",true))
        {
            if(this.RecoveryName == null) {

                this.RecoveryName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryName != null && ec.Excludes("recoveryName",true))
        {
            this.RecoveryName = null;
        }
    }


    #endregion

    } // class RecoveryPermission
    
    #endregion

    public static class ListRecoveryPermissionExtensions
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
            this List<RecoveryPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types