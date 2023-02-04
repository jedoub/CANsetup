# CANsetup
Configures Kvaser CAN devices and opens the associated channels.
Remember this solution is to demonstrate how to use the CANsetup Class and EnterSubnet Class.
The "main" Form1.cs is a straw man for your eventual mainForm. 
It basically just demonstrates how to call the CANsetup Class and reads one message per subnet using CANlib methods.

Follow the directions found in the CANsetup.cs source file to integrate the SETUP and other associated Forms into another CAN project.

* Tips for reusing SW by adding existing Classes into a Project/Solution.
* A Class is simply a chuck of code that does a particular job.
* I'll mention two alternatives for how to do this and show a third example.
* 
* Objects are created from Classes. The Windows Form itself is a Class, and when you run your program, you are creating Objects.
* 
* Now, let's get started.
* Install the CANLIB SDK found on the Kvaser Website. I have version 5.27 of the Kvaser SDK.
* 
* In the Documentation Folder of the SDK the user will find the CANlib API methods for dotNet and C#.
* There are hyper-links in the SDK to rather trivial examples, and several are pure C-code. 
* The examples, demonstrate how the methods in the library are used.
* 
* I hope this code will help jump start your CAN application.
* 
* What you won't find in the code are grandiose examples of polymorphism and inheritance constructs touted by C# aficionados.
* 
* Create a Windows Forms Project for demonstration purposes in Visual Studio.
* 
* Install the Kvaser Driver and add the necessary REFERENCES to DLLs used by the APP.
* The VS Project's Solution Explorer Tab contains the References container object.
* Add canlibCLSNET & System.Management by navigating to their source.
* Speaking of DLLs, you can accomplish code reuse by making this APP a DLL. [In Visual Studio begin by selecting a C++ Project type DLL].
* 
* Know/Find the location of the CANsetup project source, or Clone a solution from the GIT repository for your use.
* 
* Right-Click on the project in Solution explorer
* Select Add Existing Item
* For This particular example, Browse to the xxxForm.cs file in another project, and Single-click to select the file
* 
* Only select ONE of the xxxForm.cs files to add to the Project at a time. 
* If you select multiple .cs files for different WinForms, Visual Studio doesn't add them into the solution correctly. Repeat as necessary.
* Now that the File is selected in the browse window, mouse over and click the down-arrow button to the right of Add and select Add as Link.
* Then select the CANsetupForm.designer.cs, (CANsetupForm.resx will be generated), and add as Link. 
* Code re-use can also be accomplished by copying the source files and then adding the files to the Solution Explorer. The same rules apply.
* 
* You now have 2 of the 4 source files necessary for the CANsetup Form referenced by two projects.
* 
* I also made an additional Subnet form that pops up a text box allowing the user to associate a name with a particular CAN subnet. 
* I typically use the names like BB1, ESN, BB2, PWT or ISN. This feature provides naming flexibility like other generic CAN tools.
* Separately LINK these source files into your new project as well:
* EnterSubnetForm.cs, EnterSubnetForm.Designer.cs, (EnterSubnetForm.resx will be generated)
* 
* The source files for the CANsetup utilize the same namespace so a single using reference is all that is necessary in the Form1.cs of your project. (i.e. using CANsetup;)
* 
* To work with CANsetup Form in your project the developer also needs to instantiate the class. This is added using the new keyword as shown below.
* CANsetupForm idNselcCAN_HW = new CANsetupForm();
* 
* To automate the launch of a Form contained in a Class I use the C# ShowDialog() function.
* 
* Also, note the use of private and public data types. This is a simplistic way to exchange data between different classes contained in different files of a project.
* 
* Another, less manageable way, to reuse this code in another project is to simply copy the source files into the project's folder and add the files into the VS Solution Explorer. 
