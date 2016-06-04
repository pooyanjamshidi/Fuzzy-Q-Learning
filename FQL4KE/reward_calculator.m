function reward=reward_calculator(current_state,next_state)
%% This function calculates the reinforcement signal
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

% Here we can amend the reward function based on the problem formulation,
% e.g., VScaler paper
% state=[workload, rt, throughput, #VM], DESIRED_RT=Response time SLO
global DESIRED_RT W MAX_THROUGHPUT MAX_VM

if next_state(2)<DESIRED_RT
slaFactor=0;
else
    if next_state(2)>2*DESIRED_RT
        slaFactor=1;
    else
       slaFactor=(next_state(2)-DESIRED_RT)/DESIRED_RT;
    end
end
        
Ut_1=W(1)*next_state(3)/MAX_THROUGHPUT+W(2)*(1-next_state(4)/MAX_VM)+W(3)*(1-slaFactor);

%--------------------------------------------------------------------------
if current_state(2)<DESIRED_RT
slaFactor=0;
else
    if current_state(2)>2*DESIRED_RT
        slaFactor=1;
    else
       slaFactor=(current_state(2)-DESIRED_RT)/DESIRED_RT;
    end
end
        
Ut=W(1)*current_state(3)/MAX_THROUGHPUT+W(2)*(1-current_state(4)/MAX_VM)+W(3)*(1-slaFactor);


reward=Ut_1-Ut;

end