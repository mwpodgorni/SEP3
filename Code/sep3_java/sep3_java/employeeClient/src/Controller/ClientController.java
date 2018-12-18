package Controller;

import Model.Car;
import Model.EmployeeInfo;
import Model.IEmployessInfo;
import ServerCrap.Conncection;
import ServerCrap.IRmi;
import View.ClientConsole;

import java.rmi.RemoteException;

public class ClientController {
    private ClientConsole clientConsole;
    private IRmi clientExportable;
    public IEmployessInfo employeeInfo;
    public String mail;

    public ClientController() throws RemoteException {
        clientConsole = new ClientConsole();
        clientExportable = new Conncection();
        employeeInfo = new EmployeeInfo();

        chooseBetweenActions();
        employeeLogIn();
    }


    private void chooseBetweenActions() {
        boolean NotOverYet = true;
        while (NotOverYet) {
            String s = clientConsole.action("You have now 2 choiches: \n(1) to Add Car  \n(2) EXIT \n Chose your action :  ");
            if (s.equals("1")) addCar();
            if (s.equals("2")) NotOverYet = false;
        }
    }

    private void addCar() {
        String model = clientConsole.action("Enter model ");
        String plateNumber = clientConsole.action("Enter plate number");
        String colour = clientConsole.action("Enter colour ");
        Car car = new Car(plateNumber, model, colour);
    }

    private void employeeLogIn() throws RemoteException {
        boolean NotLoggedIn = true;
        while (NotLoggedIn) {
            if (Login()) {
                employeeInfo.setEmployee(clientExportable.getEmployee(mail));
                NotLoggedIn = false;
            } else {
                System.out.println("INTRUDER!! Try your luck once again..");
            }
        }
    }

    public boolean Login() throws NumberFormatException, RemoteException {
        String username = clientConsole.action("username: ");
        String password = clientConsole.action("password: ");

        return clientExportable.logIn(username, password);
    }
}
