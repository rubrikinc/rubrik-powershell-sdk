// FusionComputeResourceSpec.cs
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
    #region FusionComputeResourceSpec
    public class FusionComputeResourceSpec: BaseType
    {
        #region members

        //      C# -> System.Int32? NumaNodes
        // GraphQL -> numaNodes: Int! (scalar)
        [JsonProperty("numaNodes")]
        public System.Int32? NumaNodes { get; set; }

        //      C# -> System.Int32? VmCpuQuantity
        // GraphQL -> vmCpuQuantity: Int! (scalar)
        [JsonProperty("vmCpuQuantity")]
        public System.Int32? VmCpuQuantity { get; set; }

        //      C# -> System.Int64? VmMemQuantityMb
        // GraphQL -> vmMemQuantityMb: Long! (scalar)
        [JsonProperty("vmMemQuantityMb")]
        public System.Int64? VmMemQuantityMb { get; set; }

        //      C# -> List<FusionComputeNicSpec>? Nics
        // GraphQL -> nics: [FusionComputeNicSpec!]! (type)
        [JsonProperty("nics")]
        public List<FusionComputeNicSpec>? Nics { get; set; }

        //      C# -> FusionComputeVmProperties? VmProperties
        // GraphQL -> vmProperties: FusionComputeVmProperties (type)
        [JsonProperty("vmProperties")]
        public FusionComputeVmProperties? VmProperties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FusionComputeResourceSpec";
    }

    public FusionComputeResourceSpec Set(
        System.Int32? NumaNodes = null,
        System.Int32? VmCpuQuantity = null,
        System.Int64? VmMemQuantityMb = null,
        List<FusionComputeNicSpec>? Nics = null,
        FusionComputeVmProperties? VmProperties = null
    ) 
    {
        if ( NumaNodes != null ) {
            this.NumaNodes = NumaNodes;
        }
        if ( VmCpuQuantity != null ) {
            this.VmCpuQuantity = VmCpuQuantity;
        }
        if ( VmMemQuantityMb != null ) {
            this.VmMemQuantityMb = VmMemQuantityMb;
        }
        if ( Nics != null ) {
            this.Nics = Nics;
        }
        if ( VmProperties != null ) {
            this.VmProperties = VmProperties;
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
        //      C# -> System.Int32? NumaNodes
        // GraphQL -> numaNodes: Int! (scalar)
        if (this.NumaNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numaNodes\n" ;
            } else {
                s += ind + "numaNodes\n" ;
            }
        }
        //      C# -> System.Int32? VmCpuQuantity
        // GraphQL -> vmCpuQuantity: Int! (scalar)
        if (this.VmCpuQuantity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmCpuQuantity\n" ;
            } else {
                s += ind + "vmCpuQuantity\n" ;
            }
        }
        //      C# -> System.Int64? VmMemQuantityMb
        // GraphQL -> vmMemQuantityMb: Long! (scalar)
        if (this.VmMemQuantityMb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmMemQuantityMb\n" ;
            } else {
                s += ind + "vmMemQuantityMb\n" ;
            }
        }
        //      C# -> List<FusionComputeNicSpec>? Nics
        // GraphQL -> nics: [FusionComputeNicSpec!]! (type)
        if (this.Nics != null) {
            var fspec = this.Nics.AsFieldSpec(conf.Child("nics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FusionComputeVmProperties? VmProperties
        // GraphQL -> vmProperties: FusionComputeVmProperties (type)
        if (this.VmProperties != null) {
            var fspec = this.VmProperties.AsFieldSpec(conf.Child("vmProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmProperties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? NumaNodes
        // GraphQL -> numaNodes: Int! (scalar)
        if (ec.Includes("numaNodes",true))
        {
            if(this.NumaNodes == null) {

                this.NumaNodes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumaNodes != null && ec.Excludes("numaNodes",true))
        {
            this.NumaNodes = null;
        }
        //      C# -> System.Int32? VmCpuQuantity
        // GraphQL -> vmCpuQuantity: Int! (scalar)
        if (ec.Includes("vmCpuQuantity",true))
        {
            if(this.VmCpuQuantity == null) {

                this.VmCpuQuantity = Int32.MinValue;

            } else {


            }
        }
        else if (this.VmCpuQuantity != null && ec.Excludes("vmCpuQuantity",true))
        {
            this.VmCpuQuantity = null;
        }
        //      C# -> System.Int64? VmMemQuantityMb
        // GraphQL -> vmMemQuantityMb: Long! (scalar)
        if (ec.Includes("vmMemQuantityMb",true))
        {
            if(this.VmMemQuantityMb == null) {

                this.VmMemQuantityMb = new System.Int64();

            } else {


            }
        }
        else if (this.VmMemQuantityMb != null && ec.Excludes("vmMemQuantityMb",true))
        {
            this.VmMemQuantityMb = null;
        }
        //      C# -> List<FusionComputeNicSpec>? Nics
        // GraphQL -> nics: [FusionComputeNicSpec!]! (type)
        if (ec.Includes("nics",false))
        {
            if(this.Nics == null) {

                this.Nics = new List<FusionComputeNicSpec>();
                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            } else {

                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            }
        }
        else if (this.Nics != null && ec.Excludes("nics",false))
        {
            this.Nics = null;
        }
        //      C# -> FusionComputeVmProperties? VmProperties
        // GraphQL -> vmProperties: FusionComputeVmProperties (type)
        if (ec.Includes("vmProperties",false))
        {
            if(this.VmProperties == null) {

                this.VmProperties = new FusionComputeVmProperties();
                this.VmProperties.ApplyExploratoryFieldSpec(ec.NewChild("vmProperties"));

            } else {

                this.VmProperties.ApplyExploratoryFieldSpec(ec.NewChild("vmProperties"));

            }
        }
        else if (this.VmProperties != null && ec.Excludes("vmProperties",false))
        {
            this.VmProperties = null;
        }
    }


    #endregion

    } // class FusionComputeResourceSpec
    
    #endregion

    public static class ListFusionComputeResourceSpecExtensions
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
            this List<FusionComputeResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FusionComputeResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FusionComputeResourceSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FusionComputeResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FusionComputeResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types