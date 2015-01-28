function fis=update_knowledge_base(Q)
%% updating the rule base
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

global FISFILENAME ARCHIVEFOLDER
globalfql % global parameters initialized

% update the rule base
fis=update_fis(Q);

% archive the old rule base of FLC in place
c=clock;
newName=sprintf(strcat(FISFILENAME,'-%s.fis'),strcat(num2str(c(1,1)),'-',num2str(c(1,2)),'-',num2str(c(1,3)),'-',num2str(c(1,4)),'-',num2str(c(1,5)),'-',num2str(c(1,6))));
copyfile(FISFILENAME,strcat(ARCHIVEFOLDER,'/',newName),'f');

% replace the rule base with the updated version
writefis(fis,FISFILENAME);

end