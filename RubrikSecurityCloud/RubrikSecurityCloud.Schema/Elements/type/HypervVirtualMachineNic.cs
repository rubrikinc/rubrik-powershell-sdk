// HypervVirtualMachineNic.cs
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
    #region HypervVirtualMachineNic
    public class HypervVirtualMachineNic: BaseType
    {
        #region members

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }

        //      C# -> System.String? VirtualSwitchId
        // GraphQL -> virtualSwitchId: String! (scalar)
        [JsonProperty("virtualSwitchId")]
        public System.String? VirtualSwitchId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVirtualMachineNic";
    }

    public HypervVirtualMachineNic Set(
        System.String? InstanceId = null,
        System.Int32? NicIndex = null,
        System.String? VirtualSwitchId = null
    ) 
    {
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( NicIndex != null ) {
            this.NicIndex = NicIndex;
        }
        if ( VirtualSwitchId != null ) {
            this.VirtualSwitchId = VirtualSwitchId;
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
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceId\n" ;
            } else {
                s += ind + "instanceId\n" ;
            }
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicIndex\n" ;
            } else {
                s += ind + "nicIndex\n" ;
            }
        }
        //      C# -> System.String? VirtualSwitchId
        // GraphQL -> virtualSwitchId: String! (scalar)
        if (this.VirtualSwitchId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualSwitchId\n" ;
            } else {
                s += ind + "virtualSwitchId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (ec.Includes("instanceId",true))
        {
            if(this.InstanceId == null) {

                this.InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceId != null && ec.Excludes("instanceId",true))
        {
            this.InstanceId = null;
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (ec.Includes("nicIndex",true))
        {
            if(this.NicIndex == null) {

                this.NicIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.NicIndex != null && ec.Excludes("nicIndex",true))
        {
            this.NicIndex = null;
        }
        //      C# -> System.String? VirtualSwitchId
        // GraphQL -> virtualSwitchId: String! (scalar)
        if (ec.Includes("virtualSwitchId",true))
        {
            if(this.VirtualSwitchId == null) {

                this.VirtualSwitchId = "FETCH";

            } else {


            }
        }
        else if (this.VirtualSwitchId != null && ec.Excludes("virtualSwitchId",true))
        {
            this.VirtualSwitchId = null;
        }
    }


    #endregion

    } // class HypervVirtualMachineNic
    
    #endregion

    public static class ListHypervVirtualMachineNicExtensions
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
            this List<HypervVirtualMachineNic> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervVirtualMachineNic> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineNic> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineNic());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVirtualMachineNic> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types