using API.CustomTypes;
using Microsoft.Net.Http.Headers;

namespace API.Services.Interfaces
{
    public interface ISecretsService
    {
        public AssistantInformations? AssistantInformations { get; set; }
        public ConnectionStrings? ConnectionStrings { get; set; }
    }
}