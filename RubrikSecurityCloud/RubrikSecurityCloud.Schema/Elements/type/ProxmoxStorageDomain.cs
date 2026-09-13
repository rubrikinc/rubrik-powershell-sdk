// ProxmoxStorageDomain.cs
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
    #region ProxmoxStorageDomain
    public class ProxmoxStorageDomain: BaseType
    {
        #region members

        //      C# -> System.String? AvailableStorage
        // GraphQL -> availableStorage: String! (scalar)
        [JsonProperty("availableStorage")]
        public System.String? AvailableStorage { get; set; }

        //      C# -> System.String? FileSystem
        // GraphQL -> fileSystem: String! (scalar)
        [JsonProperty("fileSystem")]
        public System.String? FileSystem { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TotalStorage
        // GraphQL -> totalStorage: String! (scalar)
        [JsonProperty("totalStorage")]
        public System.String? TotalStorage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProxmoxStorageDomain";
    }

    public ProxmoxStorageDomain Set(
        System.String? AvailableStorage = null,
        System.String? FileSystem = null,
        System.String? Name = null,
        System.String? TotalStorage = null
    ) 
    {
        if ( AvailableStorage != null ) {
            this.AvailableStorage = AvailableStorage;
        }
        if ( FileSystem != null ) {
            this.FileSystem = FileSystem;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TotalStorage != null ) {
            this.TotalStorage = TotalStorage;
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
        //      C# -> System.String? AvailableStorage
        // GraphQL -> availableStorage: String! (scalar)
        if (this.AvailableStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availableStorage\n" ;
            } else {
                s += ind + "availableStorage\n" ;
            }
        }
        //      C# -> System.String? FileSystem
        // GraphQL -> fileSystem: String! (scalar)
        if (this.FileSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSystem\n" ;
            } else {
                s += ind + "fileSystem\n" ;
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
        //      C# -> System.String? TotalStorage
        // GraphQL -> totalStorage: String! (scalar)
        if (this.TotalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalStorage\n" ;
            } else {
                s += ind + "totalStorage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AvailableStorage
        // GraphQL -> availableStorage: String! (scalar)
        if (ec.Includes("availableStorage",true))
        {
            if(this.AvailableStorage == null) {

                this.AvailableStorage = "FETCH";

            } else {


            }
        }
        else if (this.AvailableStorage != null && ec.Excludes("availableStorage",true))
        {
            this.AvailableStorage = null;
        }
        //      C# -> System.String? FileSystem
        // GraphQL -> fileSystem: String! (scalar)
        if (ec.Includes("fileSystem",true))
        {
            if(this.FileSystem == null) {

                this.FileSystem = "FETCH";

            } else {


            }
        }
        else if (this.FileSystem != null && ec.Excludes("fileSystem",true))
        {
            this.FileSystem = null;
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
        //      C# -> System.String? TotalStorage
        // GraphQL -> totalStorage: String! (scalar)
        if (ec.Includes("totalStorage",true))
        {
            if(this.TotalStorage == null) {

                this.TotalStorage = "FETCH";

            } else {


            }
        }
        else if (this.TotalStorage != null && ec.Excludes("totalStorage",true))
        {
            this.TotalStorage = null;
        }
    }


    #endregion

    } // class ProxmoxStorageDomain
    
    #endregion

    public static class ListProxmoxStorageDomainExtensions
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
            this List<ProxmoxStorageDomain> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProxmoxStorageDomain> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProxmoxStorageDomain> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxmoxStorageDomain());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProxmoxStorageDomain> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types