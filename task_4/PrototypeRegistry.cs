using System.Collections.Concurrent;
using task_4.entities;

namespace task_4
{
    public sealed class PrototypeRegistry
    {
        private static readonly Lazy<PrototypeRegistry> _instance =
            new(() => new PrototypeRegistry());

        public static PrototypeRegistry Instance => _instance.Value;

        private readonly ConcurrentDictionary<string, Computer> _prototypes =
            new();

        private PrototypeRegistry() { }

        public void Register(string key, Computer prototype)
        {
            _prototypes[key] = prototype;
        }

        public Computer GetShallowClone(string key)
        {
            return (Computer)_prototypes[key].Clone();
        }

        public Computer GetDeepClone(string key)
        {
            return _prototypes[key].DeepClone();
        }
    }
}
