package Model;

public class EmployeeInfo implements IEmployessInfo {
    public Employee employee;

    @Override
    public void setEmployee(Employee employee) {
        this.employee = employee;
        System.out.println("Hello " + employee.getMail());
    }

    @Override
    public Employee employee() {
        return employee;
    }


}
