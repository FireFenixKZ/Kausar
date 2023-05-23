namespace Kausar.Services
{
    public interface IAuthService
    {
        //Task<bool> RefreshToken();
        public Task<MainResponse> AuthenticateUser(LoginModel loginModel);
        Task<(bool IsSuccess, string ErrorMessage)> RegisterUser(RegistrationModel registerUser);
        //Task<List<StudentModel>> GetAllStudents();
    }
}
