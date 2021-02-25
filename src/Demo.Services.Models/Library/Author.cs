using System;

namespace Demo.Services.Models.Library
{
    public class Author : ResourceBase
    {
        public string Name { get; set; } = string.Empty;

        public string Biography { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }
    }
}
