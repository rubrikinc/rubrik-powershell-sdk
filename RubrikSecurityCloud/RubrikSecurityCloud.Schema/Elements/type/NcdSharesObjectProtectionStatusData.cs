// NcdSharesObjectProtectionStatusData.cs
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
    #region NcdSharesObjectProtectionStatusData
    public class NcdSharesObjectProtectionStatusData: BaseType
    {
        #region members

        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        [JsonProperty("notProtected")]
        public System.Int64? NotProtected { get; set; }

        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        [JsonProperty("protected")]
        public System.Int64? Protected { get; set; }

        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        [JsonProperty("totalSizeInBytes")]
        public System.Int64? TotalSizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdSharesObjectProtectionStatusData";
    }

    public NcdSharesObjectProtectionStatusData Set(
        System.Int64? NotProtected = null,
        System.Int64? Protected = null,
        System.Int64? TotalSizeInBytes = null
    ) 
    {
        if ( NotProtected != null ) {
            this.NotProtected = NotProtected;
        }
        if ( Protected != null ) {
            this.Protected = Protected;
        }
        if ( TotalSizeInBytes != null ) {
            this.TotalSizeInBytes = TotalSizeInBytes;
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
        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        if (this.NotProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notProtected\n" ;
            } else {
                s += ind + "notProtected\n" ;
            }
        }
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (this.Protected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protected\n" ;
            } else {
                s += ind + "protected\n" ;
            }
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (this.TotalSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSizeInBytes\n" ;
            } else {
                s += ind + "totalSizeInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        if (ec.Includes("notProtected",true))
        {
            if(this.NotProtected == null) {

                this.NotProtected = new System.Int64();

            } else {


            }
        }
        else if (this.NotProtected != null && ec.Excludes("notProtected",true))
        {
            this.NotProtected = null;
        }
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (ec.Includes("protected",true))
        {
            if(this.Protected == null) {

                this.Protected = new System.Int64();

            } else {


            }
        }
        else if (this.Protected != null && ec.Excludes("protected",true))
        {
            this.Protected = null;
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (ec.Includes("totalSizeInBytes",true))
        {
            if(this.TotalSizeInBytes == null) {

                this.TotalSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSizeInBytes != null && ec.Excludes("totalSizeInBytes",true))
        {
            this.TotalSizeInBytes = null;
        }
    }


    #endregion

    } // class NcdSharesObjectProtectionStatusData
    
    #endregion

    public static class ListNcdSharesObjectProtectionStatusDataExtensions
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
            this List<NcdSharesObjectProtectionStatusData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdSharesObjectProtectionStatusData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdSharesObjectProtectionStatusData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdSharesObjectProtectionStatusData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdSharesObjectProtectionStatusData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types