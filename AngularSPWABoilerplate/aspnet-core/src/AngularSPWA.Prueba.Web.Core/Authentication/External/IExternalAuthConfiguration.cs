using System.Collections.Generic;

namespace AngularSPWA.Prueba.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
