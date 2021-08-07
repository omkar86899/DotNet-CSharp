using System;

namespace CrudableApp.Model
{
    public interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
