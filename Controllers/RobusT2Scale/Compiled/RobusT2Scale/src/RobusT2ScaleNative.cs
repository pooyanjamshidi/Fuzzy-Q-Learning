/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Tue Dec 23 22:31:25 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:RobusT2Scale,RobusT2Scale,0.0,private"
* "-T" "link:lib" "-d"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\Controllers\RobusT2Scale\RobusT2Scale\
* src" "-w" "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{RobusT2Scale:C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\Controllers\RobusT2
* Scale\RobusT2Scalesg.m}" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\Controllers\RobusT2Scale\robust2scales
* g.fis" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\Controllers\RobusT2Scale\scaledata.m" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace RobusT2ScaleNative
{

  /// <summary>
  /// The RobusT2Scale class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\Controllers\RobusT2Scale\RobusT2Sca
  /// lesg.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class RobusT2Scale : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static RobusT2Scale()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "RobusT2Scale.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the RobusT2Scale class.
    /// </summary>
    public RobusT2Scale()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~RobusT2Scale()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object RobusT2Scalesg()
    {
      return mcr.EvaluateFunction("RobusT2Scalesg", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object RobusT2Scalesg(Object x1)
    {
      return mcr.EvaluateFunction("RobusT2Scalesg", x1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <param name="x2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object RobusT2Scalesg(Object x1, Object x2)
    {
      return mcr.EvaluateFunction("RobusT2Scalesg", x1, x2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] RobusT2Scalesg(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "RobusT2Scalesg", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] RobusT2Scalesg(int numArgsOut, Object x1)
    {
      return mcr.EvaluateFunction(numArgsOut, "RobusT2Scalesg", x1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the RobusT2Scalesg MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <param name="x2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] RobusT2Scalesg(int numArgsOut, Object x1, Object x2)
    {
      return mcr.EvaluateFunction(numArgsOut, "RobusT2Scalesg", x1, x2);
    }


    /// <summary>
    /// Provides an interface for the RobusT2Scalesg function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// ------------------------------------------------------------------------
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// The scripts implements the sugeno fuzzy controller and
    /// produce the output which is the scaling action for horizontal elasticity.
    /// x1: workload (should be normalized in [0 100])
    /// x2: response time (should be normalized in [0 100])
    /// scalingaction: [-2 +2], this determines the change in the number of resources 
    /// ------------------------------------------------------------------------
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("RobusT2Scalesg", 2, 1, 0)]
    protected void RobusT2Scalesg(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("RobusT2Scalesg", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
