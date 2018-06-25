/*
 * Daryl Crosbie
 * ID: P453055
 */
package client;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Client {
    static PrintWriter out;
    static BufferedReader in;
    static Scanner sc;
    public static void main(String[] args) {
        try{
            Socket s = new Socket("localhost", 1234);
            out = new PrintWriter(s.getOutputStream(),true);
            in = new BufferedReader(new InputStreamReader(s.getInputStream()));
            sc = new Scanner(System.in); 
            chat();
        }catch(UnknownHostException e){
            System.out.println(e); 
            System.exit(1);
        }catch(IOException e){
            System.out.println(e); 
            System.exit(1);
        }
    } 
    public static void chat(){
       String msg;
       while(true){
           try{
               msg = in.readLine();
                   System.out.println(msg);
               
               msg = sc.nextLine();
               if(msg.length() > 0){
                   out.println(msg);
                   if(msg.equalsIgnoreCase("stop")){
                       System.exit(0);
                   }
               }
           }catch(IOException e){
               System.out.println(e);
           }
       }
    }
     /*if (args.length != 2) { 
            System.out.println("Incorrect arguments used!"); 
            System.out.println("Usage: java ClientClass hostName port#"); 
            System.exit(1); 
        }
        String host = args[0]; 
        int port = Integer.valueOf(args[1]).intValue();
        */
}
