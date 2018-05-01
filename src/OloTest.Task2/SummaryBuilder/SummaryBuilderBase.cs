using System.Text;

namespace OloTest.Task2.SummaryBuilder
{
    public abstract class SummaryBuilderBase
    {
        protected readonly StringBuilder StringBuilder;

        protected SummaryBuilderBase()
        {
            StringBuilder = new StringBuilder();
        }

        public virtual string Build()
        {
            return StringBuilder.ToString();
        }
    }
}