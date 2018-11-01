using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace NLightHouse.HostedServices
{
  public class NBXPlorerWatcher : BackgroundService
  {
    public override async Task ExecuteAsync(CancellationToken ct)
    {
      return;
    }
    public async Task StopAsync(CancellationToken ct)
    {
      return;
    }
  }
}