using Abp.AutoMapper;
using AngularSPWA.Prueba.Authentication.External;

namespace AngularSPWA.Prueba.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
