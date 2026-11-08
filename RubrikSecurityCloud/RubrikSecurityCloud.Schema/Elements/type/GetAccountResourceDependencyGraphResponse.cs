// GetAccountResourceDependencyGraphResponse.cs
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
    #region GetAccountResourceDependencyGraphResponse
    public class GetAccountResourceDependencyGraphResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> List<AccountResourceGroup>? Groups
        // GraphQL -> groups: [AccountResourceGroup!]! (type)
        [JsonProperty("groups")]
        public List<AccountResourceGroup>? Groups { get; set; }

        //      C# -> List<TightlyCoupledRelation>? TightlyCoupledRelations
        // GraphQL -> tightlyCoupledRelations: [TightlyCoupledRelation!]! (type)
        [JsonProperty("tightlyCoupledRelations")]
        public List<TightlyCoupledRelation>? TightlyCoupledRelations { get; set; }

        //      C# -> List<ResourceTraversalRule>? TraversalRules
        // GraphQL -> traversalRules: [ResourceTraversalRule!]! (type)
        [JsonProperty("traversalRules")]
        public List<ResourceTraversalRule>? TraversalRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetAccountResourceDependencyGraphResponse";
    }

    public GetAccountResourceDependencyGraphResponse Set(
        System.Boolean? IsSuccess = null,
        List<AccountResourceGroup>? Groups = null,
        List<TightlyCoupledRelation>? TightlyCoupledRelations = null,
        List<ResourceTraversalRule>? TraversalRules = null
    ) 
    {
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
        }
        if ( TightlyCoupledRelations != null ) {
            this.TightlyCoupledRelations = TightlyCoupledRelations;
        }
        if ( TraversalRules != null ) {
            this.TraversalRules = TraversalRules;
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
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccess\n" ;
            } else {
                s += ind + "isSuccess\n" ;
            }
        }
        //      C# -> List<AccountResourceGroup>? Groups
        // GraphQL -> groups: [AccountResourceGroup!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TightlyCoupledRelation>? TightlyCoupledRelations
        // GraphQL -> tightlyCoupledRelations: [TightlyCoupledRelation!]! (type)
        if (this.TightlyCoupledRelations != null) {
            var fspec = this.TightlyCoupledRelations.AsFieldSpec(conf.Child("tightlyCoupledRelations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tightlyCoupledRelations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ResourceTraversalRule>? TraversalRules
        // GraphQL -> traversalRules: [ResourceTraversalRule!]! (type)
        if (this.TraversalRules != null) {
            var fspec = this.TraversalRules.AsFieldSpec(conf.Child("traversalRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "traversalRules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (ec.Includes("isSuccess",true))
        {
            if(this.IsSuccess == null) {

                this.IsSuccess = true;

            } else {


            }
        }
        else if (this.IsSuccess != null && ec.Excludes("isSuccess",true))
        {
            this.IsSuccess = null;
        }
        //      C# -> List<AccountResourceGroup>? Groups
        // GraphQL -> groups: [AccountResourceGroup!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<AccountResourceGroup>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
        //      C# -> List<TightlyCoupledRelation>? TightlyCoupledRelations
        // GraphQL -> tightlyCoupledRelations: [TightlyCoupledRelation!]! (type)
        if (ec.Includes("tightlyCoupledRelations",false))
        {
            if(this.TightlyCoupledRelations == null) {

                this.TightlyCoupledRelations = new List<TightlyCoupledRelation>();
                this.TightlyCoupledRelations.ApplyExploratoryFieldSpec(ec.NewChild("tightlyCoupledRelations"));

            } else {

                this.TightlyCoupledRelations.ApplyExploratoryFieldSpec(ec.NewChild("tightlyCoupledRelations"));

            }
        }
        else if (this.TightlyCoupledRelations != null && ec.Excludes("tightlyCoupledRelations",false))
        {
            this.TightlyCoupledRelations = null;
        }
        //      C# -> List<ResourceTraversalRule>? TraversalRules
        // GraphQL -> traversalRules: [ResourceTraversalRule!]! (type)
        if (ec.Includes("traversalRules",false))
        {
            if(this.TraversalRules == null) {

                this.TraversalRules = new List<ResourceTraversalRule>();
                this.TraversalRules.ApplyExploratoryFieldSpec(ec.NewChild("traversalRules"));

            } else {

                this.TraversalRules.ApplyExploratoryFieldSpec(ec.NewChild("traversalRules"));

            }
        }
        else if (this.TraversalRules != null && ec.Excludes("traversalRules",false))
        {
            this.TraversalRules = null;
        }
    }


    #endregion

    } // class GetAccountResourceDependencyGraphResponse
    
    #endregion

    public static class ListGetAccountResourceDependencyGraphResponseExtensions
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
            this List<GetAccountResourceDependencyGraphResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetAccountResourceDependencyGraphResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetAccountResourceDependencyGraphResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetAccountResourceDependencyGraphResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetAccountResourceDependencyGraphResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types