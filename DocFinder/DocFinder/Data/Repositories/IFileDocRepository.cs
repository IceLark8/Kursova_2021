using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocFinder.Data.Models;

namespace DocFinder.Data.Repositories
{
    public interface IFileDocRepository
    {
        IEnumerable<FileDoc> GetFileDocs();
        
        FileDoc Get(int docId);
        
        void Insert(FileDoc doc);
        
        void Delete(int docId);
        
        void Save();
    }
}
