// CdmGlobalConfigParam.cs
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
    #region CdmGlobalConfigParam
    public class CdmGlobalConfigParam: BaseType
    {
        #region members

        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        [JsonProperty("state")]
        public CdmConfigParamState? State { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        [JsonProperty("currentValue")]
        public System.String? CurrentValue { get; set; }

        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        [JsonProperty("defaultValue")]
        public System.String? DefaultValue { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmGlobalConfigParam";
    }

    public CdmGlobalConfigParam Set(
        CdmConfigParamState? State = null,
        System.String? ClusterUuid = null,
        System.String? CurrentValue = null,
        System.String? DefaultValue = null,
        System.String? Description = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Namespace = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CurrentValue != null ) {
            this.CurrentValue = CurrentValue;
        }
        if ( DefaultValue != null ) {
            this.DefaultValue = DefaultValue;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
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
        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        if (this.CurrentValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentValue\n" ;
            } else {
                s += ind + "currentValue\n" ;
            }
        }
        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        if (this.DefaultValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultValue\n" ;
            } else {
                s += ind + "defaultValue\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespace\n" ;
            } else {
                s += ind + "namespace\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new CdmConfigParamState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        if (ec.Includes("currentValue",true))
        {
            if(this.CurrentValue == null) {

                this.CurrentValue = "FETCH";

            } else {


            }
        }
        else if (this.CurrentValue != null && ec.Excludes("currentValue",true))
        {
            this.CurrentValue = null;
        }
        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        if (ec.Includes("defaultValue",true))
        {
            if(this.DefaultValue == null) {

                this.DefaultValue = "FETCH";

            } else {


            }
        }
        else if (this.DefaultValue != null && ec.Excludes("defaultValue",true))
        {
            this.DefaultValue = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (ec.Includes("namespace",true))
        {
            if(this.Namespace == null) {

                this.Namespace = "FETCH";

            } else {


            }
        }
        else if (this.Namespace != null && ec.Excludes("namespace",true))
        {
            this.Namespace = null;
        }
    }


    #endregion

    } // class CdmGlobalConfigParam
    
    #endregion

    public static class ListCdmGlobalConfigParamExtensions
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
            this List<CdmGlobalConfigParam> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmGlobalConfigParam> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmGlobalConfigParam> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmGlobalConfigParam());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmGlobalConfigParam> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types