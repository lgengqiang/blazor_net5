using BlazorServerAppExample.Data.ViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppExample.Data
{
    public interface IAccountService
    {
        LoggedInUserViewModel Account { get; }
        Task Initialize();
        Task Login(string loginName, string password);
        Task Logout();
    }

    public class AccountService : IAccountService
    {
        private static readonly string KEY_NAME = "__user";
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public LoggedInUserViewModel Account { get; private set; }

        public AccountService(NavigationManager navigationManager, ILocalStorageService localStorageService)
        {
            System.Diagnostics.Debug.WriteLine($"AccountService.new()");
            this._navigationManager = navigationManager;
            this._localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            this.Account = await this._localStorageService.GetItem<LoggedInUserViewModel>(KEY_NAME);
        }

        public async Task Login(string loginName, string password)
        {
            this.Account = new LoggedInUserViewModel
            {
                LoginName = loginName,
                DisplayName = loginName,
            };
            await this._localStorageService.SetItem<LoggedInUserViewModel>(KEY_NAME, this.Account);
        }

        public async Task Logout()
        {
            this.Account = null;
            await this._localStorageService.RemoveItem(KEY_NAME);
            this._navigationManager.NavigateTo("/");
        }
    }
}
