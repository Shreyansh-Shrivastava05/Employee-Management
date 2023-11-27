using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Nodes;

namespace Employee_Management.Filters
{
    public class LowerCaseJsonResultFilter : ResultFilterAttribute
    {
        private object ConvertContentToLowerCase(object content)
        {
            if (content == null)
            {
                return null;
            }

            if (content is JObject jsonObject)
            {
                // Convert keys of the JSON object to lowercase
                var properties = jsonObject.Properties().ToList();
                foreach (var property in properties)
                {
                    var newPropertyName = property.Name.ToLower();
                    if (newPropertyName != property.Name)
                    {
                        property.AddBeforeSelf(new JProperty(newPropertyName, property.Value));
                        property.Remove();
                    }
                }

                return jsonObject;
            }

            if (content is IEnumerable<object> enumerableContent)
            {
                // Recursively convert items in the enumerable
                return enumerableContent.Select(item => ConvertContentToLowerCase(item)).ToList();
            }

            // For other types, return as is
            return content;
        }
    }
}
