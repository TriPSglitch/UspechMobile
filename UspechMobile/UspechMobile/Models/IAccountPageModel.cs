using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IAccountPageModel
    {
        Persons Person { get; set; }

        void Edit();


        void Logout();

        void GoBack();
    }
}