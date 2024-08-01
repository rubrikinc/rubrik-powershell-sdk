// CheckVmwareVmsRecoveryPermissionReply.cs
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
    #region CheckVmwareVmsRecoveryPermissionReply
    public class CheckVmwareVmsRecoveryPermissionReply: BaseType
    {
        #region members

        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        [JsonProperty("vmwareRecoveryType")]
        public VmwareRecoveryType? VmwareRecoveryType { get; set; }

        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        [JsonProperty("result")]
        public List<VmwareVmRecoveryAccess>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckVmwareVmsRecoveryPermissionReply";
    }

    public CheckVmwareVmsRecoveryPermissionReply Set(
        VmwareRecoveryType? VmwareRecoveryType = null,
        List<VmwareVmRecoveryAccess>? Result = null
    ) 
    {
        if ( VmwareRecoveryType != null ) {
            this.VmwareRecoveryType = VmwareRecoveryType;
        }
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        if (this.VmwareRecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmwareRecoveryType\n" ;
            } else {
                s += ind + "vmwareRecoveryType\n" ;
            }
        }
        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(conf.Child("result"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "result" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        if (ec.Includes("vmwareRecoveryType",true))
        {
            if(this.VmwareRecoveryType == null) {

                this.VmwareRecoveryType = new VmwareRecoveryType();

            } else {


            }
        }
        else if (this.VmwareRecoveryType != null && ec.Excludes("vmwareRecoveryType",true))
        {
            this.VmwareRecoveryType = null;
        }
        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        if (ec.Includes("result",false))
        {
            if(this.Result == null) {

                this.Result = new List<VmwareVmRecoveryAccess>();
                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            } else {

                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            }
        }
        else if (this.Result != null && ec.Excludes("result",false))
        {
            this.Result = null;
        }
    }


    #endregion

    } // class CheckVmwareVmsRecoveryPermissionReply
    
    #endregion

    public static class ListCheckVmwareVmsRecoveryPermissionReplyExtensions
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
            this List<CheckVmwareVmsRecoveryPermissionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckVmwareVmsRecoveryPermissionReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckVmwareVmsRecoveryPermissionReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckVmwareVmsRecoveryPermissionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckVmwareVmsRecoveryPermissionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types