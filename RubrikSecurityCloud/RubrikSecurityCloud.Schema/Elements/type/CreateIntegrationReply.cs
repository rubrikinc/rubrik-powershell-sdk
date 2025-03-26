// CreateIntegrationReply.cs
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
    #region CreateIntegrationReply
    public class CreateIntegrationReply: BaseType
    {
        #region members

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> IntegrationCreation? Info
        // GraphQL -> info: IntegrationCreation (type)
        [JsonProperty("info")]
        public IntegrationCreation? Info { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateIntegrationReply";
    }

    public CreateIntegrationReply Set(
        System.Int64? Id = null,
        IntegrationCreation? Info = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Info != null ) {
            this.Info = Info;
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
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> IntegrationCreation? Info
        // GraphQL -> info: IntegrationCreation (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(conf.Child("info"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "info" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> IntegrationCreation? Info
        // GraphQL -> info: IntegrationCreation (type)
        if (ec.Includes("info",false))
        {
            if(this.Info == null) {

                this.Info = new IntegrationCreation();
                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            } else {

                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            }
        }
        else if (this.Info != null && ec.Excludes("info",false))
        {
            this.Info = null;
        }
    }


    #endregion

    } // class CreateIntegrationReply
    
    #endregion

    public static class ListCreateIntegrationReplyExtensions
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
            this List<CreateIntegrationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateIntegrationReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateIntegrationReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateIntegrationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateIntegrationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types