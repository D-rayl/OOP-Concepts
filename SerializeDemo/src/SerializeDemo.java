/*
 * Daryl Crosbie
 * ID: P453055
 */
package serializedemo;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class SerializeDemo {

    public static void main(String[] args) {
        Person p = new Person("Tom", 18, "Male");
        serializeData(p);
        Person p2 = deserializeData(p);
        if(p2 != null){
            System.out.println(p2);
        }
    }
    static void serializeData(Person p){
        try{
            FileOutputStream fos = new FileOutputStream("C:/temp/person.ser");
            ObjectOutputStream obs = new ObjectOutputStream(fos);
            obs.writeObject(p);
            obs.close();
            fos.close();
        }catch(Exception e){
            e.printStackTrace();
        }
    }
    static Person deserializeData(Person p){
        try{
            FileInputStream fis = new FileInputStream("C:/temp/person.ser");
            ObjectInputStream obs = new ObjectInputStream(fis);
            p = (Person) obs.readObject();
            obs.close();
            fis.close();
            return p;
        }catch(Exception e){
            e.printStackTrace();
            return null;
        }
    }
            
    static class Person implements java.io.Serializable{
        String name;
        int age;
        String sex;
        
        public Person(String n, int a, String s){
                name = n;
                age = a;
                sex = s;
        }
        @Override
        public String toString(){
            return    "Name: "+name+"\n"
                    + "Age:  "+age+"\n"
                    + "Sex:  "+sex;
        }
    }
}
