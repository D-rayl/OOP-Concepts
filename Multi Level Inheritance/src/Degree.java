/*
 * Daryl Crosbie
 * ID: P453055
 */
package multi.level.inheritance;

import javax.swing.JOptionPane;

public class Degree extends AdvancedDiploma{
    
    public Degree(){
        this.level = "8 Bachelors Degree";
        showAchievements();
        
        JOptionPane.showMessageDialog(null, "Congratulations, you have graduated","Graduation", JOptionPane.PLAIN_MESSAGE);
    }
}
