using ClearnArch.Domain.Models;

namespace ClearnArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
