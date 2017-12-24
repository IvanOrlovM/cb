using System.IO;

namespace FileDefinition
{
    public abstract class AbstractHandler
    {
        private readonly string _path;

        public AbstractHandler(string path)
        {
            _path = path;
        }
        
        public string Value { get; set; }

        public void Open()
        {
            Value = File.ReadAllText(_path);
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void Change()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            File.WriteAllText(_path, Value);
        }
    }
}