// NutanixStorageContainer.cs
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
    #region NutanixStorageContainer
    public class NutanixStorageContainer: BaseType
    {
        #region members

        //      C# -> System.Int64? FreeBytes
        // GraphQL -> freeBytes: Long! (scalar)
        [JsonProperty("freeBytes")]
        public System.Int64? FreeBytes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? TotalBytes
        // GraphQL -> totalBytes: Long! (scalar)
        [JsonProperty("totalBytes")]
        public System.Int64? TotalBytes { get; set; }

        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long! (scalar)
        [JsonProperty("usedBytes")]
        public System.Int64? UsedBytes { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixStorageContainer";
    }

    public NutanixStorageContainer Set(
        System.Int64? FreeBytes = null,
        System.String? Name = null,
        System.Int64? TotalBytes = null,
        System.Int64? UsedBytes = null,
        System.String? Uuid = null
    ) 
    {
        if ( FreeBytes != null ) {
            this.FreeBytes = FreeBytes;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TotalBytes != null ) {
            this.TotalBytes = TotalBytes;
        }
        if ( UsedBytes != null ) {
            this.UsedBytes = UsedBytes;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
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
        //      C# -> System.Int64? FreeBytes
        // GraphQL -> freeBytes: Long! (scalar)
        if (this.FreeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "freeBytes\n" ;
            } else {
                s += ind + "freeBytes\n" ;
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
        //      C# -> System.Int64? TotalBytes
        // GraphQL -> totalBytes: Long! (scalar)
        if (this.TotalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalBytes\n" ;
            } else {
                s += ind + "totalBytes\n" ;
            }
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long! (scalar)
        if (this.UsedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedBytes\n" ;
            } else {
                s += ind + "usedBytes\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? FreeBytes
        // GraphQL -> freeBytes: Long! (scalar)
        if (ec.Includes("freeBytes",true))
        {
            if(this.FreeBytes == null) {

                this.FreeBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FreeBytes != null && ec.Excludes("freeBytes",true))
        {
            this.FreeBytes = null;
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
        //      C# -> System.Int64? TotalBytes
        // GraphQL -> totalBytes: Long! (scalar)
        if (ec.Includes("totalBytes",true))
        {
            if(this.TotalBytes == null) {

                this.TotalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalBytes != null && ec.Excludes("totalBytes",true))
        {
            this.TotalBytes = null;
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long! (scalar)
        if (ec.Includes("usedBytes",true))
        {
            if(this.UsedBytes == null) {

                this.UsedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UsedBytes != null && ec.Excludes("usedBytes",true))
        {
            this.UsedBytes = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
    }


    #endregion

    } // class NutanixStorageContainer
    
    #endregion

    public static class ListNutanixStorageContainerExtensions
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
            this List<NutanixStorageContainer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixStorageContainer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixStorageContainer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixStorageContainer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixStorageContainer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types