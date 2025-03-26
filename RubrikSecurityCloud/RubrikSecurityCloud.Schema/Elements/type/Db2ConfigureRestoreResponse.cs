// Db2ConfigureRestoreResponse.cs
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
    #region Db2ConfigureRestoreResponse
    public class Db2ConfigureRestoreResponse: BaseType
    {
        #region members

        //      C# -> Db2ConfigureRestoreResponseStatus? Status
        // GraphQL -> status: Db2ConfigureRestoreResponseStatus! (enum)
        [JsonProperty("status")]
        public Db2ConfigureRestoreResponseStatus? Status { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2ConfigureRestoreResponse";
    }

    public Db2ConfigureRestoreResponse Set(
        Db2ConfigureRestoreResponseStatus? Status = null,
        System.String? StatusMessage = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
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
        //      C# -> Db2ConfigureRestoreResponseStatus? Status
        // GraphQL -> status: Db2ConfigureRestoreResponseStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Db2ConfigureRestoreResponseStatus? Status
        // GraphQL -> status: Db2ConfigureRestoreResponseStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new Db2ConfigureRestoreResponseStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
    }


    #endregion

    } // class Db2ConfigureRestoreResponse
    
    #endregion

    public static class ListDb2ConfigureRestoreResponseExtensions
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
            this List<Db2ConfigureRestoreResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Db2ConfigureRestoreResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2ConfigureRestoreResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2ConfigureRestoreResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2ConfigureRestoreResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types