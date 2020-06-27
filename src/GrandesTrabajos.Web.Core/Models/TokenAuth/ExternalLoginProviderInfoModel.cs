using Abp.AutoMapper;
using GrandesTrabajos.Authentication.External;

namespace GrandesTrabajos.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
