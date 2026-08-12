// SigninAnomalyActor.cs
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
    #region SigninAnomalyActor
    public class SigninAnomalyActor: BaseType
    {
        #region members

        //      C# -> ViolationPrincipalType? ActorType
        // GraphQL -> actorType: ViolationPrincipalType! (enum)
        [JsonProperty("actorType")]
        public ViolationPrincipalType? ActorType { get; set; }

        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        [JsonProperty("actorId")]
        public System.String? ActorId { get; set; }

        //      C# -> System.String? ActorIp
        // GraphQL -> actorIp: String! (scalar)
        [JsonProperty("actorIp")]
        public System.String? ActorIp { get; set; }

        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        [JsonProperty("actorName")]
        public System.String? ActorName { get; set; }

        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninAnomalyActor";
    }

    public SigninAnomalyActor Set(
        ViolationPrincipalType? ActorType = null,
        System.String? ActorId = null,
        System.String? ActorIp = null,
        System.String? ActorName = null,
        System.String? EventId = null
    ) 
    {
        if ( ActorType != null ) {
            this.ActorType = ActorType;
        }
        if ( ActorId != null ) {
            this.ActorId = ActorId;
        }
        if ( ActorIp != null ) {
            this.ActorIp = ActorIp;
        }
        if ( ActorName != null ) {
            this.ActorName = ActorName;
        }
        if ( EventId != null ) {
            this.EventId = EventId;
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
        //      C# -> ViolationPrincipalType? ActorType
        // GraphQL -> actorType: ViolationPrincipalType! (enum)
        if (this.ActorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorType\n" ;
            } else {
                s += ind + "actorType\n" ;
            }
        }
        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        if (this.ActorId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorId\n" ;
            } else {
                s += ind + "actorId\n" ;
            }
        }
        //      C# -> System.String? ActorIp
        // GraphQL -> actorIp: String! (scalar)
        if (this.ActorIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIp\n" ;
            } else {
                s += ind + "actorIp\n" ;
            }
        }
        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        if (this.ActorName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorName\n" ;
            } else {
                s += ind + "actorName\n" ;
            }
        }
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventId\n" ;
            } else {
                s += ind + "eventId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationPrincipalType? ActorType
        // GraphQL -> actorType: ViolationPrincipalType! (enum)
        if (ec.Includes("actorType",true))
        {
            if(this.ActorType == null) {

                this.ActorType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.ActorType != null && ec.Excludes("actorType",true))
        {
            this.ActorType = null;
        }
        //      C# -> System.String? ActorId
        // GraphQL -> actorId: String! (scalar)
        if (ec.Includes("actorId",true))
        {
            if(this.ActorId == null) {

                this.ActorId = "FETCH";

            } else {


            }
        }
        else if (this.ActorId != null && ec.Excludes("actorId",true))
        {
            this.ActorId = null;
        }
        //      C# -> System.String? ActorIp
        // GraphQL -> actorIp: String! (scalar)
        if (ec.Includes("actorIp",true))
        {
            if(this.ActorIp == null) {

                this.ActorIp = "FETCH";

            } else {


            }
        }
        else if (this.ActorIp != null && ec.Excludes("actorIp",true))
        {
            this.ActorIp = null;
        }
        //      C# -> System.String? ActorName
        // GraphQL -> actorName: String! (scalar)
        if (ec.Includes("actorName",true))
        {
            if(this.ActorName == null) {

                this.ActorName = "FETCH";

            } else {


            }
        }
        else if (this.ActorName != null && ec.Excludes("actorName",true))
        {
            this.ActorName = null;
        }
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (ec.Includes("eventId",true))
        {
            if(this.EventId == null) {

                this.EventId = "FETCH";

            } else {


            }
        }
        else if (this.EventId != null && ec.Excludes("eventId",true))
        {
            this.EventId = null;
        }
    }


    #endregion

    } // class SigninAnomalyActor
    
    #endregion

    public static class ListSigninAnomalyActorExtensions
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
            this List<SigninAnomalyActor> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninAnomalyActor> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninAnomalyActor> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninAnomalyActor());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninAnomalyActor> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types