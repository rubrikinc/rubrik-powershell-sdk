// HypervisorEnvironment.cs
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
    #region HypervisorEnvironment
    public class HypervisorEnvironment: BaseType
    {
        #region members

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? HypervisorEnvironmentId
        // GraphQL -> hypervisorEnvironmentId: UUID! (scalar)
        [JsonProperty("hypervisorEnvironmentId")]
        public System.String? HypervisorEnvironmentId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> HypervisorEnvironmentDetails? HypervisorDetails
        // GraphQL -> hypervisorDetails: HypervisorEnvironmentDetails (type)
        [JsonProperty("hypervisorDetails")]
        public HypervisorEnvironmentDetails? HypervisorDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervisorEnvironment";
    }

    public HypervisorEnvironment Set(
        System.String? Fid = null,
        System.String? HypervisorEnvironmentId = null,
        System.String? Name = null,
        HypervisorEnvironmentDetails? HypervisorDetails = null
    ) 
    {
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( HypervisorEnvironmentId != null ) {
            this.HypervisorEnvironmentId = HypervisorEnvironmentId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( HypervisorDetails != null ) {
            this.HypervisorDetails = HypervisorDetails;
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.String? HypervisorEnvironmentId
        // GraphQL -> hypervisorEnvironmentId: UUID! (scalar)
        if (this.HypervisorEnvironmentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hypervisorEnvironmentId\n" ;
            } else {
                s += ind + "hypervisorEnvironmentId\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> HypervisorEnvironmentDetails? HypervisorDetails
        // GraphQL -> hypervisorDetails: HypervisorEnvironmentDetails (type)
        if (this.HypervisorDetails != null) {
            var fspec = this.HypervisorDetails.AsFieldSpec(conf.Child("hypervisorDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervisorDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.String? HypervisorEnvironmentId
        // GraphQL -> hypervisorEnvironmentId: UUID! (scalar)
        if (ec.Includes("hypervisorEnvironmentId",true))
        {
            if(this.HypervisorEnvironmentId == null) {

                this.HypervisorEnvironmentId = "FETCH";

            } else {


            }
        }
        else if (this.HypervisorEnvironmentId != null && ec.Excludes("hypervisorEnvironmentId",true))
        {
            this.HypervisorEnvironmentId = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> HypervisorEnvironmentDetails? HypervisorDetails
        // GraphQL -> hypervisorDetails: HypervisorEnvironmentDetails (type)
        if (ec.Includes("hypervisorDetails",false))
        {
            if(this.HypervisorDetails == null) {

                this.HypervisorDetails = new HypervisorEnvironmentDetails();
                this.HypervisorDetails.ApplyExploratoryFieldSpec(ec.NewChild("hypervisorDetails"));

            } else {

                this.HypervisorDetails.ApplyExploratoryFieldSpec(ec.NewChild("hypervisorDetails"));

            }
        }
        else if (this.HypervisorDetails != null && ec.Excludes("hypervisorDetails",false))
        {
            this.HypervisorDetails = null;
        }
    }


    #endregion

    } // class HypervisorEnvironment
    
    #endregion

    public static class ListHypervisorEnvironmentExtensions
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
            this List<HypervisorEnvironment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervisorEnvironment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervisorEnvironment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervisorEnvironment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervisorEnvironment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types