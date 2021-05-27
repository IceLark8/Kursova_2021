using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocFinder.Data.Models;
using DocFinder.Data.Context;

namespace DocFinder.Data.Repositories
{
    public class FileDocRepository : IFileDocRepository, IDisposable
    {
        private DocFinderContext context;

        public FileDocRepository(DocFinderContext context)
        {
            this.context = context;
        }

        public IEnumerable<FileDoc> GetStudents()
        {
            return context.FileDocs.ToList();
        }

        public FileDoc Get(int docId)
        {
            return context.FileDocs.Find(docId);
        }

        public IEnumerable<FileDoc> GetFileDocs()
        {
            return context.FileDocs.ToList();
        }

        public void Insert(FileDoc doc)
        {
            context.FileDocs.Add(doc);
        }
        public void Delete(int docId)
        {
            FileDoc doc = context.FileDocs.Find(docId);
            context.FileDocs.Remove(doc);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
