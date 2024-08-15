namespace DotNetProj
{
     //
    public interface IAnalyzer
    {

    }
    public class Analyzer
    {
        public string analyzer_id { get; set; }
        public string analyzer_name { get; set; }
        public string analyzer_ip { get; set; }
        public int analyzer_port { get; set; }

        public Analyzer(string analyzer_id, string analyzer_name, string analyzer_ip, int analyzer_port)
        {
            this.analyzer_id = analyzer_id;
            this.analyzer_name = analyzer_name;
            this.analyzer_ip = analyzer_ip; 
            this.analyzer_port = analyzer_port;
        }

    }
}
