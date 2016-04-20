function policy=pol_finder(stat)
%% This function determines the optimal policy: optimal action-value function
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NA NS

% whether vector is used
if nnz(stat.vector)>0
    % show vector
    stat.vector
    % update Q values
    for state=1:NS
        
        for action=1:NA
            
            Q(state,action)=value_finder(state,action,stat.vector)
            
        end
        
    end
    stat.Q=Q;
end
    


for state=1:NS
    % choose thre value and index of the optimum Q
    [maxQfactor,index]=max(stat.Q(state,:));
    
    policy(state)=index;
    
    value_function(state)=maxQfactor;
    
end

%show optimal policy: pi:S->A
policy

%show value function
value_function

for state=1:NS
    
    for action=1:NA
        state
        action
        stat.Q(state,action)
    end
    
end
