
using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

// Below container contains the service-implementation pairs in Startup.ConfigureServices method.
var container = Startup.ConfigureServices();

/* When we call GetRequiredService with IBarService, it will implement BarService
 * Since BarService constructor uses IFooService, it will implement FooService
 */
var barService = container.GetRequiredService<IBarService>();
barService.DoSomeRealWork();

//Output:
/* Processing 0
 * Processing 1
 * Processing 2
 * Processing 3
 * Processing 4
 */

