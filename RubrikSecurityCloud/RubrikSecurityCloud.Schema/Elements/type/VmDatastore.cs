// VmDatastore.cs
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
    #region VmDatastore
    public class VmDatastore: BaseType
    {
        #region members

        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        [JsonProperty("datastoreId")]
        public System.String? DatastoreId { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmDatastore";
    }

    public VmDatastore Set(
        System.String? DatastoreId = null,
        System.String? DatastoreName = null
    ) 
    {
        if ( DatastoreId != null ) {
            this.DatastoreId = DatastoreId;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
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
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (this.DatastoreId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreId\n" ;
            } else {
                s += ind + "datastoreId\n" ;
            }
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreName\n" ;
            } else {
                s += ind + "datastoreName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (ec.Includes("datastoreId",true))
        {
            if(this.DatastoreId == null) {

                this.DatastoreId = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreId != null && ec.Excludes("datastoreId",true))
        {
            this.DatastoreId = null;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (ec.Includes("datastoreName",true))
        {
            if(this.DatastoreName == null) {

                this.DatastoreName = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreName != null && ec.Excludes("datastoreName",true))
        {
            this.DatastoreName = null;
        }
    }


    #endregion

    } // class VmDatastore
    
    #endregion

    public static class ListVmDatastoreExtensions
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
            this List<VmDatastore> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmDatastore> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmDatastore> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmDatastore());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmDatastore> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types