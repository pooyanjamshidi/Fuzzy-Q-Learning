function action=fuzzy_action_selector(stat,rule_number)
%% This function returns the next selected actions using epsilon-greedy policy
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NA EPSILON

ran=rand(1);

%set the initial candidate action to 0 meaning that action is not selected
% action index is from 1 to J=maximum number of actions which is the same
% as number of columns in Q
action=0;

% setting the exploration probability
exploitation_probability=1-EPSILON;

% Selecting an action via epsilon-greedy policy

if ran<exploitation_probability
    % exploit
    [maxQfactor,index]=max(stat.Q(rule_number,:)); % note that max/min should be in accordance with reward/cost as reinfrocement signal
    action=index;
    
else % explore
    
    action=ceil(rand(1)*NA);
    
end

end