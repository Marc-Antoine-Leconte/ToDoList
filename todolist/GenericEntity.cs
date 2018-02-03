using System.Collections.Generic;

namespace OneNoteServiceSamplesWinUniversal.OneNoteApi
{
    /// <summary>
    /// This class represents a generic the OneNote API entity response
    /// Any response from the Notebooks/Sections/SectionGroups API (POST/GET etc) can be translated into this object for ease of use.
    /// </summary>
    /// <remarks>
    /// This is not meant to be a comprehensive SDK or data model.
    /// This is ONLY a light-weight representation of a OneNote API's entities (Notebooks, Sections, SectionGroups)
    /// The API's HTTP json response is deserialized into this object
    /// </remarks>
    public class GenericEntityResponse : ApiBaseResponse
    {
        /// <summary>
        /// Name of the entity
        /// </summary>
        public string Name;

        /// <summary>
        /// Self link to the given entity
        /// </summary>
        public string Self { get; set; }

        public List<GenericEntityResponse> Sections { get; set; }

        public List<GenericEntityResponse> SectionGroups { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Id: " + Id;
        }
    }
}