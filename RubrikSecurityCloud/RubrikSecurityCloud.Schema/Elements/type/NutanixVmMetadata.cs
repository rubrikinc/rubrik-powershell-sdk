// NutanixVmMetadata.cs
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
    #region NutanixVmMetadata
    public class NutanixVmMetadata: BaseType
    {
        #region members

        //      C# -> System.Int64? MemoryInMb
        // GraphQL -> memoryInMb: Long! (scalar)
        [JsonProperty("memoryInMb")]
        public System.Int64? MemoryInMb { get; set; }

        //      C# -> System.Int64? NumCoresPerVcpu
        // GraphQL -> numCoresPerVcpu: Long! (scalar)
        [JsonProperty("numCoresPerVcpu")]
        public System.Int64? NumCoresPerVcpu { get; set; }

        //      C# -> System.Int64? NumVcpus
        // GraphQL -> numVcpus: Long! (scalar)
        [JsonProperty("numVcpus")]
        public System.Int64? NumVcpus { get; set; }

        //      C# -> List<NutanixVmNic>? VmNics
        // GraphQL -> vmNics: [NutanixVmNic!]! (type)
        [JsonProperty("vmNics")]
        public List<NutanixVmNic>? VmNics { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmMetadata";
    }

    public NutanixVmMetadata Set(
        System.Int64? MemoryInMb = null,
        System.Int64? NumCoresPerVcpu = null,
        System.Int64? NumVcpus = null,
        List<NutanixVmNic>? VmNics = null
    ) 
    {
        if ( MemoryInMb != null ) {
            this.MemoryInMb = MemoryInMb;
        }
        if ( NumCoresPerVcpu != null ) {
            this.NumCoresPerVcpu = NumCoresPerVcpu;
        }
        if ( NumVcpus != null ) {
            this.NumVcpus = NumVcpus;
        }
        if ( VmNics != null ) {
            this.VmNics = VmNics;
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
        //      C# -> System.Int64? MemoryInMb
        // GraphQL -> memoryInMb: Long! (scalar)
        if (this.MemoryInMb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryInMb\n" ;
            } else {
                s += ind + "memoryInMb\n" ;
            }
        }
        //      C# -> System.Int64? NumCoresPerVcpu
        // GraphQL -> numCoresPerVcpu: Long! (scalar)
        if (this.NumCoresPerVcpu != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCoresPerVcpu\n" ;
            } else {
                s += ind + "numCoresPerVcpu\n" ;
            }
        }
        //      C# -> System.Int64? NumVcpus
        // GraphQL -> numVcpus: Long! (scalar)
        if (this.NumVcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numVcpus\n" ;
            } else {
                s += ind + "numVcpus\n" ;
            }
        }
        //      C# -> List<NutanixVmNic>? VmNics
        // GraphQL -> vmNics: [NutanixVmNic!]! (type)
        if (this.VmNics != null) {
            var fspec = this.VmNics.AsFieldSpec(conf.Child("vmNics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmNics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? MemoryInMb
        // GraphQL -> memoryInMb: Long! (scalar)
        if (ec.Includes("memoryInMb",true))
        {
            if(this.MemoryInMb == null) {

                this.MemoryInMb = new System.Int64();

            } else {


            }
        }
        else if (this.MemoryInMb != null && ec.Excludes("memoryInMb",true))
        {
            this.MemoryInMb = null;
        }
        //      C# -> System.Int64? NumCoresPerVcpu
        // GraphQL -> numCoresPerVcpu: Long! (scalar)
        if (ec.Includes("numCoresPerVcpu",true))
        {
            if(this.NumCoresPerVcpu == null) {

                this.NumCoresPerVcpu = new System.Int64();

            } else {


            }
        }
        else if (this.NumCoresPerVcpu != null && ec.Excludes("numCoresPerVcpu",true))
        {
            this.NumCoresPerVcpu = null;
        }
        //      C# -> System.Int64? NumVcpus
        // GraphQL -> numVcpus: Long! (scalar)
        if (ec.Includes("numVcpus",true))
        {
            if(this.NumVcpus == null) {

                this.NumVcpus = new System.Int64();

            } else {


            }
        }
        else if (this.NumVcpus != null && ec.Excludes("numVcpus",true))
        {
            this.NumVcpus = null;
        }
        //      C# -> List<NutanixVmNic>? VmNics
        // GraphQL -> vmNics: [NutanixVmNic!]! (type)
        if (ec.Includes("vmNics",false))
        {
            if(this.VmNics == null) {

                this.VmNics = new List<NutanixVmNic>();
                this.VmNics.ApplyExploratoryFieldSpec(ec.NewChild("vmNics"));

            } else {

                this.VmNics.ApplyExploratoryFieldSpec(ec.NewChild("vmNics"));

            }
        }
        else if (this.VmNics != null && ec.Excludes("vmNics",false))
        {
            this.VmNics = null;
        }
    }


    #endregion

    } // class NutanixVmMetadata
    
    #endregion

    public static class ListNutanixVmMetadataExtensions
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
            this List<NutanixVmMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types