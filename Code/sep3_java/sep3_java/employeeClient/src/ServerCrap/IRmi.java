package ServerCrap;

import Model.Car;
import Model.Employee;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface IRmi extends Remote {
    public void addCar(Car car) throws RemoteException;

    public boolean logIn(String username, String password) throws RemoteException;

    public Employee getEmployee(String email) throws RemoteException;
}
