// HvmVirtualMachineDetails.cs
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
    #region HvmVirtualMachineDetails
    public class HvmVirtualMachineDetails: BaseType
    {
        #region members

        //      C# -> System.String? HvmHostId
        // GraphQL -> hvmHostId: String! (scalar)
        [JsonProperty("hvmHostId")]
        public System.String? HvmHostId { get; set; }

        //      C# -> System.String? HvmVmId
        // GraphQL -> hvmVmId: String! (scalar)
        [JsonProperty("hvmVmId")]
        public System.String? HvmVmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HvmVirtualMachineDetails";
    }

    public HvmVirtualMachineDetails Set(
        System.String? HvmHostId = null,
        System.String? HvmVmId = null
    ) 
    {
        if ( HvmHostId != null ) {
            this.HvmHostId = HvmHostId;
        }
        if ( HvmVmId != null ) {
            this.HvmVmId = HvmVmId;
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
        //      C# -> System.String? HvmHostId
        // GraphQL -> hvmHostId: String! (scalar)
        if (this.HvmHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hvmHostId\n" ;
            } else {
                s += ind + "hvmHostId\n" ;
            }
        }
        //      C# -> System.String? HvmVmId
        // GraphQL -> hvmVmId: String! (scalar)
        if (this.HvmVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hvmVmId\n" ;
            } else {
                s += ind + "hvmVmId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? HvmHostId
        // GraphQL -> hvmHostId: String! (scalar)
        if (ec.Includes("hvmHostId",true))
        {
            if(this.HvmHostId == null) {

                this.HvmHostId = "FETCH";

            } else {


            }
        }
        else if (this.HvmHostId != null && ec.Excludes("hvmHostId",true))
        {
            this.HvmHostId = null;
        }
        //      C# -> System.String? HvmVmId
        // GraphQL -> hvmVmId: String! (scalar)
        if (ec.Includes("hvmVmId",true))
        {
            if(this.HvmVmId == null) {

                this.HvmVmId = "FETCH";

            } else {


            }
        }
        else if (this.HvmVmId != null && ec.Excludes("hvmVmId",true))
        {
            this.HvmVmId = null;
        }
    }


    #endregion

    } // class HvmVirtualMachineDetails
    
    #endregion

    public static class ListHvmVirtualMachineDetailsExtensions
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
            this List<HvmVirtualMachineDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HvmVirtualMachineDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HvmVirtualMachineDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HvmVirtualMachineDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HvmVirtualMachineDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types