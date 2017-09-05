using Microsoft.Azure.WebJobs;

namespace ContosoAdsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }
    }
}
