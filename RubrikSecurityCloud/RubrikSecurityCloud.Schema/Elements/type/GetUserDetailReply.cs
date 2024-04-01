// GetUserDetailReply.cs
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
    #region GetUserDetailReply
    public class GetUserDetailReply: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        [JsonProperty("numFilesAccessible")]
        public System.Int32? NumFilesAccessible { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetUserDetailReply";
    }

    public GetUserDetailReply Set(
        RiskLevelType? Risk = null,
        System.String? Location = null,
        System.String? Name = null,
        System.Int32? NumFilesAccessible = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumFilesAccessible != null ) {
            this.NumFilesAccessible = NumFilesAccessible;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        if (this.NumFilesAccessible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFilesAccessible\n" ;
            } else {
                s += ind + "numFilesAccessible\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
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
        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        if (ec.Includes("numFilesAccessible",true))
        {
            if(this.NumFilesAccessible == null) {

                this.NumFilesAccessible = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFilesAccessible != null && ec.Excludes("numFilesAccessible",true))
        {
            this.NumFilesAccessible = null;
        }
    }


    #endregion

    } // class GetUserDetailReply
    
    #endregion

    public static class ListGetUserDetailReplyExtensions
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
            this List<GetUserDetailReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetUserDetailReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetUserDetailReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetUserDetailReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetUserDetailReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types