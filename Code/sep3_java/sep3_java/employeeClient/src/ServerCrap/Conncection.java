package ServerCrap;

import Model.Car;
import Model.Employee;


import java.rmi.Remote;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class Conncection implements Remote, IRmi {
    public static IRmi server;

    public Conncection() throws RemoteException {
        super();
        obtainRemote("localhost");

    }

    private static boolean obtainRemote(String localhost) throws RemoteException {
        IRmi remote;
        Registry registry = LocateRegistry.getRegistry(localhost, 6584);
        try {

            remote = (IRmi) registry.lookup(localhost);
            server = remote;
            return true;

        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }


    }

    @Override
    public void addCar(Car car) throws RemoteException {
        server.addCar(car);
    }

    @Override
    public Employee getEmployee(String mail) throws RemoteException {
        return server.getEmployee(mail);
    }

    @Override
    public boolean logIn(String username, String password) throws RemoteException {
        return server.logIn(username, password);
    }


}
