// AwsActionWithUseCase.cs
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
    #region AwsActionWithUseCase
    public class AwsActionWithUseCase: BaseType
    {
        #region members

        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        [JsonProperty("action")]
        public System.String? Action { get; set; }

        //      C# -> List<System.String>? Usecase
        // GraphQL -> usecase: [String!]! (scalar)
        [JsonProperty("usecase")]
        public List<System.String>? Usecase { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsActionWithUseCase";
    }

    public AwsActionWithUseCase Set(
        System.String? Action = null,
        List<System.String>? Usecase = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( Usecase != null ) {
            this.Usecase = Usecase;
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
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> List<System.String>? Usecase
        // GraphQL -> usecase: [String!]! (scalar)
        if (this.Usecase != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usecase\n" ;
            } else {
                s += ind + "usecase\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = "FETCH";

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> List<System.String>? Usecase
        // GraphQL -> usecase: [String!]! (scalar)
        if (ec.Includes("usecase",true))
        {
            if(this.Usecase == null) {

                this.Usecase = new List<System.String>();

            } else {


            }
        }
        else if (this.Usecase != null && ec.Excludes("usecase",true))
        {
            this.Usecase = null;
        }
    }


    #endregion

    } // class AwsActionWithUseCase
    
    #endregion

    public static class ListAwsActionWithUseCaseExtensions
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
            this List<AwsActionWithUseCase> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsActionWithUseCase> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsActionWithUseCase> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsActionWithUseCase());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsActionWithUseCase> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types