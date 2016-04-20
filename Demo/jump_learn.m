function [stat,done]=jump_learn(stat)
%% This function simulates a jump and also updates the learning stats
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global ITERMAX TRM

old_state=stat.old_state;

old_action=stat.old_action;

% Determine current state

current_state=state_finder(stat);

% Record current state

stat.current_state=current_state;

% Record the immediate reward earned in going from "old_state" to "current_state"
% under old_action

stat.rimm=TRM(old_state,current_state,old_action);

% at this point stat structure contains information that is needed for
% updating the Q values, so we apply the qlearning procedure here. 
% TODO: code should be resuable in a way that different qlearning variations can
% replace the current logic

% Q-learning procedure

stat=nqlearn(stat);

% Select next action

next_action=action_selector(stat);

% Get ready to get out of this function

stat.old_state=current_state;

stat.old_action=next_action;

if stat.iter>=ITERMAX
    % simulation should end
    
    done=1;
else
    % simulation should continue
    
    done=0;
end