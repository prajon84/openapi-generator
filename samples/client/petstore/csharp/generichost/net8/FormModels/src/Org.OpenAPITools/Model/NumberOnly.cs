// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NumberOnly
    /// </summary>
    public partial class NumberOnly : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOnly" /> class.
        /// </summary>
        /// <param name="justNumber">justNumber</param>
        [JsonConstructor]
        public NumberOnly(Option<decimal?> justNumber = default)
        {
            JustNumberOption = justNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of JustNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> JustNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets JustNumber
        /// </summary>
        [JsonPropertyName("JustNumber")]
        public decimal? JustNumber { get { return this.JustNumberOption; } set { this.JustNumberOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NumberOnly {\n");
            sb.Append("  JustNumber: ").Append(JustNumber).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NumberOnly" />
    /// </summary>
    public class NumberOnlyJsonConverter : JsonConverter<NumberOnly>
    {
        /// <summary>
        /// Deserializes json to <see cref="NumberOnly" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NumberOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> justNumber = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "JustNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                justNumber = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (justNumber.IsSet && justNumber.Value == null)
                throw new ArgumentNullException(nameof(justNumber), "Property is not nullable for class NumberOnly.");

            return new NumberOnly(justNumber);
        }

        /// <summary>
        /// Serializes a <see cref="NumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="numberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NumberOnly numberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, numberOnly, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="numberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NumberOnly numberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            if (numberOnly.JustNumberOption.IsSet)
                writer.WriteNumber("JustNumber", numberOnly.JustNumberOption.Value.Value);
        }
    }
}
