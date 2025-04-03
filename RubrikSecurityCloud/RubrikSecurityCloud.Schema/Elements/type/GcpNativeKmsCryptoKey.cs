// GcpNativeKmsCryptoKey.cs
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
    #region GcpNativeKmsCryptoKey
    public class GcpNativeKmsCryptoKey: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        [JsonProperty("keyRing")]
        public System.String? KeyRing { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        [JsonProperty("projectNativeId")]
        public System.String? ProjectNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeKmsCryptoKey";
    }

    public GcpNativeKmsCryptoKey Set(
        System.String? Key = null,
        System.String? KeyRing = null,
        System.String? Location = null,
        System.String? ProjectNativeId = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyRing != null ) {
            this.KeyRing = KeyRing;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ProjectNativeId != null ) {
            this.ProjectNativeId = ProjectNativeId;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        if (this.KeyRing != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyRing\n" ;
            } else {
                s += ind + "keyRing\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        if (this.ProjectNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectNativeId\n" ;
            } else {
                s += ind + "projectNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        if (ec.Includes("keyRing",true))
        {
            if(this.KeyRing == null) {

                this.KeyRing = "FETCH";

            } else {


            }
        }
        else if (this.KeyRing != null && ec.Excludes("keyRing",true))
        {
            this.KeyRing = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        if (ec.Includes("projectNativeId",true))
        {
            if(this.ProjectNativeId == null) {

                this.ProjectNativeId = "FETCH";

            } else {


            }
        }
        else if (this.ProjectNativeId != null && ec.Excludes("projectNativeId",true))
        {
            this.ProjectNativeId = null;
        }
    }


    #endregion

    } // class GcpNativeKmsCryptoKey
    
    #endregion

    public static class ListGcpNativeKmsCryptoKeyExtensions
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
            this List<GcpNativeKmsCryptoKey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeKmsCryptoKey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeKmsCryptoKey> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeKmsCryptoKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeKmsCryptoKey> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types