/*
 * Daryl Crosbie
 * ID: P453055
 */
package rmiapp;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client {
    static Registry reg = null;
    static Crypto stub = null;
    
    public static void main(String[] args){
        int key, ans;
        String msg, code;
        try{
            reg = LocateRegistry.getRegistry(null);
            stub = (Crypto) reg.lookup("Crypto");
            System.out.println("Connected");
        }catch(Exception e){
            System.err.println(e.toString());
            e.printStackTrace();
        }
        Scanner sc = new Scanner(System.in);
        System.out.println("Caesars Cipher across RMI.\n"
                         + "Encryption Press 1.\n"
                         + "Decryption Press 2.");
        ans = sc.nextInt();
        if(ans == 1){
            System.out.print("Enter message to encrypt: ");
            msg = sc.next();
            System.out.print("Enter key: ");
            key = sc.nextInt();
            try {
                code = stub.encryption(msg, key);
                System.out.println(code);
            } catch (RemoteException ex) {
                System.out.println("Something went wrong");
            }
        }
        else if(ans == 2){
            System.out.print("Enter message to decipher: ");
            code = sc.next();
            System.out.print("Enter key: ");
            key = sc.nextInt();
            try {
                msg = stub.decryption(code, key);
                System.out.println(msg);
            } catch (RemoteException ex) {
                System.out.println("Something went wrong");
            }
        }
        else{
            System.out.println("Goodbye");
        }
    }
}
