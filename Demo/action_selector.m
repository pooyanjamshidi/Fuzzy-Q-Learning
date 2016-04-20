function action=action_selector(stat)
%% This function returns the next selected actions
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NA

ran=rand(1);

%set the initial candidate action to 1
candidate=1;

% setting the exploration probability
sum=1/NA;

complete=0;

% Selecting each action with equal probability

while 0==complete
    
    if ran<sum
        % action selected
        action=candidate;
        complete=1;
        
    else
        % next action is now the candidate for selection
        candidate=candidate+1;
        sum=sum+(1/NA);
    end
end

