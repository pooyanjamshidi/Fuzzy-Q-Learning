function reward=reward_calculator(old_state,current_state,old_action)
%% This function calculates the reinforcement signal
% Here we can amend the reward function based on the problem formulation,
% e.g., VScaler paper
% state=[workload, rt], SLA(1)=Response time SLO
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global SLA

if current_state(2)<=SLA(1) % response time SLO has not been violated
    reward=1;
else
    if (current_state(2)<=old_state(2))&&(old_action>0) % violated but has been improved due to the action
        reward=0; % not either penalize nor give positive reward
    else %violated and has been dropped from last time
        reward=exp((SLA(1)-current_state(2))/SLA(1))-1; % a negative reward between [-1 0)
    end
end

end