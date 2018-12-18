package ServerCrap;

import Model.Car;
import Model.Employee;
import ServerCrap.IRmi;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

public class serverProps implements IRmi {

    public serverProps() {
        super();
        try {
            startServer();
            System.out.println("Zdarova , Iopta !");
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    private void startServer() throws RemoteException {
        LocateRegistry.createRegistry(6584);
        Registry registry = LocateRegistry.getRegistry(6584);
        System.setProperty("java.rmi.server.hostname", "localhost");
        IRmi stub = (IRmi) UnicastRemoteObject.exportObject(this, 0);
        registry.rebind("localhost", stub);
    }


    @Override
    public void addCar(Car car) throws RemoteException {
        //TODO sql method.
    }

    @Override
    public boolean logIn(String username , String password) throws RemoteException {
        //TODO sqlmoethod
        return false;

    }

    @Override
    public Employee getEmployee(String email) throws RemoteException {
        //TODO
        return null;
    }
}
