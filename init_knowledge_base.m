function init_knowledge_base()
%% initializing the rule base and creating a folder for archiving them
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

global FISFILENAME ARCHIVEFOLDER FIS
globalfql % global parameters initialized

% create archive folder
if exist(ARCHIVEFOLDER,'dir')~=7
    mkdir(ARCHIVEFOLDER);
    fileattrib(ARCHIVEFOLDER,'+w');
end

% create the current rule base useing for reasoning
writefis(FIS,FISFILENAME);
fileattrib(FISFILENAME,'+w');

end