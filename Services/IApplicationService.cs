namespace UserMvcApp.Services
{
    public interface IApplicationService
    {
        IUserService UserService { get; }
        //ola ta services pou theloume na kanoume transactions
        //IStudentService StudentService { get; }
        //ITeacherService TeacherService { get; }
    }
}
