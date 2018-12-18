import Controller.ClientController;
import ServerCrap.Conncection;
import View.ClientConsole;

import java.rmi.RemoteException;

public class Main {
    public static void main(String[] args) throws RemoteException {
        new ClientController();
    }
}
