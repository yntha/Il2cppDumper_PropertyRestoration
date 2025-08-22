namespace Il2CppDumper_PropertyRestoration
{
    public enum SearchSectionType
    {
        Exec,
        Data,
        Bss
    }

    public class SearchSection
    {
        public ulong offset;
        public ulong offsetEnd;
        public ulong address;
        public ulong addressEnd;
    }
}
