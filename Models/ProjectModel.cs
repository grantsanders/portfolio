using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace portfolio.Models;

public class ProjectModel
{

    
        public String Id { get; set; }

        public String ProjectName { get; set; }

        public String ProjectDescription { get; set; }

        [JsonPropertyName ("img")]
        public String Image { get; set; }

        public String Url { get; set; }

    public override string ToString() => JsonSerializer.Serialize<ProjectModel>(this);

}


