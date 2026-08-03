// HypervHostVirtualSwitchesResult.cs
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
    #region HypervHostVirtualSwitchesResult
    public class HypervHostVirtualSwitchesResult: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> List<HypervVirtualSwitchInfo>? VirtualSwitches
        // GraphQL -> virtualSwitches: [HypervVirtualSwitchInfo!]! (type)
        [JsonProperty("virtualSwitches")]
        public List<HypervVirtualSwitchInfo>? VirtualSwitches { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervHostVirtualSwitchesResult";
    }

    public HypervHostVirtualSwitchesResult Set(
        System.String? Error = null,
        System.Boolean? HasMore = null,
        System.String? HostId = null,
        List<HypervVirtualSwitchInfo>? VirtualSwitches = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( VirtualSwitches != null ) {
            this.VirtualSwitches = VirtualSwitches;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        if (this.HasMore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMore\n" ;
            } else {
                s += ind + "hasMore\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> List<HypervVirtualSwitchInfo>? VirtualSwitches
        // GraphQL -> virtualSwitches: [HypervVirtualSwitchInfo!]! (type)
        if (this.VirtualSwitches != null) {
            var fspec = this.VirtualSwitches.AsFieldSpec(conf.Child("virtualSwitches"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualSwitches" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        if (ec.Includes("hasMore",true))
        {
            if(this.HasMore == null) {

                this.HasMore = true;

            } else {


            }
        }
        else if (this.HasMore != null && ec.Excludes("hasMore",true))
        {
            this.HasMore = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> List<HypervVirtualSwitchInfo>? VirtualSwitches
        // GraphQL -> virtualSwitches: [HypervVirtualSwitchInfo!]! (type)
        if (ec.Includes("virtualSwitches",false))
        {
            if(this.VirtualSwitches == null) {

                this.VirtualSwitches = new List<HypervVirtualSwitchInfo>();
                this.VirtualSwitches.ApplyExploratoryFieldSpec(ec.NewChild("virtualSwitches"));

            } else {

                this.VirtualSwitches.ApplyExploratoryFieldSpec(ec.NewChild("virtualSwitches"));

            }
        }
        else if (this.VirtualSwitches != null && ec.Excludes("virtualSwitches",false))
        {
            this.VirtualSwitches = null;
        }
    }


    #endregion

    } // class HypervHostVirtualSwitchesResult
    
    #endregion

    public static class ListHypervHostVirtualSwitchesResultExtensions
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
            this List<HypervHostVirtualSwitchesResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervHostVirtualSwitchesResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervHostVirtualSwitchesResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervHostVirtualSwitchesResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervHostVirtualSwitchesResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types