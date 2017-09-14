using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BatCheese.Data.AgentService
{
    public interface IAgentServiceClientFactory
    {
        AgentServiceClient CreateAgentServiceClient();
        
        AgentServiceClient CreateAgentServiceClient(string endpointConfigurationName);

        AgentServiceClient CreateAgentServiceClient(string endpointConfigurationName, string remoteAddress);

        AgentServiceClient CreateAgentServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress);

        AgentServiceClient CreateAgentServiceClient(Binding binding, EndpointAddress remoteAddress);
    }
}
