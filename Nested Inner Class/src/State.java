/*
 * Daryl Crosbie
 * ID: P453055
 */
package teststate;

import java.util.Scanner;
/**
 * The State class used to create a new state object
 * @author P453055
 */
public final class State {
    
    private String stateName;
    private int statePopulation;
    private CapitalCity capInfo;
    static Scanner sc = new Scanner(System.in);
    /**
     * Default constructor used for new state objects with user defined data
     */
    public State(){
        setStateInfo();
    }
    /**
     * Overloaded constructor used for predefined states
     * @param sName 
     * @param sPop
     * @param cName
     * @param cPop
     * @param cSize 
     */
    public State(String sName, int sPop, String cName, int cPop, int cSize){
        stateName = sName;
        statePopulation = sPop;
        capInfo = new CapitalCity(cName, cPop, cSize);
    }
    /**
     * Gets this instance state name
     * @return states name
     */
    public String getStateName(){
        return stateName;
    }
    /**
     * Gets this instance state population
     * @return states population
     */
    public int getStatePop(){
        return statePopulation;
    }
    /**
     * Gets this instance capital city name
     * @return capital city
     */
    public String getCityName(){
        return capInfo.cityName;
    }
    /**
     * Gets this instance city population
     * @return city population
     */
    public int getCityPop(){
        return capInfo.cityPopulation;
    }
    /**
     * Gets this instance city land size
     * @return land size
     */
    public int getCityLandSize(){
        return capInfo.cityLandSize;
    }
    /**
     * Inner Class Capital City. 
     */
    private final class CapitalCity{
        private String cityName;
        private int cityPopulation;
        private int cityLandSize;
        /**
         * Default constructor, used for new capital city objects with user data
         */
        public CapitalCity(){
            setCityInfo();
        }
        /**
         * Overloaded constructor, used for predefined capital cities
         * @param cName
         * @param cPop
         * @param cLandSize 
         */
        public CapitalCity(String cName, int cPop, int cLandSize){
            cityName = cName;
            cityPopulation = cPop;
            cityLandSize = cLandSize;
        }
        /**
         * Method gets and sets user data to a new Capital city object
         */
        public void setCityInfo(){
            System.out.print("Enter Capital City : ");
            cityName = sc.next();
            System.out.print("Enter City Population : ");
            cityPopulation = tryParseInt(sc.next());
            System.out.print("Enter City Land Size : ");
            cityLandSize = tryParseInt(sc.next());
            System.out.println();
        }
    }
    /**
     * Method gets and sets user data to a new State object
     */
    public void setStateInfo(){
        System.out.print("Enter state name : ");
        stateName = sc.nextLine();
        System.out.print("Enter state population : ");
        statePopulation = tryParseInt(sc.next());
        capInfo = new CapitalCity();
    }
    /**
     * Method to try convert user input to integer
     * @param in user input
     * @return integer value
     */
    public int tryParseInt(String in){
        int a = 0;
        try{
            a = Integer.parseInt(in);
        }catch(NumberFormatException e){
            System.out.println("Invalid");
        }
        return a;
    }
}
