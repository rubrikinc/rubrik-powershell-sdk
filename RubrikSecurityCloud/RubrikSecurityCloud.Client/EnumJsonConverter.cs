using System;
using System.Reflection;
using Newtonsoft.Json;
using RubrikSecurityCloud.Client.Models;

namespace RubrikSecurityCloud.Client
{
    public class EnumJsonConverter : JsonConverter
    {
        // Check if the input object is a nullable enum as defined in
        // the RSC Class Library. If so, this converter will be used
        // to deserialize the API response JSON from ENUM type.
        // If not, other converters will be used.
        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsGenericType &&
                objectType.GenericTypeArguments[0].IsEnum)
            {
                return true;
            }
            else
            {
                return objectType.IsEnum;
            }            
        }

        public override object ReadJson(JsonReader reader,
                                        Type objectType,
                                        object existingValue,
                                        JsonSerializer serializer)
        {
            string enumStringValue = (string)reader.Value;

            // Because everything in the RSC SDK is nullable, we should
            // get the base type before proceeding:

            if (enumStringValue == null)
            {
                return null;
            }

            if (objectType.IsGenericType)
            {
                objectType = objectType.GenericTypeArguments[0];
            }

            // If the incoming ENUM value already exists in the
            // type, return it.
            if (Enum.IsDefined(objectType, enumStringValue))
            {
                return Enum.Parse(objectType, enumStringValue);
            }

            // RS: We since some RSC enum values have '_' in them and
            // others don't we need to normalize this.
            // So I propose we strip out any '_' from the input string
            // as well as the constraint names
            enumStringValue.Replace("_", string.Empty);

            foreach (var constName in Enum.GetNames(objectType))
            {
                // Strip out any underscores from the enum value
                string cleanedConstName = constName.Replace("_", string.Empty);

                if (string.Equals(cleanedConstName, enumStringValue, StringComparison.OrdinalIgnoreCase))
                {
                    return Enum.Parse(objectType, constName);
                }
            }

            // We haven't got a match, return the fist as default
            // TODO: SPARK-212045

            throw new RscServerSchemaMismatchException(
                $"API returned \"{enumStringValue}\" as an ENUM value to " +
                $"ENUM: \"{objectType.Name}\". Valid values for " +
                $"{objectType.Name} are: "
                + string.Join(" ", Enum.GetValues(objectType)));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}

