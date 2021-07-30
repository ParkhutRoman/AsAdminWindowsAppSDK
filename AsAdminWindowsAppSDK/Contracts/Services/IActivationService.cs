using System.Threading.Tasks;

namespace AsAdminWindowsAppSDK.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
