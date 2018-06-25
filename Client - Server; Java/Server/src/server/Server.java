/*
 * Daryl Crosbie
 * ID: P453055
 */
package server;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
public class Server {
    
    static PrintWriter out;
    static BufferedReader in;
    static String line;
    static boolean crypt = false;
    
    public static void main(String[] args) {
        try(ServerSocket svs = new ServerSocket(1234)){
            System.out.println("Server on port: "+svs.getLocalPort());
            Socket cs = svs.accept();
                String clientName = cs.getInetAddress().getHostName();
                int clientPort = cs.getLocalPort();
                System.out.println("Client: "+clientName+" - Port: "+clientPort);
                
                out = new PrintWriter(cs.getOutputStream(), true);
                in = new BufferedReader(new InputStreamReader(cs.getInputStream()));
                int key;
                while(true){
                    crypt = getCrypt();
                    if(line.equalsIgnoreCase("stop")){
                        System.out.println("Client disconnected");
                        break;
                    }
                    if(crypt){
                        out.println("Enter message to encrypt");
                        line = in.readLine();
                        out.println("Enter encryption key");
                        key = Integer.parseInt(in.readLine());
                        String code = encrypt(line, key);
                        out.println("Coded msg: "+code);
                    }
                    else{
                        out.println("Enter message to decipher");
                        line = in.readLine();
                        out.println("Enter decipher key");
                        key = Integer.parseInt(in.readLine());
                        String msg = decrypt(line,key);
                        out.println("Deciphered msg: "+msg);
                    }
                }
        }
        catch(Exception e){
           System.err.println(e);
        }
    }
    public static String encrypt(String msg, int key){
        String code = "";
        char[] c = msg.toCharArray();
        for(int i = 0; i < msg.length(); i++){
            int hex = ((int)c[i]+key-97)%26+97;
            c[i] = (char)hex;
            code += String.valueOf(c[i]);
        }
        return code;
    }
    public static String decrypt(String code, int key){
        String msg = "";
        char[] c = code.toCharArray();
        for(int i = 0; i < code.length(); i++){
            int hex = ((int)c[i]-key-97)%26+97;
            c[i] = (char)hex;
            msg += String.valueOf(c[i]);
        }
        return msg;
    }
    public static boolean getCrypt(){
            out.println("Caesars Cipher Server Encrption - Press 1. Decryption - Press 2.");
            try{
            line = in.readLine();
            if(Integer.parseInt(line)==1){
                    return crypt = true;        
                    }
            }catch(Exception e){
                System.out.println(e);
            }
            return crypt = false;
    } 
}
