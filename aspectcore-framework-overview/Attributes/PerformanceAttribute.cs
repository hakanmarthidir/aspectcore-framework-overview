using AspectCore.DynamicProxy;
using System.Diagnostics;

namespace aspectcore_framework_overview.Attributes
{
    public class PerformanceAttribute : AbstractInterceptorAttribute
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {           
            var stopwatch = Stopwatch.StartNew();
            await next(context).ConfigureAwait(false);
            stopwatch.Stop();
            var method = context.ImplementationMethod;
            Debug.WriteLine($"PERFORMANCE {method.DeclaringType.Namespace} {method.DeclaringType.Name} {method.Name} {method.DeclaringType.Assembly.GetName().Name} {stopwatch.ElapsedMilliseconds} ms ");
        }
    }
}
