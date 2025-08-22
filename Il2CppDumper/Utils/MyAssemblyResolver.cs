using Mono.Cecil;

namespace Il2CppDumper_PropertyRestoration
{
    public class MyAssemblyResolver : DefaultAssemblyResolver
    {
        public void Register(AssemblyDefinition assembly)
        {
            RegisterAssembly(assembly);
        }
    }
}
