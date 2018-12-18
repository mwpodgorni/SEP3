package View;

import java.util.Scanner;

public class ClientConsole {
    private Scanner input;

    public ClientConsole() {
        input = new Scanner(System.in);
    }

    public String action(String string) {
        System.out.println(string);
        return input.nextLine();
    }
}
