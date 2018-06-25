/*
 * Daryl Crosbie
 * ID: P453055
 */
package multi.level.inheritance;

import javax.swing.JOptionPane;

/**
 * This program demonstrate multiple level inheritance. Each higher 
 * level inherits from its lower level until it reaches the super class Cert,
 * where the only attributes and methods are declared. As the user agrees to 
 * study on in the program a new object of that level will be created, and used 
 * to call the same continue study method.
 * Each time the achievements will be displayed upon construction of the new 
 * level object.
 * @author Daryl
 */
public class MultiLevelInheritance {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        int ans = JOptionPane.showConfirmDialog(null, "Study a Certificate");
        if(ans ==0){
            Cert c = new Cert();
            if(c.studyOn() == 0){
                Diploma d = new Diploma();
                if(d.studyOn() == 0){
                    AdvancedDiploma ad = new AdvancedDiploma();
                    if(ad.studyOn() == 0){
                        Degree dg = new Degree();
                    }
                }
            }
        }
    } 
}
