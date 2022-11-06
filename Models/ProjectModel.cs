using System;
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

        
        
    }


