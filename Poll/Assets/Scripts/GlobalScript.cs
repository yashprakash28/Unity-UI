using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;

public class GlobalScript : MonoBehaviour
{
    public GameObject departmentChoice;
    public GameObject electronics, mechanical, chemical;
    public GameObject infoCanvas;
    private string userChoice;
    private static float ALUcnt, RLCcnt, MonostableOscillatorcnt, LogicGatescnt, bjtcnt, chargercnt, photocnt, opampcnt,
                  faultdetectioncnt, oilwhirlingcnt, powerpresscnt, vaccumformingcnt, grindingcnt, cantilevercnt, hydrauliccnt, shapingcnt,
                  adsorptioncnt, calorimetrycnt, membraneseparationcnt, polymerizationcnt, viscositycnt, gelcnt, tyndallcnt, dnacnt,
                  ececnt, mechcnt, chemcnt, totalcnt;

    private int eceMax = 8, mechMax = 8, chemMax = 7;

    public GameObject eceLeaderboard, mechLeaderboard, chemLeaderboard, mainLeaderboard;                                      
    
    public void startPollButton()
    {
        GameObject.Find("Welcome").SetActive(false);
        departmentChoice.SetActive(true);
        // Debug.Log("sdfghj");
    }

    public void electronicsButton()
    {
        departmentChoice.SetActive(false);
        electronics.SetActive(true);
    }

    public void mechanicalButton()
    {
        departmentChoice.SetActive(false);
        mechanical.SetActive(true);
    }

    public void chemicalButton()
    {
        departmentChoice.SetActive(false);
        chemical.SetActive(true);
    }

    public void goBackButton()
    {
        departmentChoice.SetActive(true);
        chemical.SetActive(false);
        mechanical.SetActive(false);
        electronics.SetActive(false);
    }

    public void showInfo()
    {
        infoCanvas.SetActive(true);
        GameObject buttonClicked = EventSystem.current.currentSelectedGameObject;
        // Debug.Log(buttonClicked);
        userChoice = buttonClicked.name;

        /// ECE
        if(buttonClicked.name == "ALU")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Arithmetic Logic Unit Simulation";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "This module explains how to build a Programmable 1-bit ALU. In computing, an arithmetic logic unit (ALU) is a digital circuit that performs arithmetic and logical operations. Most ALUs can perform Bitwise logic operations, Integer arithmetic operations, Bit-shifting operations. Shifts can be seen as multiplications and divisions by a power of two. ";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/ALU");
            // userChoice = "alu";
        }

        else if(buttonClicked.name == "LogicGates")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Logic Gate Simulation";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The experiment will equip user with the choice of available logic gate ICs. Options available will include individual simulation of ICs and some of the basic logic operations (DeMorgan Law, etc.). The setup will include a breadboard for the formation of circuits, triggering inputs, and output LEDs. After the experiment, the user will learn the uses of logic gates by verifying the truth tables.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/LogicGates");
            // userChoice = "logicgates";
        }

        else if(buttonClicked.name == "RLC")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "RLC Simulation";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The experiment demonstrates the working of an RLC circuit. It can be operated in different configurations, R, L, C, RL, LC, RC, RLC. Each configuration will enable users to understand the flow of current and phasor diagrams. It will also support transient analysis.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/RLC");
            // userChoice = "rlc";
        }

        else if(buttonClicked.name == "MonostableOscillator")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Monostable Oscillator using 555 timer IC";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "It has one stable and one quasi-stable state. The circuit is useful for generating a single output pulse of time duration in response to a triggering signal. The width of the output pulse depends only on external components connected to the op-amp. The experiment enables users to interact with the circuit and visualize output for various input pulses on the oscilloscope.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/MonostableOscillator");
            // userChoice = "monostable";
        }

        else if(buttonClicked.name == "BJTCharacteristics")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "BJT Characteristics";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "A setup equipped with three configurations of BJT operation - CE, CB, CC. Depending upon the user’s choice respective graphs of all the configurations will be displayed. Users can dynamically change the input values to observe the changes in the respective outputs.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/bjt");
            // userChoice = "alu";
        }

        else if(buttonClicked.name == "Charger")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Design of a Charger";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The experiment includes simulation of a simple 5V power generation circuit, which converts input AC 220V signal to 5V DC. The circuit includes LM7805IC and Full Wave Rectifier for voltage regulation and rectification respectively. Parameters of components (capacitor, resistor, diodes) can be altered as per the requirement of the user for the desired output.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/charger");
            // userChoice = "logicgates";
        }

        else if(buttonClicked.name == "PhotoElectric")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Photoelectric Effect";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "A simulation demonstrating the working of the photoelectric effect. This will let the user verify the value of Planck’s Constant by changing the input wavelengths and varying the threshold potential. The final answer will be the average of all the observations.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/photoelectric");
            // userChoice = "rlc";
        }

        else if(buttonClicked.name == "OpAmp")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "OpAmp Integrator and Differentiator";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The experiment includes an op-amp based implementation of integrator and differentiator circuit. The user can choose from a variety of input pulses and observe the graph. There will be an option to vary the device parameters - resistance, capacitor - to obtain desired output values.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Electronics/opamp");
            // userChoice = "monostable";
        }

        ///Mechanical
        else if(buttonClicked.name == "fault_detection")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Fault Detection Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Model-Based Fault Detection (MBFD) is a technique that identifies Faultthrough-out the rotor system by using different mathematical fault models. The objective of this experiment is to detect the fault in a gear by using vibration signature analysis.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/fault_detection");
        }

        else if(buttonClicked.name == "oil_whirling")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Oil Whirling Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Oil whirl manifests itself as a vibration of less than one-half rotational speed. It is caused by a lightly loaded bearing riding upon its high-pressure wedge and going over the top and around. The user can change the rpm of the machine and observe the graph of acceleration vs frequency. Hence finding out a particular bolt which when loosened the vibration level is minimum.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/oil_whirling");
        }

        else if(buttonClicked.name == "power_press")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Power Press Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Using this machine, a metal piece can be modified by hitting it with a top die. The metalworking functions will include shearing, punching, forming, and assembling of metal by means of tools or dies attached to slides or rams.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/power_press");
        }

        else if(buttonClicked.name == "vaccum_forming")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Vacuum Forming Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The machine provides a platform to apply vacuum on heated plastic sheets, to convert them into permanent objects. Users can choose from an array of varied plastic strength of materials and the amount of vacuum pressure applied to it. A sheet of plastic is heated to a forming temperature, stretched onto a single-surface mold, and forced against the mold by a vacuum.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/vaccum_forming");
        }

        else if(buttonClicked.name == "surface_grinding")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Surface Grinding Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Surface Grinding is a process to produce smooth surfaces on a metal piece. This machine will involve a structure enabling the user to adjust the amount of pressure being applied on the metal surface. There will be a choice for the ferromagnetic material (held by magnetic chuck) and non-ferromagnetic material (held by vacuum).";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/surfacegrinding");
        }

        else if(buttonClicked.name == "cantilever")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Modal Analysis of Cantilever";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "This experiment involves the determination of natural vibration patterns of a cantilever beam. Intrinsic parameters of the beam can be chosen by the user. On the basis of these parameters, the beam will produce different kinds of vibrations when a hammer is hit.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/cantilever");
        }

        else if(buttonClicked.name == "hydraulic_press")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Hydraulic Press Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Since this machine works on the principle of Pascal’s Law, the user can choose the type of liquid in the pumps, hence modifying pressure. The pressure produced at the output end will compress the target object, deforming it. There will be a choice for different target objects.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/hydraulicpress");
        }

        else if(buttonClicked.name == "shaping_machine")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Shaping Machine";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "It used to produce Horizontal, Vertical, or Inclined flat surfaces by means of straight-line reciprocating single-point cutting tools similar to those which are used in lathe machine. The machine will hold the Single point cutting tool in ram and the workpiece is fixed over the table. The ram holding the tool will reciprocate over the workpiece and metal will be cut during the forward stroke. The feed is given at the end of the cutting stroke.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Mechanical/shapingmachine");
        }


        ///Chemical
        else if(buttonClicked.name == "adsorption")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Gas Adsorption Experiment";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "This experiment deals with the mass transfer operation, gas absorption, in which a soluble gas is absorbed from its mixture with an inert gas by means of a liquid in which the solute gas is more or less soluble. User can modify the parameters of column(conc. Of NaOH, flow rate of liquid and gaseous phase) and bubble pot (conc. Of NaOH)";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/adsorption");
        }

        else if(buttonClicked.name == "calorimetry")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Calorimetry Experiment";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Calorimetry involves measurements of enthalpy changes in various processes like mixing, dilution, dissolution, crystallization, adsorption or in a chemical reaction. In addition, it is used for the determination of heat capacities. In the experiment, for different values of a mole fraction of methanol, changes in the output can be observed. The current in the heating coil can be handled manually.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/calorimetry");
        }

        else if(buttonClicked.name == "tyndall")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Tyndall Effect in Colloids";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The experiment includes a demonstration of scattering phenomena in colloids. A selection can be made from a wide array of colloidal particles (aerosol, aerogel, etc.) There will be an option to increase the particle size dynamically and hence observe the produced scattering effect.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/tyndalleffect");
        }

        else if(buttonClicked.name == "polymerization")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Polymerization Experiment";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Polymerization of styrene results in volumetric shrinkage and exothermic heat. In this experiment, parameters like Volume of Reactor, Initiator Concentration, Temperature of Initiator and Temperature of Collant can be modified. Upon the start of the timer, the reaction will start and the output parameters can be observed dynamically.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/polymerization");
        }

        else if(buttonClicked.name == "viscosity")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Determination of Viscosity";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "The viscosity of liquids can be determined by examining the rate of flow of liquid. The experimental setup includes an Ostwald Viscometer, a timer, and a bunch of organic solvents. Users will have to operate the timer to determine the number of drops falling out of viscometer in constant time duration. After some calculations, the viscosity can be determined.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/viscosity");
        }

        else if(buttonClicked.name == "electrophoresis")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "Gel Electrophoresis";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "Electrophoresis is an electrokinetic phenomenon. It involves movement of charged dispersed particles with respect to the dispersion medium under the influence of a spatially uniform electric field. Gel electrophoresis technique is often used in biotechnology for the separation of DNA. User can choose from a range of DNAs, the base gel, the electrode potential, for desired separation result.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/gel");
        }

        else if(buttonClicked.name == "dna_extraction")
        {
            // Transform experimentNameObject = infoCanvas.transform.Find("ExperimentName");
            infoCanvas.transform.Find("ExperimentName").GetComponent<TextMeshProUGUI>().text = "DNA Extraction";
            infoCanvas.transform.Find("Description").GetComponent<TextMeshProUGUI>().text = "In labs, it is possible to extract the DNA of some fruits and observe them under a microscope. By a combination of appropriate chemicals, cell wall, cytoplasm, and other unnecessary cellular components DNA can be extracted. The experiment provides an array of DNAs and appropriate enzymes to choose from, hence enabling simulation of DNA extraction.";
            infoCanvas.transform.Find("Icon").GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Icons/Chemical/dnaextraction");
        }
         
    }

    public void closeInfoCanvas()
    {
        infoCanvas.SetActive(false);
    }

    public void chooseModelButton()
    {
        infoCanvas.SetActive(false);

        switch (userChoice)
        {
            case "ALU": ALUcnt += 1;
                        break;
            case "RLC": RLCcnt += 1;
                        break;
            case "MonostableOscillator": MonostableOscillatorcnt += 1;
                        break;
            case "LogicGates": LogicGatescnt += 1;
                        break;
            case "BJTCharacteristics": bjtcnt += 1;
                        break;
            case "Charger": chargercnt += 1;
                        break;
            case "PhotoElectric": photocnt += 1;
                        break;
            case "OpAmp": opampcnt += 1;
                        break;
            
            case "fault_detection": faultdetectioncnt += 1;
                        break;
            case "oil_whirling": oilwhirlingcnt += 1;
                        break;
            case "power_press": powerpresscnt += 1;
                        break;
            case "vaccum_forming": vaccumformingcnt += 1;
                        break;
            case "surface_grinding": grindingcnt += 1;
                        break;
            case "cantilever": cantilevercnt += 1;
                        break;
            case "hydraulic_press": hydrauliccnt += 1;
                        break;
            case "shaping_machine": shapingcnt += 1;
                        break;
            
            case "adsorption": adsorptioncnt += 1;
                        break;
            case "calorimetry": calorimetrycnt += 1;
                        break;
            case "tyndall": tyndallcnt += 1;
                        break;
            case "polymerization": polymerizationcnt += 1;
                        break;
            case "viscosity": viscositycnt += 1;
                        break;
            case "electrophoresis": gelcnt += 1;
                        break;
            case "dna_extraction": dnacnt += 1;
                        break;

            default: break;
        }

        ececnt = ALUcnt+RLCcnt+MonostableOscillatorcnt+LogicGatescnt+bjtcnt+chargercnt+photocnt+opampcnt;
        mechcnt = faultdetectioncnt+oilwhirlingcnt+powerpresscnt+vaccumformingcnt+shapingcnt+hydrauliccnt+cantilevercnt+grindingcnt;
        chemcnt = adsorptioncnt+calorimetrycnt+tyndallcnt+polymerizationcnt+dnacnt+gelcnt+viscositycnt;

        totalcnt = ececnt+mechcnt+chemcnt;

        Dictionary<string, float> ece = new Dictionary<string, float>()
                                            {
                                                {"ALU", ALUcnt},
                                                {"RLC", RLCcnt},
                                                {"MonostableOscillator", MonostableOscillatorcnt},
                                                {"LogicGates", LogicGatescnt},
                                                {"BJT Characteristics", bjtcnt},
                                                {"Charger", chargercnt},
                                                {"Photoelectric Effect", photocnt},
                                                {"OpAmp", opampcnt}
                                            };
        
        Dictionary<string, float> mech = new Dictionary<string, float>()
                                            {
                                                {"Fault Detection",faultdetectioncnt},
                                                {"Oil Whirling",oilwhirlingcnt},
                                                {"Power Press", powerpresscnt},
                                                {"Vaccum Forming", vaccumformingcnt},
                                                {"Shaping Machine",shapingcnt},
                                                {"Hydraulic Press",hydrauliccnt},
                                                {"Cantilever", cantilevercnt},
                                                {"Surface Grinding", grindingcnt}
                                            };

        Dictionary<string, float> chem = new Dictionary<string, float>()
                                            {
                                                {"Adsorption",adsorptioncnt},
                                                {"Calorimetry",calorimetrycnt},
                                                {"Tyndall Effect", tyndallcnt},
                                                {"Polymerization", polymerizationcnt},
                                                {"DNA Extraction",dnacnt},
                                                {"Gel Electrophoresis", gelcnt},
                                                {"Viscosity Determination", viscositycnt}
                                            };  

        var sortedece = from entryece in ece orderby entryece.Value ascending select entryece;
        var sortedmech = from entrymech in mech orderby entrymech.Value ascending select entrymech;
        var sortedchem = from entrychem in chem orderby entrychem.Value ascending select entrychem;

        eceLeaderboard.transform.Find("First").GetComponent<TextMeshProUGUI>().text = sortedece.ElementAt(eceMax-1).Key + "  " + (percentage(sortedece.ElementAt(eceMax-1).Value,ececnt)).ToString() + "%";
        eceLeaderboard.transform.Find("Second").GetComponent<TextMeshProUGUI>().text = sortedece.ElementAt(eceMax-2).Key + "  " + (percentage(sortedece.ElementAt(eceMax-2).Value,ececnt)).ToString() + "%";
        eceLeaderboard.transform.Find("Third").GetComponent<TextMeshProUGUI>().text = sortedece.ElementAt(eceMax-3).Key + "  " + (percentage(sortedece.ElementAt(eceMax-3).Value,ececnt)).ToString() + "%";

        mechLeaderboard.transform.Find("First").GetComponent<TextMeshProUGUI>().text = sortedmech.ElementAt(mechMax-1).Key + "  " + (percentage(sortedmech.ElementAt(mechMax-1).Value,mechcnt)).ToString() + "%";
        mechLeaderboard.transform.Find("Second").GetComponent<TextMeshProUGUI>().text = sortedmech.ElementAt(mechMax-2).Key + "  " + (percentage(sortedmech.ElementAt(mechMax-2).Value,mechcnt)).ToString() + "%";
        mechLeaderboard.transform.Find("Third").GetComponent<TextMeshProUGUI>().text = sortedmech.ElementAt(mechMax-3).Key + "  " + (percentage(sortedmech.ElementAt(mechMax-3).Value,mechcnt)).ToString() + "%";

        chemLeaderboard.transform.Find("First").GetComponent<TextMeshProUGUI>().text = sortedchem.ElementAt(chemMax-1).Key + "  " + (percentage(sortedchem.ElementAt(chemMax-1).Value,chemcnt)).ToString() + "%";
        chemLeaderboard.transform.Find("Second").GetComponent<TextMeshProUGUI>().text = sortedchem.ElementAt(chemMax-2).Key + "  " + (percentage(sortedchem.ElementAt(chemMax-2).Value,chemcnt)).ToString() + "%";
        chemLeaderboard.transform.Find("Third").GetComponent<TextMeshProUGUI>().text = sortedchem.ElementAt(chemMax-3).Key + "  " + (percentage(sortedchem.ElementAt(chemMax-3).Value,chemcnt)).ToString() + "%";
        
        Dictionary<string, float> main = new Dictionary<string, float>();
        int n = 0;
        foreach(KeyValuePair<string, float> element in sortedece)
        {
            main.Add(element.Key,element.Value);
            n++;
        }
        foreach(KeyValuePair<string, float> element in sortedchem)
        {
            main.Add(element.Key,element.Value);
            n++;
        }
        foreach(KeyValuePair<string, float> element in sortedmech)
        {
            main.Add(element.Key,element.Value);
            n++;
        }

        var sortedmain = from entrymain in main orderby entrymain.Value ascending select entrymain;

        mainLeaderboard.transform.Find("First").GetComponent<TextMeshProUGUI>().text = sortedmain.ElementAt(n-1).Key + "  " + (percentage(sortedmain.ElementAt(n-1).Value,totalcnt)).ToString() + "%";
        mainLeaderboard.transform.Find("Second").GetComponent<TextMeshProUGUI>().text = sortedmain.ElementAt(n-2).Key + "  " + (percentage(sortedmain.ElementAt(n-2).Value,totalcnt)).ToString() + "%";
        mainLeaderboard.transform.Find("Third").GetComponent<TextMeshProUGUI>().text = sortedmain.ElementAt(n-3).Key + "  " + (percentage(sortedmain.ElementAt(n-3).Value,totalcnt)).ToString() + "%";
        
    }

    public float percentage(float a, float t)
    {
        a = (a*100)/t;
        return ((Mathf.Round(a*100f))/100f);
    }
}
