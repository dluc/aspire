//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Extensions.Hosting
{
    public static partial class AspireRedisOutputCacheExtensions
    {
        public static void AddKeyedRedisOutputCache(this IHostApplicationBuilder builder, string name, System.Action<Aspire.StackExchange.Redis.StackExchangeRedisSettings>? configureSettings = null, System.Action<StackExchange.Redis.ConfigurationOptions>? configureOptions = null) { }

        public static void AddRedisOutputCache(this IHostApplicationBuilder builder, string connectionName, System.Action<Aspire.StackExchange.Redis.StackExchangeRedisSettings>? configureSettings = null, System.Action<StackExchange.Redis.ConfigurationOptions>? configureOptions = null) { }
    }
}