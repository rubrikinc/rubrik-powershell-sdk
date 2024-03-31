// MosaicStoreConnectionParameters.cs
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
    #region MosaicStoreConnectionParameters
    public class MosaicStoreConnectionParameters: BaseType
    {
        #region members

        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        [JsonProperty("nfsServer")]
        public System.String? NfsServer { get; set; }

        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        [JsonProperty("nfsServerMountPath")]
        public System.String? NfsServerMountPath { get; set; }

        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        [JsonProperty("storeUrl")]
        public System.String? StoreUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicStoreConnectionParameters";
    }

    public MosaicStoreConnectionParameters Set(
        System.String? NfsServer = null,
        System.String? NfsServerMountPath = null,
        System.String? StoreUrl = null
    ) 
    {
        if ( NfsServer != null ) {
            this.NfsServer = NfsServer;
        }
        if ( NfsServerMountPath != null ) {
            this.NfsServerMountPath = NfsServerMountPath;
        }
        if ( StoreUrl != null ) {
            this.StoreUrl = StoreUrl;
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
        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        if (this.NfsServer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfsServer\n" ;
            } else {
                s += ind + "nfsServer\n" ;
            }
        }
        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        if (this.NfsServerMountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfsServerMountPath\n" ;
            } else {
                s += ind + "nfsServerMountPath\n" ;
            }
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeUrl\n" ;
            } else {
                s += ind + "storeUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        if (ec.Includes("nfsServer",true))
        {
            if(this.NfsServer == null) {

                this.NfsServer = "FETCH";

            } else {


            }
        }
        else if (this.NfsServer != null && ec.Excludes("nfsServer",true))
        {
            this.NfsServer = null;
        }
        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        if (ec.Includes("nfsServerMountPath",true))
        {
            if(this.NfsServerMountPath == null) {

                this.NfsServerMountPath = "FETCH";

            } else {


            }
        }
        else if (this.NfsServerMountPath != null && ec.Excludes("nfsServerMountPath",true))
        {
            this.NfsServerMountPath = null;
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (ec.Includes("storeUrl",true))
        {
            if(this.StoreUrl == null) {

                this.StoreUrl = "FETCH";

            } else {


            }
        }
        else if (this.StoreUrl != null && ec.Excludes("storeUrl",true))
        {
            this.StoreUrl = null;
        }
    }


    #endregion

    } // class MosaicStoreConnectionParameters
    
    #endregion

    public static class ListMosaicStoreConnectionParametersExtensions
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
            this List<MosaicStoreConnectionParameters> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MosaicStoreConnectionParameters> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStoreConnectionParameters> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStoreConnectionParameters());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicStoreConnectionParameters> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types