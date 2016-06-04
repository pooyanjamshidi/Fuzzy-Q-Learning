function action=fuzzy_action_selector(Q,rule_number,epsilon)
%% This function returns the next selected actions using epsilon-greedy policy
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

global NA
globalfql % global parameters initialized

ran=rand(1);

% action index is from 1 to J=maximum number of actions which is the same
% as number of columns in Q


% setting the exploration probability
exploitation_probability=1-epsilon;

% Selecting an action via epsilon-greedy policy

if ran<exploitation_probability
    % exploit
    [maxQfactor,index]=max(Q(rule_number,:)); % note that max/min should be in accordance with reward/cost as reinfrocement signal
    action=index;
    
else % explore
    
    action=ceil(rand(1)*NA);
    
end

end