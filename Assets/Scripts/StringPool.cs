using UnityEngine;
using System.Collections;

public class StringPool : MonoBehaviour
{
	public static string[][] AFacts = new string[][] { new string[] { "How did you get here?", "-", "-" },
		new string[] {"The battery is the component that is used to supply power to the whole laptop.",
			"The battery can be recharged with the port at the side of the laptop.",
			"Battery life does deteriorate over time and through extended use unless fully discharged when used.",
			"Because battery life degrades with time, batteries should be replaced approximately every three years."
		},

		new string[] {
			"A CD Drive is a device a computer uses to read and write data that is encoded digitally on a compact disc.",
			"The CD Drive is in a modular slot on the laptop and can easily be swapped out for another disk drive.",
			"The CD Drive uses its read-head to interpret small marks on the surface of the disc binary code, which is interpreted by the computer.",
			"A CD-ROM, or “Compact Disc—Read Only Media,” stores information through a series of tiny pits cut into the surface of the disc with a laser.",
			"A CD-R, or “Compact Disc—Recordable,” rewrites information by coloring a thin layer of dye on the disc, creating a series of marked and unmarked spaces.",
			"A CD-RW, or “Compact-Disc—Re-Writable,” uses a laser to melt small marks into the disc."
		},

		new string[] {"The cooling fan and heat sink are used to cool the CPU (Central Processing Unit), which can easily overheat during strenuous use.",
			"Improper diffusion of heat from the CPU may damage its components, cause loss of data, and reduce the CPU's lifespan. ",
			"The fan is continuously pulling in cool air from the outside to ventilate the inside.",
			"There is a copper or aluminum heat sink attached to the cooling fan to attract the heat from the components, allowing for heat to be drawn away.",
			"The specifications of the fan and heat sink are based on compatibility with the CPU and how much they are expected to perform.",
			"Overheating can be caused by a buildup of dirt inside the laptop’s fans and vents."
		},                                   

		new string[] {
			"The Hard Drive is a nonvolatile memory hardware that permanently stores and retrieves information without the need for a constant power source.",
			"Hard Disks store information by changing the magnetization of small sections of the disk, which are then interpreted as 0’s or 1’s.",
			"All personal computers have a Hard Drive and use it to store files for the operating system and software that runs on the computer.",
			"Flashing is the process of wiping data off of a hard disk.",
			"The Hard Drive is a fragile component which can be damaged if dropped.",
			"The Hard Drive has an operating temperature of 0 to 60 º C and a non-operating temperature of 40 to 65 º C."
		},

		new string[] {"RAM can access any piece of data in the same amount of time no matter the physical location on the component.",
			"A constant source of power is needed to keep the memory in the RAM accessible. ",
			"If a program is using too much RAM, the least-used parts of the program are moved to the Hard Drive to free up space, slowing the process.",
			"There are two widely used types of RAM: SRAM (Static RAM) and DRAM (Dynamic RAM). SRAM is generally faster and requires less power than DRAM."
		},

		new string[] {
			"The Wi-Fi Adapter sends and receives data on a wireless network. ",
			"There are different types of wireless adapters meant for desktops or various sizes of laptops.",
			"The rate of data transfer is measured in Megabits per second (Mbps), and the operating frequency in Gigahertz (GHz).",
			"This Wi-Fi Adapter is dual band, able to use the 2.4 GHz and 5.0 GHz bandwidths to stream data.",
			"The Wi-Fi Adapter has an operating temperature of 0º to +80°C; and a non-operating temperature 40º to +85º C."
		}
	};

	public static string[][] RFacts = new string[][] { new string[] { "How did you get here?", "-", "-" },
		new string[] { "1. Locate the battery in the back middle of the laptop.", 
			"2. Slide the tabs on left and right side of battery.",
			"3. As the tabs are moved out of position, lift the battery out.",
			"4. Insert a new battery ensuring that the tabs lock it into place."
		},

		new string[] {  "1. Locate CD Drive in the lower-left section of the laptop.",
			"2. Press the button located in the back of the CD Drive, facing outward.",
			"3. Slide the old CD Drive out, and insert the new CD Drive into the empty slot.",
			"4. Press the button again when the new CD Drive is firmly in place."
		},

		new string[] { "1. Locate the fan in right-center section of the laptop.",
			"2. Remove wire connecting fan to mother board.\n- Remove the four pin patch chord.", 
			"3. Remove the five screws attaching the fan to the laptop.",
			"4. Lift the near side of the assembly and pull up and towards the near side.",
			"5. Apply new thermal paste to the underside of the heat sink.",
			"6. Insert the new fan assembly.",
			"7. Replace the five screws and the wire."
		},

		new string[] { "1. Locate Hard Drive in bottom right section of the laptop.",
			"2. Slide the old Hard Drive out of its slot.",
			"3. Insert a new Hard Drive into the slot, and press it firmly into place."
		},

		new string[] { "1. Locate the RAM at the center-bottom section of the laptop.",
			"2. Press down and out on the tabs directly to the left and right of the RAM card.",
			"3. Carefully slide RAM card out horizontally.",
			"4. Firmly push the new RAM card into place until it stops.",
			"5. Press down on the RAM card until the tabs click."
		},

		new string[] { "1. Locate the Wi-Fi Adapter in the upper left of the laptop.",
			"2. Unplug the white and black wires.",
			"3. Remove the screw on the bottom right of the Wi-Fi Adapter.",
			"4. Lift and pull the Wi-Fi Adapter up and at an angle.",
			"5. Firmly push the new Wi-Fi Adapter into place until it stops.",
			"6. Tighten the screw.",
			"7. Plug the white cable to the right side of the Wi-Fi Adapter and the black on the left."
		}
	};

	public static string[,,] TFacts = {{{ "How did you get here?", "-", "-","" },
			{ "1. The main purpose of the battery is to", "2. About how often should batteries be replaced?", "3. The battery used in this laptop stores energy using", "4. True or False? Battery life can deteriorate over time."},
			{ "1. What is the main purpose of the CD Drive?", "2. A CD-ROM stores information through a series of what?", "3. CDs and other storage media hold data using this numeral system", "4. True or False? The CD Drive cannot be swapped out with other kinds of disk drives." },//CD
			{ "1. What do the cooling fan and heat sink primarily cool?", "2. Improper diffusion of heat can cause what?", "3. The heat sink attached to the fan is made of", "4. True or False? Not all fans are compatible with any laptop" },//fan
			{ "1. What is the main purpose of the Hard Drive in a laptop?", "2. What is the operating temperature of the Hard Drive?", "3. What is the component called which stores and retrieves data from the Hard Disk?", "4.	True or false: The Hard Drive is durable and sturdy." },//HD
			{ "1. What is the main purpose of RAM?", "2. Why is it necessary to upgrade the RAM of the computer?", "3. Which of these is necessary for the continuous storage of information in RAM?", "4. True or False? There are two different types of RAM" },//RAM
			{ "1. What is the main purpose of the Wi-Fi Adaptor?", "2. What does “dual-band” mean?", "3. The Wi-Fi Adaptor’s standard transfer rate is measured in", "4. True or false? The Wi-Fi Adaptor has a standard rate of transfer of Gigahertz" }//Wi-FI
		},
		{{ "How did you get here?", "-", "-","" },
			{ "a. Act as backup RAM", "a. Once a year", "a. Nickel Zinc", "a. True" },
			{ "a. Read and/or write data on disks", "a. Tiny pits", "a. Tertiary", "a. True" },
			{ "a. Battery", "a. Damaged components", "a. Copper", "a. True" },
			{ "a. To send and receive data from external sources", "a. 0-100ºC",  "a. Read Needle", "a. True" },
			{ "a. To quickly access information for open applications", "a. RAM effects the computer's operating speed", "a. Virtual Memory", "a. True" },
			{ "a. Serve as an in-between for the Hard Drive and the RAM", "a. The Wi-Fi Adaptor can both store and retrieve data", "a. Gigaflops", "a. True" }
		},
		{{ "How did you get here?", "-", "-","" },
			{ "b. Supply power to the whole laptop", "b. Every other month" , "b. Lithium Titanate", "b. False" },
			{ "b. Provide temporary, quick access to data", "b. Different discs", "b. Base Ten", "b. False" },
			{ "b. RAM", "b. Reduced lifespan", "b. Aluminium", "b. False" },
			{ "b. To provide stable memory to store large amounts of data", "b. 15-30ºC", "b. Stylus", "b. False" },
			{ "b. To store large chunks of data", "b. The computer will be unable to connect to the internet", "b. Multiplexing", "b. False" },
			{ "b. Regulate power usage for laptop components ", "b. The adaptor is able to use the 2.4 GHz and 5.0 GHZ bandwiths", "b. Gigahertz", "b. False" }
		},
		{{ "How did you get here?", "-", "-","" },
			{ "c. Connect the laptop to the internet", "c. Every 5 years", "c. Lithium Ion", "" },
			{ "c. Burn DVDs", "c. Multiple memory cards", "c. Binary", "" },
			{ "c. CPU", "c. Loss of data", "c. Zinc", "" },
			{ "c. To flash laptop memory", "c. 0-60ºC", "c. Read/Write Head", "" },
			{ "c. To connect the laptop to the internet", "c. The computer will overheat", "c. Controlled magnetic field", "" },
			{ "c. Enable Ethernet connections", "c.	The adapter can connect to more than one wireless signal at one time", "c. Megabits", "" }
		},
		{{ "How did you get here?", "-", "-","" },
			{ "d. To read disks", "d. Every 2-3 years", "d. Sodium Sulfur", "" },
			{ "d. Provide large, permanent data storage", "d. Ink dots", "d. Hexadecimal", "" },
			{ "d. Wi-Fi Adaptor", "d. All of the above", "d. Steel", "" },
			{ "d. To store temporarily store memory for quick retrieval", "d. 30-60ºC", "d. Micro-Line", "" },
			{ "d. To provide a means of displaying debug information", "d. The Hard Drive will be over-extended", "d. Constant power source", "" },
			{ "d. To send and receive data over a wireless network ", "d. The adapter contains a redundant wireless receiver", "d.	Gigabytes", "" }
		}
	};

	public static int[,] TAnswers = { { 0, 0, 0, 0 },
		{ 2, 4, 3, 1 },
		{ 1, 1, 3, 2 },
		{ 3, 4, 1, 1 },
		{ 2, 3, 3, 2 },
		{ 1, 1, 4, 1 },
		{ 4, 2, 3, 1 }
	};

	public static string Screw = "1.  Ensure that the laptop is powered off.\n2.  Turn the laptop over to its backside.\n3.  Slide the tabs on left and right side of battery.\n4.  As the tabs are moved out of position, lift battery and remove outward.\na.  If only battery replacement is required, stop here and insert a new battery.\n5.  Turn the laptop to its front, and hold the power button for three seconds.\n6.  Close the laptop, and turn it over to its backside.\n7.  Remove the nine screws on top of the back cover, located on the picture below.\na.  Place the nine screws in a screw cup.\n8.  Remove the back cover, exposing the laptop’s components.  Orient so that the battery compartment is on the far side.\n9.  Before touching any components, ground yourself by touching a metallic object or wearing an anti-static bracelet.";
}