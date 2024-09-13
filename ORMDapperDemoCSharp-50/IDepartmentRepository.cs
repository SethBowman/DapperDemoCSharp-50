namespace ORMDapperDemoCSharp_50;

public interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllDepartments();
    public void InsertDepartment(string newDepartmentName);
}