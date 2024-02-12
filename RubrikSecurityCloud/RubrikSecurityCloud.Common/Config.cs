using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Linq;

namespace RubrikSecurityCloud
{
    public static class Config
    {
        public static string SessionVariableName = "Global:RscConnectionClient";
        /// <summary>
        /// If true, the SDK will throw an exception if the response
        /// from the server does not match the schema used by the SDK.
        /// If false, the SDK will log a warning and return null.
        /// </summary>
        public static bool SchemaStrict = false;

        /// <summary>
        /// If true, Schema warnings are logged as info.
        /// If false, Schema warnings are logged as warnings.
        /// </summary>
        public static bool MuteSchemaWarnings = true;

        /// <summary>
        /// If true, the SDK will log all API traffic to files.
        /// </summary>
        public static bool SaveApiTrafficToFile = false;

        /// <summary>
        /// If true, logging to file will replace console logging.
        /// </summary>
        public static bool LogToFile = false;

        /// <summary>
        /// The amount of time before token expiration (in minutes)
        /// at which point any further cmdlet calls will refresh the token.
        /// </summary>
        public static double TokenRefreshThresholdMinutes = 5;

        /// <summary>
        /// API Client timeout in minutes.
        /// </summary>
        public static uint ApiClientTimeOutMinutes = 6;

        /// <summary>
        /// Default profile leaf pattern.
        /// </summary>
        public static System.Collections.Generic.HashSet<string> DefaultProfileLeafPattern = new System.Collections.Generic.HashSet<string> {
            // full matches
            "^count$",
            "^description$" ,
            "^email$" ,
            "^endcursor$" ,
            "id$" ,
            "^message$",
            "^name$" ,
            "^numworkloaddescendants$" ,
            "^objecttype$" ,
            "^slaassignment$" ,
            "^startcursor$" ,
            "^success$",
            "^total$",
            "^type$" ,
            "^username$" ,
            "^version$" ,
            // prefix matches
            "^has",
            "^is",
            // partial matches
            "status",
            "state"
        };

        /// <summary>
        /// Default profile branch pattern.
        /// </summary>
        public static System.Collections.Generic.HashSet<string> DefaultProfileBranchPattern = new System.Collections.Generic.HashSet<string> {
            "^data$",
            "^items$",
            "^nodes$",
            "^pageinfo$",
            "^asyncrequeststatus$"
        };

        /// <summary>
        /// GraphQL Variables: Ignore missing required variables.
        /// </summary>
        public static bool IgnoreMissingRequiredVariables = false;

        /// <summary>
        /// When retrieving a list of objects, the maximum number of objects to return in a single request.
        /// More specifically, this sets the max value for a GraphQL
        /// connection query's "first" parameter.
        /// Setting this value to 0 or less will disable this limit.
        /// </summary>
        public static int ConnectionMaxPageSize = 50 ;

        /// <summary>
        /// Log a warning if ConnectionMaxPageSize is exceeded.
        /// </summary>
        public static bool WarnIfConnectionPageSizeExceeded = true;

        /// <summary>
        /// Return config as JSON
        /// </summary>
        public static string ToJson()
        {
            var configProperties = typeof(Config)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .ToDictionary(
                    field => field.Name,
                    field => field.GetValue(null)
                );

            return Newtonsoft.Json.JsonConvert.SerializeObject(configProperties, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
