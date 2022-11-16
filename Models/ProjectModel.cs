using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace portfolio.Models;

public class ProjectModel
{

    
        public String Id { get; set; }

        public String Name { get; set; }

        public String Url { get; set; }

        public String Image { get; set; }

        public String Description { get; set; }

    public override string ToString() => JsonSerializer.Serialize<ProjectModel>(this);

}


