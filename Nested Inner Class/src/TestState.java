/*
 * Daryl Crosbie
 * ID: P453055
 */
package teststate;
/**
 * Testing class
 * @author P453055
 */
public class TestState {

    public static void main(String[] args) {
        
        State WA = new State("Western Australia", 2613700, "Perth", 2022044, 6417);
        State NSW = new State("New South Wales", 7704300, "Sydney", 5131326, 12367);
        
        System.out.println("State               : "+WA.getStateName()+"\n"
                         + "State Population    : "+WA.getStatePop()+"\n"
                         + "Capital City        : "+WA.getCityName()+"\n"
                         + "City Population     : "+WA.getCityPop()+"\n"
                         + "City Land Size      : "+WA.getCityLandSize()+"\n");
        
        System.out.println("State               : "+NSW.getStateName()+"\n"
                         + "State Population    : "+NSW.getStatePop()+"\n"
                         + "Capital City        : "+NSW.getCityName()+"\n"
                         + "City Population     : "+NSW.getCityPop()+"\n"
                         + "City Land Size      : "+NSW.getCityLandSize()+"\n");
        
        State newState = new State();
        System.out.println("State               : "+newState.getStateName()+"\n"
                         + "State Population    : "+newState.getStatePop()+"\n"
                         + "Capital City        : "+newState.getCityName()+"\n"
                         + "City Population     : "+newState.getCityPop()+"\n"
                         + "City Land Size      : "+newState.getCityLandSize()+"\n");
    }
    
    
}
