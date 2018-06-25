/*
 * Daryl Crosbie
 * ID: P453055
 */
package rmiapp;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

public class RMIapp implements Crypto {
    public RMIapp(){}
    public static void main(String[] args) {
       try{
            RMIapp app = new RMIapp();
            Crypto stub = (Crypto) UnicastRemoteObject.exportObject(app, 0);
            Registry reg = LocateRegistry.getRegistry();
            reg.bind("Crypto", stub);
            System.err.println("Server Ready");
       }catch(Exception e){
           System.out.println(e.toString());
           e.printStackTrace();
       }  
    }

    @Override
    public String encryption(String msg, int key) throws RemoteException {
         String code = "";
        char[] c = msg.toCharArray();
        for(int i = 0; i < msg.length(); i++){
            int hex = ((int)c[i]+key-97)%26+97;
            c[i] = (char)hex;
            code += String.valueOf(c[i]);
        }
        return code;
    }

    @Override
    public String decryption(String code, int key) throws RemoteException {
        String msg = "";
        char[] c = code.toCharArray();
        for(int i = 0; i < code.length(); i++){
            int hex = ((int)c[i]-key-97)%26+97;
            c[i] = (char)hex;
            msg += String.valueOf(c[i]);
        }
        return msg;
    } 
}
