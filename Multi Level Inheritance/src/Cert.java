/*
 * Daryl Crosbie
 * ID: P453055
 */
package multi.level.inheritance;
import javax.swing.JOptionPane;
/**
 *
 * @author Daryl
 */
public class Cert {
    
    protected String level;
    
    public Cert(){
        this.level = "5 Certificate";
        showAchievements();
    }    
    public void showAchievements(){
        JOptionPane.showMessageDialog(null,"Level "+level+" achieved",
                "Awarded Achievements",JOptionPane.PLAIN_MESSAGE);
    }
    public int studyOn(){
        return JOptionPane.showConfirmDialog(null, "Continue studying?");
    }
}
