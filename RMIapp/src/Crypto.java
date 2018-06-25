/*
 * Daryl Crosbie
 * ID: P453055
 */
package rmiapp;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface Crypto extends Remote {
    
    String encryption(String msg, int key) throws RemoteException;
    String decryption(String msg, int key) throws RemoteException;
}
