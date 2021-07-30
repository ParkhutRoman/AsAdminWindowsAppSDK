using System;

namespace AsAdminWindowsAppSDK.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
