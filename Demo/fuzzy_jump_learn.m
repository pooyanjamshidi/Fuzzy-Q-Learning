function [stat,done]=fuzzy_jump_learn(stat,new_input)
%% This function simulates a jump and also updates the learning stats
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global ITERMAX

old_state=stat.old_state;

old_action=stat.old_action;

% Record current state

stat.current_state=new_input;

% Record the immediate reward earned in going from "old_state" to "current_state"
% under old_action

stat.rimm=reward_calculator(old_state,new_input,old_action);

% at this point stat structure contains information that is needed for
% updating the Q values, so we apply the qlearning procedure here. 
% TODO: code should be resuable in a way that different qlearning variations can
% replace the current logic

% call fuzzy Q-learning procedure

stat=fqlearn(stat);

% Select next action

next_action=fuzzy_action_calculator(stat,new_input);

% Get ready to get out of this function

stat.old_state=new_input;

stat.old_action=next_action;

if stat.iter>=ITERMAX
    % simulation should end
    
    done=1;
else
    % simulation should continue
    
    done=0;
end