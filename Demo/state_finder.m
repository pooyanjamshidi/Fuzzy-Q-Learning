function candidate=state_finder(stat)
%% This function returns the next selected state
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global TPM

ran=rand(1);

old_action=stat.old_action;
old_state=stat.old_state;

%set the initial candidate state to 1
candidate=1;

sum=0;

sum=sum+TPM(old_state,candidate,old_action);

% 0 stands when the selection process is not complete yet and 1 means that
% the next state has been selected randomly.
complete=0;

while 0==complete
    
    if ran<sum
        
        complete=1;
        
    else
        % select the next state
        % TODO: probably i need to change the state selection mechanism as it's
        % more inclined towards early states
        candidate=candidate+1;
        
        sum=sum+TPM(old_state,candidate,old_action);
        
    end
    
end

