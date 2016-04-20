MATLAB Builder NE (.NET Component)


1. Prerequisites for Deployment 

. Verify the MATLAB Compiler Runtime (MCR) is installed and ensure you    
  have installed version 8.1 (R2013a).   

. If the MCR is not installed, do the following:
  (1) enter
  
      >>mcrinstaller
      
      at MATLAB prompt. The MCRINSTALLER command displays the 
      location of the MCR Installer.

  (2) run the MCR Installer.

Or download the Windows 64-bit version of the MCR for R2013a 
from the MathWorks Web site by navigating to

   http://www.mathworks.com/products/compiler/mcr/index.html
   

For more information about the MCR and the MCR Installer, see 
Distribution to End Users in the MATLAB Compiler documentation  
in the MathWorks Documentation Center.  
      
NOTE: You will need administrator rights to run MCRInstaller.

2. Files to Deploy and Package

-RobusT2Scale.dll
   -contains the generated component using MWArray API. 
-RobusT2ScaleNative.dll
   -contains the generated component using native API.
-This readme file

. If the target machine does not have the version 8.1 of the MCR installed, and the end 
  users are unable to download the MCR using the above link, include MCRInstaller.exe.



Auto-generated Documentation Templates:

MWArray.xml - This file contains the code comments for the MWArray data conversion 
              classes and their methods. This file can be found in either the component 
              distrib directory or in
              <mcr_root>*\toolbox\dotnetbuilder\bin\win64\v2.0

RobusT2Scale_overview.html - HTML overview documentation file for the generated 
                             component. It contains the requirements for accessing the 
                             component and for generating arguments using the MWArray 
                             class hierarchy.

RobusT2Scale.xml - This file contains the code comments for the RobusT2Scale component 
                             classes and methods. Using a third party documentation tool, 
                             this file can be combined with either or both of the 
                             previous files to generate online documentation for the 
                             RobusT2Scale component.

                 


3. Resources

To learn more about:               See:
===================================================================
MWArray classes                    <matlab_root>*\help\toolbox\
                                   dotnetbuilder\MWArrayAPI\
                                   MWArrayAPI.chm  
Examples of .NET Web Applications  Web Deployment in the MATLAB   
                                   Builder NE documentation in the  
                                   MathWorks Documentation Center


4. Definitions

For information on deployment terminology, go to 
http://www.mathworks.com/help. Select MATLAB Compiler >   
Getting Started > About Application Deployment > 
Application Deployment Terms in the MathWorks Documentation 
Center.



* NOTE: <mcr_root> is the directory where MCR is installed on the target machine.
        <matlab_root> is the directory where MATLAB is installed on the target machine.

