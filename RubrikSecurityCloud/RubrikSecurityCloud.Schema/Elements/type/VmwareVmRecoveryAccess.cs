// VmwareVmRecoveryAccess.cs
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
    #region VmwareVmRecoveryAccess
    public class VmwareVmRecoveryAccess: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        [JsonProperty("isRecoverable")]
        public System.Boolean? IsRecoverable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        [JsonProperty("vmwareVmId")]
        public System.String? VmwareVmId { get; set; }

        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        [JsonProperty("vmwareVmName")]
        public System.String? VmwareVmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmRecoveryAccess";
    }

    public VmwareVmRecoveryAccess Set(
        System.Boolean? IsRecoverable = null,
        System.Boolean? IsViewable = null,
        System.String? VmwareVmId = null,
        System.String? VmwareVmName = null
    ) 
    {
        if ( IsRecoverable != null ) {
            this.IsRecoverable = IsRecoverable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( VmwareVmId != null ) {
            this.VmwareVmId = VmwareVmId;
        }
        if ( VmwareVmName != null ) {
            this.VmwareVmName = VmwareVmName;
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
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (this.IsRecoverable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRecoverable\n" ;
            } else {
                s += ind + "isRecoverable\n" ;
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
        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        if (this.VmwareVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmwareVmId\n" ;
            } else {
                s += ind + "vmwareVmId\n" ;
            }
        }
        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        if (this.VmwareVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmwareVmName\n" ;
            } else {
                s += ind + "vmwareVmName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (ec.Includes("isRecoverable",true))
        {
            if(this.IsRecoverable == null) {

                this.IsRecoverable = true;

            } else {


            }
        }
        else if (this.IsRecoverable != null && ec.Excludes("isRecoverable",true))
        {
            this.IsRecoverable = null;
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
        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        if (ec.Includes("vmwareVmId",true))
        {
            if(this.VmwareVmId == null) {

                this.VmwareVmId = "FETCH";

            } else {


            }
        }
        else if (this.VmwareVmId != null && ec.Excludes("vmwareVmId",true))
        {
            this.VmwareVmId = null;
        }
        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        if (ec.Includes("vmwareVmName",true))
        {
            if(this.VmwareVmName == null) {

                this.VmwareVmName = "FETCH";

            } else {


            }
        }
        else if (this.VmwareVmName != null && ec.Excludes("vmwareVmName",true))
        {
            this.VmwareVmName = null;
        }
    }


    #endregion

    } // class VmwareVmRecoveryAccess
    
    #endregion

    public static class ListVmwareVmRecoveryAccessExtensions
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
            this List<VmwareVmRecoveryAccess> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareVmRecoveryAccess> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmRecoveryAccess> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmRecoveryAccess());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmRecoveryAccess> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types