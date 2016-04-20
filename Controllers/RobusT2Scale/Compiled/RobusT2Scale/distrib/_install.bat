ECHO OFF

:START
ECHO Deploying project RobusT2Scale

SET NEEDUPDATEPATH=
IF EXIST MCRInstaller.exe (
    ECHO Running MCRInstaller    
    MCRInstaller.exe    
    SET NEEDUPDATEPATH=1
) ELSE IF EXIST MCRInstaller.cmd (
    ECHO Running remote MCRInstaller
    MCRInstaller.cmd
    SET NEEDUPDATEPATH=1
)

          

:COMPLETE
ECHO Installation complete.
ECHO Please refer to the documentation for any additional setup steps.