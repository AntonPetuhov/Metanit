using DotNetProj;

namespace Database
{
    public class AnalyzerDB
    {
        public AnalyzerDB()
        {

        }
        public List<Analyzer> GetAllAnalyzers()
        {
            List<Analyzer> analyzerList = new List<Analyzer>()
            {
                new Analyzer(Guid.NewGuid().ToString(), "Sysmex XN-550", "172.18.0.1", 8001),
                new Analyzer(Guid.NewGuid().ToString(), "Exias", "172.18.0.2", 8002),
                new Analyzer(Guid.NewGuid().ToString(), "Mindray BC620", "172.18.0.3", 8003),
            };

            return analyzerList;
        }
    }
}

/*
namespace DotNetProj.DataBase
{
    public class AnalyzerDB
    {
        public AnalyzerDB()
        {
            
        }
        public List<Analyzer> GetAllAnalyzers()
        {
            List<Analyzer> analyzerList = new List<Analyzer>()
            {
                new Analyzer(Guid.NewGuid().ToString(), "Sysmex XN-550", "172.18.0.1", 8001),
                new Analyzer(Guid.NewGuid().ToString(), "Exias", "172.18.0.2", 8002),
                new Analyzer(Guid.NewGuid().ToString(), "Mindray BC620", "172.18.0.3", 8003),
            };

            return analyzerList;

    }

    }
}
*/