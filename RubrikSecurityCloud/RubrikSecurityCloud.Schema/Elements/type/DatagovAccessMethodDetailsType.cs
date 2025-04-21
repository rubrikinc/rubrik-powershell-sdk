// DatagovAccessMethodDetailsType.cs
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
    #region DatagovAccessMethodDetailsType
    public class DatagovAccessMethodDetailsType: BaseType
    {
        #region members

        //      C# -> AccessMethod? AccessMethod
        // GraphQL -> accessMethod: AccessMethod! (enum)
        [JsonProperty("accessMethod")]
        public AccessMethod? AccessMethod { get; set; }

        //      C# -> AccessMethodDetailsType? Details
        // GraphQL -> details: AccessMethodDetailsType (union)
        [JsonProperty("details")]
        public AccessMethodDetailsType? Details { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DatagovAccessMethodDetailsType";
    }

    public DatagovAccessMethodDetailsType Set(
        AccessMethod? AccessMethod = null,
        AccessMethodDetailsType? Details = null
    ) 
    {
        if ( AccessMethod != null ) {
            this.AccessMethod = AccessMethod;
        }
        if ( Details != null ) {
            this.Details = Details;
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
        //      C# -> AccessMethod? AccessMethod
        // GraphQL -> accessMethod: AccessMethod! (enum)
        if (this.AccessMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessMethod\n" ;
            } else {
                s += ind + "accessMethod\n" ;
            }
        }
        //      C# -> AccessMethodDetailsType? Details
        // GraphQL -> details: AccessMethodDetailsType (union)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AccessMethod? AccessMethod
        // GraphQL -> accessMethod: AccessMethod! (enum)
        if (ec.Includes("accessMethod",true))
        {
            if(this.AccessMethod == null) {

                this.AccessMethod = new AccessMethod();

            } else {


            }
        }
        else if (this.AccessMethod != null && ec.Excludes("accessMethod",true))
        {
            this.AccessMethod = null;
        }
        //      C# -> AccessMethodDetailsType? Details
        // GraphQL -> details: AccessMethodDetailsType (union)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                var impls = new List<AccessMethodDetailsType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (AccessMethodDetailsType)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<AccessMethodDetailsType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (AccessMethodDetailsType)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
    }


    #endregion

    } // class DatagovAccessMethodDetailsType
    
    #endregion

    public static class ListDatagovAccessMethodDetailsTypeExtensions
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
            this List<DatagovAccessMethodDetailsType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DatagovAccessMethodDetailsType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DatagovAccessMethodDetailsType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DatagovAccessMethodDetailsType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DatagovAccessMethodDetailsType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types