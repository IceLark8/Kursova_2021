using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spire.Doc;
using System.IO;

namespace DocFinder.Data.Models
{
    public class FileDoc : Base
    {
        public string Name { get; set; }

        public string Text { get; set; }
        
        public string? Authtor { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public string Source { get; set; }
    }
}
