using System.Threading.Tasks;

namespace AsAdminWindowsAppSDK.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
