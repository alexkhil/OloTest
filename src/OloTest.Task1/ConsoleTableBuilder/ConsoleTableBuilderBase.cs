using ConsoleTables;

namespace OloTest.Task1.ConsoleTableBuilder
{
    /// <summary>
    /// Base class for Console Table builders
    /// </summary>
    public abstract class ConsoleTableBuilderBase
    {
        protected readonly ConsoleTable ConsoleTable;

        protected ConsoleTableBuilderBase() => ConsoleTable = new ConsoleTable();

        protected abstract void BuildHeader();
        protected abstract void BuildRows();

        public virtual ConsoleTable Build()
        {
            BuildHeader();
            BuildRows();
            return ConsoleTable;
        }
    }
}