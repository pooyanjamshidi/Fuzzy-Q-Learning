/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Wed Jan 14 15:42:48 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:Learning,FQL,0.0,private" "-T" "link:lib"
* "-d" "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\Compiled\Learning\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{FQL:C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\fqlearn.m,C:\Users\pooya
* njam\Source\Repos\pooyan-amir\RL-Q\FQL\fuzzy_action_calculator.m,C:\Users\pooyanjam\Sour
* ce\Repos\pooyan-amir\RL-Q\FQL\init_knowledge_base.m,C:\Users\pooyanjam\Source\Repos\pooy
* an-amir\RL-Q\FQL\initq.m,C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\update_kno
* wledge_base.m}" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\approximate_q_function.m" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\error_signal_calculator.m" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\fuzzy_action_selector.m" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\reward_calculator.m" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\update_fis.m" "-a"
* "C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\value_function_calculator.m" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Learning
{

  /// <summary>
  /// The FQL class provides a CLS compliant, MWArray interface to the MATLAB functions
  /// contained in the files:
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\fqlearn.m
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\fuzzy_action_calculator.m
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\init_knowledge_base.m
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\initq.m
  /// <newpara></newpara>
  /// C:\Users\pooyanjam\Source\Repos\pooyan-amir\RL-Q\FQL\update_knowledge_base.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class FQL : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static FQL()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "Learning.ctf";

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
    /// Constructs a new instance of the FQL class.
    /// </summary>
    public FQL()
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
    ~FQL()
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
    /// Provides a single output, 0-input MWArrayinterface to the fqlearn MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fqlearn()
    {
      return mcr.EvaluateFunction("fqlearn", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the fqlearn MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q_in1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fqlearn(MWArray Q_in1)
    {
      return mcr.EvaluateFunction("fqlearn", Q_in1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the fqlearn MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fqlearn(MWArray Q_in1, MWArray current_state)
    {
      return mcr.EvaluateFunction("fqlearn", Q_in1, current_state);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the fqlearn MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <param name="next_state">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fqlearn(MWArray Q_in1, MWArray current_state, MWArray next_state)
    {
      return mcr.EvaluateFunction("fqlearn", Q_in1, current_state, next_state);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the fqlearn MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <param name="next_state">Input argument #3</param>
    /// <param name="ais">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fqlearn(MWArray Q_in1, MWArray current_state, MWArray next_state, 
                     MWArray ais)
    {
      return mcr.EvaluateFunction("fqlearn", Q_in1, current_state, next_state, ais);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the fqlearn MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fqlearn(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fqlearn", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the fqlearn MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q_in1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fqlearn(int numArgsOut, MWArray Q_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "fqlearn", Q_in1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the fqlearn MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fqlearn(int numArgsOut, MWArray Q_in1, MWArray current_state)
    {
      return mcr.EvaluateFunction(numArgsOut, "fqlearn", Q_in1, current_state);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the fqlearn MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <param name="next_state">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fqlearn(int numArgsOut, MWArray Q_in1, MWArray current_state, 
                       MWArray next_state)
    {
      return mcr.EvaluateFunction(numArgsOut, "fqlearn", Q_in1, current_state, next_state);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the fqlearn MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q_in1">Input argument #1</param>
    /// <param name="current_state">Input argument #2</param>
    /// <param name="next_state">Input argument #3</param>
    /// <param name="ais">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fqlearn(int numArgsOut, MWArray Q_in1, MWArray current_state, 
                       MWArray next_state, MWArray ais)
    {
      return mcr.EvaluateFunction(numArgsOut, "fqlearn", Q_in1, current_state, next_state, ais);
    }


    /// <summary>
    /// Provides an interface for the fqlearn function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function implements Fuzzy Q-Learning
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void fqlearn(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("fqlearn", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fuzzy_action_calculator()
    {
      return mcr.EvaluateFunction("fuzzy_action_calculator", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fuzzy_action_calculator(MWArray Q)
    {
      return mcr.EvaluateFunction("fuzzy_action_calculator", Q);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fuzzy_action_calculator(MWArray Q, MWArray input)
    {
      return mcr.EvaluateFunction("fuzzy_action_calculator", Q, input);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <param name="epsilon">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray fuzzy_action_calculator(MWArray Q, MWArray input, MWArray epsilon)
    {
      return mcr.EvaluateFunction("fuzzy_action_calculator", Q, input, epsilon);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fuzzy_action_calculator(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fuzzy_action_calculator", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fuzzy_action_calculator(int numArgsOut, MWArray Q)
    {
      return mcr.EvaluateFunction(numArgsOut, "fuzzy_action_calculator", Q);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fuzzy_action_calculator(int numArgsOut, MWArray Q, MWArray input)
    {
      return mcr.EvaluateFunction(numArgsOut, "fuzzy_action_calculator", Q, input);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the fuzzy_action_calculator
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <param name="epsilon">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] fuzzy_action_calculator(int numArgsOut, MWArray Q, MWArray input, 
                                       MWArray epsilon)
    {
      return mcr.EvaluateFunction(numArgsOut, "fuzzy_action_calculator", Q, input, epsilon);
    }


    /// <summary>
    /// Provides an interface for the fuzzy_action_calculator function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function returns the global action inferred by the FLC. This should be
    /// enacted to the enviornment
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void fuzzy_action_calculator(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                              argsIn)
    {
      mcr.EvaluateFunction("fuzzy_action_calculator", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the init_knowledge_base
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// initializing the rule base and creating a folder for archiving them
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    ///
    public void init_knowledge_base()
    {
      mcr.EvaluateFunction(0, "init_knowledge_base", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the init_knowledge_base MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// initializing the rule base and creating a folder for archiving them
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] init_knowledge_base(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "init_knowledge_base", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the initq MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function initialize the q-values in the look up table
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray initq()
    {
      return mcr.EvaluateFunction("initq", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the initq MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function initialize the q-values in the look up table
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] initq(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "initq", new MWArray[]{});
    }


    /// <summary>
    /// Provides an interface for the initq function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function initialize the q-values in the look up table
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void initq(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("initq", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the update_knowledge_base
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// updating the rule base
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray update_knowledge_base()
    {
      return mcr.EvaluateFunction("update_knowledge_base", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the update_knowledge_base
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// updating the rule base
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="Q">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray update_knowledge_base(MWArray Q)
    {
      return mcr.EvaluateFunction("update_knowledge_base", Q);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the update_knowledge_base
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// updating the rule base
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] update_knowledge_base(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "update_knowledge_base", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the update_knowledge_base
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// updating the rule base
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Q">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] update_knowledge_base(int numArgsOut, MWArray Q)
    {
      return mcr.EvaluateFunction(numArgsOut, "update_knowledge_base", Q);
    }


    /// <summary>
    /// Provides an interface for the update_knowledge_base function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// updating the rule base
    /// Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void update_knowledge_base(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                            argsIn)
    {
      mcr.EvaluateFunction("update_knowledge_base", numArgsOut, ref argsOut, argsIn);
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
