namespace UspechMobile.Models
{
    interface IAuthorizationModel
    {
        string Login { get; set; }
        string Password { get; set; }
        void Authorize();
        void Registration();
    }
}