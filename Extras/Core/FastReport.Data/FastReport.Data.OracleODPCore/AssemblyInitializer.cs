using FastReport.Utils;

namespace FastReport.Data
{
    public class OracleOdpCoreAssemblyInitializer : AssemblyInitializerBase
  {
    public OracleOdpCoreAssemblyInitializer()
    {
      RegisteredObjects.AddConnection(typeof(OracleDataConnection));
    }
  }
}
